using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns_07
{
    public class Contract
    {
        public DateTime Date { get; private set; }
        public string Customer { get; private set; }
        public ContractType Type { get; private set; }

        public Contract(DateTime date, string customer, ContractType type)
        {
            Date = date;
            Customer = customer;
            Type = type;
        }
        public void NextState()
        {
            if (Type == ContractType.New)
                Type = ContractType.InProgress;
            else if (Type == ContractType.InProgress)
                Type = ContractType.Finished;
            else if (Type == ContractType.Finished)
                Type = ContractType.Closed;
        }

        public void PreviousState()
        {
            if (Type == ContractType.InProgress)
                Type = ContractType.New;
            else if (Type == ContractType.Finished)
                Type = ContractType.InProgress;
            else if (Type == ContractType.Closed)
                Type = ContractType.Finished;
        }

        public State SaveState()
        {
            return new State(new Contract(Date, Customer, Type));
        }

        public void RestoreState(State state)
        {
            Date = state.Contract.Date;
            Customer = state.Contract.Customer;
            Type = state.Contract.Type;
        }

    }
}