using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queantifires_oprators_for_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int count = (int)numbers.LongCount();
            Console.WriteLine($"Count: {count}");

            Console.ReadLine();


            Queantifires_oprators_for_linq

            #region all

            List<int> num1 = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool allgret = num1.All(x => x > 5);

            Console.WriteLine(allgret);
            Console.ReadLine();

            #endregion all

            #region any

            List<int> num1 = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool anyeven = num1.Any(x => x > 500);

            Console.WriteLine(anyeven);
            Console.ReadLine();

            #endregion any

            #region Contains


            List<int> num1 = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            bool contains = num1.Contains(10); //true 
            bool contains1 = num1.Contains(1); //false


            Console.WriteLine(contains);
            Console.WriteLine(contains1);

            Console.ReadLine();



            #endregion Contains



        }
    }
}
