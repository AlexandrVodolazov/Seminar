// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите число: ");
string value = Console.ReadLine();
int dayweek = Convert.ToInt32(value);

if (dayweek == 1)
{
    Console.WriteLine("Понедельник");
}

if (dayweek == 2)
{
    Console.WriteLine("Вторник");
}

if (dayweek == 3)
{
    Console.WriteLine("Среда");
}

if (dayweek == 4)
{
    Console.WriteLine("Четверг");
}

if (dayweek == 5)
{
    Console.WriteLine("Пятница");
}

if (dayweek == 6)
{
    Console.WriteLine("Суббота");
}

if (dayweek == 7)
{
    Console.WriteLine("Воскресенье");
}

if(dayweek < 1 || dayweek > 7)
{
    Console.WriteLine("Дни недели закончились!!!");
}




