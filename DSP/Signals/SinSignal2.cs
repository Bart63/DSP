using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class SinSignal2 : Signal
    {
        public SinSignal2(float a, float t1, float d, float t, int f) : base(a, t1, d, t, f, true)
        {
            GeneratePoints(isContinuous);
        }

        public override float Func(float t)
        {
            return (float)(0.5f * A * (Math.Sin(2 * Math.PI / T * (t - t1)) +
                Math.Abs( Math.Sin((2 * Math.PI) / T * (t - t1)))));
        }
    }
}
