using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_04
{
    public class Positivo : EstadoDaConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0)
            {
                conta.EstadoAtual = new Negativo();
            }
        }
    }
}