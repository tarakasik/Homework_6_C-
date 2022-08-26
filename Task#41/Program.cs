// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Clear();
Console.Write("Input numbers by a space ' ': ");
string[] userNumbers = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int positiveNumbers = 0;

for (int i = 0; i < userNumbers.Length; i++)
{
    if (int.Parse(userNumbers[i]) > 0)
    {
        positiveNumbers++;
    }
}
Console.WriteLine($"Numbers > 0 : {positiveNumbers}");
