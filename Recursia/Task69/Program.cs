// Найти сумму элементов от M до N, N и M заданы
int N = 10;
int M = 1;
int SumElement(int N, int M)
{   
    if (M == N) return N;
    if (M > N) return M + SumElement((M - 1), N);
    else return M + SumElement((M + 1), N);
}
Console.WriteLine(SumElement(N, M));

