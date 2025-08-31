using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Envio.Models
{
    public abstract class Costo
    {
        public string Concepto { get; private set; }

    
        public abstract double ValorFinal { get; }

        public Costo(string concepto)
        {
            Concepto = concepto;
        }

        
        public abstract string VerDetalle();
    }
}
