using PoliInf;
using System;
using System.Reflection.Metadata;

namespace Zestaw3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void zadanie1a()
            {
                int amount = 5, randomNumber, avrage, sum = 0, min = 100, max = -1;
                string wypisaneLiczby = "";
                Random random = new Random();
                

                for (int i = 0; i < amount; i++)
                {
                    randomNumber = random.Next(0, 100);
                    sum += randomNumber;
                    wypisaneLiczby = wypisaneLiczby + randomNumber + ", ";

                    if (randomNumber > max)
                    {
                        max = randomNumber;
                    }
                    if (randomNumber < min)
                    {
                        min = randomNumber;
                    }
                }
                avrage = sum / amount;
                Console.WriteLine("wylosowane liczby: " + wypisaneLiczby);
                Console.WriteLine("Srednia " + amount + " liczb wylosowanych: " + avrage);
                Console.WriteLine("Najmniejsza liczba z liczb wylosowanych: " + min);
                Console.WriteLine("Najwieksza liczba z liczb wylosowanych: " + max);
                Console.ReadLine();
            }
            //zadanie1a();

            static void zadanie1ab()
            {
                int amount, randomNumber, avrage, sum = 0, min = 100, max = -1;
                string wypisaneLiczby = "";
                Random random = new Random();

                try
                {
                    amount = Utils.GetUserInputInt("Podaj ile liczb wylosowac", "Podano text");
                }
                catch { return; }


                for (int i = 0; i < amount; i++)
                {
                    randomNumber = random.Next(0, 100);
                    sum += randomNumber;
                    wypisaneLiczby = wypisaneLiczby + randomNumber + ", ";

                    if (randomNumber > max)
                    {
                        max = randomNumber;
                    }
                    if (randomNumber < min)
                    {
                        min = randomNumber;
                    }
                }
                avrage = sum / amount;
                Console.WriteLine("wylosowane liczby: " + wypisaneLiczby);
                Console.WriteLine("Srednia " + amount + " liczb wylosowanych: " + avrage);
                Console.WriteLine("Najmniejsza liczba z liczb wylosowanych: " + min);
                Console.WriteLine("Najwieksza liczba z liczb wylosowanych: " + max);
                Console.ReadLine();
            }

            static void zadanie1b()
            {
                int amount, randomNumber, avrage, sum = 0, min = 100, max = -1;
                string liczbaLiczbLosowychWpisana, wypisaneLiczby = "";
                Console.WriteLine();
                liczbaLiczbLosowychWpisana = Console.ReadLine();
                try
                {
                    amount = Utils.GetUserInputInt("Podaj ile liczb wylosowac", "Podano text");
                }
                catch { return; }

                Random losowa = new Random();
                amount = int.Parse(liczbaLiczbLosowychWpisana);

                int i = 0;
                do
                {
                    randomNumber = losowa.Next(0, 100);
                    wypisaneLiczby = wypisaneLiczby + randomNumber + ", ";

                    sum += randomNumber;
                    if (randomNumber > max)
                    {
                        max = randomNumber;
                    }
                    if (randomNumber < min)
                    {
                        min = randomNumber;
                    }
                    i++;
                }while (i < amount);
                avrage = sum / amount;
                Console.WriteLine("wylosowane liczby: " + wypisaneLiczby);
                Console.WriteLine("Srednia " + amount + " liczb wylosowanych: " + avrage);
                Console.WriteLine("Najmniejsza liczba z liczb wylosowanych: " + min);
                Console.WriteLine("Najwieksza liczba z liczb wylosowanych: " + max);
                Console.ReadLine();

            }
            //zadanie1b();

            

            static void zadanie2()
            {
                string line = "";

                for (int i = 1; i < 11; i++)    
                {
                    for(int j = 1; j < 11; j++)
                    {
                        line = i * j + " ";
                    }
                    Console.WriteLine(line);
      
                }

            }


            static void zadanie3()
            {
                string[] tablicaLiter = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";               
                string formated = "";

                for(int i = 0; i < alphabet.Length; i++)
                {
                    if(i != alphabet.Length - 1)
                    {
                        formated += $"{alphabet[i]}, ";
                    }
                    else
                    {
                        formated += $"{alphabet[i]}.";
                    }
                }
                Console.WriteLine(formated);

                string reversed = "";
                for(int i = alphabet.Length -1; 0 <= 0; i--)
                {
                    reversed += alphabet[i];
                }

                for (int i = 0; i < reversed.Length; i++)
                {
                    if (i != reversed.Length - 1)
                    {
                        formated += $"{reversed[i]}, ";
                    }
                    else
                    {
                        formated += $"{reversed[i]}.";
                    }
                }

                Console.WriteLine(formated);     
            }
            static void zadanie3()
            {
                string[] tablicaLiter = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string formated = "";
                int i = 0;
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (i != alphabet.Length - 1)
                    {
                        formated += $"{alphabet[i]}, ";
                    }
                    else
                    {
                        formated += $"{alphabet[i]}.";
                    }
                }while(i < alphabet.Length);

                Console.WriteLine(formated);

                string reversed = "";
                for (int i = alphabet.Length - 1; 0 <= 0; i--)
                {
                    reversed += alphabet[i];
                }

                for (int i = 0; i < reversed.Length; i++)
                {
                    if (i != reversed.Length - 1)
                    {
                        formated += $"{reversed[i]}, ";
                    }
                    else
                    {
                        formated += $"{reversed[i]}.";
                    }
                }

                Console.WriteLine(formated);
            }
            //zadanie3();

            static void zadanie3a()
            {
                string[] tablicaLiter = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                string literyAZ = "", literyZA = "";
                int licznik;

                licznik = 0;
                while (licznik < tablicaLiter.Length)
                {
                    literyAZ += tablicaLiter[licznik] + ", ";
                    licznik++;
                }
                licznik = 26;
                while (licznik > 0)
                {
                    literyZA += tablicaLiter[licznik - 1] + ", ";
                    licznik--;
                }

                Console.WriteLine(literyAZ);
                Console.WriteLine(literyZA);
                Console.ReadLine();
            }
            //zadanie3a();

            static void zadanie3b()
            {
                string[] tablicaLiter = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                string literyAZ = "", literyZA = "";
                int licznik;

                licznik = 0;
                do
                {
                    literyAZ += tablicaLiter[licznik] + ", ";
                    licznik++;
                } while (licznik < tablicaLiter.Length);

                licznik = 26;
                do
                {
                    literyZA += tablicaLiter[licznik - 1] + ", ";
                    licznik--;
                } while (licznik > 0);
                Console.WriteLine(literyAZ);
                Console.WriteLine(literyZA);
                Console.ReadLine();
            }
            //zadanie3b();

            static void zadanie4()
            {
                int liczbaA, liczbaB, licznik = 0;

                for ( int liczba = 1000; liczba < 10000; liczba++  )
                {
                    liczbaA = liczba / 100;
                    liczbaB = liczba % 100;

                    if (liczbaA * liczbaA + liczbaB * liczbaB == liczba) 
                    {
                        licznik++;
                        Console.WriteLine(liczbaA + " * " + liczbaA + " + " + liczbaB + " * " + liczbaB + " = " + liczba);
                    }
                }
                Console.WriteLine("Znaleziono takich liczb: " + licznik);
                Console.ReadLine( );
            }
            //zadanie4();

            static void zadanie5()
            {
                string podanyCiagZnakow;
                Console.WriteLine("Podal liczbe lub zdanie lub slowo");
                podanyCiagZnakow = Console.ReadLine();

                podanyCiagZnakow = podanyCiagZnakow.Replace(" ", "").ToLower();

                char[] tablica1 = new char[podanyCiagZnakow.Length];
                char[] tablica2 = new char[podanyCiagZnakow.Length];
                bool czySieZgadza = true;
                int licznik = 0;
                

                for (int i = 0; i < podanyCiagZnakow.Length; i++)
                {
                    tablica1[i] = podanyCiagZnakow[i];
                }
                for (int i = podanyCiagZnakow.Length; i > 0; i--)
                {
                    tablica2[licznik] = podanyCiagZnakow[i-1];
                    licznik++;
                }
                for(int i = 0; i < podanyCiagZnakow.Length; i++)
                {
                    if (tablica2[i] == tablica1[i] )
                    {
                        czySieZgadza = true;
                    }
                    else
                    {
                        czySieZgadza = false;
                        break;
                    }
                }
                if ( czySieZgadza == true)
                {
                    Console.WriteLine("To jest palindrom");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("To nie jest palindrom");
                    Console.ReadLine();
                }
            }
            //zadanie5();

            static void zadanie6()
            {
                try
                {
                    int iStart = Environment.TickCount; 
                    int r, iloscWylosowan, losoweX, losoweY, punktyWKole = 0, punktyPozaKolem = 0, wszystkiePunkty;
                    decimal pi;
                    Random generuj = new Random();

                    Console.WriteLine("Podaj promien r: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj ile wylosowc punktow: ");
                    iloscWylosowan = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < iloscWylosowan; i++)
                    {
                        losoweX = generuj.Next(-r, r);
                        losoweY = generuj.Next(-r, r);

                        if ((losoweX * losoweX) + (losoweY * losoweY) <= (r * r)) 
                        {
                            punktyWKole ++;
                        }
                        else
                        {
                            punktyPozaKolem ++;
                        }
                    }
                    // pole kw = 2r * 2r = 4 r^2
                    // pole koła = pi r^2
                    // teoretycznie pole kola / pole kw == punkty w kole / wszystkie punkty (w kole i poza)
                    // pi r^2 / 4 r^2 == punkty w kole / wszystkie punkty
                    // pi/4 == punkty w kole / wszystkie punkty
                    // pi == 4(punkty w kole / wszystkie punkty)
                    wszystkiePunkty = punktyWKole + punktyPozaKolem;
                    pi = Convert.ToDecimal(4 * ((decimal)punktyWKole / (decimal)wszystkiePunkty));

                    
                    Console.WriteLine("Wartosc pi: ");
                    Console.WriteLine(pi);

                    int iKoniec = Environment.TickCount;
                    int czasTrwania = iKoniec - iStart;
                    Console.WriteLine("Czas trwania programu: ");
                    Console.WriteLine(czasTrwania + " ms");
                    Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine("Niepoprawinie podano wartosc");
                    Console.ReadLine();
                }
            }
            //zadanie6();

            static void zadanie5zestaw1()
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

                } while (licznikProb < 10);

                if (czyZgadnieta == false)
                {
                    Console.WriteLine("Nie udalo ci sie zgadnac liczby przez 10 prob, twoj ostatni strzal to - " + wpisanaWartosc + " a wylosowana liczba to - " + wylosowanaLiczba + ".");
                }
            }
            //zadanie5zestaw1();

            static void zadanie6zestaw1()
            {
                try
                {
                    string liczbaWpisana;
                    int licznik = 0, suma = 0;
                    Console.WriteLine("Wpisz liczbe ktorej sume cyfr chcesz obliczyc: ");
                    liczbaWpisana = Console.ReadLine();

                    while( licznik < liczbaWpisana.Length)
                    {
                        suma += int.Parse(liczbaWpisana[licznik].ToString());
                        licznik++;
                    }
                    Console.WriteLine("Suma cyfr: " + suma);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Niepoprawinie podano wartosc");
                    Console.ReadLine();
                }
            }
            //zadanie6zestaw1();

            static void zadanie7zestaw1()
            {
                try
                {
                    int liczba, resztaZDzielenia = 0;
                    Console.WriteLine("Podaj liczbe aby sprawdzic czy to liczba pierwsza");
                    liczba = Convert.ToInt32(Console.ReadLine());
                    
                    if(liczba > 2)
                    {
                        for (int i = 2; i < liczba; i++)
                        {
                            resztaZDzielenia = liczba % i;
                            if (resztaZDzielenia == 0)
                            {
                                Console.WriteLine("To nie jest liczba pierwsza da sie ja podzielic przez: " + i);
                                Console.ReadLine();
                                return;
                            }
                        }
                        Console.WriteLine("To jest liczba pierwsza nie da sie ja podzielic przez inne liczby bez reszty");
                        Console.ReadLine();
                    }
                    if(liczba <= 2 && liczba >= 0)
                    {
                        Console.WriteLine("To jest liczba pierwsza nie da sie ja podzielic przez inne liczby bez reszty");
                        Console.ReadLine();
                    }
                    if (liczba < 0)
                    {
                        Console.WriteLine("To nie jest liczba naturalna");
                        Console.ReadLine();
                    }

                }
                catch
                {
                    Console.WriteLine("Niepoprawinie podano wartosc");
                    Console.ReadLine();
                }
            }
            //zadanie7zestaw1();

            static void zadanie8zestaw1()
            {
                try
                {
                    string liczbaWpisana, liczbaOdwrocona = "";
                    Console.WriteLine("Wpisz liczbe w ktorej chcesz odwrocic cyfry: ");
                    liczbaWpisana = Console.ReadLine();
                    int licznik = liczbaWpisana.Length;

                    do
                    {
                        licznik--;
                        if(liczbaWpisana[licznik] == '0' && licznik == liczbaWpisana.Length - 1)
                        {

                        }
                        else
                        {
                            liczbaOdwrocona += liczbaWpisana[licznik];
                        }
                    } while (licznik > 0);

                    Console.WriteLine("Liczba odwrocona: " + liczbaOdwrocona);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Niepoprawinie podano wartosc");
                    Console.ReadLine();
                }
            }
            //zadanie8zestaw1();

        }
    }
}