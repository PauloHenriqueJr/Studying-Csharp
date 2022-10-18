using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_05
{
    public class NotaFiscalBuilder
    {
        private string razaoSocial;
        private string cnpj;
        private double valorBruto;
        private double impostos;
        private DateTime data;
        private string observacoes;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorBruto += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            data = DateTime.Now;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(razaoSocial, cnpj, data, valorBruto, impostos, todosItens, observacoes);
        }
    }
}