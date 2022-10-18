// Программа, котрая на входе принимает значение, а на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

Console.Write("Введие число: ");
string inputString = Console.ReadLine();
Double number = Convert.ToDouble(inputString);
Double ReverNumber = 1 / number;
Console.Write($"{ReverNumber:F2}");   // Округление, 2 знака после запятой.



