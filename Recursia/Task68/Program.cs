// Показать натуральные числа от M до N, N и M заданы


int N = 10;
int M = 1;
// string PrintN(int N)
// {       можно так
//         return N <=0 ? String.Empty : $"{N} {PrintN(N-1)} ";
//         или так // if(N < 0) return String.Empty ;
//         // return  $"{N} {PrintN(N-1)} ";
// }
// Console.WriteLine(PrintN(N));
// или так короче
string PrintN(int N, int M) => M <= N ? String.Empty : $" {PrintN(N-1)} {N} ";
Console.WriteLine(PrintN(N, M));