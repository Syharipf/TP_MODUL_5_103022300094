using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HaloGeneric
{   
    public void SapaUser<T>(T praktikan)
    {
        Console.WriteLine($"Halo {praktikan}");
    }
}

