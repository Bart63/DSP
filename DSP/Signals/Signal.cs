using LiveCharts.Defaults;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSP.Signals
{
    public abstract class Signal
    {
        public float A; //aplituda
        public float t1; //czas początkowy
        public float d; //czas trwania sygnału
        public float T; //okres
        public int f; //czestotliwosc probkowania

        public List<ObservablePoint> points;

        protected Signal(float a, float t1, float d, float t, int f)
        {
            points = new List<ObservablePoint>();

            A = a;
            this.t1 = t1;
            this.d = d;
            T = t;
            this.f = f;
        }

        public abstract void GeneratePoints();
    }
}
