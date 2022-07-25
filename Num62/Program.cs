//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

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

int [,] arr = new int [4,4];
int plus = 1;
int i = 0;
int j = 0;

while (plus <= arr.GetLength(0) * arr.GetLength(1))
{
  arr[i, j] = plus;
  plus++;
  if (i <= j + 1 && i + j < arr.GetLength(1) - 1) j++;
  else if (i < j && i + j >= arr.GetLength(0) - 1) i++;
  else if (i >= j && i + j > arr.GetLength(1) - 1) j--;
  else i--;
}

printArray(arr);