using System;
using System.Reflection;
namespace latebinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type STUDENTType=executingAssembly.GetType("latebinding.STUDENT");

            object STUDENTInstance = Activator.CreateInstance(STUDENTType);

           MethodInfo GetFullNameMethod  = STUDENTType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "latebinding";
            parameters[1] = "sao";

          string fullname =(string)  GetFullNameMethod.Invoke(STUDENTInstance, parameters);
            Console.WriteLine("Full Nmae ={0}", fullname);
            /*STUDENT s1 = new STUDENT();
            string fullname = s1.GetFullName("latebinding", "sahoo");
            Console.WriteLine("Full Nmae ={0}", fullname);*/
        }
    }
    public class STUDENT
    {
        public string GetFullName(string FirstName, String LastName)
        {
            return FirstName + "" + LastName;
        }
    }
}
