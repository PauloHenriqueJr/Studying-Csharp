using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_06
{
    public abstract class NotaBase : INota
    {
        public int Frequencia { get; protected set; }
    }

    public class Do : NotaBase
    {
        public Do()
        {
            Frequencia = 262;
        }
    }

    public class Re : NotaBase
    {
        public Re()
        {
            Frequencia = 294;
        }
    }

    public class Mi : NotaBase
    {
        public Mi()
        {
            Frequencia = 330;
        }
    }

    public class Fa : NotaBase
    {
        public Fa()
        {
            Frequencia = 349;
        }
    }

    public class Sol : NotaBase
    {
        public Sol()
        {
            Frequencia = 392;
        }
    }

    public class La : NotaBase
    {
        public La()
        {
            Frequencia = 440;
        }
    }

    public class Si : NotaBase
    {
        public Si()
        {
            Frequencia = 494;
        }
    }

    
}