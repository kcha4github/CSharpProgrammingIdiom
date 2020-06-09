using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceConverter
{
    /// <summary>
    /// フィートとメートルの単位変換クラス
    /// </summary>
    public static class FeetConverter
    {
        /// <summary>
        /// メートルからフィートを求める
        /// </summary>
        /// <param name="meter"></param>
        /// <returns></returns>
        public static double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        /// <summary>
        /// フィートからメートルを求める
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public static double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
