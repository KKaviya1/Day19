using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    FieldInfo[] fields;
        //    MemberInfo[] members;
        //    MethodInfo[] method;
        //    ConstructorInfo[] constructors;

            Type type = typeof(OurClass);
            PropertyInfo[] properties = type.GetProperties();
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine("Properties in our classes");
            foreach(var prop in properties)
            {
                Console.WriteLine("Property:" +prop.Name);
            }
            Console.WriteLine("\nMethods in our class");
            foreach(var method in methodInfos)
            {
                Console.WriteLine("Methods:" + method.Name);
            }

            Console.ReadKey();







        }
    }
}
