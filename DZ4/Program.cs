// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)
using System;
using static System.Console;
Clear();
Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
Write("Введите глубину массива  ");
int g=int.Parse(ReadLine());
int[,,] array=FillArray(m,n,g);
PrintArray(array);



int[,,] FillArray(int rows,int len,int Ranc)
{
    Random rng = new Random();
    int[,,] array=new int[rows,len,Ranc];
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            array[i,j,k]=rng.Next(10,100);
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{   
    
    for(int i=0;i<array.GetLength(0);i++)
    {   
        for(int j=0;j<array.GetLength(1);j++)
        {  for(int k=0;k<array.GetLength(2);k++)
            {
                Write($"{array[i,j,k]}({i},{j},{k})   ");
            }
        WriteLine();
        }
    }
}
