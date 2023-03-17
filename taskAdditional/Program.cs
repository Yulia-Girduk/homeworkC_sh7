// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Вводим значения для работы с массивом
int Prompt (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Заполняем массив
int[] GenerateArray (int numLength, int numStart, int numEnd)
{
    int[] array = new int[numLength];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(numStart, numEnd+1);
    }
    return array;
}

//Выводим массив на экран
void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length-1) Console.Write($"{array[i]} ");// выводим все элементы массива,кроме последнего
        else Console.Write($"{array[i]}");// выводим последний элемент массива
    }
    Console.Write($"]");
}

// Проверяем есть ли сумма двух элементов массива равная target
(int,int) CheckOutTwoSumElementsIsTarget(int[] array, int target)
{
    int index1 = 0;
    int index2 = 0;
    bool endTask = false;
    for (int i = 0; i < array.Length-1; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i]+array[j]== target)
            {
                index1 = i;
                index2 = j;
                endTask = true;
                break;
            }
        }
        if (endTask) break;
    }
    return (index1,index2);
}

int numberLength = Prompt("Введите значение длины массива: ");

int numberStart = Prompt("Введите начальное значение для заполнения массива: ");
int numberEnd = Prompt("Введите конечное значение для заполнения массива: ");

int target = Prompt("Введите число для проверки суммы target: ");


int[] arrayNumbers = GenerateArray(numberLength, numberStart, numberEnd);
PrintArray(arrayNumbers);

Console.WriteLine();

(int index1, int index2) = CheckOutTwoSumElementsIsTarget(arrayNumbers, target);
Console.WriteLine($"Сумма элементов массива с индексами [{index1}, {index2}] = {target}");


