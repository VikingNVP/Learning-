// Задача 2
Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a < b) {
   Console.Write("Max = " + b + "\nMin = " + a);
} else if (a > b) {
   Console.Write("Max = " + a + "\nMin = " + b);
} else {
   Console.Write("Числа равны");
}
