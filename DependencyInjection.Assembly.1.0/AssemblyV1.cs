using DependencyInjection.SharedComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Assembly._1._0
{
    public class AssemblyV1 : IVersionable
    {
        public string GetVersion()
        {
            return "Assembly Version 1";
        }
    }
}
