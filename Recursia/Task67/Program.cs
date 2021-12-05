// 67. Показать натуральные числа от N до 1, N задано


int N = 10;
// string PrintN(int N)
// {       можно так
//         return N <=0 ? String.Empty : $"{N} {PrintN(N-1)} ";
//         или так // if(N < 0) return String.Empty ;
//         // return  $"{N} {PrintN(N-1)} ";
// }
// Console.WriteLine(PrintN(N));
// или так короче
string PrintN(int N) => N <=0 ? String.Empty : $"{N} {PrintN(N-1)} ";
Console.WriteLine(PrintN(N));
