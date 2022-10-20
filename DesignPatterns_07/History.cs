using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_07
{
    public class History
    {
        public List<State> States { get; private set; } = new List<State>();
        public void Push(State state)
        {
            States.Add(state);
        }
        public State Pop(int index)
        {
            return States[index];
        }
    }
}