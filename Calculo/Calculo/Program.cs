using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Le damos la bienvenida al usuario
            Console.WriteLine("Bienvenido");
            //instanciamos la clase dar valor y la mandamos a llamar
            Dar_valor Dar= new Dar_valor();
            Dar.CapturarValores();
            Console.ReadKey();
         
        }
    }
}
