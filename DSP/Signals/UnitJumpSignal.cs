using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class UnitJumpSignal : Signal
    {

        public float ts;
        public UnitJumpSignal(float a, float t1, float d, int f, float ts) : base(a, t1, d, 0, f, true)
        {
            this.ts = ts;

            GeneratePoints(isContinuous);
        }

        public override float Func(float t)
        {
            if (t > ts)
                return A;

            if (t == ts)
                return A / 2;

            else
                return 0;
        }
    }
}
