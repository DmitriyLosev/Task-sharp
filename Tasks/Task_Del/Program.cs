long index = 2;
long num = 600851475143;
while (index * index < num)
{
    if(num % index == 0 )
    {
        num = num / index;
    Console.WriteLine($"Остаок после деления {num}");
    Console.WriteLine($"делитель {index}");
    }
    else 
    {
        index++;
    }
}

Console.WriteLine($"Наибольший простой делитель делитель равен {num}");
  
