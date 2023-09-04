﻿// ЗАДАЧА:
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

System.Console.Write("Введите количество элементов ");
int size = System.Convert.ToInt32(System.Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = System.Convert.ToString(System.Console.ReadLine());
    arrayStrings[i] = element;
}
string[] arrayElements = new string[size];
int leng = 3;
int position = 0;

for (int e = 0; e < size; e++)
{
    if (arrayStrings[e].Length <= leng)
    {
        arrayElements[position] = arrayStrings[e];
        position++;
    }
}
System.Console.WriteLine();
PrintArray(arrayElements);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Элементы соответствующие требованиям массива [{array[i]}]");
    }   
     
    System.Console.WriteLine();
}