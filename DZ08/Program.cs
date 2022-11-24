/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
string numberline = Console.ReadLine().Replace(" ","");
int maxindex = numberline.Length - 1;
string result = "является";

for (int i = 0; i <= maxindex; i++) {

    if (numberline[i] != numberline[maxindex - i])
    {
        result = "не является";
        break;
    }    
}

Console.WriteLine($"Введенное значение {result} палиндромом");
