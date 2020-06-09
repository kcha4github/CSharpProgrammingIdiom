using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceConverter
{
    /// <summary>
    /// フィートとメートルの単位変換クラス
    /// </summary>
    class FeetConverter
    {
        /// <summary>
        /// メートルからフィートを求める
        /// </summary>
        /// <param name="meter"></param>
        /// <returns></returns>
        public double FromMeter(double meter)
        {
            return meter / 0.3048;
        }

        /// <summary>
        /// フィートからメートルを求める
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
