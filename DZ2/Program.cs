// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
Clear();
Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
int[,] array=FillArray(m,n);
PrintArray(array);
WriteLine($"Строка с наименьшей суммой элементов имеет индекс: {GetMinSumLineIndex(array)+1}");

int GetMinSumLineIndex(int[,]array)
{
    int Index=0,Min=0;
    for(int i=0;i<array.GetLength(0);i++)
    {
        if(Min>sumLinteInArray(array,i))
        {
            Min=sumLinteInArray(array,i);
            Index=i;
        }
    }
    return Index;
}


int sumLinteInArray(int[,] array, int Line)
{
    int sum=0;
    for(int i=0;i<array.GetLength(1);i++)    
        sum+=array[Line,i];
    return sum;
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
           Write($" {array[i,j]}");else Write($"  {array[i,j]}");
           else
           if(array[i,j]/10!=0)
           Write($"  {array[i,j]}");else Write($"   {array[i,j]}");
        }
        WriteLine();
    }
}


