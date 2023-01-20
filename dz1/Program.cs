void PrintNumbers(int N)
{
    if(N==1)
    {
        Console.Write(N);
        return;
    }
    {
        Console.Write($"{N}, ");
        PrintNumbers(N-1);
    }
}


Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(N);