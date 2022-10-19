using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_06
{
    public class FurElise : IPartitura
    {
        private IList<INota> notas;

        public FurElise(NotasMusicais notas)
        {
            this.notas = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("sol"),
                notas.Pega("la"),
                notas.Pega("la"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("re"),
                notas.Pega("re"),
                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("sol"),
                notas.Pega("sol"),
                notas.Pega("la"),
                notas.Pega("la"),
                notas.Pega("sol"),
                notas.Pega("do"),
                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("sol"),
                notas.Pega("la"),
                notas.Pega("la"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("re"),
                notas.Pega("re"),
                notas.Pega("do")
            };
        }

        public IList<INota> Notas
        {
            get { return notas; }
        }
    }
}