using System;
using System.Collections.Generic;
using System.Linq;

namespace lekcija6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TaskPlusTwo();
            TaskHas23();
        }
        /*
         Ņemot vērā masīva 2 garumu, atgrieziet true, ja tajā ir 2 vai 3.
         */
        static void TaskHas23()
        {
            var list = new List<int> { 2, 4 };
            var has2Or3 = list.Any(x => x == 2 || x == 3);
            Console.WriteLine(has2Or3);
        }
        static void TaskPlusTwo()
        {
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 8, 9 };
            int[] resultArr = new int[4];
            var index = 0;
            foreach (var i in arr1)
            {
                resultArr[index] = i;
                index++;
            }
            foreach (var i in arr2)
            {
                resultArr[index] = i;
                index++;
            }
            foreach (var i in resultArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
