using PoliInf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_drugie
{
    class Program
    {
        // reimplementacja z zestawu 1
        static int guessingNumber(int randomNumber = -1) // wartos bazowa dla argumentu, jesli go nie podamy bedzie -1 co wylosuje nowy numer lub mozemy przekazac poprzedni numer
        {
            int userNumber;
            
            if (randomNumber == -1) // jesli nie wpisalismy nic lub -1 wylosujemy nowy numer
            {
                Random random = new Random();
                randomNumber = random.Next(10);
            }
            
            try
            {
                string errorMessage = "Nie podano liczby calkowita lub podano text"; // nie obsuguje blendu zakresu zgadywania
                userNumber = Utils.GetUserInputInt("Zgadnij liczbę od 0 do 9", errorMessage);
            }
            catch
            {
                Console.WriteLine("Zmarnowano jedno zgadniecie");
                return randomNumber;
            }

            string mainMessage = $", twoja liczba to: {userNumber} a wylosowana liczba to:{randomNumber}.";

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Brawo udalo ci sie odgadnac wylosowana liczbe" + mainMessage);
                return randomNumber;
            }
            else
            {
                Console.WriteLine("Brawo udalo ci sie odgadnac wylosowana liczbe" + mainMessage);
                return -1;
            }
        }

        static void guessingNumberMultipleTImes() 
        {
            int wylosowanaLiczba, wpisanaLiczba, licznikProb = 0;
            string wpisanaWartosc;
            bool czyLiczbaJestPoprawnieWpisana = true, czyZgadnieta = false;

            Random generuj = new Random();
            wylosowanaLiczba = generuj.Next(0, 10);

            do
            {
                Console.WriteLine("Odgadnij liczbe od 0 do 9.");
                wpisanaWartosc = Console.ReadLine();
                czyLiczbaJestPoprawnieWpisana = int.TryParse(wpisanaWartosc, out wpisanaLiczba);
                licznikProb += 1;

                if (czyLiczbaJestPoprawnieWpisana == true)
                {
                    if (wpisanaLiczba == wylosowanaLiczba)
                    {
                        Console.WriteLine("Brawo udalo ci sie odgadnac wylosowana liczbe, twoja liczba to: " + wpisanaLiczba + " a wylosowana liczba to: " + wylosowanaLiczba + ".");
                        Console.WriteLine("Zgadles/as w " + licznikProb + " probie.");
                        Console.WriteLine("Nacisnij Enter, aby powrocic do menu.");
                        Console.ReadLine();
                        czyZgadnieta = true;
                        break;
                    }
                    else
                    {
                        if (wpisanaLiczba > wylosowanaLiczba)
                        {
                            Console.WriteLine("Za duza.");
                        }
                        else
                        {
                            Console.WriteLine("Za mala.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawnie wpisana liczba.");
                    Console.WriteLine("Nacisnij Enter, aby zgadywac dalej.");
                    Console.ReadLine();
                }

            }while(licznikProb < 10);

            if (czyZgadnieta == false)
            {   
                // aby wpisac ostatni strzal uzytkownika uzywam zmiennej 'wpisanaWartosc' aby wyswietlilo sie to co wpisal uzytkownik niezaleznie czy to liczba czy tekst
                Console.WriteLine("Nie udalo ci sie zgadnac liczby przez 10 prob, twoj ostatni strzal to - " + wpisanaWartosc + " a wylosowana liczba to - " + wylosowanaLiczba + ".");
            }
        }

        static void diceRoleSimulation()
        {
            int wartoscNaKostce, liczbaRzutow = 0, licznikJedynek = 0, licznikDwojek = 0, licznikTrojek = 0, licznikCzworek = 0, licznikPiatek = 0, licznikSzostek = 0;
            bool czyJedynkiZblizoneDo100, czyDwojkiZblizoneDo100, czyTrojkiZblizoneDo100, czyCzworkiZblizoneDo100, czyPiatkiZblizoneDo100, czySzostkiZblizoneDo100;
            Random rzut = new Random();

            do
            {
                liczbaRzutow += 1;
                wartoscNaKostce = rzut.Next(1,7);
                switch (wartoscNaKostce)
                {
                    case 1:
                        licznikJedynek += 1;
                        break;
                    case 2:
                        licznikDwojek += 1;
                        break;
                    case 3:
                        licznikTrojek += 1;
                        break;
                    case 4:
                        licznikCzworek += 1;
                        break;
                    case 5:
                        licznikPiatek += 1;
                        break;
                    case 6:
                        licznikSzostek += 1;
                        break;
                }
            } while (liczbaRzutow < 600);

            czyJedynkiZblizoneDo100 = czyZblizonaDo100(licznikJedynek);
            czyDwojkiZblizoneDo100 = czyZblizonaDo100(licznikDwojek);
            czyTrojkiZblizoneDo100 = czyZblizonaDo100(licznikTrojek);
            czyCzworkiZblizoneDo100 = czyZblizonaDo100(licznikCzworek);
            czyPiatkiZblizoneDo100 = czyZblizonaDo100(licznikPiatek);
            czySzostkiZblizoneDo100 = czyZblizonaDo100(licznikSzostek);

            if ( czyJedynkiZblizoneDo100 == true && czyDwojkiZblizoneDo100 == true && czyTrojkiZblizoneDo100 == true && czyCzworkiZblizoneDo100 == true && czyPiatkiZblizoneDo100 == true && czySzostkiZblizoneDo100 == true )
            {
                Console.WriteLine("Wszystkie ilosci wyrzuconych oczek kostka sa zblizone do 100 z bledem pomiaru 10.");
            }
            else
            {
                Console.WriteLine("Nie wszystkie ilosci wyrzuconych oczek kostka sa zblizone do 100 z bledem pomiaru 10.");
            }

            Console.WriteLine("");
            Console.WriteLine("Wykres dla liczby wyrzuconych oczek (jedna gwiazdka to 5 rzutow o danej wartosci):");
            Console.WriteLine("");
            Console.Write(" 1: ");
            wykresIlosci(licznikJedynek);
            Console.Write(" 2: ");
            wykresIlosci(licznikDwojek);
            Console.Write(" 3: ");
            wykresIlosci(licznikTrojek);
            Console.Write(" 4: ");
            wykresIlosci(licznikCzworek);
            Console.Write(" 5: ");
            wykresIlosci(licznikPiatek);
            Console.Write(" 6: ");
            wykresIlosci(licznikSzostek);
            Console.WriteLine("");
        }

        // funkcja sprawdzajaca czy dana liczba jest zblizona do 100 z bledem +- 10
        static bool czyZblizonaDo100(int liczbaBadana)
        {
            int roznica;
            roznica = liczbaBadana - 100;
            if (roznica <= 10 && roznica >= -10) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // rysuje wykres dla kazdej 5 rysuje 1 '*' (w zaokragleniu)
        static void wykresIlosci(int ilosc )
        {
            string wykres = "";
            int iloraz;
            iloraz = ilosc / 5;
            for (int i = 0; i < iloraz; i++) 
            {
                wykres = wykres + " * ";
            }
            Console.WriteLine(wykres);
        }

        enum wyborRuchu
        {
            kamien,
            papier,
            nozyce
        }

        static void rockPaperScisors()
        {
            int ruchKomputeraWylosowany, punktyGracza = 0, punktyKomputera = 0;
            wyborRuchu ruchGraczaEnum, ruchKomputeraEnum;
            string wpisanyRuchGracza, ruchKomputera;
            bool czyRuchWpisanyPoprawnie;
            Random ruch = new Random();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Punkty gracza: " + punktyGracza + " punkty komputera: " + punktyKomputera + ".");
                Console.WriteLine("Wybierz swoj ruch od 0 do 2.");
                Console.WriteLine(" 0 - Kamien.");
                Console.WriteLine(" 1 - Papier.");
                Console.WriteLine(" 2 - Nozyce.");
                wpisanyRuchGracza = Console.ReadLine();
                czyRuchWpisanyPoprawnie = Enum.TryParse<wyborRuchu>(wpisanyRuchGracza, true, out ruchGraczaEnum);

                ruchKomputeraWylosowany = ruch.Next(0,3);
                ruchKomputera = Convert.ToString(ruchKomputeraWylosowany);
                Enum.TryParse<wyborRuchu>(ruchKomputera, out ruchKomputeraEnum);

                if (czyRuchWpisanyPoprawnie == true && (int)ruchGraczaEnum < 3 && (int)ruchGraczaEnum >= 0)
                {
                    if (ruchGraczaEnum == ruchKomputeraEnum)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ruch komputera: " + ruchKomputeraEnum + ".");
                        Console.WriteLine("Ruch gracza: " + ruchGraczaEnum + ".");
                        Console.WriteLine("Remis graj dalej.");
                    }
                    else
                    {
                        if (ruchGraczaEnum == wyborRuchu.nozyce && ruchKomputeraEnum == wyborRuchu.papier)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ruch komputera: " + ruchKomputeraEnum + ".");
                            Console.WriteLine("Ruch gracza: " + ruchGraczaEnum + ".");
                            Console.WriteLine("Wygrales ta runde.");
                            punktyGracza = punktyGracza + 1;
                        }
                        else
                        {
                            if (ruchGraczaEnum == wyborRuchu.papier && ruchKomputeraEnum == wyborRuchu.kamien)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ruch komputera: " + ruchKomputeraEnum + ".");
                                Console.WriteLine("Ruch gracza: " + ruchGraczaEnum + ".");
                                Console.WriteLine("Wygrales ta runde.");
                                punktyGracza = punktyGracza + 1;
                            }
                            else
                            {
                                if (ruchGraczaEnum == wyborRuchu.kamien && ruchKomputeraEnum == wyborRuchu.nozyce)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Ruch komputera: " + ruchKomputeraEnum + ".");
                                    Console.WriteLine("Ruch gracza: " + ruchGraczaEnum + ".");
                                    Console.WriteLine("Wygrales ta runde.");
                                    punktyGracza = punktyGracza + 1;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Ruch komputera: " + ruchKomputeraEnum + ".");
                                    Console.WriteLine("Ruch gracza: " + ruchGraczaEnum + ".");
                                    Console.WriteLine("Przegrales ta runde.");
                                    punktyKomputera = punktyKomputera + 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Niepoprawnie wybrano ruch kliknij enter aby grac dalej.");
                    Console.ReadLine();
                }
            } while( punktyGracza < 3 && punktyKomputera < 3 );

            if (punktyGracza > punktyKomputera)
            {
                Console.WriteLine("");
                Console.WriteLine("Wygrales gratulacje kliknij enter aby wrocic do menu.");
                Console.WriteLine("Punkty gracza: " + punktyGracza + " punkty komputera: " + punktyKomputera + ".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Niestety przegrales kliknij enter aby wrocic do menu.");
                Console.WriteLine("Punkty gracza: " + punktyGracza + " punkty komputera: " + punktyKomputera + ".");
                Console.ReadLine();
            }
        }

        static void multiplicationTableQuiz()
        {
            int liczbaPierwsza, liczbaDruga, wynikMnozenia, odpowiedzGraczaInt, punktyGracza = 0;
            string odpowiedzGracza;
            
            Random losowaLiczba = new Random();

            for (int i = 0; i < 5; i++) 
            {
                liczbaPierwsza = losowaLiczba.Next(1, 11);
                liczbaDruga = losowaLiczba.Next(1, 11);

                wynikMnozenia = liczbaPierwsza * liczbaDruga;
                Console.WriteLine("Podaj wynik mnozenia liczb:");
                Console.WriteLine(" " + liczbaPierwsza + " * " + liczbaDruga + " = ?");
                odpowiedzGracza = Console.ReadLine();

                int.TryParse(odpowiedzGracza, out odpowiedzGraczaInt);

                if( odpowiedzGraczaInt == wynikMnozenia)
                {
                    punktyGracza = punktyGracza + 1;
                }
            }

            switch (punktyGracza)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ocena - niedostateczny, zdobyto " + punktyGracza + " punktow.");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ocena - dostateczny, zdobyto " + punktyGracza + " punktow.");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ocena - dobry, zdobyto " + punktyGracza + " punktow.");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("Ocena - bardzo dobry, zdobyto " + punktyGracza + " punktow.");
                    break;
            }
        }

        static void temperatureSimulation()
        {
            double pomiarLosowy, pomiarPelny, pomiarWlasciwy, najmniejszyPomiar, najwiekszyPomiar, sredniaPomiarow, sumaWszystkichPomiarow;
            double[] tablicaPomiarow = new double[20], pomiaryWyzszeNiz24 = new double[20];
            int numerPomiaru, komorkaTablicy = 0;

            Random wylosujPomiar = new Random();

            for (int i = 0; i < tablicaPomiarow.Length; i++) 
            {
                pomiarLosowy = wylosujPomiar.NextDouble();
                pomiarPelny = (pomiarLosowy * (26 - 18)) + 18;
                pomiarWlasciwy = Math.Round(pomiarPelny, 1);
                tablicaPomiarow[i] = pomiarWlasciwy;
            }

            // Na sam poczatek za najmniejszy i za razem najwiekszy pomiar przyjmuje pierwsza wartosc tablicy oraz do sumy wszystkich pomiarow dodaje pierwsza wartosc tablicy, bo petla ja pomija
            najmniejszyPomiar = tablicaPomiarow[0];
            najwiekszyPomiar = tablicaPomiarow[0];
            sumaWszystkichPomiarow = 0;

            for (int i = 0; i < tablicaPomiarow.Length; i++)
            {
                numerPomiaru = i + 1;
                Console.WriteLine("Pomiar " + numerPomiaru + " " + tablicaPomiarow[i] + "°C");

                if (najmniejszyPomiar > tablicaPomiarow[i])     // szukam najmniejszego pomiaru
                {
                    najmniejszyPomiar = tablicaPomiarow[i];
                }

                if (najwiekszyPomiar < tablicaPomiarow[i])      // szukam najwiekszego pomiaru
                {
                    najwiekszyPomiar = tablicaPomiarow[i];
                }

                if (tablicaPomiarow[i] > 24 || tablicaPomiarow[i] < 20)     // szukam pomiarow poza skali i dodaje je do tablicy
                {
                    pomiaryWyzszeNiz24[komorkaTablicy] = tablicaPomiarow[i];
                    komorkaTablicy++;
                }
                sumaWszystkichPomiarow = sumaWszystkichPomiarow + tablicaPomiarow[i];
            }
            sredniaPomiarow = Math.Round(sumaWszystkichPomiarow / 20, 1);

            Console.WriteLine("Najmniejszy pomiar to: " + najmniejszyPomiar + "°C");
            Console.WriteLine("Najwiekszy pomiar to: " + najwiekszyPomiar + "°C");
            Console.WriteLine("Srednia pomiarow to: " + sredniaPomiarow + "°C");
            Console.WriteLine("Liczba pomiarow z poza zakresu 20-24°C to: " + komorkaTablicy);

        }

        static bool programLoop()
        {
            int userChoise;
            bool dontShowDupplicateMessage = false;
            string menueMessage = """
                Wybierz:
                 1. Zgadywanie liczby - jedna proba.
                 2. Zgadywanie liczby - do skutku.
                 3. Symulacja rzutow kostka.
                 4. Papier, kamien, nozyce.
                 5. quiz z tabliczki mnozenia.
                 6. symulacja czujnika temperatury.
                 7. wyczysc konsole.
                 8. zakoncz program.
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
                        guessingNumber();
                        break;
                    case 2:
                        guessingNumberMultipleTImes();
                        break;
                    case 3:
                        diceRoleSimulation();
                        break; 
                    case 4:
                        rockPaperScisors();
                        break;
                    case 5:
                        multiplicationTableQuiz();
                        break;
                    case 6:
                        temperatureSimulation();
                        break;
                    case 7:
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Zamknieto program");
                        return false;
                    default:
                        if (dontShowDupplicateMessage)
                        {
                            break;
                        }
                        Console.WriteLine("Wybrano niepoprawna opcje");
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
