//2 способ
int Max(int arg1, int arg2, int arg3) // берем некоторые аргументы под номерами arg1 arg2 arg3
{ 
    int result = arg1;  // описываем тело метода
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;

    return result; //необходимо что бы метод возвращал result
}
// 1 способ
int a1 = 12;
int b1 = 2522;
int c1 = 2;

int a2 = 55;
int b2 = 114;
int c2 = 3;

int a3 = 16;
int b3 = 99;
int c3 = 31;
   // 1 способ
//int max = a1;
//if (a1 > max) max = a1;
//if (b1 > max) max= b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max= b3;
//if (c3 > max) max = c3;

// 2 способ
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);