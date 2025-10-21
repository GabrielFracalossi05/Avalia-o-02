int voto;
int candidatoA = 0;
int candidatoB = 0;
int candidatoC = 0;
int votosNulos = 0;

do
{
    Console.WriteLine("\nVote em um dos candidatos:");
    Console.WriteLine("1 - Candidato A");
    Console.WriteLine("2 - Candidato B");
    Console.WriteLine("3 - Candidato C");
    Console.WriteLine("9 - Voto Nulo");
    Console.WriteLine("0 - Encerrar votação");
    Console.Write("Digite seu voto: ");

    voto = int.Parse(Console.ReadLine());

    switch (voto)
    {
        case 1:
            candidatoA++;
            break;
        case 2:
            candidatoB++;
            break;
        case 3:
            candidatoC++;
            break;
        case 9:
            votosNulos++;
            break;
        case 0:
            Console.WriteLine("Votação encerrada.");
            break;
        default:
            Console.WriteLine("Voto inválido. Tente novamente.");
            break;
    }

} while (voto != 0);

Console.WriteLine("\n--- Resultado da Votação ---");
Console.WriteLine($"Candidato A: {candidatoA} voto(s)");
Console.WriteLine($"Candidato B: {candidatoB} voto(s)");
Console.WriteLine($"Candidato C: {candidatoC} voto(s)");
Console.WriteLine($"Votos Nulos: {votosNulos}");
