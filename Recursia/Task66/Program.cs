// 66. Показать натуральные числа от 1 до N, N задано


int N = 10;
// string PrintN(int N)
// {       можно так
//         return N <=0 ? String.Empty : $"{PrintN(N-1)} {N}";
//         или так // if(N < 0) return String.Empty ;
//         // return  $"{PrintN(N-1)} {N}";
// }
// Console.WriteLine(PrintN(N));
// или так короче
string PrintN(int N) => N <=0 ? String.Empty : $"{PrintN(N-1)} {N}";
Console.WriteLine(PrintN(N));