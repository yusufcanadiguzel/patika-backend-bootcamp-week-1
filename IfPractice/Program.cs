int number;

//Kullanicidan sayi isteniyor
Console.Write("Lutfen bir sayı giriniz: ");

//Kullanicidan sayi aliniyor
number = int.Parse(Console.ReadLine()!);
Console.WriteLine();

//Esitlik kontrolleri
if (number < 10)
    Console.WriteLine("Girilen sayi 10'dan kucuktur.");
else if (number == 10)
    Console.WriteLine("Girilen sayi 10'a esittir");
else
    Console.WriteLine("Girilen sayi 10'dan buyuktur");

//Tek-cift kontrolu
if (number % 2 == 0)
    Console.WriteLine("Girilen sayi cifttir");
else
    Console.WriteLine("Girilen sayi tektir");
