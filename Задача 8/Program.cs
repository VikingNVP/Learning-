// \Задача 8
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;
for(int i = b; i <= a; i += 2)
{
    Console.Write(i);
    Console.Write(',');
}
