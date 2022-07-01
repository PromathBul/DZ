// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9

// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0

// Результат
// 16 4 18
// 84 16 16
// 107 18 28


using System;
using static System.Console;
Clear();
Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
int[,] array1=FillArray(m,n);
PrintArray(array1);
WriteLine();
int[,] array2=FillArray(m,n);
PrintArray(array2);
// int[,] array1={{6,0,2},{0,4,8},{0,7,9}}; 
// int[,] array2={{0,0,3},{5,0,4},{8,2,0}}; проверочный код при запуске данного кода верхнюю часть кода надо удалить
// PrintArray(array1);
// WriteLine();
// PrintArray(array2);
WriteLine("Матрица произведения двух этих массивов:");
PrintArray(ProizvArray(array1,array2));

int[,] ProizvArray(int[,]array1,int[,] array2)
{   
    int[,] ProizvArray = new int[array1.GetLength(0), array2.GetLength(1)];
 
        for (int i = 0; i < array1.GetLength(0); ++i)
            for (int j = 0; j < array2.GetLength(0); ++j)
                for (int k = 0; k < array2.GetLength(1); ++k)
                    ProizvArray[i, k] += array1[i, j] * array2[j, k];
    return ProizvArray;
}

int[,] FillArray(int rows,int len)
{
    int[,] array=new int[rows,len];
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(0,5);
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
