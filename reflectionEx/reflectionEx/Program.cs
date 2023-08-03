using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflectionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginManager manager = new PluginManager();
            manager.LoadPlugins();
            manager.ExecutePlugins();


            Console.ReadKey();
        }
    }
}
