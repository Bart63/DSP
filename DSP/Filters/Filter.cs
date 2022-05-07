using DSP.Signals;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Filters
{
    public abstract class Filter
    {
        public List<float> coefficients;
        public int sampleFrequency;
        
        public string filterName { get; private set; }

        public List<ObservablePoint> filteredSignal;

        public Filter(List<float> coefficients, string name, int sampleFrequency)
        {
            this.coefficients = coefficients;
            filterName = name;
            this.sampleFrequency = sampleFrequency;
        }

        public List<ObservablePoint> GetFilteredSignal(List<float> x, float t0)
        {
            List<ObservablePoint> result = new List<ObservablePoint>();

            float diff = 1 / (float)sampleFrequency;

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

        public virtual string GetInfo()
        {
            return "Nazwa: " + filterName + "\n" +
                "Współczynniki: " + string.Join(" || ", coefficients.Select(x => x.ToString())) + "\n"
                + "Częstotliwość próbkowania: " + sampleFrequency + "\n";

        }
    }
}
