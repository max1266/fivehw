Console.Clear();
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
double result = 0;
double min = 100;
double max = 0;
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min){
        min = array[i];
    }
}
result = max - min;
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine(result);
