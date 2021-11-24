void FillArray(int[] collection) // метод void ничего не возвращает, и не используем оператор return
{
    int length = collection.Length; // получаем длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;

    }


}

void PrintArray(int[] col) // метод который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }



}

int Indexof(int[] collrction, int fihd)
{
    int count = collection.Length;
    int index = 0;
    while(index < count)

    {if(collection[index] == find
    
    
    }
    index++
}

int[] array = new int[10]; //создаём массив с 10 элементами, по умолчанию заполнен нулями
FillArray(array); // метод заполняет массив
PrintArray(array); // вывод на экран массива