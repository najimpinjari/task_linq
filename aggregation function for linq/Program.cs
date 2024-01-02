using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace aggregation_function_for_linq
{
    internal class program
    {
        static void main()
        {
            aggregation oprators for linq in c# 

            #region aggreagation oprators count  

            list<int> numbers = new list<int> { 2, 4, 6, 1, 7, 3 };
             int count = numbers.count();

            console.writeline(count);

            console.readline();

            #endregion aggreagation oprators count  

            #region aggreagation oprators sum

            list<int> num1 = new list<int> { 3, 5, 6, 7, 9, 22, 44, 66, 77, 22, 44 };
            int sum = num1.sum();

            console.writeline(sum);

            console.readline();


            #endregion aggreagation oprators sum 

            #region aggreagation oprators average    

            list<int> num2 = new list<int> { 44, 55, 66, 2, 22, 44, 99, 11, 33 };
            double ave = num2.average();

            console.writeline(ave);

            console.readkey();


            #endregion aggreagation oprators average

            #region aggreagation oprators min

            list<int> list1 = new list<int> { 44, 22, 44, 11, 77, 88, 99, 45, 27 };
            int min = list1.min();

            console.writeline(min);
            console.readline();

            #endregion aggreagation oprators min

            #region aggreagation oprators max


            list<int> list2 = new list<int> { 44, 22, 44, 11, 77, 88, 99, 45, 27 };
            int max = list2.max();

            console.writeline(max);
            console.readline();

            #endregion aggreagation oprators max

            #region aggreagation oprators aggregate

            list<int> list3 = new list<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int aggregate = list3.aggregate((c, x) => c + x);
            console.writeline(aggregate);

            list<int> numbers = new list<int> { 1, 2, 3, 4, 5 };
            int product = numbers.aggregate((acc, x) => acc * x);
            console.writeline($"product: {product}");


            console.readline();

            #endregion aggreagation oprators aggregate
        }
    }
}
