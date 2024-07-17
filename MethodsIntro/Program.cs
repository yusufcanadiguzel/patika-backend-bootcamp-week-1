//şarkı sözünü yazdırır
void Sing()
{
    Console.WriteLine("Forever Isn't Long Enough");
}

//rastgele birsayının ikiye bölümünden kalanı döndürür
int GetRandomHalf()
{
    Random random = new Random();

    var number = random.Next();
    var result = number % 2;

    return result;
}

//verilen iki sayının çarpımını döndürür
int Multiplication(int firstNumber, int secondNumber) => firstNumber * secondNumber;

//verilen ad ve soyada göre mesaj yazdırır
void SayWelcome(string firstName, string lastName)
{
    Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}");
}

//uygulamalar
Sing();

Console.WriteLine(GetRandomHalf());

Console.WriteLine(Multiplication(firstNumber: 3, secondNumber: 3));

SayWelcome(firstName: "Yusufcan", lastName: "Adıgüzel");