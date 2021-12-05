// Написать программу вычисления функции Аккермана
//             n + 1, m = 0
// A(m,n) =    A(m - 1, 1) m > 0, n = 0;
//             A(m - 1, A(m, n - 1)) , m > 0, n > 0
int m = 4;
int n = 0;
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return  (n + 1);
    if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1 ));
}
Console.WriteLine(FunctionAkkerman(m, n));