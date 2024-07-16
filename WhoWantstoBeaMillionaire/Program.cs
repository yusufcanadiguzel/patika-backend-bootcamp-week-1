int correctAnswerCount = 0;
string userAnswer;

//ilk soru
Console.WriteLine("Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama b) Deve");
Console.Write("Cevabınız: ");

//kullanici cevabini almak
userAnswer = Console.ReadLine()!.ToLower();

//cevap kontrol
if (userAnswer == "lama")
    correctAnswerCount++;

//ikinci soru
Console.WriteLine("Dünya'ya en yakın olan gök cinsi hangisidir ?");
Console.WriteLine("a) Ay b) Mars");
Console.Write("Cevabınız: ");

//kullanici cevabini almak
userAnswer = Console.ReadLine()!.ToLower();

//cevap kontrol
if (userAnswer == "ay")
    correctAnswerCount++;

//sonuc kontrol
if (correctAnswerCount < 2)
{
    //ucuncu soru
    Console.WriteLine("5 * 2 + 8 / 2 - 2 ?");
    Console.WriteLine("a) 7 b) 12");
    Console.Write("Cevabınız: ");

    //kullanici cevabini almak
    userAnswer = Console.ReadLine()!.ToLower();

    //cevap kontrol
    if (userAnswer == "12")
        correctAnswerCount++;
}

if(correctAnswerCount == 3 || correctAnswerCount == 2)
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
else
    Console.WriteLine("Maalesef ödülü kazanamadınız.");

