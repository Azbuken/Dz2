// Задача 1 
// Напишите программу, которая принимает на 
// вход трехзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456->5
// 782->8
// 918->1

// int num = new Random().Next(100,1000); 
// Console.WriteLine(num);
// int a = num/10;
// int Result = a%10; 
// Console.WriteLine(Result);

// Задача 2
// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей 
// цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 326729 -> 6

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

// Задача 3
// Напишите программу, которая на вход принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 ->да
// 7 ->да
// 2 ->нет

// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine()); 

// if (num >= 1 && num <= 5) 
// { 
//     Console.Write("Нет, это не выходной день"); 
// } 
//  else if (num >= 6 && num <= 7) 
// { 
//     Console.Write("Да, это выходной день"); 
// } 
// else Console.Write("Не существует такого дня недели"); 


