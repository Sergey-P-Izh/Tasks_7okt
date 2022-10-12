Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
	Console.WriteLine($"{count} -> {count*count*count}");
	count = count + 1;
}
