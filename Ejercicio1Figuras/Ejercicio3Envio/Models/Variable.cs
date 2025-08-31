using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Envio.Models
{
    public class Variable:Costo
    {
        public double PrecioPorUnidad { get; private set; }
        public double Unidades { get; private set; }


        public override double ValorFinal => PrecioPorUnidad * Unidades;

        public Variable(string concepto, double unidades, double precioPorUnidad) : base(concepto)
        {
            Unidades = unidades;
            PrecioPorUnidad = precioPorUnidad;
        }

        public override string VerDetalle()
        {
            return $"{Concepto} ({Unidades}x${PrecioPorUnidad:F2}): ${ValorFinal:F2}";
        }
    }
}
