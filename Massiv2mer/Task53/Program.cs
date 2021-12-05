// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
void findNumber(int[,] array, int number)
{
    bool f = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                f = true;

                if (f) Console.WriteLine($"Ваше число {number} есть в масиве строка {i + 1}  стобец {j + 1}");
            }
        }
    }
    if (f) Console.Write("Все числа найдены");
    else Console.WriteLine($"Ваше число {number} необнаружено");

}
findNumber(array, number);


