using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StockAccountManagement
{
    public class FetchStockData
    {
        public Stock Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stock>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

    }
}
