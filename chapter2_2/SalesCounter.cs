using System;
using System.Collections.Generic;
using System.Text;

namespace chapter2_2
{
    /// <summary>
    /// 売上集計クラス
    /// </summary>
    public class SalesCounter
    {
        private List<Sale> _sales;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="sales"></param>
        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

        /// <summary>
        /// 店舗別売上を求める
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] += sale.Amount;
                }
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
    }
}
