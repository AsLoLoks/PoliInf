using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliInf.Exercises
{
    
    internal class ExerciseSetOne
    {
        static void pythagoras()
        {
            int a, b, c;

            try
            {
                string errorMessage = "Nie podano liczby calkowita lub podano text";
                a = Utils.GetUserInputInt("Podaj bok a", errorMessage);
                b = Utils.GetUserInputInt("Podaj bok b", errorMessage);
                c = Utils.GetUserInputInt("Podaj bok c", errorMessage);
            }
            catch { return; }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Error: Conajmniej jedna z liczb nie jest dodatnia");
                return;
            }

            int hypotenuse = c;
            if (a > b && a > c)
            {
                hypotenuse = a;
                a = c;
            }
            else
            if (b > a && b > c)
            {
                hypotenuse = a;
                b = c;
            }

            if (a * a + b * b == hypotenuse * hypotenuse)
            {
                Console.WriteLine("To jest rójkąt pitagorejski");
            }
            else
            {
                Console.WriteLine("To nie jest trójkąt pitagorejski");
            }
            return;
        }

        static void lineFunction()
        {
            float a, b, c;
            try
            {
                string errorMessage = "Podano text";
                a = Utils.GetUserInputFloat("Podaj wartosc a", errorMessage);
                b = Utils.GetUserInputFloat("Podaj wartosc b", errorMessage);
                c = Utils.GetUserInputFloat("Podaj wartosc c", errorMessage);
            }
            catch { return; }

            if (a == 0)
            {
                Console.WriteLine("Error: Niedozwolona wartość współczynnika a. Nacisnij klawisz Enter.");
                return;
            }

            float x = (c - b) / a;
            Console.WriteLine($"x jest rowny {x}");
            return;
        }

        static void guessingNumber()
        {
            int userNumber;
            Random random = new Random();
            int randomNumber = random.Next(10);
            try
            {
                string errorMessage = "Nie podano liczby calkowita lub podano text";
                userNumber = Utils.GetUserInputInt("Zgadnij liczbę od 0 do 9", errorMessage);
            }
            catch { return; }

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Zgadłeś/aś");
            }
            else
            {
                Console.WriteLine($"Nie zgadłeś/aś {randomNumber}");
            }
            return;
        }

        static void age()
        {
            int age;
            int ageCategory = 0;
            try
            {
                age = Utils.GetUserInputInt("Podaj wiek", "Niepoprawnie wpisano wartosc");
            }
            catch { return; }


            if (age < 0 || age > 120)
            {
                Console.WriteLine("Error: Niepoprawny przedzial wiekowy");
                return;
            }

            // ageCategory zostanie nadpisana tylko jesli jest mozliwy starszy wiek
            if (age > 0)
                ageCategory = 1;
            if (age > 12)
                ageCategory = 2;
            if (age > 17)
                ageCategory = 3;
            if (age > 40)
                ageCategory = 4;
            if (age > 60)
                ageCategory = 5;

            //wymagany switch, poprawniejszy kod:
            //if (age > 0 && age < 12)
            //    Console.WriteLine("Dziecko");
            //else ...
            switch (ageCategory)
            {
                case 1:
                    Console.WriteLine("Dziecko");
                    break;
                case 2:
                    Console.WriteLine("Junior");
                    break;
                case 3:
                    Console.WriteLine("Senior");
                    break;
                case 4:
                    Console.WriteLine("Master");
                    break;
                case 5:
                    Console.WriteLine("Weteran");
                    break;
                default:
                    Console.WriteLine("Error: Cos poszło nie tak");
                    break;
            }

            return;
        }

        static void calculator()
        {
            // string wieloniniowy 
            string menuMessage = """
                    Wybierz:
                     1.Dodawanie(+)
                     2.Odejmowanie(-)
                     3.Mnożenie(*)
                     4.Dzielenie(/)
                     5.Potęgowanie(x ^ y)
                     6.Porównanie(czy x > y)
                   """;

            int x, y, userChoice;

            try
            {
                string errorMessage = "Nie podano poprawnej wartosci";
                x = Utils.GetUserInputInt("Podaj liczbe x", errorMessage);
                y = Utils.GetUserInputInt("Podaj liczbe y", errorMessage);
                userChoice = Utils.GetUserInputInt(menuMessage, errorMessage);
            }
            catch { return; }


            //malo czytelny zapis
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine($"{x + y}");
                    break;
                case 2:
                    Console.WriteLine($"{x - y}");
                    break;
                case 3:
                    Console.WriteLine($"{x * y}");
                    break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Error: Dzielenie przez 0");
                        return;
                    }

                    Console.WriteLine($"{x / y}");
                    break;
                case 5:
                    int pow = x;
                    x = 1;
                    for (int i = 0; i < y; i++)
                    {
                        x *= pow;
                    }

                    Console.WriteLine($"{x}");
                    break;
                case 6:
                    if (x > y)
                    {
                        Console.WriteLine($"{x} Jest większe od {y}");
                    }
                    else
                    {
                        Console.WriteLine($"{x} Nie jest większe od {y}");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Cos poszło nie tak");
                    break;
            }

            return;
        }

        enum daysOfTheWeek
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }

        static void peekADay()
        {
            string day;
            daysOfTheWeek daysOfTheWeek;

            try // bez implemantecji w utils
            {
                Console.WriteLine("Podaj dzien tygodnia z duzej litery bez polskich znakow");
                day = Console.ReadLine();
                daysOfTheWeek = Enum.Parse<daysOfTheWeek>(day);
            }
            catch
            {
                Console.WriteLine("Error: Niepoprawnie wpisano wartosc");
                return;
            }

            if ((int)daysOfTheWeek > 4) //rzutowanie
            {
                Console.WriteLine("Jest weekend");
            }
            else
            {
                Console.WriteLine("Jest dzien roboczy");
            }

            return;
        }

        static void bitOperations()
        {

            int userChoise;
            int numberA;
            int numberB = 0; //if nie zapobiega bledu braku przypisanej zmiennej, przypisujemy ja teraz zeby kompilator sie nie czepial
            string menueMessage = """
                    Wybierz: 
                     1. Negacja bitowa – ~A 
                     2. XOR (bitowe „exclusive or”) – A ^ B 
                     3. Przesunięcie w lewo o 1 bit – A << 1
                     4. Przesunięcie w prawo o 1 bit – A >> 1
                    """;
            string errorMessage = "Nie podano poprawnej wartosci";

            try
            {
                userChoise = Utils.GetUserInputInt(menueMessage, errorMessage);
                numberA = Utils.GetUserInputInt("Podaj A", errorMessage);
                if (userChoise == 4) //wspomniany wyzej if
                    numberB = Utils.GetUserInputInt("Podaj B", errorMessage);
            }
            catch { return; }
            string binA = decToBin(numberA);

            switch (userChoise)
            {
                case 1: //negacja
                    binA = negation(binA);
                    binA = stripFrontZeros(binA);
                    numberA = binToDec(binA);
                    Console.WriteLine(numberA);
                    break;
                case 2: //xor
                    string binB = decToBin(numberB);
                    binA = exclusivOr(binA, binB);
                    binA = stripFrontZeros(binA);
                    numberA = binToDec(binA);
                    Console.WriteLine(numberA);
                    break;
                case 3: //lewo
                    binA = shifLeft(binA, 1);
                    numberA = binToDec(binA);
                    Console.WriteLine(numberA);
                    break;
                case 4: //prawo
                    binA = shifRight(binA, 1);
                    numberA = binToDec(binA);
                    Console.WriteLine(numberA);
                    break;
                default:
                    Console.WriteLine("Wybrano niepoprawna opcje");
                    break;
            }

            return;
        }
        static string decToBin(int dec) //z małym oszutwem
        {
            return Convert.ToString(dec, 2); // zmiana na dowolny system z 10 u nas 2
        }

        static int binToDec(string bin) //z małym oszutwem
        {
            return Convert.ToInt32(bin, 2); // zmiana z dowolnago systemu na 10 u nas z 2
        }

        static string negation(string bin)
        {
            string nbin = "";

            for (int i = 0; i < bin.Length; i++) //przechodzimy po kazdym indexe dopisujac odwrotnosc 
            {
                if (bin[i] == '1')
                {
                    nbin += "0";
                }
                else
                {
                    nbin += "1";
                }
            }

            return nbin;
        }

        static string stripFrontZeros(string bin)
        {
            string nbinStrip = "";
            bool startWriting = false;

            for (int i = 0; i < bin.Length; i++) // szukamy pierwszej 1 i przepisujemy wszystko co za nia
            {
                if (bin[i] == '1')
                    startWriting = true;
                if (startWriting)
                {
                    nbinStrip += bin[i];
                }
            }

            return nbinStrip;
        }


        static string exclusivOr(string binLong, string binShort)
        {
            if (binLong.Length < binShort.Length)
            {
                string temp = binLong; //zmienna temp zeby nie stracic binLong przy zamianie
                binLong = binShort;
                binShort = temp;
            }

            int difference = binLong.Length - binShort.Length; // dodajemy zera z przodu krutszej liczby dla prostoty iteracji 1001 10 -> 1001 0010
            for (int i = 0; i < difference; i++)
            {
                binShort = "0" + binShort;
            }

            string rbin = "";
            for (int i = 0; i < binLong.Length; i++)
            {
                if (binLong[i] == binShort[i])
                {
                    rbin += "0";
                }
                else
                {
                    rbin += "1";
                }
            }

            return rbin;
        }

        static string shifRight(string bin, int shift)
        {
            return bin.Substring(0, bin.Length - shift);  //"zaczynajac od 0 indexu przepisujemy wszystkie znaki ale mniej o shif"
        }

        static string shifLeft(string bin, int shift)
        {
            for (int i = 0; i < shift; i++)
            {
                bin += "0";
            }
            return bin;
        }

        static bool programLoop()
        {
            int userChoise;
            bool dontShowDupplicateMessage = false;
            string menueMessage = """
                Wybierz: 
                 1. Trójka pitagorejska 
                 2. Rozwiązanie równania liniowego 
                 3. Zgadywanie liczby (losowanie jednokrotne) 
                 4. Kwalifikacja wieku zawodnika (instrukcja switch) 
                 5. Kalkulator rozbudowany (operacje matematyczne i logiczne) 
                 6. Typ wyliczeniowy enum (dni tygodnia) 
                 7. Operatory bitowe (~, ^, <<, >>) 
                 8. Wyczyść konsole 
                 9. Zakończ program
                """;
            string errorMessage = "Nie podano liczby calkowita lub podano text";
            try
            {
                userChoise = Utils.GetUserInputInt(menueMessage, errorMessage);
            }
            catch
            {
                userChoise = 0;
                dontShowDupplicateMessage = true;
            }

            switch (userChoise)
            {
                case 1:
                    pythagoras();
                    break;
                case 2:
                    lineFunction();
                    break;
                case 3:
                    guessingNumber();
                    break;
                case 4:
                    age();
                    break;
                case 5:
                    calculator();
                    break;
                case 6:
                    peekADay();
                    break;
                case 7:
                    bitOperations();
                    break;
                case 8:
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine("Program zakończony");
                    return false;
                default:
                    if (dontShowDupplicateMessage)
                    {
                        break;
                    }
                    Console.WriteLine("Niepoprawnie wybrano opcje");
                    break;
            }
            return true;
        }

        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                continueRunning = programLoop();
            }
        }
    }
}
