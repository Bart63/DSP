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

        private const int _integralAccuracy = 300;

        public bool isContinuous;



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

            
        }

        public Signal (float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null)
        {
            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
            this.isContinuous = isContinuous;

            PointsReal = pointsReal;
            PointsIm = pointsIm;

            
        }

        public virtual void GeneratePoints(bool isContinuous, Action resetValuesCallback = null)
        {
            for (int i = 0; i < ((d - t1) * f); i++)
            {
                float t = (float)i / f + t1;

                PointsReal.Add(new ObservablePoint(t, Func(t)));
            }

            if (resetValuesCallback != null)
            {
                resetValuesCallback();
            }

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
                
                AverageSignalValue = (float)(1 / (PointsReal.First().Y - PointsReal.Last().Y)
                    * (MathExtensions.Integration.Calculate(t1, d - t1,
                    _integralAccuracy, Func)));
            }
            else
            {
                AverageSignalValue = (float)(PointsReal.Sum(x => x.Y) / (PointsReal.First().Y - PointsReal.Last().Y + 1));
            }
        }

        protected void CalculateAverageSignalAbsValue(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalAbsValue = (float)(1 / (PointsReal.First().Y - PointsReal.Last().Y)
                    * (MathExtensions.Integration.Calculate(t1, d - t1, _integralAccuracy, 
                    delegate (float t) { return Math.Abs(Func(t)); })));
            }
            else
            {
                AverageSignalAbsValue = (float)(PointsReal.Sum(x => Math.Abs(x.Y))
                    / (PointsReal.First().Y - PointsReal.Last().Y + 1));
            }
        }

        protected void CalculateAverageSignalPower(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalPower = (float)(1 / (PointsReal.First().Y - PointsReal.Last().Y) *
                    (MathExtensions.Integration.Calculate(t1, d - t1, _integralAccuracy,
                    delegate (float t) { return (float)Math.Pow(Func(t), 2); })));
            }
            else
            {
                AverageSignalPower = (float)((PointsReal.Sum(x => Math.Pow(x.Y, 2))) /
                    (PointsReal.First().Y - PointsReal.Last().Y + 1));
            }
        }

        protected void CalculateVariance(bool isContinuous)
        {
            if (isContinuous)
            {
                Variance = (float)(1 / (PointsReal.First().Y - PointsReal.Last().Y) *
                    (MathExtensions.Integration.Calculate(t1, d - t1, _integralAccuracy,
                    delegate (float t) { return (float)Math.Pow(Func(t) - AverageSignalValue, 2); })));
            }
            else
            {
                Variance = (float)((PointsReal.Sum(x => Math.Pow(x.Y - AverageSignalValue, 2)) /
                    (PointsReal.First().Y - PointsReal.Last().Y)));
            }
        }

        protected void CalculateEffectiveValue()
        {
            EffectiveValue = (float)Math.Sqrt(AverageSignalPower);
            
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

    }
}
