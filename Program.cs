using System;

namespace FHT
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = 1024;
            int[] signal = Generator.GetSin(period, 15, 128);
            int[] signal2 = Generator.GetSin(period, 1.5, 0);
            signal = Generator.CombineSignal(signal, signal2);
            double[] output = FHT.CalcForward(signal);
            var pl = new PlotWindow("signal", signal);
            var p2 = new PlotWindow("FHT", Converter.DoubleToInt(output, 0.03, true), true);
            var p3 = new PlotWindow("sin", Converter.DoubleToInt(FHT.CalcBackward(output)));
            Console.WriteLine("Waiting for exit...");
            Console.ReadKey();
        }
    }
}
