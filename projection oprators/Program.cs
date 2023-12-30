using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projection_oprators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = new List<string> {"radhesh" , "sham" , "pratham", "gotya", "najim"};

            //List<string> friendincapital = new List<string>();
            //foreach (var item in friends)
            //{
            //    // friendincapital.Add(item.ToLower());
            //    friendincapital.Add(item.ToUpper());
            //}
            IEnumerable<string> namesincap = friends.Select(s => s.ToUpper());


            foreach (var item in namesincap)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

            List<int> lenth = new List<int>();

            foreach (var item in friends)
            {
                lenth.Add(item.Length);
            }
            foreach (var item in lenth)
            {
                Console.WriteLine($" {item}");
            }

            Console.ReadLine();
        }

    }
}
