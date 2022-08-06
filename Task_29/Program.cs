// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Примеры:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int N = 8;
Console.WriteLine("Введите 8 чисел ");
int[] myArray = new int[N];
for (int i = 0; i < N; i++)
    myArray[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
    Console.Write("{0} ", myArray[i]);