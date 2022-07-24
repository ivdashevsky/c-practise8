// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int minSumRows(int [,] a)
{
    //Одномерный массив, заполняющий в каждый элемент сумму строки двумерного массива
    int [] sumArray = new int [a.GetLength(0)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
                sum = sum + a[i,j];
        }
        sumArray[i] = sum;
    }
    //Min элемент
    int min = sumArray[0];
    int min_index = 0;
    for (int i = 0; i < sumArray.GetLength(0); i++)
    {
        if (sumArray[i] < min) 
        {
            min = sumArray[i];
            min_index = i;
        }
    }
    return min_index + 1;
}

int m = 3;
int n = 3;

int [,] array = getArray(m,n);
printArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с минимальной суммой элементов - {minSumRows(array)}");


