 void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Задайте длину массива ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение для массива ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальное значение для массива ");
int max = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int[size];

FillArray(array, min, max);
PrintArray (array);
Console.WriteLine(" ");

int result = 0;
for (int i = 0; i < size/2; i++)
{ 
    result = array[i]*array[size-1-i];
    Console.WriteLine($"Произведение пары чисел: {result}");
} 
    



