using System;
using System.Collections.Generic;
using System.IO;

namespace chapter2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter(ReadSales("sales.csv"));
            
            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string,int> obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }

        }

        /// <summary>
        /// 売上データを読み込み、Saleオブジェクトのリストを返す
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        static List<Sale> ReadSales(string filepath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filepath);

            foreach(string line in lines)
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
