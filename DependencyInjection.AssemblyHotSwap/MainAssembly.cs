using DependencyInjection.SharedComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.AssemblyHotSwap
{
    public class MainAssembly
    {
        private IVersionable _version;

        public MainAssembly(IVersionable version)
        {
            _version = version;
        }
        public IVersionable Version
        {
            get
            {
                return _version;
            }
        }
    }
}
