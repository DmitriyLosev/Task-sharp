//2 способ
int Max(int arg1, int arg2, int arg3) // берем некоторые аргументы под номерами arg1 arg2 arg3
{ // описываем тело метода
    int result = arg1;  
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;

    return result; //необходимо что бы метод возвращал result
}
//определяем массив int[] и даём название массиву array, после знака равно в фигурных скобках перечисляем значени из массива
int[]  array = {1, 25, 15, 3, 21, 11, 47, 6, 9};
//array [0] = 12; // обращение к конкретному элементу массива, в квадратных скобках его индекс
//Console.WriteLine(array[5]);

   
// 2 способ
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
