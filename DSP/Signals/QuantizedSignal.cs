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
        private List<ObservablePoint> quantizedSignal;

        public float MSE;
        public float SNR;
        public float PSNR;
        public float MD;

        public QuantizedSignal(float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm)
        {
            quantizedSignal = new List<ObservablePoint>();

            Quantize();
        }

        private void Quantize()
        {

        }
    }
}
