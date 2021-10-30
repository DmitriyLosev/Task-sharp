int numberA = new Random().Next(1, 10); //int тип данных для хранения целых чисел. После знака равно оператор генератор псевдо случайных чисел от 1 до 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
