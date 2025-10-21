
Console.Write("Digite o número inicial (Start): ");
int start = int.Parse(Console.ReadLine());
Console.Write("Digite o número final (End): ");
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)

{

    Console.WriteLine($"\nTabuada do {num}:");

    for (int i = 1; i <= 10; i++)

    {

        int resultado = num * i;

        Console.WriteLine($"{num} x {i} = {resultado}");

    }

}
    



