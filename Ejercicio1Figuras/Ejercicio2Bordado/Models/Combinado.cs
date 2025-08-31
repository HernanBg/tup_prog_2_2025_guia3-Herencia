using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bordado.Models
{
    public class Combinado:IMotivoBordado
    {
        private List<IMotivoBordado> motivos;

        public Combinado(List<IMotivoBordado> motivos)
        {
            motivos = motivos;
        }

        public char[] GetPatron()
        {
            var combinedPattern = new List<char>();
            foreach (var motivo in motivos)
            {
                combinedPattern.AddRange(motivo.GetPatron());
            }
            return combinedPattern.ToArray();
        }

        public override string ToString()
        {
            return "Combinado: " + string.Join(", ", motivos.Select(m => m.ToString()));
        }
    }
}
