using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DSP.Helpers
{
    public static class Histogram
    {
        public static (List<int> data, List<string> labels) CreateHistogram
            (List<ObservablePoint> points, int numberOfSections)
        {
            List<int> histogramData = new List<int>();
            List<string> histogramLabels = new List<string>();

            int n = points.Count();

            List<float> Ypoints = points.Select(x => (float)x.Y).ToList();
           

            float h = (Ypoints.Max() - Ypoints.Min()) / numberOfSections;

            List<Point> sections = new List<Point>();

            int j = 0;
            for (int i = 0; i < numberOfSections; i++)
            {
                if (sections.Count == 0)
                {
                    sections.Add(new Point(Ypoints.Min(), Ypoints.Min() + h));

                    histogramLabels.Add(Math.Round(sections[j].X, 2) + " - " + Math.Round(sections[j].Y, 2));

                }
                else
                {
                    sections.Add(new Point(sections[j].Y, sections[j].Y + h));
                    
                    j++;

                    histogramLabels.Add(Math.Round(sections[j].X, 2) + " - " + Math.Round(sections[j].Y, 2));

                    
                }
                
            }

            for (int i = 0; i < numberOfSections; i++)
            {
                histogramData.Add(Ypoints.Count(x => x >= sections[i].X && x < sections[i].Y));
            }

            return (histogramData, histogramLabels);
        }
    }
}
