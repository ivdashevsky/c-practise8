//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int [,] getArray(int mL, int nL)
{
    int [,] result = new int[mL,nL];
    for (int i = 0; i < mL; i++)
    {
        for (int j = 0; j < nL; j++)
        {
            result[i,j] = new Random().Next(0,11);
        }
    }
    return result;
}

void printArray(int [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) //0 - строка
    {
        for (int j = 0; j < a.GetLength(1); j++) //1 - столбец
        {
            Console.Write($"{a[i,j]} ");
        }      
        Console.WriteLine();
    }
}

void sortArray(int [,] a)
{
    int [,] newarr = new int [a.GetLength(0), a.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {

        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                    if (a[i,j] <= a[i,k])
                    {
                        int x = a[i,j];
                        a[i,j] = a[i,k];
                        a[i,k] = x;
                    }
            }
        }
    }
}

int m = 5;
int n = 8;

int [,] array = getArray(m,n);
printArray(array);
sortArray(array);
Console.WriteLine();
printArray(array);

