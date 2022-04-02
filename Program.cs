using System;

namespace InventoryDataManagementDemo
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            string path = "E:/LFP 119/Dat 11 & 12/JSONDemo/JSONDemo/JSON.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].Name);
                Console.WriteLine(data.typesOfRice[i].Weight);
                Console.WriteLine(data.typesOfRice[i].Price);
                
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.typesOfGrains.Count; i++)
            {
                Console.WriteLine(data.typesOfGrains[i].Name);
                Console.WriteLine(data.typesOfGrains[i].Weight);
                Console.WriteLine(data.typesOfGrains[i].Price);
               
            }

            Console.WriteLine("--------------");
            for (int i = 0; i < data.typesOfWheats.Count; i++)
            {
                Console.WriteLine(data.typesOfWheats[i].Name);
                Console.WriteLine(data.typesOfWheats[i].Weight);
                Console.WriteLine(data.typesOfWheats[i].Price);
                
            }
        }
    }
}
