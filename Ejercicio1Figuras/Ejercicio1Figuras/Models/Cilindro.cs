using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Figuras.Models
{
    public class Cilindro: IVolumetrica

    {
        public double Radio { get; set; }
        public double Altura { get; set; }

        public Cilindro(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return 2 * Math.PI * Radio * (Radio + Altura);
        }

        public double CalcularVolumen()
        {
            return Math.PI * Radio * Radio * Altura;
        }

        public override string ToString()
        {
            return $"Cilindro: Radio={Radio:F2}, Altura={Altura:F2}, Área={CalcularArea():F2}, Volumen={CalcularVolumen():F2}";
        }
    }
}
