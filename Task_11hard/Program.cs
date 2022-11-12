// Задача 11 HARD - необязательная: Напишите программу,
// которая принимает на вход целое число любой разрядности 
// и удаляет вторую цифру слева направо этого
// числа. И, конечно же, через строку решать нельзя:

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
// int x > 0;
int digitsCount = (int)Math.Log10(x) + 1; // всего цифр в числе
int multiplier = (int)Math.Pow(10, digitsCount - 2); // множитель предпоследнего разряда
int result = x % multiplier + x / multiplier / 10 * multiplier; // все что справа от разряда + все что слева, делённое на 10
Console.WriteLine("Значение числа с удаленной второй цифрой: " +result);
