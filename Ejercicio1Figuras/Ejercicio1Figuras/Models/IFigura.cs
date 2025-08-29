using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Figuras.Models
{
    public interface IFigura
    {
        double CalcularArea();
    }


    public interface ISuperficie : IFigura
    {
        double CalcularPerimetro();
    }

 
    public interface IVolumetrica : IFigura
    {
        double CalcularVolumen();
    }
}
