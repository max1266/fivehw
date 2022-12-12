Console.Clear();
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int summ = 0;
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99,100);
    if( i % 2 !=0)
    {
        summ = summ + array[i];
    }
   
}
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(summ);