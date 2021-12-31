// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух 
//предыдущих. Первые два элемента последовательности задаются пользователем
int A = 2;
int B = 3;
int N = 2;
int Fibonacci(int A, int B, int N)
{   
    Console.WriteLine( "${A + B}");
    return N == 0 ? B : Fibonacci(A + B, A + B, N-1);
    
}
Fibonacci(A, B, N);
//Console.WriteLine(Fibonacci(A, B, N));