// Задайте массив, заполненный случайными положительными 3-значными числами. Напишите программу, которая покажет кол-во четных чисел в массиве
int[]array = new int[10];
FillArray(array);
PrintArray(array);
SumEvenNumbers(array);
void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random.Next(100,1000);
    }
}
void PrintArray(int[] array);
Console.WriteLine($"{array[]}");
void SunEvenNumbers(int[] array)
{
for (int i=0; i<array.Length; i++)
sum++;
}
Console.WriteLine("The numver of even digits is" +sum);