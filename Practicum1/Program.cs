﻿//Задача
//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые

//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные
int[] array = new int[10]; //создаём новый массив на 10 значений
int index = 0;
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();

// Исключение элементов нарушения возрастания
//int index1 = 0;
//int[] array1 = new int[10];
int currentElement = array[0];
Console.WriteLine(currentElement);
index = 1;
while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
        //array1[index1] = array[index];
        //Console.WriteLine(array1[index1]);
        //index1++;
    }
    index++;
}

//больше среднего арифметического элементов A
index = 0;
int result = array.Length;
int sum = 0;

while (index < result)
{
    sum = sum + array[index];
    index++;
}

int aref = sum/result;
Console.WriteLine($"Среднее арефметическое {aref}");

index = 0;
while (index <= 9)
{
    if(array[index] < aref)
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
//убираем чётные
Console.WriteLine();
index = 0;
while (index <= 9)
{
    if(array[index] % 2 !=0  )
    {
        Console.WriteLine(array[index]);
    }
    index++;
}
