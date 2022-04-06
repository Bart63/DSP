using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class TrianSignal : Signal
    {
        public float kw;

        private int k;
        public TrianSignal(float a, float t1, float d, float t, int f, float kw) : base(a, t1, d, t, f, true)
        {
            this.kw = kw;
            k = 0;

            GeneratePoints(isContinuous, resetK);
        }

        public override float Func(float t)
        {
            
            if (t >= ((k * T) + t1) && t <= ((kw * T) + (k * T) + t1))
            {
                return (float)Math.Round((A/(kw*T))*(t - (k * T) - t1), 2);
            }
            else if (t >= ((kw * T) - (k * T) + t1) && t <= (T + (k * T) + t1))
            {
                return (float)Math.Round(((-A/(T * (1 - kw))) * (t - (k * T) - t1) + (A/(1 - kw))), 2);
            }
            else
            {
                k += 1;
                return Func(t);
            }
        }

        private void resetK()
        {
            k = 0;
        }
    }
}
