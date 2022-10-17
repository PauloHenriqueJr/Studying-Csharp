using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_02
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("CANETA", orcamento) && Existe("LAPIS", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}