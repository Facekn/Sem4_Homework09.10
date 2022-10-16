void FillArray(int[] array)
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      array[i] = new Random().Next(-9,10);
   }
}
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($" {array[i]} ");
    }
}
int[] array = new int[12];

FillArray (array);
PrintArray(array);


int sumpol = 0;
int sumotr = 0;

for (int i = 0; i < array.Length; i++)
{ 
    if (array[i] > 0)
    {      
      sumpol = sumpol + array[i];
    }
    else 
    {
        sumotr = sumotr + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма положительных чисел массива - " + sumpol);
Console.WriteLine("Сумма отрицательных  чисел массива - " + sumotr);