int ReadInt(string message)
{
    Console.Write(message + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}

void Nember(int num)
{
      int negativNumbers = 0;
      int positivNumbers = 0;
      int[] array = new int[num];

for(int i = 0; i < array.Length; i++)
     {
    array[i] = new Random().Next(100,1000); 
    Console.Write( array[i] + " | ");
     }
   Console.WriteLine();
for (int i = 0;i < num; i++)
     {
    if(array[i] % 2 == 0)
    {
        positivNumbers++;
    }
    else
    {
        negativNumbers++;
    }

     }
     Console.WriteLine(" Положительных чисел в массиве -> " + positivNumbers);

}



Nember(ReadInt("Введите колличество элементов в массиве"));