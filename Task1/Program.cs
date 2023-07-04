// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пять символов: ");
string? N = Console.ReadLine();

if(N.Length != 5) 
{
    Console.WriteLine("Введено не пять символов!");
    Environment.Exit(0);
}

bool check1(string? i)
{
    if (i[0] == i[4])
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool check2(string? i)
{
    if (i[1] == i[3])
    {
        return true;
    }
    else
    {
        return false;
    }
}

if(check1(N) && check2(N))
{
    Console.WriteLine("Введенное выражение является палиндромом!");
}
else
{
    Console.WriteLine("Введенное выражение НЕ является палиндромом.");
}
