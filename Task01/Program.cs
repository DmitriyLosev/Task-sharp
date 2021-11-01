//Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые

//делятся на k, но не на l
//делятся хотябы на k или на l
//не делятся на (k + l)

//1. делятся на k, но не на l
Random rnd = new Random();
int n = rnd.Next(100, 1000);
int k = rnd.Next(1, 10);
int l = rnd.Next(1, 10);
int index = 0;
int count = 0;
while(index < n)
{
    if(index % k == 0 && index % l !=0)
    {
        count++;
    }
    
    index++;  
    
}
Console.WriteLine($"количество натуральных чисел не превосходящих заданного числа {n}, которые делятся на {k}, но не на {l} равно {count}");
Console.WriteLine();
//1. делятся на k, или на l
index = 0;
count = 0;
while(index < n)
{
    if(index % k == 0 || index % l ==0)
    {
        count++;
    }
    
    index++;  
    
}
Console.WriteLine($"количество натуральных чисел не превосходящих заданного числа {n}, которые делятся на {k} или на {l} равно {count}");
//не делятся на (k + l)
Console.WriteLine();
index = 0;
count = 0;
while(index < n)
{
    if(index % (k+1) != 0)
    {
        count++;
    }
    
    index++;  
    
}
Console.WriteLine($"количество натуральных чисел не превосходящих заданного числа {n}, которые не делятся на ({k} + 1) равно {count}");