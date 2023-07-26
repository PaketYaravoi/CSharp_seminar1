/* Задача 1 - Написать программу которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
 
a = 25 , b =5 -> Да
a = 2 , b = 10  ->  нет 
a = 9 , b = -3 -> да
a = -3 , b = 9-> нет */


Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()); // Конструкция Int.Pars() - позволяет конвертировать значение 
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()); //  из строковых типов данных в "интовое" (целочисленные числа)



if(number2*number2 == number1)
{
    Console.WriteLine($"число: {number1} - квадрат числа: {number2}");
}
else
{
    Console.WriteLine($"число: {number1} - не является квадратом числа:  {number2}");
}
