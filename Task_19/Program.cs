// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощьttю числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

using System;

class Program {
static void Main(string[] args) {
    int num, temp, revNum = 0, rem;
Console.WriteLine("Enter a number : ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while (num > 0)
{
    rem = num %10;
    revNum = revNum * 10 + rem;
    num = num / 10;
}
if(revNum == temp)
   Console.WriteLine("Number is Palindrome"); 
else
   Console.WriteLine("Number is not Palindrome");

Console.ReadLine();    
}  
}