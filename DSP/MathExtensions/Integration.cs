using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.MathExtensions
{
    public static class Integration
    {
        public delegate float FUNC(float t);

        public static double Calculate(List<ObservablePoint> points)
        {
            float value = 0;

            
            for (int i = 0; i < points.Count - 1; i++)
            {
                value += (float)((points[i].Y + points[i + 1].Y) *
                    (points[i + 1].X - points[i].X) * 0.5);
            }

            return value;
        }
    }
}
