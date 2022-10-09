// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

void Table (int num)
{
    if (num >= 1)
        {
            int counter = 1;
            while (counter <= num)
            {
                Console.WriteLine ($"{counter, 5}  {Math.Pow((counter), 3), 5}");
                counter ++;
            } 
        }
    else
    {
        Console.WriteLine ("Введено некорректное значение");
    }
}

Table (number);