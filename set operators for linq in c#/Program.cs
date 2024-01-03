using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_operators_for_linq_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            set operators for linq in c#

            #region union 
            Returns the distinct duplicate elements from two collections.


            var collection1 = new List<int> { 1, 2, 3 };
            var collection2 = new List<int> { 3, 4, 5 };

            var result = collection1.Union(collection2);

            Console.WriteLine(result);
            Console.ReadLine();



            var collection1 = new List<int> { 1, 2, 3 };
            var collection2 = new List<int> { 3, 4, 5 };

            var result = collection1.Union(collection2);

            foreach (var item in result)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();

            Console.ReadLine();

            Result will contain: 1, 2, 3, 4, 5

            #endregion union 

            #region intersect

            var collection1 = new List<int> { 1, 2, 3 };
            var collection2 = new List<int> { 3, 4, 5 };

            var result = collection1.Intersect(collection2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Result will contain: 3


            #endregion intersect

            #region Except

            var collection1 = new List<int> { 1, 2, 3 };
            var collection2 = new List<int> { 3, 4, 5 };

            var result = collection1.Except(collection2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            #endregion Except

            #region Concat


            var collection1 = new List<int> { 1, 2, 3 };
            var collection2 = new List<int> { 3, 4, 5 };

            var result = collection1.Concat(collection2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            #endregion Concat


            #region Distinct

            var collection1 = new List<int> { 1, 2, 3, 2, 3, 4, 5, 6, 7 };

            var result = collection1.Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            #endregion Distinct


            #region sequevence eaqual

            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 1, 2, 3, 4, 5 };

            bool areEqual = list1.SequenceEqual(list2);

            Console.WriteLine("Are the sequences equal? " + areEqual); // This should print "true"

            Console.ReadLine();

            #endregion sequevence eaqual


        }
    }
}
