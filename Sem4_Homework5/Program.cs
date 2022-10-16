void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
      Random size = new Random();
      array [i] = size.Next(min, max);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

Console.WriteLine("Задайте длину массива");
int size = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите минимальное значение для массива ");
int min = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите максимальное значение для массива ");
int max = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];

FillArray( array, min, max);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==1)
    {
       sum = sum + array[i];
    }
    else
    {
      sum = sum+0;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях, равна  {sum}");