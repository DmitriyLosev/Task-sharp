// 0. Вывести квадрат числа
// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32 (Console.ReadLine());
// int kvadrat(int n)
// {
//     return  n * n;
// }
// int kv = kvadrat(n);
// Console.WriteLine($"{n} в квдрате = {kv}");
// 1. По двум заданным числам проверять является ли первое квадратом второго
// Console.WriteLine("Введите первое число");
// int n1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int n2 = Convert.ToInt32 (Console.ReadLine());
// bool kvadrat1(int n1,int n2)
// {
//     if (n1 == n2 * n2) return true;
//     else return false;
// }
// if (kvadrat1(n1, n2) == true) 
// Console.WriteLine($"{n1} является  квадратом {n2}");
// else
// Console.WriteLine($"{n1} не является  квадратом {n2}");
// 2. Даны два числа. Показать большее и меньшее число 
// Console.WriteLine("Введите первое число");
// int n1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int n2 = Convert.ToInt32 (Console.ReadLine());

//     if (n1 > n2) Console.WriteLine($"{n1} большее число");
//     if (n1 < n2) Console.WriteLine($"{n2} большее число");
//     if (n1 == n2) Console.WriteLine($"числа {n1} и {n2} равны ");

// 3. По заданному номеру дня недели вывести его название
// Console.WriteLine("Введите номер дня недели от 1 до 7");
// int numberDay = Convert.ToInt32 (Console.ReadLine());
// string dayWeek(int numberDay)
// {
//     string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//     return week[numberDay-1];
// }
// if (numberDay == 0 || numberDay > 7 || numberDay < 0)
// Console.WriteLine($"Ввведите число от 1 до 7");
// else
// Console.WriteLine($"{numberDay} день недели это {dayWeek(numberDay)}");
//  4. Найти максимальное из трех чисел 

// Console.WriteLine("Введите первое число");
// int n1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int n2 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int n3 = Convert.ToInt32 (Console.ReadLine());
// int max(int n1, int n2, int n3)
// {
//     int Max = n1;
//     if (n1 > n2 && n1 > n3) Max = n1 ;
//     if (n2 > n1 && n2 > n3) Max = n2 ;
//     if (n3 > n1 && n3 > n2) Max = n3 ;
//     return Max;
// }
// int Max = max(n1, n2, n3);
// Console.WriteLine($"Максимальное число = {Max}");
// 5. Написать программу вычисления значения функции y=f(a) 
// 6. Выяснить является ли число чётным 
// Console.WriteLine("Введите  число");
// int a = Convert.ToInt32 (Console.ReadLine());
// bool chet( int a)
// {
//     if (a % 2 == 0) return true;
//     else return false;
// }
// if (chet(a) == true) 
// Console.WriteLine("Число чётное");
// else 
// Console.WriteLine("Число не чётное");
//7. Показать числа от -N до N
// Console.WriteLine("Введите  число N");
// int N = Convert.ToInt32 (Console.ReadLine());
// void PrintN(int N)
// {
//         for(int index = - N; index <= N; index++)
//     {
//         Console.Write($"{index}, ");
//     }

// }
// PrintN(N); //!!!!!!!!!!!!!!!!зачем?
//  8. Показать четные числа от 1 до N 
// Console.WriteLine("Введите  число N");
// int N = Convert.ToInt32 (Console.ReadLine());
// void PrintN(int N)
// {
//         for(int index = 1; index <= N; index++)
//     {
//         Console.Write($"{index}, ");
//     }

// }
// PrintN(N); //!!!!!!!!!!!!!!!!зачем?

// 9. Показать последнюю цифру трёхзначного числа
// Console.WriteLine("Введите  трёхзначное число");
// int N = Convert.ToInt32 (Console.ReadLine());
// int Metod3 (int N)
// {
//     return N % 10;
// }
// int N3 = Metod3(N);
// Console.WriteLine($"Последняя цифра трёхзначного числа это {N3}");
// 10. Показать вторую цифру трёхзначного числа
// Console.WriteLine("Введите  трёхзначное число");
// int N = Convert.ToInt32 (Console.ReadLine());
// int Metod2 (int N)
// {
//     return N % 100 / 10;
// }
// int N2 = Metod2(N);
// Console.WriteLine($"Вторая цифра трёхзначного числа это {N2}");
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int N = new Random().Next(10, 100);
// Console.WriteLine($"{N}");
// int maxx(int N)
// {
//     int a = N / 10;
//     int b = N % 10;
//     int Max = a;
//     if (a > b) Max = a;
//     if (a < b) Max = b;
//     return Max; 
// }
// int Maximum = maxx(N);
// Console.WriteLine($"Наибольшая цифра в числе {Maximum}");

