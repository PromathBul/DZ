// ** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
System.Console.Clear();
System.Console.Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
System.Console.Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
int[,] array=FillArray(m,n);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine();
for(int i=0;i<array.GetLength(0);i++)
    SortArrayLine(array,i);
PrintArray(array);

void SortArrayLine(int[,] array,int LineNumber)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (array[LineNumber,j] < array[LineNumber,j + 1])
            {
                int tmp = array[LineNumber,j];
                array[LineNumber,j] = array[LineNumber,j + 1];
                array[LineNumber,j + 1] = tmp;
            }
        }
    }
}


int[,] FillArray(int rows,int len)
{
    int[,] array=new int[rows,len];
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(-10,10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
           if(array[i,j]<0)if(array[i,j]/10!=0)
           System.Console.Write($" {array[i,j]}");else System.Console.Write($"  {array[i,j]}");
           else
           if(array[i,j]/10!=0)
           System.Console.Write($"  {array[i,j]}");else System.Console.Write($"   {array[i,j]}");
        }
        WriteLine();
    }
}


