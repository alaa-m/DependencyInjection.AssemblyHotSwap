using DependencyInjection.Assembly._1._0;
using DependencyInjection.SharedComponents;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.AssemblyHotSwap
{
    class Program
    {

        static void Main(string[] args)
        {
            
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                var container = new UnityContainer();

                //Hard code mapping
                //container.RegisterType<IVersionable, AssemblyV1>();

                //Configuarion Mapping
                ConfigurationManager.RefreshSection("unity");
                var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");;
                container.LoadConfiguration(section);

                MainAssembly assembly = container.Resolve<MainAssembly>();
                Console.WriteLine(string.Format("Your Assembly Version is {0}",assembly.Version.GetVersion()));
                Console.WriteLine("Press Any Key to Call Assembly Again or Press Escape to Exit...");
                container.Dispose();
            }
        }
    }
}
