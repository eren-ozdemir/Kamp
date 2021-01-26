using System;
using System.Collections.Generic;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Object, string> dict = new Dictionary<Object, string>();
            dict.Add(3, "Elma");
            dict.Add("A", "Armut");
            dict.Add(4, "Karpuz");
            Console.WriteLine(dict[3]); ;

            //foreach (KeyValuePair<Object, string> item in dict)
            //{
            //    Console.WriteLine("Key = " + item.Key + ", Value = " + item.Value);
            //}


        }
    }
}
