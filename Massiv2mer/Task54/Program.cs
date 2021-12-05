// 54. В матрице чисел найти сумму элементов главной диагонали
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
FillArray(array, 1, 3);
PrintArray(array);
int sumDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0, j = 0;i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
    {
        sum = sum +  array[i, j];
       
        
    }
    
    return sum;
}
sumDiag(array);
Console.WriteLine(sumDiag(array));
