// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Welcome to the IsEven program!");
Console.WriteLine("Please, insert your number:");
var input = Console.ReadLine();
var number = default(int);
if (int.TryParse(input, out number))
{
    Console.WriteLine( number % 2 == 0 ? "да" : "нет");
}
else
{
    Console.WriteLine("Sorry, program could not handle inserted value... Bye!");
}