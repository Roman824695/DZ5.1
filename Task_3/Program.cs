int ReadInt(string message)
{
    Console.Write(message + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}


void Array(int number)
{
    double max = 0;
    double min = 0;
double[] array = new double[number];

for(int i = 0; i < array.Length; i++)
     {
    array[i] = new Random().Next(-100,100); 
   Console.Write( array[i] + " | ");
     }
     Console.WriteLine("  ");
      

for (int i = 0;i < array.Length; i++)
    {
        if(array[i] > max)
        {
              max = array[i];
        }

        if(array[i] < min)
        {
            min = array[i]; 
        }
    }
    double diff = max - min;
Console.WriteLine("разница между максимальным и минимальным элементом массива -> " + diff);

}



Array(ReadInt("Введите колличество элементов в массиве"));
