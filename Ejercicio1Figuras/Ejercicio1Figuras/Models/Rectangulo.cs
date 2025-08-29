using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Figuras.Models
{
    public class Rectangulo: ISuperficie
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public double CalcularArea()
        {
            return Ancho * Largo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Largo);
        }

        public override string ToString()
        {
            return $"Rectángulo: Ancho={Ancho:F2}, Largo={Largo:F2}, Área={CalcularArea():F2}, Perímetro={CalcularPerimetro():F2}";
        }
    }
}
