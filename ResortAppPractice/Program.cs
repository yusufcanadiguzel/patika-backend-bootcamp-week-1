string location, tripType, userDecide;
int peopleCount, locationPrice = 0, tripPrice = 0;
bool isCorrect = false, isFinished = false;

do
{
    //lokasyonları listeleme
    Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");

    do
    {
        //kullanıcıdan lokasyon tercihi ister
        Console.Write("Lütfen gitmek istediğiniz lokasyonu seçiniz (bodrum/marmaris/çeşme) : ");
        location = Console.ReadLine()!.ToLower();

        //hata kontrolü yapar
        if (location == "bodrum" || location == "marmaris" || location == "çeşme")
        {
            //lokasyona göre fiyatı belirler
            locationPrice = (location == "bodrum") ? 4000 : ((location == "marmaris") ? 3000 : 5000);
            Console.WriteLine();
            isCorrect = true;

        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyiniz.");
        }

    } while (!isCorrect);

    //kullanıcıdan kişi sayısını ister
    Console.Write("Lütfen kaç kişi olucağını giriniz: ");
    peopleCount = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    //kullanıcıyı bilgilendirir
    Console.WriteLine($"Tatil lokasyonunuz: {location} - Kişi sayısı : {peopleCount}");
    Console.WriteLine();

    //yolculuk tipi listeler
    Console.WriteLine("Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

    do
    {
        //kullanıcının ulaşım tercihini alır
        isCorrect = false;
        Console.Write("Lütfen kullanmak istediğiniz ulaşım türünü seçiniz (1/2) : ");
        tripType = Console.ReadLine()!.ToLower();

        //hata kontrolü yapar
        if (tripType == "1" || tripType == "2")
        {
            //ulaşım türüne göre fiyatı belirler
            Console.WriteLine();
            tripType = (tripType == "1") ? "Kara ulaşımı" : "Hava ulaşımı";
            tripPrice = (tripType == "Kara ulaşımı") ? 1500 : 4000;
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyiniz.");
        }
    } while (!isCorrect);

    //son bilgilendirme
    Console.WriteLine($"Tatil lokasyonu: {location} - Kişi sayısı: {peopleCount} - Ulaşım türü: {tripType}");
    Console.WriteLine($"Toplam tutar: {locationPrice + peopleCount * tripPrice}");

    //kullanıcının son kararını alır
    Console.Write("Tatili planlamak istiyor musunuz? (e/h) : ");
    userDecide = Console.ReadLine()!.ToLower();

    if (userDecide == "e")
        Console.WriteLine("Sonraki aşamaya geçiliyor...");
    else
        Console.WriteLine("İyi günler dileriz.");

    Console.WriteLine("---------------------------------------------------------");
} while (!isFinished);