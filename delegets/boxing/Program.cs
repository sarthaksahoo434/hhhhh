using System;

namespace boxing
{
    class Program
    {

        static public void Main()
        {

            int num = 2020;
            object obj = num;
            num = 100;

            System.Console.WriteLine
            ("Value - type value of num is : {0}", num);
            System.Console.WriteLine
            ("Object - type value of obj is : {0}", obj);
        }
    }
}