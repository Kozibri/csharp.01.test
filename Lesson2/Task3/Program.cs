﻿/*
Задание 3. Работа в сессионных залах
Семинар 2. Простые алгоритмы на C#
Напишите программу, которая будет принимать на вход два
числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит
остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/

int a = 16;
int b = 8;
if (a % b == 0)
    {
        System.Console.WriteLine("да");
    }
else
    {
        System.Console.WriteLine("нет" + "," + " " + (a % b));
    }