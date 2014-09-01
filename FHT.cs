using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHT
{
    class FHT
    {
        public static double[] CalcForward(int[] input)
        {
            int N = input.Length;
            double[] result = new double[N];
            double pi2 = (Math.PI * 2) / N;
            for (int k = 0; k < N; k++)
            {
                double pi2k = pi2 * k;
                for (int n = 0; n < N; n++)
                {
                    double s = (pi2k * n) ;
                    result[k] += (Math.Sin(s)+Math.Cos(s)) * input[n];
                }
            }
            return result;
        }

        public static double[] CalcBackward(double[] input)
        {
            int N = input.Length;
            double[] result = new double[N];
            double pi2 = (Math.PI * 2) / N;
            for (int k = 0; k < N; k++)
            {
                double pi2k = pi2 * k;
                for (int n = 0; n < N; n++)
                {
                    double s = (pi2k * n);
                    result[k] += (Math.Sin(s) + Math.Cos(s)) * input[n];
                }
                result[k] = result[k] / N;
            }
            return result;
        }
    }
}
