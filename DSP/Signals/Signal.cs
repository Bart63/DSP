using LiveCharts.Defaults;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSP.Signals
{
    public class Signal
    {
        public float A; //aplituda
        public float t1; //czas początkowy
        public float d; //czas trwania sygnału
        public float T; //okres
        public int f; //czestotliwosc probkowania

        public List<ObservablePoint> PointsReal;
        public List<ObservablePoint> PointsIm;

        public float AverageSignalValue;
        public float AverageSignalAbsValue;
        public float AverageSignalPower;
        public float Variance;
        public float EffectiveValue;
        public float endTime;

        public float MSE;
        public float SNR;
        public float PSNR;
        public float MD;
        public float ENOB;

        public bool isContinuous;

        public SignalType signalType;
        public SignalType baseSignalType { get; set; }

        protected List<ObservablePoint> sampledSignalPoints;

        protected Func<float, float> func;

        public int sampleFrequency;

        protected int quantizationLevels;

        protected List<ObservablePoint> reconstructedSignalPointsReal;

        public enum SignalType
        {
            original, sampled, quantized, reconstructed, filtered
        };

        protected Signal(float a, float t1, float d, float t, int f, bool isContinuous, SignalType signalType)
        {
            PointsReal = new List<ObservablePoint>();
            PointsIm = new List<ObservablePoint>();

            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
            sampleFrequency = f;
            this.isContinuous = isContinuous;
            this.signalType = signalType;

            endTime = (((int)(d / T)) * T) + t1;

            if (endTime == t1)
                endTime = t1 + d;

            
        }

        public Signal (float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null, SignalType signalType = SignalType.original, bool calculateParams = true)
        {
            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
            sampleFrequency = f;
            this.isContinuous = isContinuous;

            float newA = (float)pointsReal.Select(x => Math.Abs(x.Y)).Max();

            if (newA > a)
                A = newA;

            PointsReal = new List<ObservablePoint>();
            if (pointsReal != null)
                PointsReal.AddRange(pointsReal);

            PointsIm = new List<ObservablePoint>();
            if (pointsIm != null)
                PointsIm.AddRange(pointsIm);

            endTime = (((int)(d / T)) * T) + t1;

            if (endTime == t1)
                endTime = t1 + d;

            this.signalType = signalType;

            if (calculateParams)
            {
                CalculateAverageSignalAbsValue(isContinuous);
                CalculateAverageSignalValue(isContinuous);
                CalculateAverageSignalPower(isContinuous);
                CalculateVariance(isContinuous);
                CalculateEffectiveValue();
            }
        }

       

        public virtual void GeneratePoints(bool isContinuous, Action resetValuesCallback = null)
        {
            for (int i = 0; i < (d * f); i++)
            {
                float t = (float)Math.Round((float)i / f + t1, 5);

                PointsReal.Add(new ObservablePoint(t, Func(t)));
            }

            if (resetValuesCallback != null)
            {
                resetValuesCallback();
            }

            endTime = (((int)(d / T)) * T) + t1;
            if (endTime == t1)
                endTime = t1 + d;


            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();

        }
        public virtual float Func(float t)
        {
            return 0;
        }

        protected void CalculateAverageSignalValue(bool isContinuous)
        {
            if (isContinuous)
            {
                float f = (1 / (endTime - t1));
                float f2 = (float)MathExtensions.Integration.Calculate(GetRealPointsWithTime(t1, endTime));

                AverageSignalValue = (float)(1 / (endTime - t1)
                    * (MathExtensions.Integration.Calculate(GetRealPointsWithTime(t1, endTime))));
            }
            else
            {
                AverageSignalValue = (float)(PointsReal.Sum(x => x.Y) / (PointsReal.Count));
            }
        }

        protected void CalculateAverageSignalAbsValue(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalAbsValue = (float)(1 / (endTime - t1)
                    * MathExtensions.Integration.Calculate(GetRealPointsWithTime(t1, endTime,
                    delegate (float x) { return Math.Abs(x); })));
            }
            else
            {
                AverageSignalAbsValue = (float)(PointsReal.Sum(x => Math.Abs(x.Y))
                    / (PointsReal.Count));
            }
        }

        protected void CalculateAverageSignalPower(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalPower = (float)(1 / (endTime - t1) *
                    MathExtensions.Integration.Calculate(GetRealPointsWithTime(t1, endTime,
                    delegate (float x) { return x * x; })));
            }
            else
            {
                AverageSignalPower = (float)((PointsReal.Sum(x => Math.Pow(x.Y, 2))) /
                    (PointsReal.Count));
            }
        }

        protected void CalculateVariance(bool isContinuous)
        {
            if (isContinuous)
            {
                Variance = (float)(1 / (endTime - t1) *
                    MathExtensions.Integration.Calculate(GetRealPointsWithTime(t1, endTime,
                    delegate (float x) { return (float)Math.Pow(AverageSignalValue - x, 2); })));
            }
            else
            {
                Variance = (float)((PointsReal.Sum(x => Math.Pow(x.Y - AverageSignalValue, 2)) /
                    (PointsReal.Count)));
            }
        }

        protected void CalculateEffectiveValue()
        {
            EffectiveValue = (float)Math.Pow(AverageSignalPower, 0.5);
            
        }

        public List<ObservablePoint> GetRealPointsWithTime (float t1, float t2,
            Func<float, float> modifier = null)
        {
            if (modifier == null)
                return PointsReal.Where(x => x.X >= t1 && x.X <= t2).ToList();
            else
            {
                return PointsReal.Where(x => x.X >= t1 && x.X <= t2).
                    Select(x => new ObservablePoint(x.X, modifier((float)x.Y))).ToList();
            }
        }

        public virtual List<ObservablePoint> GetRealPointsToChart()
        {
            if (PointsReal.Count() <= 1000)
            {
                return PointsReal;
            }
            else
            {
                int d = (int)((float)PointsReal.Count / 1000);

                if (d == 0)
                    return PointsReal;

                return PointsReal.Where((x, i) => i % d == 0).ToList();
            }
        }

        public static Signal operator + (Signal s1, Signal s2)
        {
            List<ObservablePoint> newPoints = new List<ObservablePoint>();

            for (int i = 0; i < s1.PointsReal.Count; i++)
            {
                newPoints.Add(new ObservablePoint(s1.PointsReal[i].X, s1.PointsReal[i].Y + s2.PointsReal[i].Y));
            }

            Signal signal = new Signal(newPoints.Max(x => (float)x.Y), s1.t1, s1.d, s1.T, s1.f, s1.isContinuous, newPoints);

            return signal;
        }

        public static Signal operator -(Signal s1, Signal s2)
        {
            List<ObservablePoint> newPoints = new List<ObservablePoint>();

            for (int i = 0; i < s1.PointsReal.Count; i++)
            {
                newPoints.Add(new ObservablePoint(s1.PointsReal[i].X, s1.PointsReal[i].Y - s2.PointsReal[i].Y));
            }

            Signal signal = new Signal(newPoints.Max(x => (float)x.Y), s1.t1, s1.d, s1.T, s1.f, s1.isContinuous, newPoints);

            return signal;
        }

        public static Signal operator *(Signal s1, Signal s2)
        {
            List<ObservablePoint> newPoints = new List<ObservablePoint>();

            for (int i = 0; i < s1.PointsReal.Count; i++)
            {
                newPoints.Add(new ObservablePoint(s1.PointsReal[i].X, s1.PointsReal[i].Y * s2.PointsReal[i].Y));
            }

            Signal signal = new Signal(newPoints.Max(x => (float)x.Y), s1.t1, s1.d, s1.T, s1.f, s1.isContinuous, newPoints);

            return signal;
        }

        public static Signal operator /(Signal s1, Signal s2)
        {
            List<ObservablePoint> newPoints = new List<ObservablePoint>();

            s2.PointsReal = s2.PointsReal.Select(x => new ObservablePoint(x.X, Math.Round(x.Y, 5))).ToList();

            for (int i = 0; i < s1.PointsReal.Count; i++)
            {
                if (s2.PointsReal[i].Y != 0)
                    newPoints.Add(new ObservablePoint(s1.PointsReal[i].X, s1.PointsReal[i].Y / s2.PointsReal[i].Y));
                else
                    newPoints.Add(new ObservablePoint(s1.PointsReal[i].X, s1.PointsReal[i].Y));

            }


            Signal signal = new Signal(newPoints.Max(x => (float)x.Y), s1.t1, s1.d, s1.T, s1.f, s1.isContinuous, newPoints);

            return signal;
        
        }

        public Signal Convolution(Signal s2)
        {
            List<float> points1 = PointsReal.Select(x => (float)x.Y).ToList();
            List<float> points2 = s2.PointsReal.Select(x => (float)x.Y).ToList();

            float diff = 1 / (float)sampleFrequency;


            int n = points1.Count + points2.Count - 1;

            List<ObservablePoint> result = new List<ObservablePoint>();

            for (int i = 0; i < n; i++)
            {
                float value = 0;

                for (int j = 0; j < points1.Count; j++)
                {
                    int xIndex = i - j;

                    value += (float)(points1[j] * ((xIndex >= 0 && xIndex < points2.Count) ? points2[xIndex] : 0));

                }

                result.Add(new ObservablePoint((float)(t1 + (i * diff)), value));
            }

            Signal s = new Signal(A, t1, d, T, f, isContinuous, result, null, signalType);
            s.baseSignalType = baseSignalType;

            return s;

        }

        public Signal Corelation(Signal s2)
        {
            List<float> points1 = PointsReal.Select(x => (float)x.Y).ToList();
            List<float> points2 = s2.PointsReal.Select(x => (float)x.Y).ToList();

            float diff = 1 / (float)sampleFrequency;


            int n = points1.Count + points2.Count - 1;

            List<ObservablePoint> result = new List<ObservablePoint>();

            for (int i = points2.Count - 1; i >= (-1) * points1.Count; i--)
            {
                float value = 0;

                for (int j = 0; j < points1.Count; j++)
                {
                    int xIndex = i + j;

                    value += (float)(points1[j] * ((xIndex >= 0 && xIndex < points2.Count) ? points2[xIndex] : 0));

                }

                result.Add(new ObservablePoint((float)(t1 + (i * diff)), value));
            }

            Signal s = new Signal(A, t1, d, T, f, isContinuous, result, null, signalType);
            s.baseSignalType = baseSignalType;

            return s;

        }

        public void Move(int numberOfSamples)
        {
            List<ObservablePoint> temporary = new List<ObservablePoint>();

            foreach(var v in PointsReal)
            {
                temporary.Add(new ObservablePoint(v.X, v.Y));
            }

            PointsReal.RemoveRange(temporary.Count - numberOfSamples, numberOfSamples);

            int i = 0;
            foreach(var v in temporary.GetRange(temporary.Count - numberOfSamples, numberOfSamples))
            {
                PointsReal.Insert(i, new ObservablePoint(v.X, v.Y));
                i++;
            }

            for (i = 0; i < PointsReal.Count; i++)
            {
                PointsReal[i].X = temporary[i].X;
            }
        }

        public float CalculateMSE(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float value = 0;

            for (int i = 0; i < originalPoints.Count; i++)
            {
                value += (float)Math.Pow((originalPoints[i].Y - quantizedPoints[i].Y), 2);
            }

            return value / originalPoints.Count;
        }

        public float CalculateSNR(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float nom = 0;
            float denom = 0;

            for (int i = 0; i < originalPoints.Count; i++)
            {
                nom += (float)Math.Pow(originalPoints[i].Y, 2);
                denom += (float)Math.Pow(originalPoints[i].Y - quantizedPoints[i].Y, 2);
            }

            return (float)(10 * Math.Log10(nom / denom));
        }

        public float CalculatePSNR(List<ObservablePoint> originalPoints)
        {
            float max = (float)originalPoints.Max(x => x.Y);

            return (float)(10 * Math.Log10(max / MSE));
        }

        public float CalculateMD(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float max = (float)Math.Abs(originalPoints[0].Y - quantizedPoints[0].Y);

            for (int i = 1; i < originalPoints.Count; i++)
            {
                float newMax = (float)Math.Abs(originalPoints[i].Y - quantizedPoints[i].Y);

                if (newMax > max)
                    max = newMax;
            }

            return max;
        }

        public float CalculateENOB()
        {
            return (SNR - 1.76f) / 6.02f;
        }

        protected virtual void Sample(ref List<ObservablePoint> sampledSignal, List<ObservablePoint> points)
        {

        }

        protected virtual void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int quantizationFrequency, int reconstructionFrequency, int n)
        {

        }

        protected double sinc(double t)
        {
            if (t == 0)
                return 1;
            else
                return Math.Sin(Math.PI * t) / (Math.PI * t);
        }

        protected virtual void Quantize(List<ObservablePoint> points, ref List<ObservablePoint> quantizedSignal, int levels)
        {

        }
    }
}
