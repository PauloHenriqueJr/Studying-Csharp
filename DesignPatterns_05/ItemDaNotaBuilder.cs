using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_05
{
    public class ItemDaNotaBuilder
    {
        private string nome;
        private double valor;

        public ItemDaNotaBuilder ComNome(string nome)
        {
            this.nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(nome, valor);
        }
    }
}