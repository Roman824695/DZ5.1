int ReadInt(string message)
{
    Console.Write(message + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}


// Помогите пожалуйста. Все пытаюсь разобраться с функциями. 
//Не знаю как из функции(Array) вытянеть массив чтобы потом его использовать в новой функции(Sum).

/*
int[] Array(int num)
{
int[] array = new int[num];

for(int i = 0; i < array.Length; i++)
     {
    array[i] = new Random().Next(-100,100); 
   Console.Write( array[i] + " | ");
     }
     return array[];
}

int Sum(int array[])
{
    int sum = 0;

for (int i = 0;i < array.Length; i++)
     {
    if(i % 2 == 0)
    {
        sum += array[i];
    }
    else
    {
        sum2 += array[i];
    }

}
Console.WriteLine("Сумма чисел массива который расположен на не четных позициях ровна -> " + sum2);
}


Array(ReadInt("Введите число из скольки будет состоять массив"));

Sum(Array());
*/


void Array(int num)
{
int[] array = new int[num];

for(int i = 0; i < array.Length; i++)
     {
    array[i] = new Random().Next(-100,100); 
   Console.Write( array[i] + " | ");
     }
     Console.WriteLine("  ");
      int sum = 0;
      int sum2 = 0;

for (int i = 0;i < array.Length; i++)
     {
    if(i % 2 == 0)
    {
        sum += array[i];
    }
    else
    {
        sum2 += array[i];
    }

}
Console.WriteLine("Сумма чисел массива который расположен на не четных позициях ровна -> " + sum2);
}



Array(ReadInt("Введите колличество элементов в массиве"));