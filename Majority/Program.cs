const int majority = 18;

int age, years;

Console.WriteLine("Escreva a sua idade");
age = Convert.ToInt32(Console.ReadLine());

// Calcula quantos anos faltam para atingir a maioridade

years = majority - age;

if (years > 0)
{
    Console.WriteLine($"Falta(m), {years} ano(s) para você atingir a maioridade\n");
}
else
{
    Console.WriteLine("Você já atingiu a maioridade\n");
}

