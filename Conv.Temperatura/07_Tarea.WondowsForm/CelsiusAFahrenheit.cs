using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Tarea.WondowsForm
{
    public class CelsiusAFahrenheit : IConversorTemperatura
    {
        public double Convertir(double grados)
        {
            return (grados * 1.8) + 32;
        }
    }
}
