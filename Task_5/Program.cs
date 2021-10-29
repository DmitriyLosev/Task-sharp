Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine(); // тип данных строка переменная username = считываем данные Console.ReadLine()
if(username.ToLower() == "маша") // if - если, далее в скобках условие, переменная == в кавычках имя,ToLower() переводит в нижний регистр 
{
    Console.WriteLine("Мы рады тебя видеть Маша"); // в фигурных скобках действие если условие выполняется
}
else // иначе 
{
    Console.Write("Привет, "); // если условие if не выполняется переходим в else - иначе
    Console.WriteLine(username);
}
