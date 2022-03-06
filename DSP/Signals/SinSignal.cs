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
        public SinSignal(float a, float t1, float d, float t, int f, bool isContinuous) : base(a, t1, d, t, f, isContinuous)
        {
            GeneratePoints(true);
        }

        public override float Func(float t)
        {
            return (float)(A * Math.Sin((2 * Math.PI / T) * (t - t1)));
        }

    }
}
