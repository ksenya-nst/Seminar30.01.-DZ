// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a > 99 && a < 1000)
{
    System.Console.WriteLine($"Вторая цифра равна {(a / 10) % 10}");
}
else{
    System.Console.WriteLine("Введено не трехзначное число");
}