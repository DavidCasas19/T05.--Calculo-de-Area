using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Dar_valor
    {
        public void CapturarValores()
        {
            //instanciamos la clase operaciones
            Operaciones x = new Operaciones();
            //le pedimos al usuario  los valores
            Console.WriteLine("ingrese Lado A");
            double VA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese Lado B");
            double VB = Convert.ToDouble(Console.ReadLine());

            
            int Val = 5;
            //asignamos los valores capturados
            double ResA = x.CalcularArea(VA), ResB = x.CalcularArea(VA, VB), ResC = x.CalcularArea(VA, VB, Val);

            //Enseñamos el resultado
            Console.WriteLine("   ");
            Console.WriteLine("El area de un cuadrado es:" +"  "+ ResA);
            Console.WriteLine("   ");
            Console.WriteLine("El area de un rectangulo es:" + "  " + ResB);
            Console.WriteLine("   ");
            Console.WriteLine("El area de un triangulo es:" + "  " + ResC);
            Console.ReadKey();
        }
        }
}
