//Задача
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
Console.WriteLine("Массив А");
while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(val);
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив B, Исключены элементы нарушающие возрастание в массиве А");
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
Console.WriteLine("Массив B, исключены значения больше Средне арефметического масива A");
Console.WriteLine(aref);

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
Console.WriteLine("Массив B, исключены чётные значения из массива А");
index = 0;
while (index <= 9)
{
    if(array[index] % 2 !=0  )
    {
        
        Console.WriteLine(array[index]);
    }
    index++;
}

