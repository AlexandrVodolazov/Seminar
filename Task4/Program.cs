// Программа вычисления модуля числа.
//2->2
//-3->3
//-7->7

Console.Write("Please type the number: ");
int number = int.Parse(Console.ReadLine());

int mod = number;
if (number < 0)
{
    mod = -number;
}

Console.WriteLine(mod + "is abs of number");   // так же эту строку можно записать: ($"{mod} is abs of number");




