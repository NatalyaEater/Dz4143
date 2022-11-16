// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-7, 567, 89, 223->3

Console.Clear();
Console.Write("Введите любое колличество чисел через запятую ");


NewMetod(Console.ReadLine());

void NewMetod(string args)
{
int[] newNum = Array.ConvertAll(args.Split(','), int.Parse);
int count = 0;
for (int i = 0; i < newNum.Length; i++)
{
    if (newNum[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввел чисел больше нуля {count} ");
}
