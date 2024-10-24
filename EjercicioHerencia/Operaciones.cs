using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double AreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double PerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }

        public double VolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
    }
}