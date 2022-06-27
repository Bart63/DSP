using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Defaults;

namespace DSP.Signals
{
    // S3 custom signal
    internal class CustomSignal : Signal
    {
        public CustomSignal(float a, float t1, float d, float t, int f) : base(a, t1, d, t, f, true, SignalType.original)
        {
            GeneratePoints(isContinuous);
        }

        public override float Func(float t)
        {
            return A * (float)Math.Sin((Math.PI / T) * (t - t1)) + (float)Math.Sin((8 * Math.PI / T) * (t - t1));
        }

    }
}
