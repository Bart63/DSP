using LiveCharts.Defaults;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSP.Signals
{
    public abstract class Signal
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

        protected Signal(float a, float t1, float d, float t, int f)
        {
            PointsReal = new List<ObservablePoint>();
            PointsIm = new List<ObservablePoint>();

            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
        }

        public virtual void GeneratePoints(bool isContinuous)
        {
            for (float t = t1; t < d; t += 1 / (float)f)
            {
                PointsReal.Add(new ObservablePoint(t, Func(t)));
            }


            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
        }
        public abstract float Func(float t);

        protected void CalculateAverageSignalValue(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalValue = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d, 300 ,Func)));
            }
        }

        protected void CalculateAverageSignalAbsValue(bool isContinuous)
        {
            if (isContinuous)
            {
                AverageSignalAbsValue = (float)(1 / (d - t1) * (MathExtensions.Integration.Calculate(t1, d, 300, 
                    delegate (float t) { return Math.Abs(Func(t)); })));
            }
        }
    }
}
