using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_04
{
    public class Negativo : EstadoDaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo >= 0)
            {
                conta.EstadoAtual = new Positivo();
            }
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Saldo negativo");
        }
    }
}