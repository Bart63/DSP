﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Defaults;
using MathNet.Numerics;

namespace DSP.Signals
{
    public class GaussianNoiseSignal : Signal
    {
        MathNet.Numerics.Distributions.Normal normal;

        
        public GaussianNoiseSignal(float a, float t1, float d, int f) : base(a, t1, d, 0, f, true, SignalType.original)
        {
            
            normal = new MathNet.Numerics.Distributions.Normal(0, a);

            GeneratePoints(isContinuous, null);
        }

        public override void GeneratePoints(bool isContinuous, Action a)
        {
            double[] normalDst = new double[(int)((d - t1) * f)];

            normal.Samples(normalDst);

            


            float t = t1;
            for (int i = 0; i < normalDst.Count(); i++)
            {
                PointsReal.Add(new ObservablePoint(t, normalDst.ToArray()[i]));
                t += 1 / (float)f;
            }

            endTime = t1 + d;

            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }

        
    }
}
