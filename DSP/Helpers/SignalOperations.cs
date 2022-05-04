using DSP.Signals;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Helpers
{
    public static class SignalOperations
    {
        public static List<ObservablePoint> Convolution(List<float> h, List<float> x,
            float sampleFrequency, float t0)
        {
            List<ObservablePoint> result = new List<ObservablePoint>();

            float diff = 1 / sampleFrequency;

            int n = h.Count + x.Count - 1;

            for (int i = 0; i < n; i++)
            {
                float t = t0 + i * diff;

                float value = 0;

                for (int j = 0; j < h.Count; j++)
                {
                    int xIndex = i - j;

                    value += (float)(h[j] * ((xIndex >= 0 && xIndex < x.Count) ? x[xIndex] : 0));

                }

                result.Add(new ObservablePoint(t, value));
            }

            return result;
        }
    }
}
