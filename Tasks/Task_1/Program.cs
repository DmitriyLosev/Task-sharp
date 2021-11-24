int[] CreateArray(int count) // Метод создания массива
{
    return new int[count];
}

// void FillArray(int[] array) // метод заполнения массива
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

void FillArray2(int[] array, int minValue, int maxValue) // метод заполнения массива 2 способ
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

//void PrintArray(int[] array) // метод печать массива
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

string PrintArray2(int[] array) // метод печать массива
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
int Sum(int[] array) // метод нахождения суммы положительных значения массива
{
    int count = array.Length;
    int sumP = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] > 0) sumP += array[i];
    }
    return sumP;
}
int Raz(int[] array) // метод нахождения суммы отрицательных значения массива
{
    int count = array.Length;
    int razP = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] < 0) razP += array[i];
    }
    return razP;
}
// использование методов в одном блоке
int[] arr = CreateArray(10);
FillArray2(arr, 0, 10);
Console.WriteLine(PrintArray2(arr));
int s = Sum(arr);
int r = Raz(arr);
Console.WriteLine(s);
Console.WriteLine(r);



