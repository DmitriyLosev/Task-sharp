Console.Clear(); // очищает окно теминала
//Console.SetCursorPosition(10, 4); // команда рисует точку, в скобакх отступ от левого края 10 символов и отступ от верхнего 4 символа
//Console.WriteLine("*"); // в теминале отобразиться хвездочка в указанных в строке 2 координатах
int xa = 40; // отступ по координате х 1 символ
int ya = 1; // отступ по координате у 1 символ, в строках 4 и 5 задали первую точку в координатах х и у
int xb = 1; // отступ по координате х 1 символ
int yb = 30; // отступ по координате у 30 символ, в строках 6 и 7 задали вторую точку в координатах х и у
int xc = 80;
int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");
int x = xa, y = xb; // в случайную точку х в неё кладем первую точку
int count = 0;
while(count < 10000) // пока count меньше чем 10
{
    int number = new Random().Next(0, 3); // генерируем случайное число с помощью генераторора псевдо случайных чисел в полуинтервалк 0,3 (0,1,2)
    if(number == 0) // если случайное число равно 0
    {
        x = (x + xa) / 2; // то в этом случае кладем в х середину отрезка первой вершины
        y = (y + ya) / 2;
    }
    if(number == 1)
    {
        x = (x + xb) / 2; 
        y = (y + yb) / 2;
    }
    if(number == 2)
    {
        x = (x + xc) / 2; 
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y); // устанавливаем курсор в нужнкю позицию
    Console.WriteLine("*");
    count++; // или count+=1 или count = count + 1
}
