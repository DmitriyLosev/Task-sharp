// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
            Console.Write($"{array[i, j] :f1}      ");
        }
        Console.WriteLine();
    }
}
void PrintNewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] :f1}      ");
    }
}
double[,] array = CreateArray(3, 3);
FillArray(array, 1, 10);
PrintArray(array);

double[] arithmeticMean(double[,] array)
{   
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j, i];
        }
        newArray[i] = sum / array.GetLength(1);
        
        sum = 0;
    }
    return newArray;    
}
Console.WriteLine("Среднее арефметическое");
PrintNewArray(arithmeticMean(array));

