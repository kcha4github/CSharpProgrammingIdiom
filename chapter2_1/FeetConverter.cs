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
        private const double ratio = 0.3048;

        /// <summary>
        /// メートルからフィートを求める
        /// </summary>
        /// <param name="meter"></param>
        /// <returns></returns>
        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        /// <summary>
        /// フィートからメートルを求める
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
