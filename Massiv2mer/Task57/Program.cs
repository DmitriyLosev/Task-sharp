// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
FillArray(array, 1, 5);
PrintArray(array);
int SortArray([,] array)
{   
    int min = array[i, j];
    
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min ) array[i, j] = min;
            else array[i, j] 

        }
    }
    return array;
}
SortArray(array);
Console.WriteLine(SortArray(array));