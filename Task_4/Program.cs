/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] arrayNumbers = new int[2,2,2];

int[] temp = { 11, 22, 33, 44, 55, 66, 77, 88};
int b = 0;
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
       
        for (int a = 0; a < arrayNumbers.GetLength(2); a++)
        {
            arrayNumbers[i, j, a] = temp[b];
            b++;
        }
    }
}

for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
    {
        for (int a = 0; a < arrayNumbers.GetLength(2); a++)
        {
            Console.Write($"{arrayNumbers[i, j, a]}({i},{j},{a})  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}