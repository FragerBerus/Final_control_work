﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
Console.Write("Введите количество элементов массива: ");
uint lengthArray = Convert.ToUInt32(Console.ReadLine());
var ArrayText = new string[lengthArray];
Console.Clear();
for (int i = 0; i < lengthArray; i++)
{
    Console.Write($"Введите текстовое значение {i + 1} элемента массива: ");
    ArrayText[i] = Convert.ToString(Console.ReadLine());
    Console.Clear();
}