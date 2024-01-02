using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_opaatos__for_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Element_opaatos__for_linq

            #region first 
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            int firsteven = num.First(x => x % 2 == 0);

            Console.WriteLine(firsteven);
            Console.ReadLine();

            #endregion first 


            #region FirstOrDefault 
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            int firstordefault = num.FirstOrDefault(x => x % 2 == 0);  //1
            Console.WriteLine(firstordefault);


            List<int> numbers = new List<int> { 1, 3, 5 }; // 0
            int firstEvenOrDefault = numbers.FirstOrDefault(x => x % 2 == 0);
            Console.WriteLine($"First even number or default: {firstEvenOrDefault}");

            Console.ReadLine();

            #endregion FirstOrDefault 


            #region last 
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            //  int lastOdd = num.Last(x => x % 2 != 0);
            int lastOdd = num.Last();


            Console.WriteLine(lastOdd);
            Console.ReadLine();

            #endregion last 



            #region LastOrDefault 

            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            int lastOddOrDefault = num.LastOrDefault(x => x % 2 != 0);

            Console.WriteLine(lastOddOrDefault);

            Console.ReadLine();


            #endregion LastOrDefault

        }
    }
}
