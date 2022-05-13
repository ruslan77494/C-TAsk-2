// : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72

int number = new Random().Next(10,1000);

string strr = number.ToString();

Console.WriteLine($"{number} -> {strr[0]}{strr[2]}");


