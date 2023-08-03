using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflection
{
    public class OurClass
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to OurClass");
        }
        public void SecondMethod()
        {
            Console.WriteLine("second method");
        }
        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private string name;
        public string Name
        {
            get { return  name; }
            set { name = value; }
        }
    }
    
}
