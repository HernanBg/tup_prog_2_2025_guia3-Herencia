using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Figuras.Models
{
    public class Servicio
    {
        private List<IFigura> figuras;

        public Servicio()
        {
            figuras = new List<IFigura>();
        }

        public bool VerFigura(int idx, out IFigura figura)
        {
            if (idx >= 0 && idx < figuras.Count)
            {
                figura = figuras[idx];
                return true;
            }
            figura = null;
            return false;
        }

        public int VerCantidad()
        {
            return figuras.Count;
        }

        public void AgregarFigura(IFigura figura)
        {
            figuras.Add(figura);
        }

        public bool EliminarFigura(int idx)
        {
            if (idx >= 0 && idx < figuras.Count)
            {
                figuras.RemoveAt(idx);
                return true;
            }
            return false;
        }

        public List<IFigura> GetFiguras()
        {
            return figuras;
        }
    }
}
