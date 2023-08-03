using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionEx
{
   public class PlugInTwo : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin two executing.........");
        }
    }
    
}

