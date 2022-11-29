﻿/* Написать программу, которая из имеющиегося массива строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно 
ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
обойтись исключительно массивами. */

int ArrayThree(string[] text)                            // Задаем длину массива
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3) count++;
    }
    return count;
}
