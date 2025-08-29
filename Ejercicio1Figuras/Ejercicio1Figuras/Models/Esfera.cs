using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Figuras.Models
{
   public class Esfera: IVolumetrica
    {
        public double Radio { get; set; }

        public Esfera(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return 4 * Math.PI * Radio * Radio;
        }

        public double CalcularVolumen()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radio, 3);
        }

        public override string ToString()
        {
            return $"Esfera: Radio={Radio:F2}, Área={CalcularArea():F2}, Volumen={CalcularVolumen():F2}";
        }

    }
}
