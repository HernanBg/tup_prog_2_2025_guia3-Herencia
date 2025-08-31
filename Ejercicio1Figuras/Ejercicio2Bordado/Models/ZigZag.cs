using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bordado.Models
{
    public class ZigZag:IMotivoBordado
    {
     private char[] patron = { '/', '\\', '/', '\\' };

    public char[] GetPatron()
    { return patron; }
     public override string ToString()
     {
            return "ZigZag";
     }   
     
            
     
    }
}
