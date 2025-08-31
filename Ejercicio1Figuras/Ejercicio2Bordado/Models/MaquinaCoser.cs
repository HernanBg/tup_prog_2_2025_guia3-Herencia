using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bordado.Models
{
    public class MaquinaCoser
    {
        private List<IMotivoBordado> motivos;
        private int _currentStitchIndex;
        private char[] _combinedPattern;

        public MaquinaCoser()
        {
            motivos = new List<IMotivoBordado>();
            _currentStitchIndex = 0;
        }

        public void AgregarMotivo(IMotivoBordado motivo)
        {
            motivos.Add(motivo);
        }

        public void Iniciar()
        {
            var combined = new List<char>();
            foreach (var motivo in motivos)
            {
                combined.AddRange(motivo.GetPatron());
            }
            _combinedPattern = combined.ToArray();
            _currentStitchIndex = 0;
        }

        public string DarPuntada()
        {
            if (_combinedPattern == null || _currentStitchIndex >= _combinedPattern.Length)
            {
                return "Finalizado";
            }

            char stitch = _combinedPattern[_currentStitchIndex];
            _currentStitchIndex++;

            return stitch.ToString();
        }

        public void Reiniciar()
        {
            motivos.Clear();
            _combinedPattern = null;
            _currentStitchIndex = 0;
        }

        public List<IMotivoBordado> GetMotivos()
        {
            return motivos;
        }
    }
}
