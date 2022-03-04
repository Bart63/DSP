using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Defaults;

namespace DSP.Signals
{
    internal class SinSignal : Signal
    {
        public SinSignal(float a, float t1, float d, float t, int f) : base(a, t1, d, t, f)
        {
            GeneratePoints();
        }

        public override void GeneratePoints()
        {
            for (float t = t1; t < d; t += 1/(float)f)
            {
                points.Add(new ObservablePoint(t, A * Math.Sin((Math.PI / T) * (t - t1))));
            }
        }
    }
}
