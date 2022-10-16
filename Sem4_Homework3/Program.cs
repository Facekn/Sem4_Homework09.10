void FillArray(int[] array)
{
   int length = array.Length;
   for (int i = 0; i < length; i++)
   {   
      array[i] = new Random().Next(100,999);
   }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];
FillArray(array);
PrintArray(array);

int sumchet = 0;
int sumnechet = 0;

for (int i = 0; i < array.Length; i++)
{    
    if (array[i]%2==0)
    {
       int count = 1; 
       sumchet = sumchet + count;
       count++;
    }
    else
    {
       int count = 1; 
       sumnechet = sumnechet + count;
       count++;
    }
}
Console.WriteLine();
Console.WriteLine($"В массиве {sumchet} четных чисел"); 
Console.WriteLine($"В массиве {sumnechet} нечетных чисел");
