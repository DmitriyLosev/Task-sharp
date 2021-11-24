// int[] CreateArray(int count) // Метод создания массива целых чисел
// {
//     return new int[count];
// }



// char[] CreateArrayChar(int count) // Метод создания массива символов
// {
//     return new char[count];
// }
// // void FillArray2(int[] array) // метод заполнения массива
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

// void FillArray(int[] array, int minValue, int maxValue) // метод заполнения массива 2 способ
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
// }

// void FillArrayChar(char[] array, int minValue, int maxValue) // метод заполнения массива 2 способ
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = Convert.ToChar(new Random().Next(minValue, maxValue));
//     }
// }

//void PrintArray2(int[] array) // метод печать массива
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// string PrintArray(int[] array) // метод печать массива
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }

// string PrintArrayChar(char[] array) // метод печать массива
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }


// int Replace(int [] array)
// {
    
//     int count = array.Length; // обращаемся к свойству показывающему количество символов в строке
//     for (int i = 0; i < array.length; i++)
//         if(array[i] > 0  ) result = result *(-1);
//         else result = result *(-1);
//     return result;
// }

                              // Почувствуй себя сеньором

//31. Задать массив из 8 элементов и вывести их на экран 

// Console.WriteLine("массив их 8 элементов");
// char[] arr = CreateArrayChar(8);
// FillArrayChar(arr, 100, 240);
// Console.WriteLine(PrintArrayChar(arr));

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// Console.WriteLine("массив их 8 элементов c 0 и 1");
// int[] arr = CreateArray(8);
// FillArray(arr, 0, 2);
// Console.WriteLine(PrintArray(arr));

// 33. Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
// int Sum(int[] array) // метод нахождения суммы положительных значения массива
// {
//     int count = array.Length;
//     int sumP = 0;
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i] > 0) sumP += array[i];
//     }
//     return sumP;
// }
// int Raz(int[] array) // метод нахождения суммы отрицательных значения массива
// {
//     int count = array.Length;
//     int razP = 0;
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i] < 0) razP += array[i];
//     }
//     return razP;
// }
// // использование методов в одном блоке
// int[] arr = CreateArray(10);
// FillArray(arr, 0, 10);
// Console.WriteLine(PrintArray(arr));
// int s = Sum(arr);
// int r = Raz(arr);
// Console.WriteLine(s);
// Console.WriteLine(r);

// 34. Написать программу замену элементов массива на противоположные

// Console.WriteLine("Первоначальный массив A");
// int[] arr = CreateArray(10);
// FillArray(arr, -10, 10);
// Console.WriteLine(PrintArray(arr));
// void Replace(int[] arr)
// {
//     for(int index = 0; index < arr.Length; index++)
//     arr[index] *= -1;  
// }
// Replace(arr);
// Console.WriteLine(PrintArray(arr));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// Console.WriteLine("Заданный массив");
// int[] arr = CreateArray(5);
// FillArray(arr, 1, 5);
// Console.WriteLine(PrintArray(arr));
// int N = new Random().Next(1, 5);
// Console.WriteLine($"Задано число {N}");
// int index = 0;
// void number(int N)
// {   
//     while(index < arr.Length)
//     {
//     if (arr[index] == N)  Console.WriteLine($"Число {N} присутствует  в заданном массиве");

//     index++;
//     }
// }
// number(N);



    

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел

// Console.WriteLine("Заданный массив");
// int[] arr = CreateArray(10);
// FillArray(arr, 100, 1000);
// Console.WriteLine(PrintArray(arr));
// int sum = 0;
// int Nechet(int Sum) 
// {
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         if (arr[i] % 2 != 0) sum ++;
//     }
//     return sum;
// }
// int Chet = Nechet(sum);
// Console.WriteLine($"В массиве {Chet} нечётных чисел");


// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Console.WriteLine("Заданный массив");
// int[] arr123 = CreateArray(123);
// FillArray(arr123, 1, 999);
// Console.WriteLine(PrintArray(arr123));
// int Count = 0;
// int count(int Count)
// {   
//     for(int index = 0; index < arr123.Length; index++)
//     {
//         if (arr123[index] >= 10 && arr123[index] < 99 ) Count++;
//     }
//     return Count;
// }
// int kol = count(Count);
// Console.WriteLine($"В массиве {kol} элементов из отрезка [10,99]");

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// Console.WriteLine("Заданный массив");
// int[] arr = CreateArray(5);
// FillArray(arr, 1, 10);
// Console.WriteLine(PrintArray(arr));
// int sum = 0;
// int SumOddPozition( int sum)
// {   
//     for(int index = 0; index < arr.Length; index++ )
//     {
//         if (index % 2 !=0) sum = sum + arr[index];
//     }
//     return sum;
// }
// int Sum = SumOddPozition(sum);
// Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции равна {Sum}");
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Console.WriteLine("Заданный массив");
// int[] arr = CreateArray(10);
// FillArray(arr, 1, 10);
// Console.WriteLine(PrintArray(arr));
// int first = arr[0];
// int last = arr[arr.Length-1];
// Console.WriteLine("Произведение пар чисел");
// string result = string.Empty;
// string duet(int[] Duet)
// {       
//     string result = string.Empty;
//     for(int index = 0; index < arr.Length /2 ; index++ )
//     { 
//          result += $"{arr[index] * arr[arr.Length-1-index]} ";
         
//     }
//     return result;
    
// }
// string res = duet(arr);
// Console.WriteLine(res); 

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


// double[] mass = new double[10] {2.1, 2.5, 3.4, 5.7, 6.9, 1.4, 3.5, 7.2, 8.1, 3.6};
// Console.WriteLine($"Заданный массив {mass}");
// double max(double[] Max)
// {   
//     double max = mass[0];
//     for(int index = 1; index < mass.Length; index++)
//     if(mass[index] > max) max = mass[index];
//     return max;
// }
// double maximum = max(mass);
// Console.WriteLine($" Максимальное число {maximum}");
// double min(double[] Min)
// {   
//     double min = mass[0];
//     for(int index = 1; index < mass.Length; index++)
//     if(mass[index] < min) min = mass[index];
//     return min;
// }
// double minimum = min(mass);
// Console.WriteLine($" Минимальное число {minimum}");

// double raz(double maximum, double minimum)
// {
//     return maximum - minimum;
// }
// double raznica = raz(maximum, minimum);
// Console.WriteLine($"Разница между максимальным и минимальным элементом равна {raznica :f1}");

// double[] CreateMass(int count) // Метод создания массива целых чисел
// {
//     return new double[count];
// }

// void FillMass(double[] mass) // метод заполнения массива 
// {
//     int count = mass.Length;
//     for (int i = 0; i < count; i++)
//     {
//         mass[i] = new Random().NextDouble()*100;
//     }
// }
// string PrintMass(double[] mass) // метод печать массива
// {
//     int count = mass.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{mass[i]:f2} ";
//     }
//     return res;
// }

// double[] mass = CreateMass(10);
// FillMass(mass);
// Console.WriteLine(PrintMass(mass));

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 

// int a = 6;
// int b = 6; 
// int c = 6;
// bool treug(int a, int b,int c)
// {   
//     return ((a < b + c) && (b < a + c) && (c < a + b));
    //if ((a < b + c) && (b < a + c) && (c < a + b))  return true ; 
    //else return false;
}
// if (treug(a, b, c) == true) 
// Console.WriteLine($"Три числа {a}, {b}, {c} являются сторонами треугольника");
// if (treug(a, b, c) == false)
// Console.WriteLine($"Три числа {a}, {b}, {c} НЕ являются сторонами треугольника");

// Console.WriteLine(treug(a,b,c));
// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите число");
string N = Console.ReadLine();


// 43. Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите десятичное число");
int N = Convert.ToInt32 (Console.ReadLine());
string dv(int N)
{       
        string Nbin = string.Empty;
        while(N > 0)
        {
        Nbin = (N % 2) + Nbin;
        N /=2;
        }
        return Nbin;
}
string number = dv(N);
Console.WriteLine(number);


// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива
