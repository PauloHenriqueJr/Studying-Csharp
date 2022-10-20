namespace DesignPatterns_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            History history = new History();

            Contract contract = new Contract(DateTime.Now, "John Doe", ContractType.New);
            history.Push(contract.SaveState());
            contract.NextState();
            history.Push(contract.SaveState());
            contract.NextState();
            history.Push(contract.SaveState());
            contract.NextState();
            history.Push(contract.SaveState());
            contract.NextState();
            history.Push(contract.SaveState());

            contract.RestoreState(history.Pop(3));
            Console.WriteLine(contract.Type);

            contract.RestoreState(history.Pop(2));
            Console.WriteLine(contract.Type);

            contract.RestoreState(history.Pop(1));
            Console.WriteLine(contract.Type);
        }

        // Creating contract using the memento pattern
    }

}