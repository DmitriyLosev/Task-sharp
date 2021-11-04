//Работа с текстами
//Дан текст:

//- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали вместо нашего
// Винценгероде, вы бы взяли приступом согласие прусского короля.
// Вы так красноречивы. Вы дадите мне чаю?

//В текстенужно все пробелы заменить черточками
// маленькие быквы "к" заменить на большие
// а большие "С" на маленькие
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего Винценгероде, "
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//            012345  // номера символов внути кавычек
// s[3]     //    обращение к символу  

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty; // пуста строка
    int length = text.Length; // обращаемся к свойству показывающему количество символов в строке
    for (int i = 0; i < length; i++)
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
