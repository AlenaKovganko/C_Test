// Задача 2: Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.

Random rnd = new Random();
int [] array1 = new int [10];
int [] array2 = new int [array1.Length];


void CreateArray(int [] array1)
{
    for(int i =0; i <array1.Length; i++ )
    {
            array1[i] = rnd.Next(1,50);
    }
}
void PrintArray(int [] array1)
{
    for(int i =0; i <array1.Length; i++ )
    {
            Console.Write($"{array1[i],3}");
    }
}
void NumbersMoreThan8 (int [] array1)
{
    int index = 0;
    for(int i = 0; i <array1.Length; i++)
    {
          if(array1[i] > 8) 
           {
               array2[index] = array1[i];
               Console.Write($"{array2[index]} ");
           }
    }

}
CreateArray (array1);
Console.WriteLine("Рандомный массив из целых чисел");
PrintArray (array1);
Console.WriteLine();
Console.WriteLine("Массив из чисел, которые больше 8");
NumbersMoreThan8 (array1);