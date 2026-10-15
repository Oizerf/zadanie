//1
// Console.Write ("Podaj Liczbę: ");
// int liczbacalkowita = int.Parse(Console.ReadLine()!);
// if (liczbacalkowita % 2 == 0)
// {
//     Console.WriteLine ("Liczba jest parzysta");
// }
// else
// {
//     Console.WriteLine ("Liczba jest nieparzysta");
// }
//2
// Console.Write ("podaj kierunek:");
// string kierunek = Console.ReadLine();
// switch (kierunek)
// {
//     case "północ":
//         Console.WriteLine("Wyruszasz w stronę gór.");
//         break;
//     case "południe":
//         Console.WriteLine("Wyruszasz w stronę pustyni.");
//         break;
//     case "wschód":
//         Console.WriteLine("Wyruszasz w stronę lasu.");
//         break;
//     case "zachód":
//         Console.WriteLine("Wyruszasz w stronę morza.");
//         break;        
// }
//3
// Console.Write("wiek:");
// int wiek = int.Parse(Console.ReadLine()!);
// if (wiek<0)
// {
//     Console.WriteLine("niepoprawny wiek");
// }
// else if (wiek<13)
// {
//     Console.WriteLine("dziecko");
// }
// else if (wiek<18)
// {
//     Console.WriteLine("nastolatek");
// }
// else if (wiek<65)
// {
//     Console.WriteLine("osoba dorosła");
// }
// else
// {
//     Console.WriteLine("senior");
// }
//4
// Console.Write("punkty życia:");
// int zycie = int.Parse(Console.ReadLine()!);
// Console.Write("czy ma klusz:");
// bool klucz= bool.Parse(Console.ReadLine()!);
// Console.Write("czy zna hasło:");
// bool haslo= bool.Parse(Console.ReadLine()!);
// if (zycie>0 && (klucz || haslo))
// {
//     Console.WriteLine("może wejść do lochu");
// }
// else if (zycie<=0)
// {
//     Console.WriteLine("Bohater nie może wejść — nie żyje.");
// }
// else
// {
//     Console.WriteLine("nie może wejść, ponieważ nie ma sposobu otwarcia drzwi.");
// }
//4,2
// int zloto = int.Parse(Console.ReadLine()!);
// string stan = zloto > 29 ? "Możesz kupić miksturę." : "Brakuje złota.";
// Console.WriteLine($"{stan}.");
//5
// Console.Write("życie bohatera:");
// int zycie = int.Parse(Console.ReadLine()!);
// Console.Write("obrażenia broni:");
// int obrazenia = int.Parse(Console.ReadLine()!);
// Console.Write("czy ma miksture:");
// bool mikstura = bool.Parse(Console.ReadLine()!);
// Console.Write("akcja:");
// int akcja = int.Parse(Console.ReadLine()!);
// if (zycie<1)
// {
//     Console.WriteLine("Przegrana");
// }
// else
// {
//     switch (akcja)
//     {
//         case 1:
//             Console.WriteLine($"obrazenia:{obrazenia}");
//             break;
//         case 2:
//             if (mikstura==true)
//             {
//             Console.WriteLine("leczy sie");
//             }
//             break;
//         case 3:
//             Console.WriteLine("ucieka");
//             break;
//         default :
//             Console.WriteLine("Nieznana akcja.");
//             break;
//     }
// }
// if (zycie < 21 && zycie >1)
// {
//     Console.WriteLine("niskie zdrowie bohatera.");
// }
//6
Console.Write("imie:");
string imie = Console.ReadLine()!;
Console.Write("punkty życia:");
int zycie = int.Parse(Console.ReadLine()!);
Console.Write("poziom:");
int poziom = int.Parse(Console.ReadLine()!);
Console.Write("siła:");
int sila = int.Parse(Console.ReadLine()!);
Console.Write("złoto:");
int zloto = int.Parse(Console.ReadLine()!);
if (zloto>50)
{
    Console.WriteLine("bogaty");
}
if (zycie<25 && zycie>0)
{
    Console.WriteLine("ma niski poziom zdrowia");
}
if (sila>40)
{
    Console.WriteLine("op heros");
}
