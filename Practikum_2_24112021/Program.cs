//* GameInit() - метод, который задает все исходные значения в вашей игре.
// * MakeMove() - ходы, задаются этим методом.
// * RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
// * CheckNumber(int PlayesrNumber, int SecretNumber)
// * GameOver(bool winner) - 



int CreateSecretNumber(int min, int max) // Метод создаёт число от мин до макс CreateSecretNumber(1, 100)
{
    return new Random().Next(min, max);
}
int RequestNumber(int PlayesrNumber) // Метод просит игрока ввести число из диапозона мин макс
{
    Console.WriteLine("Начинаем, попытайтесь угадать какое число загадал компьютер");
    PlayesrNumber = Convert.ToInt32(Console.ReadLine());
    if (PlayesrNumber > max) Console.WriteLine("Вы ввели число более 100, введите от 1 до 100");
    if (PlayesrNumber < min) Console.WriteLine("Вы ввели число меньше 1, введите от 1 до 100");
    return PlayesrNumber;
}
bool MakeMove(int SecretNumber, int count)
{
    int PlayesrNumber = RequestNumber;
    if (PlayesrNumber == SecretNumber)
    {
        return true;
    }
    if (PlayesrNumber > SecretNumber)
    {
        Console.WriteLine("Ваше число больше загаданного");
    }
    else
    {
        Console.WriteLine("Ваше число меньше загаданного");
    }
    return false;
}

Console.WriteLine("Консольная игра <<Угадай число>>");
Console.WriteLine($"У вас 3 попытки, что бы угадать число от 1 до 100");
int count = 3;
int min = 1;
int max = 100;
int SecretNumber = CreateSecretNumber(min, max);
RequestNumber(PlayesrNumber);
MakeMove();



