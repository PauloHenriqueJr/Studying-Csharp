using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}