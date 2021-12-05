// Показать двумерный массив размером m×n заполненный вещественными числами
// Показать двумерный массив размером m×n заполненный целыми числами
double[,] CreateArray(int i, int j) // Метод создания массива целых чисел
{
    return new double[i, j];
}
void FillArray(double[,] array, double minValue, double maxValue) // метод заполнения массива двумерного
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble() * 100;
    }
}
void PrintArray(double[,] array) // метод печать массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] :f1} ");
        }
        Console.WriteLine();
    }
}
double[,] array = CreateArray(5, 5);
FillArray(array, 5, 10);
PrintArray(array);
