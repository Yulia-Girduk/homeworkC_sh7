// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Выводим сообщения для пользователя и возвращаем введенные данные пользователем.
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Выводим массив на экран.
void PrintArray(double[,] tableArray)
{
    Console.WriteLine();
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write($"{tableArray[i, j]}      ");
        }
        Console.WriteLine();
    }
}

// Генерируем (задаем) массив вещественных чисел.
double[,] GenerateArray(int numberRow, int numberColumn)
{
    double[,] tableArray = new double[numberRow, numberColumn];
    for (int i = 0; i < tableArray.GetLength(0); i++)
    {
        for (int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = new Random().NextDouble();
        }
    }
    return tableArray;
}

int numberRow = Prompt("Введите значение количества строк массива");
int numberColumn = Prompt("Введите значение количества столбцов массива");

double[,] tableArray = GenerateArray(numberRow,numberColumn);
PrintArray(tableArray);
