//10 adet mesaj
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine();

//1-20 arasindaki sayilar
Console.WriteLine("1-20 arasindaki sayilar");

for (int i = 1;i <= 20; i++)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n--------------------------------------");

//1-20 arasindaki cift sayilar
Console.WriteLine("1-20 arasindaki sayilar");

for (int i = 2; i <= 20; i+=2)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n--------------------------------------");

//50-150(dahil) arasindaki sayilarin toplami
Console.WriteLine("50-150(dahil) arasindaki sayilarin toplami");
int total = 0;

for (int i = 50; i <= 150; i++)
{
    total += i;
}
Console.Write(total.ToString());

Console.WriteLine("\n--------------------------------------");

//1-120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı
Console.WriteLine("1-120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı");

int oddTotal = 0, evenTotal = 0;

for(int i = 1;i < 120; i++)
{
    if (i % 2 == 0)
        evenTotal += i;
    else
        oddTotal += i;
}  
Console.WriteLine($"Cift sayilarin toplami = {evenTotal}");
Console.WriteLine($"Cift sayilarin toplami = {oddTotal}");