using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class calculo
    {
        float numero1;
        float numero2;
        string operacion;
        DateTime fecha;
        float resultado;

        public string MostrarEnHistorial()
        {
            return fecha + "--->" + numero1 + operacion + numero2 + "=" + resultado;
        }

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Resultado { get => resultado; set => resultado = value; }


        
        /*public float suma()
        {
            return numero1 + numero2;
        }

        public float resta()
        {
            return numero1 - numero2;
        }

        public float multiplicacion()
        {
            return numero1 * numero2;
        }

        public float division()
        {
            return numero1 / numero2;
        }*/
    }
}
