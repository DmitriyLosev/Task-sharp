// Написать программу возведения числа А в целую стень B
int A = 2;
int B = 3;
int Exponentiation(int A, int B)
{
    return B == 0 ? 1 : Exponentiation(A, B - 1) * A;
}
Console.WriteLine(Exponentiation(A, B));