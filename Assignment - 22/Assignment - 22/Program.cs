using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{

    public class Program
    {
        public static void MapProperties(Source source, Destination destination)
        {
            Type sourceType = source.GetType();
            Type destType = destination.GetType();

            PropertyInfo[] sourceProperties = sourceType.GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                PropertyInfo destProperty = destType.GetProperty(sourceProperty.Name);

                if (destProperty != null && destProperty.PropertyType == sourceProperty.PropertyType)
                {
                    object value = sourceProperty.GetValue(source);
                    destProperty.SetValue(destination, value);
                }
            }
        }
        static void Main(string[] args)
        {
            Source source = new Source
            {
                
                Name = "Viya Mathi",
                Age = 22,
                Address = "No:34,White town,Pondicherry"
            };

            Destination destination = new Destination();

            MapProperties(source, destination);

            Console.WriteLine("**Destination Properties**");
            Console.WriteLine("Name: " + destination.Name);
            Console.WriteLine("Age: " + destination.Age);
            Console.WriteLine("Pincode: " + destination.Pincode);
            Console.WriteLine("IsLocation: " + destination.IsLocation);
            Console.ReadKey();
        }
    }
}
