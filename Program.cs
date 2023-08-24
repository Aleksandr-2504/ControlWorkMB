/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
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
  if (arr.Length == 1) Write($"[{arr[arr.Length - 1]}]");
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

string[] ArrayStr3(string[] stringArrayN)//формирует массив не более 3-х символов 
{
  int n = new Random().Next(4);//рандомный интервал длины массива: 0,1,2,3 или [0, 4) 
  string[] resultNew = new string[n];
  if (resultNew.Length == 0)
    return resultNew;
  else
  {
    for (int i = 0; i < resultNew.Length; i++)
    {
      int j = new Random().Next(stringArrayN.Length);//интервал [0, stringArrayN.Length)
      resultNew[i] = stringArrayN[j];
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

