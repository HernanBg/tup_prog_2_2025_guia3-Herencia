using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Envio.Models
{
    public class Fijo:Costo
    {
        private double _valorFijo;

        
        public override double ValorFinal => _valorFijo;

        public Fijo(string concepto, double valorFijo) : base(concepto)
        {
            _valorFijo = valorFijo;
        }

    
        public override string VerDetalle()
        {
            return $"{Concepto}: ${ValorFinal:F2}";
        }




    }
}
