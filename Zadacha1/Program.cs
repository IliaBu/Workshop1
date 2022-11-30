/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
double max = number1;

if (number1 > max) {
    max = number1;
}
if (number2 > max) {
    max = number2;
}

Console.WriteLine("a = " + Convert.ToString(number1) + ", b = " + Convert.ToString(number2) + " -> max = " + Convert.ToString(max));