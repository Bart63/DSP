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

        
        

        public bool isContinuous;

        public bool isQuantized;


        protected Signal(float a, float t1, float d, float t, int f, bool isContinuous)
        {
            PointsReal = new List<ObservablePoint>();
            PointsIm = new List<ObservablePoint>();

            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
            this.isContinuous = isContinuous;

            endTime = (((int)(d / T)) * T) + t1;

            if (endTime == t1)
                endTime = t1 + d;

            isQuantized = false;
        }

        public Signal (float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null, bool isQuantized = false)
        {
            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
            this.isContinuous = isContinuous;

            PointsReal = new List<ObservablePoint>();
            if (pointsReal != null)
                PointsReal.AddRange(pointsReal);

            PointsIm = new List<ObservablePoint>();
            if (pointsIm != null)
                PointsIm.AddRange(pointsIm);

            endTime = (((int)(d / T)) * T) + t1;

            if (endTime == t1)
                endTime = t1 + d;

            this.isQuantized = isQuantized;

            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }

       

        public virtual void GeneratePoints(bool isContinuous, Action resetValuesCallback = null)
        {
            for (int i = 0; i < (d * f); i++)
            {
                float t = (float)i / f + t1;

                
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

        public List<ObservablePoint> GetRealPointsToChart()
        {
            if (PointsReal.Count() <= 1000)
            {
                return PointsReal;
            }
            else
            {
                int d = PointsReal.Count / 1000;

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

            s2.PointsReal = s2.PointsReal.Select(x => new ObservablePoint(x.X, Math.Round(x.Y, 2))).ToList();

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
    }
}
