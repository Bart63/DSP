using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Simulation
{
    public class Buffer
    {
        public int length { get; }
        public List<ObservablePoint> values { get; set; }

        public Buffer(int length)
        {
            this.length = length;
            values = new List<ObservablePoint>(length);
        }

        public void AddValues(List<ObservablePoint> values)
        {
            this.values.Clear();
            this.values.AddRange(values);

            while(this.values.Count > length)
            {
                this.values.RemoveAt(this.values.Count - 1);
            }
        }

    }
}
