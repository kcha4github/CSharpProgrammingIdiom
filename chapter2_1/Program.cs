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
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
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
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        /// <summary>
        /// フィートからメートルを求める
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        /// <summary>
        /// メートルからフィートを求める
        /// </summary>
        /// <param name="meter"></param>
        /// <returns></returns>
        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}
