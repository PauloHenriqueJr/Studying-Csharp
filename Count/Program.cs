int counter = 5;  // contador = 10    

while (counter > 0)
{
    Console.WriteLine($"Detonação em: {counter}");
    Console.Beep(1500, 500);
    counter--;
    Thread.Sleep(800); // metodo beep
}

Console.WriteLine("Booom!\n");
Console.Beep(800, 689);
Thread.Sleep(1000);



