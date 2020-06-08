using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // フィートからメートルへの対応表を出力
            for(int feet = 1; feet <= 10; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
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
    }
}
