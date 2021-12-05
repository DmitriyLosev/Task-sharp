// Написать программу, которая обменивает элементы первой строки и последней строки
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
double ChangeFirstFinish(double[] array)
{
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i, j] = array[(array.GetLength(0)--)-1, array[(array.GetLength(1)--)-1];
        }
        
    }
    return newArray;

ChangeFirstFinish(array);
PrintNewArray(array);
int[,] ArraySwap(int[,] arr)
{
    int buff = 0;
    int n = arr.GetLength(0);
    //int k = arr.GetLength(1);
    for (int i = 0; i < arr.GetLength(1); i++)
    {

        // Console.WriteLine(arr.GetLength(0));
        // Console.WriteLine(arr.GetLength(1));
        buff = arr[0, i];
        arr[0, i] = arr[n - 1, i];
        arr[n - 1, i] = buff;
        // Console.WriteLine(n);
        // Console.WriteLine(k);
    }
    return arr;
}
PrintArray(FillArray((arr)));
Console.WriteLine();
PrintArray(ArraySwap(arr));
