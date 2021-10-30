﻿//Задача 2
//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
//Создать на его основе масив B, отбрасывая те, которые нарушают порядок

//возрастания
//элементы, больше 8
//знакочередования
int[] array = new int[10]; //создаём новый массив на 10 значений
int index = 0;
int minValue = -50;
int maxValue = 50;
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(minValue, maxValue); // [-50, -49]
    
    index++;
}

index = 0;
// печатаем массив
Console.WriteLine("Массив А");
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив B, Исключены элементы нарушающие порядок возрастания в массиве А");
// Исключение элементов нарушения возрастания

int currentElement = array[0];
Console.WriteLine(currentElement);
index = 1;

while (index <= 9)
{
    if(array[index]>currentElement)
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
        
    }
    index++;
}



//Исключаем значения больше 8
Console.WriteLine();
Console.WriteLine("Массив B, исключены значения больше 8 из массива A ");
index = 0;
while (index <= 9)
{
    if(array[index] < 8  )
    {
        
        Console.WriteLine(array[index]);
    }
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив B, исключены значения нарушающие знакочередования в массиве A ");
currentElement = array[0];
Console.WriteLine(currentElement);
index = 1;
while (index <= 9)
{
    if(currentElement > 0 && array[index] < 0 )
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    
    if(currentElement < 0 && array[index] > 0 )
    {
        Console.WriteLine(array[index]);
        currentElement = array[index];
    }
    index++;
}