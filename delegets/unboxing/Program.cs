using System;

namespace unboxing
{
    class Program
    {
        static public void Main()
        {
            int num = 23;
            object obj = num;
            int i = (int)obj;
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}