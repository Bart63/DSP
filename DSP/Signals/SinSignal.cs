using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Defaults;

namespace DSP.Signals
{
    internal class SinSignal : Signal
    {
        public SinSignal(float a, float t1, float d, float t, int f) : base(a, t1, d, t, f, true)
        {
            GeneratePoints(isContinuous);
        }

        public override float Func(float t)
        {
            return (float)Math.Round(A * Math.Sin((2 * Math.PI / T) * (t - t1)), 2);
        }

    }
}
