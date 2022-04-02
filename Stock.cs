using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class Stock
    {

        public List<StockList> Stocklist;

    }
    public class StockList
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

    }

}
