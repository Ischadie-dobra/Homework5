//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*

Не работает, всю голову сломала. 
Массив выводит, но не считает четные числа
Но я пыталась

int[] FillArrayWhithRandomNumber(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(100, 1000);
}
return array;
}
System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

void FindEven(int[] Array)
{
    int even = 0;
        for(int i = 0; i < array.Length; i++)
    {    
        if(array[i] % 2 == 0)
          {
            even = even + 1;
          }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + even);
}
*/




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] array = new int[size];
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(1, 100);
}
return array;
}
System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int sum = 0;

for (int z = 1; z < array.Length; z+=2)
    sum = sum + array[z];

    Console.WriteLine($"Сумма элементов cтоящих на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 1; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,100);
        }
}
*/







//Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
//[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

//Все, сдаюсь. Не получается.
// из этой задачи могу тольео задать массив. Дальше ничего не работает.

Console.WriteLine("Введите числа через пробел:");
string[] arrayNumber =  Console.ReadLine().Split(' ');
Console.WriteLine($"[{string.Join(", ", arrayNumber)}]");

double min = 0;
double max = 0;
for(int i = 0; i < arrayNumber.Length; i++)
{
    if (arrayNumber[i] > max)
        {
            max = arrayNumber[i];
        }
    if (arrayNumber[i] < min)
        {
            min = arrayNumber[i];
        }
      double diff = max - min; 
      return diff; 
}




Console.WriteLine($"Максимальный элемент массива = {max}, минимальный элемент массива = {min}");













/*


double[] numbers = {size};
double min = numbers[0];
double max = numbers[0];

foreach (double num in numbers)
{
    if (num < min)
        min = num;
    if (num > max)
        max = num;
}

double difference = max - min;
Console.WriteLine($"[{string.Join(", ", numbers)}]");
Console.WriteLine($"Разница между минимальным и максимальным элементами: {difference}");
*/