using System;
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

        
        public GaussianNoiseSignal(float a, float t1, float d, int f) : base(a, t1, d, 0, f, true)
        {
            
            normal = new MathNet.Numerics.Distributions.Normal(0, 1);

            GeneratePoints(isContinuous, null);
        }

        public override void GeneratePoints(bool isContinuous, Action a)
        {
            double[] normalDst = new double[(int)((d - t1) * f)];

            normal.Samples(normalDst);

            float m = A / (float)normalDst.Max();

            List<float> points = (normalDst.ToList().Select(i => (float)i * m)).ToList();


            float t = t1;
            for (int i = 0; i < points.Count(); i++)
            {
                PointsReal.Add(new ObservablePoint(t, points.ToArray()[i]));
                t += 1 / (float)f;
            }
        }

        
    }
}
