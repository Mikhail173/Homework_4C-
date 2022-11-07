//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// То ли задача поставлена не правильно, то ли примеры не от нее.
// Я сделал, чтобы вводился размер массива, заполнялся случайными
// числами, максимальное из которых тоже вводилось, и массив выводился в консоль.
Console.WriteLine("Input the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max number");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = GetArray(size);

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(0,max+1);
    }
    return array;
}
Console.WriteLine(String.Join(",",array));
