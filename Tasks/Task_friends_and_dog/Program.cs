Console.WriteLine($"Задача: Сколько раз пробежит собака от одного друга к другому, пока они идут на встречу друг другу?");
Console.WriteLine($"Введите дистанцию между друзьями");
double distance = Convert.ToDouble (Console.ReadLine()); //Дистанция между друзьями
Console.WriteLine($"Введите скорость первого друга");
double firstfriendspeed = Convert.ToDouble (Console.ReadLine()); // скорость первого друга
Console.WriteLine($"Введите скорость второго друга");
double secondfriendspeed = Convert.ToDouble (Console.ReadLine()); // скорость второго друга
Console.WriteLine($"Введите скорость собаки");
double dogspeed = Convert.ToDouble (Console.ReadLine()); // скорость собаки
int friend = 2; // собака первый пробег начинается от второго друга к первому
int count = 0; // количество пробегов
double time = 0; // дополнительная переменная для расчёта остатка дистанции
Console.WriteLine($"Введите дистанцию между друзьями где они остановяться");
double end = Convert.ToDouble (Console.ReadLine()); // расстояние между друзьми, до которго нужно вести подсчёт количества пробегов собаки
while (distance > end) //Выполнять цикл  ниже (в фигурных скобках) пока дистанция между друзьми больше 10 (end в условии равен 10)
{
    if(friend == 1) // если переменная friend ровна 1, то выполяется условия ниже в фигурных скобках
    {
            time = distance / (firstfriendspeed + dogspeed); 
            friend = 2; // значение переменной friend меняется на два, блок else пропускаем и переходим к подсчёту дистанции
    } 
    else // иначе, а это значит переменная friend  рована 2, то выполняется условие ниже
    {
        time = distance / (secondfriendspeed + dogspeed);
        friend = 1; // значение переменной friend меняется на один и происходит переход к расчёту дистанции
    } 
    distance = distance - (firstfriendspeed + secondfriendspeed) * time ; //подсчёт оставшейся дистанции между друзьями за один пробег собаки
    count++; // счётчик количества пробега собаки между друзьями, после каждого прохождения циклв, увличивается на 1
    distance = Math.Round(distance, 2); 
    Console.Write($"Между друзьями осталось {distance} метров, "); //доплнительно показывает дистанцию между друзьями после каждого пробега собаки
    Console.WriteLine($"собака пробежала {count} раз"); // счётчик после каждого пробега собаки
}
distance = Math.Round(distance, 2); //погуглил и нашел как округлить полученные значения, в скобках указываем перменную, после запятой, сколько знаков оставить
Console.WriteLine($"Расстояние между друзьями {distance} метров");
Console.WriteLine($"Результат: Пока друзья идут на встречу к друг другу, собака пробежит {count} раз(а)");