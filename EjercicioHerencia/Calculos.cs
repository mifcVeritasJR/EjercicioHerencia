using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Calculos : Operaciones
    {
        public void Imprimir()
        {
            double radio = 5;
            double largo = 10;
            double ancho = 4;
            double lado = 3;

            double area = AreaCirculo(radio);
            double perimetro = PerimetroRectangulo(largo, ancho);
            double volumen = VolumenCubo(lado);

            Console.WriteLine($"Área del círculo con radio {radio}: {area}");
            Console.WriteLine($"Perímetro del rectángulo con largo {largo} y ancho {ancho}: {perimetro}");
            Console.WriteLine($"Volumen del cubo con lado {lado}: {volumen}");
        }
    }