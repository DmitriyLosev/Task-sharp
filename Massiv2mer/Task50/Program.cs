//  В двумерном массиве n×k заменить четные элементы на противоположные
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
FillArray(array, -10, 10);
PrintArray(array);
Console.WriteLine();
int[,] replacingEvenOpposites(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] % 2 == 0) array[i, j] =- array[i, j];
    }
    return array;
}
replacingEvenOpposites(array);
PrintArray(array);