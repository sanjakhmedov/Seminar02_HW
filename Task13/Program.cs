// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет. Решить без использования строк.

// Console.Write("Please enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = num;
// int result = 0;
// // int find = 0;

// if (num / 100 == 0)
// {
//     Console.WriteLine("There is no 3rd number!!!");
// } 
// else
// {
//     while (index / 100 == 0)
//     {
        
//         result = num / 10;
//         Console.WriteLine(result);
//     }
//     Console.WriteLine(result % 10);
// }


int num = Convert.ToInt32(Console.ReadLine());



int result = num;
int div = 0;
int index = 100;
while (index < 10)
{
    result = num / div;
    Console.WriteLine(index + ": " + result);
    index++;
    num += 100;
    
}
Console.WriteLine(result);
