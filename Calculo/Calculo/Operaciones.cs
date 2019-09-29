using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Operaciones
    {
        //hacemos los metodos con sobrecarga para realizar las operaciones
        public double CalcularArea(double LadoA)
        {
           
            var ResA = LadoA * LadoA;
            return ResA;
            //retornamos el valor
        }

        public double CalcularArea(double LadoA, double LadoB)
        {
            var ResB = LadoA * LadoB;
            return ResB;
        }

        public double CalcularArea(double LadoA, double LadoB, int Num)
        {
            Num = 2;
            var ResC = LadoA * LadoB /Num ;
            return ResC;
        }
    }

}
