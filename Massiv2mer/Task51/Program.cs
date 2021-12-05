// Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] CreateArray(int i, int j) // Метод создания массива целых чисел
{
    return new int[i, j];
}
void FillArray(int[,] array, int minValue, int maxValue) // метод заполнения массива двумерного
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}
void PrintArray(int[,] array) // метод печать массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = CreateArray(5, 5);
FillArray(array, 1, 10);
Console.WriteLine();
int[,] sumAMN(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = i + j;
    }
    return array;
}
sumAMN(array);
PrintArray(array);
