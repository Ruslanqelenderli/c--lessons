using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Methods
    {
        public static void Test1(string exp , int size,ref int value)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static int Test2 (int data,out int value)
        {
            data += 5;
            value = data;
            return data;
        }

    }
}
