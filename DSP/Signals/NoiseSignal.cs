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

        public NoiseSignal(float a, float t1, float d, int f, bool isContinuous) : base(a, t1, d, 0, f, isContinuous)
        {
            r = new Random();

            GeneratePoints(isContinuous);
        }

        public override void GeneratePoints(bool isContinuous)
        {
            for (float t = t1; t < d; t += 1 / (float)f)
            {
                PointsReal.Add(new ObservablePoint(t, Func(t)));
            }
        }

        public override float Func(float t)
        {
            return (float)((r.NextDouble() * (2 * -A)) + A);
        }
    }
}
