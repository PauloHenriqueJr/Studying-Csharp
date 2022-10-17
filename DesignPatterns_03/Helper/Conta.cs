using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_03
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public string Agencia { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void DepositaValorNegativo(double valor)
        {
            this.Saldo -= valor;
        }

        public void SacaValorNegativo(double valor)
        {
            this.Saldo += valor;
        }
    }
}