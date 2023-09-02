/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
        из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
        ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
        рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;
using static System.Console;

void PrintArr(string[] arr)//вывод на печать начального и конечного массивов
{
  if (arr.Length == 0) Write("[]");
  if (arr.Length == 1) Write($"[{arr[0]}]");
  if (arr.Length >= 2)
  {
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
      Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
  }
}

string[] ArrayStr3(string[] stringArrayN)//формирует массив эл-в не более 3-х символов 
{
  int n = 0;
  for (int i = 0; i < stringArrayN.Length; i++)//цикл для определения длины нового массива
  {
    if(stringArrayN[i].Length <= 5)//проверка количества символов в эл-те с учетом("")
    {
      n++;
    }
  }
  int m = 0;
  string[] resultNew = new string[n];
  for (int j = 0; j < stringArrayN.Length; j++)//определение значений эл-ов нового массива
  {
    if(stringArrayN[j].Length <= 5)//проверка количества символов в эл-те с учетом("")
    {
      resultNew[m] = stringArrayN[j];
      m++;
    }
  }
  return resultNew;
}

Clear();
Write("Введите M строк через запятую с пробелом: ");
string strM = ReadLine();
string[] array = strM.Split(", ");
string[] arrNew = ArrayStr3(array);
PrintArr(array);
Write(" -> ");
PrintArr(arrNew);


