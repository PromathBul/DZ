// Задача 62. Заполните спирально массив 4 на 4
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
using System;
using static System.Console;
Clear();
Write("Введите число строк массива  ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов массива  ");
int n=int.Parse(ReadLine());
int[,] array=new int[m,n];

WriteLine();
WriteLine("Метод заполнения массива циклическим способом в два цикла");
array=FillArraySpiral(array);// Метод заполнения массива циклическим способом в два цикла, моя личная разработка
PrintArray(array);
array=new int[m,n];
WriteLine();

int count1=0;
bool Numeric=true;
WriteLine("Рекурсивный метод заполнения массива");
FillSpiralicArray(0,0);// Рекурсивный метод, моя личная разработка, до конца не довел
PrintArray(array);

WriteLine();
WriteLine("Уникальный метод заполнения квадратных массивов");
int[,] array1=Fillsquarearray();// уникальный метод заполнения квадратных массивов, подсмотрел на просторах инета
PrintArray(array1);

int[,] Fillsquarearray()// уникальный метод заполнения квадратных массивов, подсмотрел на просторах инета
{
int[,] A = new int[m, n];
            if(n==m){
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = n;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = n * (dirChanges % 2) + m * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            }else
            WriteLine("Массив не квадратный, заполнение данным методом невозможно");
return A;
}
 
            
void FillSpiralicArray(int x,int y)//Метод заполнения массива рекурсией
{   
   
    if(array[x,y]==0)
    {   
        count1++;
        array[x,y]=count1;
        if(y+1<array.GetLength(1)&&Numeric==true)  FillSpiralicArray(x,y+1);
        if(x+1<array.GetLength(0)&&Numeric==true) FillSpiralicArray(x+1,y);else Numeric=false;
        if(y-1>=0)FillSpiralicArray(x,y-1); 
        if(x-1>=0){FillSpiralicArray(x-1,y);}
    } else {
        Numeric=true;
        return;
    }
    Numeric=true;x--;y--;
}
int[,] FillArraySpiral(int[,]array)//Метод заполнения массива циклическим способом в два цикла
{   
    bool Signal=false, cod=true;
    int x=0,y=0,Step=0,count=1,Line=0;
    if(array.GetLength(1)>array.GetLength(0))Line=array.GetLength(0)/2;else Line=array.GetLength(1)/2;
    do
    {   while(Signal!=true)
        {
            
            if(array[x,y]==0)
            {   
                array[x,y]=count;
                if(Step==Line)Step--;
                if(y+1<array.GetLength(1)-Step&&cod==true){y++;}
                else
                if(x+1<array.GetLength(0)-Step&&cod==true){x++;}
                else
                if(y-1>=0+Step){y=y-1;cod=false;}
                else
                if(x-1>=0+Step){x-=1;}
            }else {Signal=true;cod=true;}
            count++;
            
        }
        ++Step;
        x+=1;
        y+=1;
        count--;
        if(array[x,y]!=0)Signal=true; else Signal=false;
    }
    while(!Signal);
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