// 12. Удалить вторую цифру трёхзначного числа
// int N = new Random().Next(100, 1000);
// Console.WriteLine($"{N}");
// int maxx(int N)
// {
//     int a = N / 100;
//     int b = N % 10;

//     return a*10+b; 
// }
// int Maximum = maxx(N);
// Console.WriteLine($"Ответ {Maximum}");


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// bool num(double N, double n)
// {
//   if (N % n == 0 ) return true;
//   else return false;
// }
// if (num(N, n)==true);
// Console.WriteLine("Число  кратно числу");
// else
// Console.WriteLine("Число  не кратно числу , остаток равен");

// Console.WriteLine("Введите первое число");
// double n1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число");
// double n2 = Convert.ToInt32 (Console.ReadLine());
// bool num(double n1,double n2)
// {

//     if (n1 % n2 == 0) return true;
//     else return false;
// }
// if (num(n1, n2) == true) 
// Console.WriteLine($"число {n1} кратно числу  {n2}");
// else
// Console.WriteLine($"{n1} не кратно числу {n2}, остаток равен {(n1 % n2)}");


// 14. Найти третью цифру числа или сообщить, что её нет*/ 
// int N = new Random().Next(1, 1000);
// Console.WriteLine(N);
// bool find(int N)
// {
//     if (N > 99) return true;
//     else return false;
// }
// if (find(N) == true) 
// Console.WriteLine($"Третья цифра {N%10}");
// else
// Console.WriteLine($"Третьей цифры нет");

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
int N = new Random().Next(1, 10000000);
Console.WriteLine(N);
bool find(int N)
{

  if (N % 7 == 0 && N % 23 == 0) return true;
  else return false;

}
if (find(N) == true) 
Console.WriteLine($"Число {N} кратно 7 и 23");
if (find(N) == false)
Console.WriteLine($"Число {N} не кратно 7 и 23");


// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// Console.WriteLine("Введите номер дня недели от 1 до 7");
// int numberDay = Convert.ToInt32 (Console.ReadLine());
// string dayWeek(int numberDay) 
// {
//     string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//     return week[numberDay-1];
// }
// if (numberDay == 0 || numberDay > 7 || numberDay < 0)
// Console.WriteLine($"Введите число от 1 до 7"); //??????????????????????????????
// if (numberDay == 6 || numberDay == 7)
// Console.WriteLine($"Это {dayWeek(numberDay)} выходной день");
// else
// Console.WriteLine($"{numberDay} день недели это {dayWeek(numberDay)} и является будним");

// 17. По двум заданным числам проверять является ли одно квадратом другого
// int N1 = new Random().Next(1, 100);
// Console.WriteLine(N1);
// int N2 = new Random().Next(1, 100);
// Console.WriteLine(N2);
// bool kvadr(int N1, int N2)
// {
//     if (N1 == N2 * N2 || N2 == N1 * N1) return true;
//     else return false;
// }
// if (kvadr(N1, N2) == true)
// Console.WriteLine("Да является");
// else
// Console.WriteLine("Нет, не является");

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y



// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int x = new Random().Next(-100, 100);
// Console.WriteLine($"Задана координата x = {x}");
// int y = new Random().Next(-100, 100);
// Console.WriteLine($"Задана координата y = {y}");
// int chet = 0;
// int metod (int chet)
// {   

//     if (x > 0 && y > 0) chet = 1 ;
//     if (x < 0 && y > 0) chet = 2 ;
//     if (x < 0 && y < 0) chet = 3 ;
//     if (x > 0 && y < 0) chet = 4 ;
//     return chet;

// }
// chet = metod(chet);
// Console.WriteLine($"Точка находиться в четверти номер {chet}");

// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом

// 23. Показать таблицу квадратов чисел от 1 до N 
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32 (Console.ReadLine());
// for(int n = 1; n <= N; n++)
//     {
//         Console.WriteLine($"Квадрат числа {n} = {n * n}");
//     }
// 24. Найти кубы чисел от 1 до N
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32 (Console.ReadLine());
// for(int n = 1; n <= N; n++)
//     {
//         Console.WriteLine($"Куб числа {n} = {n * n * n}");
//    }
// 25. Найти сумму чисел от 1 до А
// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32 (Console.ReadLine());
// int metod(int A)
// {
//     int result = 0;
//     for(int n = 1; n <= A; n++)
//     {
//         result = result + n;
//     }
//     return result;
// }
// int res = metod(A);    
// Console.WriteLine($"Сумма чисел от 1 до {A} = {res}");
// 26. Возведите число А в натуральную степень B используя цикл
// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень B");
// int B = Convert.ToInt32(Console.ReadLine());
// int step(int A, int B)
// {
//     int result = 1;
//     while (B--> 0) result *= A; // B-- пока B уменьшается до 1.
    //// for(int B1 =1; B1 <= B; B1++)
    //// {   
    ////     result = result * A;
    ////     Console.WriteLine(result);

    // }  
