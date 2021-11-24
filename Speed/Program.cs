//Каждая буква замещает некоторую десятичную цифру 0 - 9. 
//Расшифруйте равенство и найдите наибольшую СКОРОСТЬ.

//СК*ОР=ОСТЬ
//СКО-РО=СТЬ
//СКО+РО=СТЬ
int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);
int index = 0;
 