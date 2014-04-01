using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Question - Implement StringHashMap::Get and StringHashMap::Put(string key, string value)

namespace StringHashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHashMap stringHashMap = new StringHashMap();

            stringHashMap.put("test", "foo");
            stringHashMap.put("good", "bla");
            stringHashMap.put("interviews", "almost there");

            Console.WriteLine("Key: {0}, Value: {1}", "interviews", stringHashMap.get("interviews"));

            string result = stringHashMap.get("gappuakshaybharathmuppichuppu");

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Value not present");
                stringHashMap.put("gappuakshaybharathmuppichuppu", "love of my life");
            }
        }
    }

     class StringHashMap 
     {
        public StringHashMap()
        {
           size = 5;
           table = new List<List<KeyValuePair<string, string>>>();

           for (int i = 0; i < size; i++)
           {
               table.Add(new List<KeyValuePair<string, string>>());
           }

        }

        public String get(String key)
        {
            int position = Hash(key);

            List<KeyValuePair<string, string>> list =  table[position];
  
            foreach(var item in list)
            {
               if (item.Key == key)
               {
                   return item.Value;
               }
            }

            return null;
        }
        
        public void put(String key, String value)
        {
            int position = Hash(key);

            table[position].Add(new KeyValuePair<string, string>(key, value));
        }

        private int size { get; set; }

        private List<List<KeyValuePair<string, string>>> table; 

        private int Hash(string key)
        {
            return (Math.Abs(key.GetHashCode()) % size); 
        }
    }
}
