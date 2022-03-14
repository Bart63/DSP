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

        public static double Calculate(float xp, float xk, int n, FUNC func)
        {
            float dx, calka, s, x;

            dx = (xk - xp) / n;

            calka = 0;
            s = 0;
            for (int i = 1; i < n; i++)
            {
                x = xp + i * dx;
                s += func(x - dx / 2);
                calka += func(x);
            }
            s += func(xk - dx / 2);
            calka = (dx / 6) * (func(xp) + func(xk) + 2 * calka + 4 * s);

            return calka;
        }
    }
}
