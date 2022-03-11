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

        
        public GaussianNoiseSignal(float a, float t1, float d, int f, bool isContinuous) : base(a, t1, d, 0, f, isContinuous)
        {
            
            normal = new MathNet.Numerics.Distributions.Normal(0, 1);

            GeneratePoints(isContinuous);
        }

        public override void GeneratePoints(bool isContinuous)
        {
            double[] normalDst = new double[(int)((d - t1) * f)];

            normal.Samples(normalDst);

            float valueMin = (float)normalDst.Min();
            float valueMax = (float)normalDst.Max();
            float scaleRange = 1;
            float valueRange = valueMax - valueMin;

            List<float> normalized = normalDst.Select(i => (float)(scaleRange * ((i - valueMin)/valueRange))).ToList();

            List<float> points = (normalized.Select(i => i * (2 * A) - A)).ToList();


            float t = t1;
            for (int i = 0; i < points.Count(); i++)
            {
                PointsReal.Add(new ObservablePoint(t, points.ToArray()[i]));
                t += 1 / (float)f;
            }
        }

        
    }
}
