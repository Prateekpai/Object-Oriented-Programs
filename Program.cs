using System;
namespace StockAccountManagement
{
    public class Program
    {
        public static void Main(string[]args)
        {
            string Path =  "E:/LFP 119/Dat 11 & 12/StockAccountManagement/StockAccountManagement/StockList.json";
            
            FetchStockData fetchStockData = new FetchStockData();
            Stock data = fetchStockData.Read(Path);

            for (int i = 0; i < data.Stocklist.Count; i++)
            {
                Console.WriteLine(data.Stocklist[i].Name);
                Console.WriteLine(data.Stocklist[i].Qty);
                Console.WriteLine(data.Stocklist[i].Price);
                int value = data.Stocklist[i].Qty * data.Stocklist[i].Price;
                Console.WriteLine("The value of " + data.Stocklist[i].Name + " Stock is  :" + value);
                Console.WriteLine();
            }

        }
    }
}
