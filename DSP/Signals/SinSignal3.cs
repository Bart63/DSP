using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class SinSignal3 : Signal
    {
        public SinSignal3(float a, float t1, float d, float t, int f) : base(a, t1, d, t, f, true)
        {
            GeneratePoints(isContinuous);
        }

        public override float Func(float t)
        {
            return (float)Math.Round((A * Math.Abs(Math.Sin(Math.PI * 2 / T * (t - t1)))), 2);
        }
    }
}
