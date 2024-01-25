using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRacional
{
    public static class Calculadora
    {
        
        public static String Operar(String x, String y, String operador)
        {
            string[] fraccion1 = x.Split('/');
            string[] fraccion2 = y.Split('/');

            double numerador1 = Double.Parse(fraccion1[0]);
            double denominador1 = Double.Parse(fraccion1[1]);
            double numerador2 = Double.Parse(fraccion2[0]);
            double denominador2 = Double.Parse(fraccion2[1]);
            double numeradorResultado;
            double denominadorResultado;


            switch (operador)
            {
                case "+":
                    numeradorResultado = (numerador1 * denominador2) + (numerador1 * denominador2);
                    denominadorResultado = denominador1 * denominador2;

                    break;
                case "-":
                    numeradorResultado = (numerador1 * denominador2) - (numerador1 * denominador2);
                    denominadorResultado = denominador1 * denominador2;
                    break;
                case "*":
                    numeradorResultado = numerador1 * numerador2;
                    denominadorResultado = denominador2 * denominador1;
                    break;
                case "/":
                    numeradorResultado = numerador1 * denominador2;
                    denominadorResultado = denominador1 * numerador2;
                    break;
            }

            return "";
    


        }

        public static Boolean IsEven( double numero)
        {
            return numero%2 == 0;

        }

        public static String IsEvenOrOdd(double numero)
        {
            if (IsEven(numero))
            {
                return "El número " + numero + " es par";
            }
            else
            {
                return "El número " + numero + " es impar";
            }
        }
    }
}
