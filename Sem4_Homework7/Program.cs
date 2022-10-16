void PrintArray (double[] array)
{
   for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}
double [] array = {0.34, 8.56, 4.32, -9.47, 3.25};
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
  if (array[i]>max) max = array[i];
}
for (int i = 0; i < array.Length; i++)
{
  if (array[i]<min) min = array[i];
}

double result = max-min;
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива {result}");