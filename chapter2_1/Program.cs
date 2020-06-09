using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // フィートからメートルへの対応表を出力
            PrintFeetToMeterList(1, 10);
            // メートルからフィートへの対応表を出力
            PrintMeterToFeetList(1, 10);
        }

        /// <summary>
        /// フィートからメートルへの対応表を出力
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        static void PrintFeetToMeterList(int start, int stop)
        {
            FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = converter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        /// <summary>
        /// メートルからフィートへの対応表を出力
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        static void PrintMeterToFeetList(int start, int stop)
        {
            FeetConverter converter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = converter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
