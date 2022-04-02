using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagementDemo
{
    public class Rice
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfGrains> typesOfGrains;
        public List<TypesOfWheats> typesOfWheats;
    }


    public class TypesOfRice
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }

    public class TypesOfGrains
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }

    public class TypesOfWheats
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}
