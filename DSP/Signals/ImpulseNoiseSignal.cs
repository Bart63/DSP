using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class ImpulseNoiseSignal : Signal
    {
        public float p;

        private Random random;

        public ImpulseNoiseSignal(float a, float t1, float d, int f, float p) : base(a, t1, d, 0, f, false, SignalType.original)
        {
            this.p = p;
            random = new Random();

            GeneratePoints(isContinuous);
        }

        public override void GeneratePoints(bool isContinuous, Action resetValuesCallback = null)
        {
            int n = (int)((d - t1) * f);

            for (int i = 0; i < n; i++)
            {
                float r = (float)random.NextDouble();

                if (r < p)
                    PointsReal.Add(new ObservablePoint((float)i / f, A));
                else
                    PointsReal.Add(new ObservablePoint((float)i / f, 0));
            }


            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }
    }
}
