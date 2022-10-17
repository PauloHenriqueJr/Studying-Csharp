using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_03
{
    public class IHIT:TemplateDeImpostoCondicional
    {
            
            public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
            {
                return TemDoisItensComMesmoNome(orcamento);
            }
    
            public override double MaximaTaxacao(Orcamento orcamento)
            {
                return orcamento.Valor * 0.13 + 100;
            }
    
            public override double MinimaTaxacao(Orcamento orcamento)
            {
                return orcamento.Valor * (0.01 * orcamento.Itens.Count);
            }
    
            private bool TemDoisItensComMesmoNome(Orcamento orcamento)
            {
                List<string> noOrcamento = new List<string>();
                foreach (Item item in orcamento.Itens)
                {
                    if (noOrcamento.Contains(item.Nome)) return true;
                    else noOrcamento.Add(item.Nome);
                }
                return false;
            }
    }
}