using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class NoiseSignal : Signal
    {
        Random r;

        public NoiseSignal(float a, float t1, float d, int f) : base(a, t1, d, 0, f, true, SignalType.original)
        {
            r = new Random();

            GeneratePoints(isContinuous, null);
        }

        public override void GeneratePoints(bool isContinuous, Action a)
        {
            for (float t = t1; t < d; t += 1 / (float)f)
            {
                PointsReal.Add(new ObservablePoint(t, Func(t)));
            }

            endTime = t1 + d;

            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }

        public override float Func(float t)
        {
            return (float)((r.NextDouble() * (2 * -A)) + A);
        }
    }
}
