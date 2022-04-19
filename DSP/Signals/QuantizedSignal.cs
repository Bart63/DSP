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


            MSE = CalculateMSE(pointsReal, quantizedSignalPoints);
            SNR = CalculateSNR(pointsReal, quantizedSignalPoints);
            PSNR = CalculatePSNR(pointsReal);
            MD= CalculateMD(pointsReal, quantizedSignalPoints);
            ENOB = CalculateENOB();

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
