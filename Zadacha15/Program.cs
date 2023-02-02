﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет


System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        System.Console.WriteLine("Понедельник - будний день");
        break;
    case 2:
        System.Console.WriteLine("Вторник - будний день");
        break;
    case 3:
        System.Console.WriteLine("Среда - будний день");
        break;
    case 4:
        System.Console.WriteLine("Четверг - будний день");
        break;
    case 5:
        System.Console.WriteLine("Пятница - будний день");
        break;
    case 6:
        System.Console.WriteLine("Суббота - выходной день");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье - выходной день");
        break;
    default:
        System.Console.WriteLine("Такого дня недели не существует");
        break;
}
