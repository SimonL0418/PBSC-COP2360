using System;

public class Animal
{
    public string Name { get; set; }
}

public class Pet : Animal
{
    public int Age { get; set; }
    public string Species { get; set; }
}

class Program
{
    static void Main()
    {
        Pet exotic = new Pet { Name = "Aurelius Maximillian the III", Age = 3, Species = "Peacock" };
        Console.WriteLine($"Pet: {exotic.Name}, Age: {exotic.Age}, Species: {exotic.Species}");
    }
}
