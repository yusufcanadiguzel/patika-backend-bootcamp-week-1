//Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int counter = 1;

while (counter <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    counter++;
}

Console.WriteLine("-----------------------------------------------------");

//1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
counter = 1;

while (counter <= 20)
{
    Console.WriteLine(counter);

    counter++;
}

Console.WriteLine("-----------------------------------------------------");

//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
counter = 2;
while (counter <= 20)
{
    if(counter % 2 == 0)
        Console.WriteLine(counter);

    counter++;
}

Console.WriteLine("-----------------------------------------------------");

//50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
counter = 50;
int total = 0;

while (counter <= 150)
{
    total += counter;
    counter++;
}

Console.WriteLine("50 ile 150 arasındaki sayıların toplamı " + total);

//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int oddTotal = 0, evenTotal = 0;
counter = 1;

while (counter <= 120)
{
    if (counter % 2 == 0)
        evenTotal += counter;
    else
        oddTotal += counter;

    counter++;
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + oddTotal);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenTotal);