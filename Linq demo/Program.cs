using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_demo
{
    class Program
    {
        private static readonly char gotya;
        private static char najim;

        static void Main(string[] args)
        {
            int[] age = {20,22,23,24,25,26,27,28,29,30,32,32,33,45};
            var a = from i in age where i > 30 orderby i ascending select  i;

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            string[] partners = { "sagar", "karan", "Gopal", "Gotya", "radhesh" };
            //var partner = from room in partners where room.StartsWith("g") select room; // for finding like oprator ,,order by sometning  function 
            var partner = from room in partners where room.Contains("G") select room; // for finding name same as like oprator in sql 


            foreach (string item in partner)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}