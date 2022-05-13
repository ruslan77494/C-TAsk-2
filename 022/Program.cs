/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то 
программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
1*/

Console.WriteLine(" Пожалуйста Введите Первое Число");
string fistnNumberStr = Console.ReadLine();
Console.WriteLine("Пожалуйста Введите Второе  Число");
string secondNumberStr = Console.ReadLine();

int first = int.Parse(fistnNumberStr);
int second = int.Parse(secondNumberStr);
int result = first % second;

if(result == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"Не кратно, остаток {result}");

