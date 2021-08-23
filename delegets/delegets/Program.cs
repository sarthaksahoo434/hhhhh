﻿using System;

namespace delegets
{
    class Program
    {

        /*public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);*/
        public delegate void mathmatical(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }


        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }

        public static void Main(String[] args)
        {
            Program obj = new Program();
            /*  addnum del_obj1 = new addnum(obj.sum);
              subnum del_obj2 = new subnum(obj.subtract);
              del_obj1(100, 40);
              del_obj2(100, 60);*/
            mathmatical obj1 = new mathmatical(obj.sum);
            mathmatical obj2 = new mathmatical(obj.subtract);
            obj1(10, 20);
            obj2(50, 40);
        }
    }
}