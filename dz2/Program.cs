int CalculateSum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else if (M < N)
    {
        return M + N + CalculateSum(M + 1, N - 1);
    }
    else
    {
        return 0;
    }
}

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int result = CalculateSum(M, N);
Console.WriteLine($"M = {M}; N = {N} -> {result}");
