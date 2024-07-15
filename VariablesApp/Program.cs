Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");

//T.C. kimlik numarasi
Console.Write("T.C. Kimlik Numarasi: ");
string tcNumber = Console.ReadLine()!;
Console.WriteLine();

//Ad
Console.Write("Adi: ");
string ad = Console.ReadLine()!;
Console.WriteLine();

//Soyad
Console.Write("Soyadi: ");
string soyad = Console.ReadLine()!;
Console.WriteLine();

//Telefon numarasi
Console.Write("Telefon Numarasi: ");
string phoneNumber = Console.ReadLine()!;
Console.WriteLine();

//Yas
Console.Write("Yas: ");
int yas = int.Parse(Console.ReadLine()!);
Console.WriteLine();

//Ilk urun fiyati
Console.Write("Ilk Aldigi Urunun Fiyati: ");
int firstProduct = int.Parse(Console.ReadLine()!);
Console.WriteLine();

//Ikinci urun fiyati
Console.Write("Ikinci Aldigi Urunun Fiyati: ");
int secondProduct = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("-----------------------------------------------------");

int totalPrice = firstProduct + secondProduct;

//Bilgilerin ekrana yazilmasi
Console.WriteLine($"{tcNumber} Tc numarali {ad} {soyad} isimli kisi icin kayit olusturulmustur.");
Console.WriteLine($"{phoneNumber} telefon numarasina bildirim mesaji gonderilmistir.");
Console.WriteLine($"{totalPrice} toplam harcama karsiligi kazanilan 10% patika puan miktari -> {totalPrice / 10} TL'dir.");