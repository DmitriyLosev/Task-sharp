// Найти сумму цифр числа
int N = 7859999;
int SumNumber(int N)
{
   return N==0 ? N : N % 10 + SumNumber(N/10);
}
Console.WriteLine(SumNumber(N));