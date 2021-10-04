using System;
using System.Collections.Generic;
using System.Text;

namespace aula_1.minhas_classes
{
    public class Calc
    {
        double _n1;

        public double N1
        {
            get => _n1;
            set => _n1 = value;
        }
        public double N2 { get => _n2; set => _n2 = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        double _n2;

        string resultado;

        public void Somar()
        {
            resultado = (_n1 + _n2).ToString();
        }

        public string Subtrair()
        {

            return (_n1 - _n2).ToString();
        }
        public string Multiplicar(double a, double b)
        {
            return (a * b).ToString();
        }
        public double Multiplicar()
        {
            return _n1 * _n2;
        }
        public void Dividir()
        {
            
                resultado = (_n1 / _n2).ToString();

            if(_n2 == 0)
            {
                resultado = "Não é possivel dividir por zero";
            }


        }
    }
}
