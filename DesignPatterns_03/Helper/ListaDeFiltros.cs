using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_03
{
    public static class ListaDeFiltros
    {
        public class FiltroMenorQue100Reais:Filtro
        {
            public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }
            public FiltroMenorQue100Reais() : base() { }

            public override IList<Conta> Filtra(IList<Conta> contas)
            {
                IList<Conta> filtradas = new List<Conta>();
                foreach (Conta c in contas)
                {
                    if (c.Saldo < 100) filtradas.Add(c);
                }
                foreach (Conta c in Proximo(contas))
                {
                    filtradas.Add(c);
                }

                return filtradas;
            }
        }

        public class FiltroMaiorQue500MilReais:Filtro
        {
            public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }
            public FiltroMaiorQue500MilReais() : base() { }

            public override IList<Conta> Filtra(IList<Conta> contas)
            {
                IList<Conta> filtradas = new List<Conta>();
                foreach (Conta c in contas)
                {
                    if (c.Saldo > 500000) filtradas.Add(c);
                }
                foreach (Conta c in Proximo(contas))
                {
                    filtradas.Add(c);
                }

                return filtradas;
            }
        }

        public class FiltroMesmoMes:Filtro
        {
            public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }
            public FiltroMesmoMes() : base() { }

            public override IList<Conta> Filtra(IList<Conta> contas)
            {
                IList<Conta> filtradas = new List<Conta>();
                foreach (Conta c in contas)
                {
                    if (c.DataAbertura.Month == DateTime.Now.Month &&
                        c.DataAbertura.Year == DateTime.Now.Year)
                    {
                        filtradas.Add(c);
                    }
                }
                foreach (Conta c in Proximo(contas))
                {
                    filtradas.Add(c);
                }

                return filtradas;
            }
        }

    }
}