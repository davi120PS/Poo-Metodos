using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.Clases
{
    public class Funciones
    {
        #region Metodo de suma
        public int Suma(int num1,int num2,int num3,int num4)
        {
            int resultado = num1 + num2 + num3 + num4;
            return resultado;
        }
        #endregion
        #region Metodo de resta
        public void Resta()
        {
            int num1=10,num2=2,num3=5;
            int resultado = num1 - num2;
            Console.WriteLine("La resta es: " + resultado);
        }
        #endregion
    }
}
