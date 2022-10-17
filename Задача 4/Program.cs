// Задача 4
Console.Clear();
Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if ((a > b) && (a > c)){
    Console.WriteLine("Max = " + a);
}else if((b > a) && (b > c)){
    Console.WriteLine("Max = " + b);
}
else if((c > a) && (c > b)){
    Console.WriteLine("Max = " + c);
}
Console.WriteLine();
