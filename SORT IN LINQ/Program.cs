using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORT_IN_LINQ
{
    class Program
    {
        static void Main()
        {   
            //sample data list of intiger values 
            List<int> numbers  = new List<int> {9,2,3,7,4,8,1};

            //sorting in asending and disending order 
            var sortnum = numbers.OrderByDescending( n => n); 


            //for displaing sorting numbers
            foreach (var number in sortnum)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
