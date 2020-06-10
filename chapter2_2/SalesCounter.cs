using System;
using System.Collections.Generic;
using System.IO;

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

        /// <summary>
        /// 売上データを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<Sale> ReadSales(string filepath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }

            return sales;
        }

    }
}
