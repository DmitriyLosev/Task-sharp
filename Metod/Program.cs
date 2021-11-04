// Методы
// Вид 1, не принимают аргументы и ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор");
}
Method1();
//Вид 2, принимают аргументы, но ничего не возвращают
void Method2(string msg) // в скобках аргумены
{
    Console.WriteLine(msg);
}
Method2(msg: "тест сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; // увеличение счётчика на еденицу называется инкримент, уменьшение декриментом
    }
}
Method21("Текст", 4); //Вызов метода, увидим текст 4 раза
Method21(count: 4, msg: "новый текст"); // 2 вариант

//Вид 3, не принимают аргументы, но возвращают
int Method3() // оюязательно указываем тип данных, аргументы не указываем в скобках
{
    return DateTime.Now.Year; // обязательно return
}
int year = Method3();
Console.WriteLine(year);
//Вид 4, методы который что то принимают и что то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res =  Method4(10, "z");
Console.WriteLine(res);