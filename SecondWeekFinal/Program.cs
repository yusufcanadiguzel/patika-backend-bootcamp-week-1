using System.Xml.Linq;

// 1 - Aşağıdaki çıktıyı yazan bir program: Merhaba Nasılsın ? İyiyim Sen nasılsın ?
Console.WriteLine("1 - Aşağıdaki çıktıyı yazan bir program: Merhaba Nasılsın ? İyiyim Sen nasılsın ?");
Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
Console.WriteLine("2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.");
string firstName = "yusufcan";
int number = 0;
Console.WriteLine($"{number} - {firstName}");

// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Console.WriteLine("3 - Rastgele bir sayı üretip , ekrana yazdırınız.");
Random random = new Random();
Console.WriteLine(random.Next());

// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Console.WriteLine("4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.");
Console.WriteLine(random.Next() % 3);

// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.WriteLine("5 - Kullanıcıya yaşını sorup , 18'den büyükse \"+\" küçükse \"-\" yazdıran bir uygulama.");
Console.Write("Lütfen yaşınızı giriniz: ");
var age = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine((age < 18) ? "-" : "+");

// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
Console.WriteLine("6 - Ekrana 10 defa \" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.\" yazan bir uygulama.");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("7 - Kullanıcıdan 2 adet metinsel değer alıp \"Gülse Birsel\" , \"Demet Evgar\" , bunların yerlerini değiştiriniz.");
Console.Write("Lütfen araya virgül koyarak iki isim giriniz: ");
var userInput = Console.ReadLine()!;
var names = userInput.Split(',');
names[0] = "Gülse Birsel";
names[1] = "Demet Evgar";
foreach (var name in names)
    Console.WriteLine(name);

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
Console.WriteLine("8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana \"Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma\" yazsın.");
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
static int Sum(int firstNumber, int secondNumber) => firstNumber + secondNumber;

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
static string ReturnChoice(string choice)
{
    Console.Write("Lütfen bir değer seçiniz (true/false): ");
    var userInput = Console.ReadLine()!;
    var result = (choice == "true") ? "Doğru" : "Yanlış";
    return result;
}
ReturnChoice("false");

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.");
static int FindOldest(int firstAge, int secondAge, int thirdAge)
{
    return (firstAge > secondAge) ? ((firstAge > thirdAge) ? firstAge : thirdAge) : ((secondAge > thirdAge) ? secondAge : thirdAge);
}
FindOldest(12,11,14);

// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
Console.WriteLine("12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.");
static int FindBiggest(params int[] numbers)
{
    var result = numbers.Max();

    Console.WriteLine(result);

    return result;
}
FindBiggest(1, 2, 3, 4, 5, 11, 12, 13, 14, 15);

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.");
static void ChangeNames(string name)
{
    Console.Write("Lütfen araya virgül koyarak iki isim giriniz: ");
    var userInput = Console.ReadLine()!;
    var userGivenNames = userInput.Split(',');
    var tempName = userGivenNames[0];
    userGivenNames[0] = userGivenNames[1];
    userGivenNames[1] = tempName;
    foreach (var n in userGivenNames)
        Console.WriteLine(name);
}

// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.");
static bool IsOddNumber(int number)
{
    return (number % 2 == 0) ? false : true;
}
IsOddNumber(12);

// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.");
static void FindTotalDistance()
{
    Console.Write("Lütfen hız bilgisini km cinsinden giriniz: ");
    var speed = int.Parse(Console.ReadLine()!);

    Console.Write("Lütfen zaman bilgisini saat cinsinden giriniz: ");
    var time = double.Parse(Console.ReadLine()!);

    Console.WriteLine($"Gidilen mesafe: {speed * time}km");
}
FindTotalDistance();

// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.");
static void FindAreaOfCircle(int radius)
{
    Console.WriteLine($"Dairenin alanı: {Math.PI * Math.Pow(radius, 2)}");
}
FindAreaOfCircle(10);

// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
Console.WriteLine("17 - \"Zaman bir GeRi SayIm\" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.");
string text = "Zaman bir GeRi SayIm";
Console.WriteLine(text.ToLower());
Console.WriteLine(text.ToUpper());

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
text = "    Selamlar   ";
static void TrimText(ref string text)
{
    text.Trim();
}
TrimText(ref text);