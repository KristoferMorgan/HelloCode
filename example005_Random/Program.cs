// Найти сумму двух чисел с случайными значениями
int Number_A = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(Number_A);
int Number_B = new Random().Next(1, 10); // 1 2 3 4....9
Console.WriteLine(Number_B);
int result = Number_A + Number_B;
Console.WriteLine(result);