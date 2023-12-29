using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_list_in_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"najim", "arbaz" , "rupesh" ,"nilesh", "shailesh" };


            var sortnum = names.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            foreach (string name in sortnum)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
