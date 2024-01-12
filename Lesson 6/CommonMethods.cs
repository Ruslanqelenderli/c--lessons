using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class CommonMethods
    {
        //public static void Calculate()
        //{
        //    int userNumber = int.Parse(Console.ReadLine());
        //    int sum = userNumber + 5;
        //    sum = sum - 3;
        //    Console.WriteLine(sum);
        //}

        //public static int Calculate2()
        //{
        //    int userNumber = int.Parse(Console.ReadLine());
        //    int sum = userNumber - 5;

        //    if (sum == 0)
        //        return sum;
        //    sum = sum - 3;
        //    Console.WriteLine(sum);

        //    decimal example = 4;

        //    return sum;
        //}


        //public static void Calculate(int age=22,string name = "Ruslan")
        //{
        //    Console.WriteLine($"User name is {name}.He is {age}");
        //}

        public static void Calculate(int age, string name = "Ruslan" )
        {
            if (age == 0) Console.WriteLine(name);

            Console.WriteLine($"He is {age}");
        }


        //public static void Calculate(int num ,params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int i in numbers)
        //    {
        //        sum += i;
        //    }
        //    Console.WriteLine(sum);
        //}

        //public static void Calculate2(int[] numbers)
        //{

        //}



        public static void CalculateRef(ref int number)
        {
            Console.WriteLine(number);  
        }

        public static void CalculateOut(out int num)
        {
            num = 5;
        }

        public static void CalculateIn(in int num)
        {
            if(num == 0) return;
        }
    }
}
