﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Filters
{
    public class LowPassFilter : Filter
    {
        public int f0 { get; private set; }

        public LowPassFilter(List<float> coefficients, string name, int sampleFrequency, int f0) :
            base(coefficients, name, sampleFrequency)
        {
            this.f0 = f0;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + 
                "Częstotliwość odcięcia: " + f0 + " Hz";
        }
    }
}