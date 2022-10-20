using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_07
{
    public class State
    {
        public Contract Contract { get; private set; }
        public State(Contract contract)
        {
            Contract = contract;
        }

        
    }
}