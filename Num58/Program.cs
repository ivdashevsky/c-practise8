//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

int [,] multiplArray(int [,] arr1, int [,] arr2)
{
    int [,] res = new int [arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            res[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    return res;
}


int m = 5;
int n = 9;

int [,] array1 = getArray(m,n);
int [,] array2 = getArray(m,n);
printArray(array1);
Console.WriteLine();
printArray(array2);
Console.WriteLine();
printArray(multiplArray(array1,array2));
