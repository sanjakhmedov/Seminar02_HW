// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

Console.Write("Please enter the number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
bool CheckDay(int num)
{
    return num == 6 || num == 7;
}

Console.WriteLine(CheckDay(day));