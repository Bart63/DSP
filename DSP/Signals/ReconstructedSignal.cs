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
        public ReconstructedSignal(float a, float t1, float d, float t, bool isContinuous, int methodIndex, int quantizationFrequency, int reconstructionFrequency,
            List<ObservablePoint> pointsReal, List<ObservablePoint> originalPointsReal ,List<ObservablePoint> pointsIm = null, int n = 0)
            : base(a, t1, d, t, reconstructionFrequency, isContinuous, pointsReal, pointsIm, SignalType.reconstructed)
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

        protected override void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int quantizationFrequency, int reconstructionFrequency, int n)
        {
            

            switch(method)
            {
                case 0:

                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 5);

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

                    // 1 2 3 4 5
                case 1:

                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)Math.Round((float)i / reconstructionFrequency + t1, 5);

                        float value = 0;

                        ObservablePoint closestPoint = points.Aggregate((x1, x2) => Math.Abs(x1.X - t) < Math.Abs(x2.X - t) ? x1 : x2);
                        int closestPointIndex = points.IndexOf(closestPoint);

                        int leftStartIndex = (closestPointIndex - n) < 0 ? 0 : closestPointIndex - n;

                        int leftCount = closestPointIndex - leftStartIndex + 1;

                        int rightStartIndex = (closestPointIndex + 1) > points.Count - 1 ? points.Count - 1 : closestPointIndex + 1;

                        int rightCount = (points.Count - rightStartIndex) < n ? points.Count - rightStartIndex : n;

                        List <ObservablePoint> closestPoints = new List<ObservablePoint>();

                        closestPoints.AddRange(points.GetRange(leftStartIndex, leftCount));
                        closestPoints.AddRange(points.GetRange(rightStartIndex, rightCount));

                        for (int j = 0; j < closestPoints.Count; j++)
                        {
                            int realIndex = points.IndexOf(closestPoints[j]);
                            value += (float)(closestPoints[j].Y * sinc((t / (1 / (float)quantizationFrequency)) - realIndex));
                        }

                        reconstructedSignal.Add(new ObservablePoint(t, value));
                    }


                    break;
            }
        }


       
        
    }
}
