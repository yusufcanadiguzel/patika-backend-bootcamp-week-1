//Giris mesaji ve urun listeleme
Console.WriteLine("Ruya Manavina Hos Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Cilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger butun meyveler = 4");

//Kullanicidan tercihi alma
Console.Write("Hangi meyveyi satin almak isterniz? (Elma/Armut/Cilek/Muz/Diger) : ");
string chosenProduct = Console.ReadLine()!.ToLower();

//Meyvenin kontrolu
switch (chosenProduct)
{
    case "elma":
    case "cilek":
        Console.WriteLine("Sectiginiz mevyenin fiyati = 2 TL");
        break;
    case "armut":
    case "muz":
        Console.WriteLine("Sectiginiz mevyenin fiyati = 3 TL");
        break;
    case "diger":
        Console.WriteLine("Sectiginiz mevyenin fiyati = 4 TL");
        break;
    default:
        Console.WriteLine("Tercih ettiginiz meyve stokta bulunmamaktadir.");
        break;
}

//Meyvenin kontrolu
if (chosenProduct == "elma" || chosenProduct == "cilek")
    Console.WriteLine("Sectiginiz mevyenin fiyati = 2 TL");
else if (chosenProduct == "armut" || chosenProduct == "muz")
    Console.WriteLine("Sectiginiz mevyenin fiyati = 3 TL");
else if(chosenProduct == "diger")
    Console.WriteLine("Sectiginiz mevyenin fiyati = 4 TL");
else
    Console.WriteLine("Tercih ettiginiz meyve stokta bulunmamaktadir.");