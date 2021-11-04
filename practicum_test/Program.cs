
// //Задача 2
// //Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// //Создать на его основе масив B, отбрасывая те, которые нарушают порядок

// //возрастания
// //элементы, больше 8
// //знакочередования

int length = 10;
int[] arrayA = new int[length];
int indexA = 0;
int minValue = -100;
int maxValue = 100;

while (indexA < length)
{
    arrayA[indexA] = new Random().Next(minValue, maxValue);
    indexA++;
}

indexA = 0;

while (indexA < length)
{
    Console.WriteLine($"A{indexA + 1} = {arrayA[indexA]}");
    indexA++;
}

int[] arrayB = new int[length];
int indexB = 0;
indexA = 0;
while (indexB < (length - 1))
{
    arrayB[indexB] = arrayA[indexA];
    indexA++;
    indexB++;
}

Console.WriteLine("Массив В, не нарушающий порядок возрастания: ");
indexA = 0;
indexB = 0;
int newIndB = 1;
int currentElement = arrayB[0];
Console.WriteLine($"B{newIndB} = {currentElement}");
while (indexB <= (length - 1))
{
    if (arrayB[indexB] > currentElement)
    {
        Console.WriteLine($"B{newIndB + 1} = {arrayB[indexB]}");
        currentElement = arrayB[indexB];
        newIndB++;
    }
    indexB++;
}

Console.WriteLine("Массив В, где элементы не больше 8: ");
indexB = 0;
newIndB = 1;
while (indexB <= (length - 1))
{
    if (arrayB[indexB] < 8)
    {
        Console.WriteLine($"B{newIndB} = {arrayB[indexB]}");
        newIndB++;
    }
    indexB++;
}

Console.WriteLine("Массив В, со знакочередованием элементов: ");
indexB = 0;
newIndB = 1;
currentElement = arrayB[indexB];
Console.WriteLine($"B{newIndB} = {currentElement}");
while (indexB < length)
{
    if (((currentElement > 0) && (arrayB[indexB] < 0)) || ((currentElement < 0) && (arrayB[indexB] > 0)))
    {
        
        Console.WriteLine($"B{newIndB + 1} = {arrayB[indexB]}");
        currentElement = arrayB[indexB];
        newIndB++;
    }
    indexB++;
}