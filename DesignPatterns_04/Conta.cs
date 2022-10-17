using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_04
{
    public class Conta
    {
        public double Saldo { get; set; }
        public EstadoDaConta EstadoAtual { get; set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
            EstadoAtual = new Positivo();
        }

        public void Deposita(double valor)
        {
            EstadoAtual.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            EstadoAtual.Saca(this, valor);
        }
    }
}