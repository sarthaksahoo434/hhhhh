using System;
using System.Data;
using System.Reflection;

namespace reflection
{
    public class STUDENT
    {
        public int Id { get; set;}
        public string Nmae { get; set; }
        public STUDENT()
        {
            this.Id = 0;
            this.Nmae = string.Empty;
        }
        public STUDENT(int ID,string name)
        {
            this.Id = ID;
            this.Nmae = name;
        }
        public void PrintID()
        {
            Console.WriteLine("ID={0}", this.Id);
        }
        public void printName()
        {
            Console.WriteLine("Name ={0}", this.Nmae);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Type T = Type.GetType("reflection.STUDENT");*/
            Type T = typeof(STUDENT);
           Console.WriteLine("Full name ={0}", T.FullName);
            Console.WriteLine("Just name ={0}", T.Name);
            Console.WriteLine("Just the namespace ={0}", T.Namespace);
            /*  System.Reflection.MethodInfo[] methodInfo = Type.GetMethods();*/
            Console.WriteLine();
            Console.WriteLine("properties in student");
            PropertyInfo[]properties=T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+ "  "+property.Name);
            }

            Console.WriteLine("methods in coustmer");
           MethodInfo[] methods = T.GetMethods();
            foreach ( MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+""+method.Name  );
            }
        }
    }
}
