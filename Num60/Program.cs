//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] getArray(int mL, int nL, int oL)
{
    int [,,] result = new int[mL,nL,oL];
    for (int i = 0; i < mL; i++)
    {
        for (int j = 0; j < nL; j++)
        {
            for (int k = 0; k < oL; k++)
            {
                result[i,j,k] = new Random().Next(10,100);
            }
        }
    }
    return result;
}

void printArray(int [,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(2); k++)
            {
               Console.WriteLine($"{a[i,j,k]} ({i},{j},{k}) ");
            }
        }      
        Console.WriteLine();
    }
}

//Перевод трёхмерного массива в одномерный

int [] toOneRow(int [,,] arr)
{
    int [] newArr = new int [arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                newArr[m] = arr[i,j,k];
                m++;
            }
        }
    }
    return newArr;
}

//Метод, считывающий одинаковые значения и заменяющий их на новый
int [] findSameNum(int [] arr)
{
    int m = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i>=1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                   arr[i] = new Random().Next(10, 100);
                   j = 0;
                   m = arr[i];
                }
            }
        }
    }
    return arr;
}

int [,,] array = getArray(2,2,2);
Console.WriteLine("Оригинальный трёхмерный массив");
printArray(array);
Console.WriteLine("Вывод трёхмерного массива в одну строку");
int [] oneR = toOneRow(array);
Console.WriteLine(String.Join(" ", oneR));
Console.WriteLine("Проверка на одинаковые значения и замена на уникальные");
findSameNum(oneR);
Console.WriteLine(String.Join(" ", oneR));
Console.WriteLine("Возвращение трёхмерного массива: ");

//Возвращение одномерного массива обратно в трёхмерный

array = new int [array.GetLength(0), array.GetLength(1), array.GetLength(2)];
int x = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k] = oneR[x];
            x++;
        }
    }
}
printArray(array);