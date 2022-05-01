﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class RectSignal : Signal
    {
        public float kw;

        private int k;

        public RectSignal(float a, float t1, float d, float t, int f, float kw) : base(a, t1, d, t, f, true, SignalType.original)
        {
            this.kw = kw;
            k = 0;

            GeneratePoints(isContinuous, resetK);
        }

        public override float Func(float t)
        {
            if (t == t1)
                return 0;

            if (t >= ((k * T) + t1) && t <= ((kw * T) + (k * T) + t1))
            {
                return A;
            }
            else if (t >= ((kw * T) - (k * T) + t1) && t <= (T + (k * T) + t1))
            {
                return 0;
            }
            else
            {
                k += 1;
                return Func(t);
            }
        }

        private void resetK ()
        {
            k = 0;
        }
    }
}
