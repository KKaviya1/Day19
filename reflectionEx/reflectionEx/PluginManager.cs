using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace reflectionEx
{
    public class PluginManager
    {
        List<IPlugin> plugins;
    
        public PluginManager() 
        { 
            plugins = new List<IPlugin>();  
        }
        public void LoadPlugins(string plugDirectory = null)
        {
            string path = plugDirectory ?? AppDomain.CurrentDomain.BaseDirectory;
            var pluginFiles = Directory.GetFiles(path, ".dll");
            foreach (var file in pluginFiles)
            {
                Assembly assembly = Assembly.Load(file);
                var pluginTypes = assembly.GetTypes().Where(type => typeof(IPlugin).IsAssignableFrom(type));
                foreach (var pluginType in pluginTypes)
                {
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginType);
                    plugins.Add(plugin);
                }


            }
        }
            public void ExecutePlugins()
            {
            Console.WriteLine("executing plugins");
            foreach (var plugin in plugins)
            {
                plugin.Execute();
            }
        }
        
            
    }
}
