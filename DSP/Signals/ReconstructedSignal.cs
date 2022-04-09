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

        public ReconstructedSignal(float a, float t1, float d, float t, bool isContinuous, int methodIndex, int quantizationFrequency, int reconstructionFrequency,
            List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null, int n = 0)
            : base(a, t1, d, t, reconstructionFrequency, isContinuous, pointsReal, pointsIm, false)
        {
            reconstructedSignalPointsReal = new List<ObservablePoint>();

            Reconstruct(methodIndex, ref reconstructedSignalPointsReal, PointsReal, quantizationFrequency, reconstructionFrequency, n);

            PointsReal = reconstructedSignalPointsReal;
        }

        private void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int quantizationFrequency, int reconstructionFrequency, int n)
        {
            

            switch(method)
            {
                case 0:

                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 3);

                        int index = points.FindIndex(x => x.X > t);

                        if (index == -1)
                            break;

                        index--;

                        
                        Tuple<double, double> parameters = Fit.Line(new double[] { points[index].X, points[index + 1].X },
                            new double[] { points[index].Y, points[index+1].Y });

                        float a = (float)parameters.Item2;
                        float b = (float)parameters.Item1;

                               
                        reconstructedSignal.Add(new ObservablePoint(t, b + (t * a)));
                                
                        
                    }

                    break;


                case 1:

                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 3);

                        float value = 0;

                        for (int j = 0; j < n; j++)
                        {
                            value += (float)(points[j].Y * sinc((t / (1 / (float)quantizationFrequency)) - j));
                        }

                        reconstructedSignal.Add(new ObservablePoint(t, value));
                    }


                    break;
            }
        }

        private double sinc(double t)
        {
            if (t == 0)
                return 1;
            else
                return Math.Sin(Math.PI * t) / (Math.PI * t);
        }
        
    }
}
