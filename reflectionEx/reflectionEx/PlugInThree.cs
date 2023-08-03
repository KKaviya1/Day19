using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionEx
{
   public class PlugInThree : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin three executing.......");
        }
    }
}
