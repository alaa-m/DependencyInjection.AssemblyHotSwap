using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SharedComponents
{
    public interface IVersionable
    {
        string GetVersion();
    }
}
