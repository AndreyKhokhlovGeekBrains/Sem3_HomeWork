// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное чило: ");
string? N = Console.ReadLine();


bool check1(string? i)
{
    if(i == null)
    {
        Console.WriteLine("Введено пустое значение.");
        return false;
    }
    else if (Convert.ToInt32(i[0]) == Convert.ToInt32(i[4]))
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
    if(i == null)
    {
        Console.WriteLine("Введено пустое значение.");
        return false;
    }
    else if (Convert.ToInt32(i[1]) == Convert.ToInt32(i[3]))
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
    Console.WriteLine("Число является палиндромом!");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом.");
}
