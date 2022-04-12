using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class QuantizedSignal : Signal
    {
        private List<ObservablePoint> quantizedSignalPoints;

        

        public int quantizationLevels;
        
        public QuantizedSignal(float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, int quantizationLevels, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, true)
        {
            quantizedSignalPoints = new List<ObservablePoint>();

            this.quantizationLevels = quantizationLevels;
            Quantize(pointsReal, ref quantizedSignalPoints, quantizationLevels);

            List<ObservablePoint> allQuantizedPoints = new List<ObservablePoint>();

            for (int i = 0; i < (d * f); i++)
            {
                float actualT = (float)Math.Round((float)i / f + t1, 4);

                int index = quantizedSignalPoints.FindIndex(x => x.X > actualT);

                if (index == -1)
                    index = quantizedSignalPoints.Count - 1;
                else
                    index--;

                allQuantizedPoints.Add(new ObservablePoint(actualT, quantizedSignalPoints[index].Y));

            }

            MSE = CalculateMSE(pointsReal, allQuantizedPoints);
            SNR = CalculateSNR(pointsReal, allQuantizedPoints);
            PSNR = CalculatePSNR(pointsReal);
            MD= CalculateMD(pointsReal, allQuantizedPoints);

            PointsReal = quantizedSignalPoints;


            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();

        }

        private void Quantize(List<ObservablePoint> points, ref List<ObservablePoint> quantizedSignal, int levels)
        {
            levels--;
            float step = A * 2 / levels;


            for (int i = 0; i < points.Count; i++)
            {
                float value = (float)(step * Math.Floor(points[i].Y / step + 0.5));

                quantizedSignal.Add(new ObservablePoint(points[i].X, value));
            }

        }

        
        
    }
}
