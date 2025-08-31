using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Envio.Models
{
    public class Envio
    {
        private List<Costo> _costos;

        public double ValorTotal
        {
            get
            {
                double total = 0;
                foreach (Costo costo in _costos)
                {
                    total += costo.ValorFinal;
                }
                return total;
            }
        }

        public Envio()
        {
            _costos = new List<Costo>();
        }

        public void AgregarCosto(Costo nuevoCosto)
        {
            _costos.Add(nuevoCosto);
        }

        public string VerDetalle()
        {
            var detalle = new StringBuilder();
            foreach (Costo costo in _costos)
            {
                detalle.AppendLine(costo.VerDetalle());
            }
            detalle.AppendLine($"Total: ${ValorTotal:F2}");
            return detalle.ToString();
        }
    }
}
