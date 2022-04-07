using LiveCharts.Defaults;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class ReconstructedSignal : Signal
    {
        public List<ObservablePoint> reconstructedSignalPointsReal;

        public ReconstructedSignal(float a, float t1, float d, float t, int f, bool isContinuous, int methodIndex, int k, List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, false)
        {
            reconstructedSignalPointsReal = new List<ObservablePoint>();

            Reconstruct(methodIndex, ref reconstructedSignalPointsReal, PointsReal, k);

            PointsReal = reconstructedSignalPointsReal;
        }

        private void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int k)
        {
            switch(method)
            {
                case 0:

                    int difference = (int)Math.Round((float)points.Count(x => x.X < t1 + T) / k);

                    List<ObservablePoint> keyPoints = new List<ObservablePoint>();

                    for (int i = 0; i < points.Count; i += difference)
                    {
                        keyPoints.Add(points[i]);
                    }

                    for (int i = 0; i < keyPoints.Count; i++)
                    {
                        if (i+1 < keyPoints.Count)
                        {
                            Tuple<double, double> parameters = Fit.Line(new double[] { keyPoints[i].X, keyPoints[i + 1].X },
                                new double[] { keyPoints[i].Y, keyPoints[i+1].Y });

                            float a = (float)parameters.Item2;
                            float b = (float)parameters.Item1;

                            for (int j = i * difference; j < (i+1) * difference; j++)
                            {
                                reconstructedSignal.Add(new ObservablePoint(points[j].X, b + (points[j].X * a)));
                            }
                        }
                    }

                    break;


                case 1:



                    break;
            }
        }

        
    }
}
