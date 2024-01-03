using ServiceStack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_oparetors
{
    class Program
    {
        static void Main(string[] args)
        {
            conversion opretors

            #region To arrays

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbrearray = numbers.ToArray();

            foreach (int num in numbrearray)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

            The ToArray operator converts a sequence into an array.


            #endregion To arrays


            #region To List

            var numberarray = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numberslist = numberarray.ToList();

            foreach (int number in numberslist)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

            The ToList operator converts a sequence into a List<T>.

            Here, an array of integers (numbersArray) is converted into a List<int>.
            This is handy when you need to work with a list instead of an array.


            #endregion To List


            #region ToDictionary

            var keyvaluepairs = new List<KeyValuePairs<int, string>>
            {
                   new KeyValuePairs<int, string> { 1,"one"},
                   new KeyValuePair<int, string> { 2,"two"},

            };

            Dictionary<int, string> Dictionary = keyvaluepairs.ToDictionary(pair => pair.Key, pair => pair.Value);

            var keyValuePairs = new List<KeyValuePair<int, string>>

            {
                         new KeyValuePair<int, string>(1, "One"),
                          new KeyValuePair<int, string>(2, "Two"),
                          // ...
            };

            Dictionary<int, string> dictionary = keyValuePairs.ToDictionary(pair => pair.Key, pair => pair.Value);

            var filteredDictionary = keyValuePairs.Where(pair => pair.Key % 2 == 0).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in filteredDictionary)
            {
                Console.WriteLine(pair.Key);
            }
            Console.ReadLine();

            #endregion ToDictionary


            #region cast

            ArrayList mixedlist = new ArrayList { 1, "two", 3, "four", 5 };
            var number = mixedlist.Cast<int>();

            foreach (var i in number)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            #endregion cast


            #region AsEnumerable, AsQueryable

            List<int> numbers = new List<int>() { 1, 2, 3 };

            IQueryable<int> numbers1 = numbers.AsQueryable();

            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            ArrayList numbers2 = new ArrayList() { 1, 2, 3 };

            IEnumerable<int> numebrs3 = numbers2.Cast<int>();

            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            #endregion AsEnumerable, AsQueryable




        }
    }
}