//     return result;
// }
// int st = step(A, B);
// Console.WriteLine($"A ^ B = {st}");
// 27. Определить количество цифр в числе
// int A = new Random().Next(1, 999999999);
// Console.WriteLine(A);
// int kol(int A)
// {   
        
//         int count = 0;
//         while(A > 1)
//         {   
//             A = A / 10;
//             count++;
//         }
//         return count;
// }
// int koll = kol(A);
// Console.WriteLine($"Количество цифр в {A} = {koll}");


// 28. Подсчитать сумму цифр в числе
// int A = new Random().Next(1, 1000);
// Console.WriteLine(A);
// int kol(int A)
// {       
//         int sum = 0;
//         while( A >= 1)
//         {   
//             int B = A % 10;
//             sum = sum + B;
//             A = A / 10;
//         }
//         return sum;
// }
// int koll = kol(A);
// Console.WriteLine($"Сумма цифр в {A} = {koll}");

//Console.WriteLine(kol(111111));

// 29. Написать программу вычисления произведения чисел от 1 до N
// int N = 10;
// int i = 1;
// int proizvedenie(int N)
// {   
//     int sum = 1;
//     while(i < N )
//     {
//         sum = sum*(i+1);
//         Console.WriteLine(sum);
//         i++;
//     }
//     return sum;

// }
// int pr = proizvedenie(N);
// Console.WriteLine($"Произведение чисел от 1 до {N} = {pr}");


// 30. Показать кубы чисел, заканчивающихся на четную цифру от 1 до N
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine($"Кубы чисел, заканчивающихся на четную цифру от 1 до {N}");
// int kubchet(int res)
// {   
//         int result = 0;
//         for(int n = 2; n*n*n <= N; n+=2)
//         {   
//             result = n*n*n;
//             Console.WriteLine(result);
//         }
//     return result;
// }
// kubchet(N);

// Почувствуй себя сеньором
//31. Задать массив из 8 элементов и вывести их на экран 
// string PrintArray(char[] array)
// {   
//     string result = string.Empty ;
//     for (int index = 0; index < array.Length; index++)
    
//         result += $"{Convert.ToChar(new Random().Next(100, 240))}";
//         return result;
    
// }
// char[] array = new char[8];
// Console.WriteLine("массив их 8 элементов");
// Console.WriteLine(PrintArray(array));


// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int PrintArray(int[] array)
// {   
//     int result = 0;
//     for (int index = 0; index < array.Length; index++)
//     {
//         result = new Random().Next(0, 2);
//         Console.Write($"{result} ");
//     }
//         return result;
    
// }
// int[] array = new int[8];
// Console.WriteLine("массив их 8 элементов c 0 и 1");
// PrintArray(array);
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// int[] CreatArray(int count)

// int Array(int[] array)//[0,1,2,3,4,5,6,7,8,9]
// {   
//     int index = 0;
//     for (; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(0, 10); 
//     }
//         return array[index];
// }

// int PrintArray(int[] array)
// {
//     int index = 0;
//     for (; index < array.Length; index++)
//      Console.Write($"array[index] ");
//     return array[index];
// }

// int[] array = new int[12];
// PrintArray(array);
// Array(array);
// Console.WriteLine("массив их 12 элементов от 0 до 9");

//_____________________________________________________________________
// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

int[] CreateArray(int count) // Метод создания массива
{
    return new int[count];
}

void FillArray(int[] array) // метод заполнения массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void FillArray2(int[] array, int minValue, int maxValue) // метод заполнения массива 2 способ
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] array) // метод печать массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string PrintArray2(int[] array) // метод печать массива
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int Sum(int[] array) // метод нахождения суммы положительных значения массива
{
    int count = array.Length;
    int sumP = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] > 0) sumP += array[i];
    }
    return sumP;
}
// использование методов в одном блоке
int[] arr = CreateArray(10);
FillArray2(arr, 0, 3);
Console.WriteLine(PrintArray2(arr));
int s = Sum(arr);
Console.WriteLine(s);








// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива