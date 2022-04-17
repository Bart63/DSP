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
            List<ObservablePoint> pointsReal, List<ObservablePoint> originalPointsReal ,List<ObservablePoint> pointsIm = null, int n = 0)
            : base(a, t1, d, t, reconstructionFrequency, isContinuous, pointsReal, pointsIm, false)
        {
            reconstructedSignalPointsReal = new List<ObservablePoint>();

            Reconstruct(methodIndex, ref reconstructedSignalPointsReal, PointsReal, quantizationFrequency, reconstructionFrequency, n);


            MSE = CalculateMSE(originalPointsReal, reconstructedSignalPointsReal);
            SNR = CalculateSNR(originalPointsReal, reconstructedSignalPointsReal);
            PSNR = CalculatePSNR(originalPointsReal);
            MD = CalculateMD(originalPointsReal, reconstructedSignalPointsReal);
            ENOB = CalculateENOB();

            PointsReal = reconstructedSignalPointsReal;

            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }

        private void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int quantizationFrequency, int reconstructionFrequency, int n)
        {
            

            switch(method)
            {
                case 0:

                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 4);

                        int index = points.FindIndex(x => x.X > t);

                        if (index == -1)
                        {
                            index = points.Count - 2;
                        }
                        else
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
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 4);

                        float value = 0;

                        ObservablePoint closestPoint = points.Aggregate((x1, x2) => Math.Abs(x1.X - t) < Math.Abs(x2.X - t) ? x1 : x2);
                        int closestPointIndex = points.IndexOf(closestPoint);

                        List<ObservablePoint> leftSide = points.GetRange(0, closestPointIndex);
                        List<ObservablePoint> rightSide = points.GetRange(closestPointIndex, points.Count - closestPointIndex);

                        List<ObservablePoint> closestPoints = new List<ObservablePoint>();

                        if (leftSide.Count != 0)
                        {
                            int index = (leftSide.Count - n - 1) < 0 ? 0 : (leftSide.Count - n);
                            int count = (leftSide.Count - index - 1) < n ? leftSide.Count - index : (leftSide.Count - index);
                            closestPoints.AddRange(leftSide.GetRange(index, count));
                        }

                        if (rightSide.Count != 0)
                        {
                            int index = 0;
                            int count = n > rightSide.Count ? rightSide.Count : n;
                            closestPoints.AddRange(rightSide.GetRange(index, count));
                        }
                        

                        for (int j = 0; j < closestPoints.Count; j++)
                        {
                            value += (float)(closestPoints[j].Y * sinc((t / (1 / (float)quantizationFrequency)) - j));
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
