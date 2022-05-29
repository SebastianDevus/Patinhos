int quantosPatinhos, contador;

Console.Write("\nQuantos patinhos? ");
contador = quantosPatinhos = Convert.ToInt32(Console.ReadLine());

try
{
    if (quantosPatinhos < 2)
    {
        throw new Exception("Devem ter pelo menos 2 patinhos");
    }
    else
    {
        while (contador >= 1)
        {
            contador = LogicaPatinhos(contador);
        }
        Console.WriteLine("\nA mamãe patinha foi procurar");
        Console.WriteLine("Além das montanhas");
        Console.WriteLine("Na beira do mar");
        Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
        Console.WriteLine($"E os {quantosPatinhos} patinhos voltaram de lá.");
    }
}
catch (Exception e)
{
    ExibeMensagemErro(e.Message);
}
finally
{
    Console.ResetColor();
    Console.WriteLine("\nFim.\n");
}

// Subrotina, para melhor leitura do código
static int LogicaPatinhos(int contador)
{
    if (contador == 1)
    {
        Console.WriteLine($"\n{contador} patinho foi passear");
        Console.WriteLine("Além das montanhas");
        Console.WriteLine("Para brincar");
        Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
        Console.WriteLine("Mas nenhum patinho voltou de lá.");

        contador--;
    }
    else // Caso seja mais do que 1
    {


        Console.WriteLine($"\n{contador} patinhos foram passear");
        Console.WriteLine("Além das montanhas");
        Console.WriteLine("Para brincar");
        Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");

        contador--;
        if (contador == 1) // Acertando conjugação dependendo do número de patinhos
        {
            Console.WriteLine($"Mas só {contador} patinho voltou de lá.");
        }
        else
        {
            Console.WriteLine($"Mas só {contador} patinhos voltaram de lá.");
        }
    }

    return contador;
}

// Subrotina de tratamento de erros
static void ExibeMensagemErro(string mensagemDeErro)
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n{mensagemDeErro}");
}