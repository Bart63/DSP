using DSP.Signals;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Filters
{
    public class Filter
    {
        public List<float> coefficients;
        private Signal signal;

        public List<ObservablePoint> filteredSignal;

        public Filter(List<float> coefficients)
        {
            this.coefficients = coefficients;

        }

        public List<ObservablePoint> GetFilteredSignal(List<float> x,
            float sampleFrequency, float t0)
        {
            List<ObservablePoint> result = new List<ObservablePoint>();

            float diff = 1 / sampleFrequency;

            int n = coefficients.Count + x.Count - 1;

            for (int i = 0; i < n; i++)
            {
                float t = t0 + i * diff;

                float value = 0;

                for (int j = 0; j < coefficients.Count; j++)
                {
                    int xIndex = i - j;

                    value += (float)(coefficients[j] * ((xIndex >= 0 && xIndex < x.Count) ? x[xIndex] : 0));

                }

                result.Add(new ObservablePoint(t, value));
            }

            return result;
        }
    }
}
