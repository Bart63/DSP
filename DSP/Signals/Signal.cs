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

        public virtual void GeneratePoints(bool isContinuous)
        {
            for (float t = t1; t < d; t += 1 / (float)f)
            {
                PointsReal.Add(new ObservablePoint(t, Func(t)));
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
                AverageSignalValue = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d,
                    _integralAccuracy, Func)));
            }
        }

        protected void CalculateAverageSignalAbsValue(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalAbsValue = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d, _integralAccuracy, 
                    delegate (float t) { return Math.Abs(Func(t)); })));
            }
        }

        protected void CalculateAverageSignalPower(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalPower = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d, _integralAccuracy,
                    delegate (float t) { return (float)Math.Pow(Func(t), 2); })));
            }
        }

        protected void CalculateVariance(bool isContinuous)
        {
            if (isContinuous)
            {
                Variance = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d, _integralAccuracy,
                    delegate (float t) { return (float)Math.Pow(Func(t) - AverageSignalValue, 2); })));
            }
        }

        protected void CalculateEffectiveValue()
        {
            EffectiveValue = (float)Math.Sqrt(AverageSignalPower);
            
        }

    }
}
