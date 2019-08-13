using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            Random rng = new Random(30);
            for (int i = 0; i < 30; i++)
            {
                list.Add(rng.Next(40));
            }

            Console.WriteLine(string.Join(',' , list));
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 10 || list[i] < 5)
                {
                    // list.Remove(list[i]);
                    list.RemoveAt(i);
                }
               
            }
            Console.WriteLine(string.Join(',', list));
        }
    }
}
