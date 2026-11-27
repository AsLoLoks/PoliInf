using System.Diagnostics.Contracts;

namespace PoliInf.ExercisesArrays
{
    public class ExercisesChars
    {
                // Zadania – znaki
        // a) Wczytaj linijkę tekstu i policz, ile wprowadzono liter, cyfr i odstępów.
        //     – Wskazówka: foreach po znakach linii oraz char.IsLetter, char.IsDigit, char.IsWhiteSpace.
        public static void GetTextCounts(){
            Console.WriteLine("Podaj text do policzenia liter cyfr i spacji");
            string message = Console.ReadLine();
            StringMethods stringMethods = new StringMethods(message);

            Console.WriteLine($"Ilosc liter = {stringMethods.GetCounterLetters()}");
            Console.WriteLine($"Ilosc cyfr = {stringMethods.GetCounterDigits()}");
            Console.WriteLine($"Ilosc znakow bialych = {stringMethods.GetCounterWhiteSpaces()}");
        }

        // b) Wczytaj linijkę tekstu i wypisz wprowadzone znaki, zamieniając każdą wielką literę na znak '*'.
        //     – Wskazówka: char.IsUpper; wypisuj znak po znaku przez Console.Write. 
        public static void GetCensoreCapitalLetters(){
            Console.WriteLine("Podaj text do zacenzurowania dużych liter ");
            string message = Console.ReadLine();
            StringMethods stringMethods = new StringMethods(message);

            Console.WriteLine($"Tak wygląda wynik cenzury = {stringMethods.GetCensoredCapitalText()}");
        }
        // c) Wczytaj 8-bitową liczbę binarną (np. 00101100) i wypisz wagę najbardziej znaczącej jedynki (tu: 32).
        //     – Wskazówka: pierwsza jedynka od lewej na pozycji i ma wagę 2^(7 − i). Sprawdź, czy wczytano dokładnie 8 znaków 0 lub 1.
         public static void GetMostImportantBitValue(){
            Console.WriteLine("Podaj liczbe binarna osmio bitowa do wyznaczenia najbardziej znaczacego bitu, jesli wynikiem bedzie -1 to wpisana liczba nie przeszla walidacji");
            string message = Console.ReadLine();
            StringMethods stringMethods = new StringMethods(message);

            Console.WriteLine($"Najbardziej znaczacy bit ma wartosc = {stringMethods.GetMostImportantBitValue()}");
        }
        // d) Wczytaj 4-cyfrową liczbę szesnastkową (np. 1A3F) i wyznacz jej odpowiednik dziesiętny (tu:6719).
        //     – Wskazówka: zamień każdą cyfrę na wartość 0–15 instrukcją if (osobno cyfry '0'–'9' i litery 'A'–'F'), a wynik licz schematem Hornera: wynik = wynik * 16 + wartosc.
        //     – Do sprawdzenia wyniku: Convert.ToInt32(tekst, 16) – ale w zadaniu należy napisać konwersję samodzielnie.
        


    }
}