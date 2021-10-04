using System;
using System.Collections.Generic;
using System.Text;

namespace aula_1.minhas_classes
{
    public class CalcCientifica : Calc
    {
        public string Potenciação()
        {
            return Math.Pow(N1, N2).ToString();
        }

        public void ComparaNumero()
        {

            if (N1 > N2)
            {
                Resultado = ("o primeiro número é maior");
            }
            else if (N1 < N2)
            {
                Resultado = ("o segundo número é maior");
            }
            else
            {
                Resultado = ("os números são iguais");
            }
        }

            public void ImparPar()
            {
            if (N1% 2 == 0 && N2 % 2 == 1)
            {
                Resultado = ("o primeiro número é par e o segundo número é ímpar");
            }
            else if (N1 % 2 == 1 && N2 % 2 == 0)
            {
                Resultado = ("o primeiro número é impar e o segundo número é par");
            }
            else if (N1 % 2 == 1 && N2 % 2 == 1)
            {
                Resultado = ("os dois números são impares");
            }
            else
            {
                Resultado = ("os dois números são pares");
            }

        }

        public string AreaTriangulo()
        {



            return ((N1 * N2)/2).ToString();
        }
    }
    }



