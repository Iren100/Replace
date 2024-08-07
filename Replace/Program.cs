﻿//number 1
using Replace;

var mas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

var run35 = new Run35(mas);
var r = run35.ActionConverter();
Console.WriteLine(string.Join(",", r));

//number 2
var mas2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

run35 = new Run35(mas2);
r = new Run47(mas2, run35).ActionConverter();
Console.WriteLine(string.Join(",", r));

//number 3
var run35new = new Run35new(mas2);
r = new Run47new(mas2, run35new).ActionConverter();
Console.WriteLine(string.Join(",", r));

//factory
Console.WriteLine();

Creator cr = new ConcreteCreator1(mas2);
Product pr = cr.FactoryMethod();
Console.WriteLine(string.Join(",", pr.Znach));

cr = new ConcreteCreator2(mas2);
pr = cr.FactoryMethod();
Console.WriteLine(string.Join(",", pr.Znach));

Console.ReadLine();


