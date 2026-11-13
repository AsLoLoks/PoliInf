using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliInf.Exercises
{
    internal class ExerciseSetThree
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
            } while (i < amount);
            avrage = sum / amount;
            Console.WriteLine("wylosowane liczby: " + wypisaneLiczby);
            Console.WriteLine("Srednia " + amount + " liczb wylosowanych: " + avrage);
            Console.WriteLine("Najmniejsza liczba z liczb wylosowanych: " + min);
            Console.WriteLine("Najwieksza liczba z liczb wylosowanych: " + max);
            Console.ReadLine();

        }
        //zadanie1b();



        static void writeMultiplicationTable()
        {
            string line = "";

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    line = i * j + " ";
                }
                Console.WriteLine(line);

            }

        }


        static void writhAlphabetFor()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string formated = "";

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
            }
            Console.WriteLine(formated);

            string reversed = "";
            for (int i = alphabet.Length - 1; i >= 0; i--)
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
        static void writhAlphaberDoWhile()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string formated = "";
            int i = 0;
            do
            {
                if (i != alphabet.Length - 1)
                {
                    formated += $"{alphabet[i]}, ";
                }
                else
                {
                    formated += $"{alphabet[i]}.";
                }
                i++;
            } while (i < alphabet.Length);

            Console.WriteLine(formated);

            string reversed = "";
            i = alphabet.Length - 1;
            do
            {
                reversed += alphabet[i];
                i--;
            } while (i >= 0);
            i = 0;
            do
            {
                if (i != reversed.Length - 1)
                {
                    formated += $"{reversed[i]}, ";
                }
                else
                {
                    formated += $"{reversed[i]}.";
                }
                i++;
            } while (i < reversed.Length);

            Console.WriteLine(formated);
        }

        static void writhAlphaberWhile()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string formated = "";
            int i = 0;
            while (i < alphabet.Length)
            {
                if (i != alphabet.Length - 1)
                {
                    formated += $"{alphabet[i]}, ";
                }
                else
                {
                    formated += $"{alphabet[i]}.";
                }
                i++;
            }

            Console.WriteLine(formated);

            string reversed = "";
            i = alphabet.Length - 1;
            while (i >= 0)
            {
                reversed += alphabet[i];
                i--;
            }
            i = 0;
            while (i < reversed.Length)
            {
                if (i != reversed.Length - 1)
                {
                    formated += $"{reversed[i]}, ";
                }
                else
                {
                    formated += $"{reversed[i]}.";
                }
                i++;
            }

            Console.WriteLine(formated);
        }
        //zadanie3();



        static void zadanie4() //zbyd specyficne na sensowna nazwe 
        {
            int numberA, numberB, count = 0;

            for (int i = 1000; i < 10000; i++)
            {
                numberA = i / 100;
                numberB = i % 100;

                if (numberA * numberA + numberB * numberB == i)
                {
                    count++;
                    Console.WriteLine($"{numberA} ^ 2 + {numberB} ^ 2 = {i}");
                }
            }
            Console.WriteLine($"Znaleziono takich liczb: {count}");
        }
        //zadanie4();

        static void isPalindrome()
        {
            string userWord;
            Console.WriteLine("Podal liczbe lub zdanie lub slowo");
            userWord = Console.ReadLine();

            userWord = userWord.Replace(" ", "").ToLower();
            int j = userWord.Length - 1;
            for (int i = 0; i <= Math.Round((double)userWord.Length / 2); i++)
            {
                if (userWord[i] != userWord[j])
                {
                    Console.WriteLine("To nie jest palindrom");
                    return;
                }
                j--;
            }
            Console.WriteLine("To jest palindrom");
            return;

        }
        //zadanie5();

        static void getPi()
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

                for (int i = 0; i < iloscWylosowan; i++)
                {
                    losoweX = generuj.Next(-r, r);
                    losoweY = generuj.Next(-r, r);

                    if ((losoweX * losoweX) + (losoweY * losoweY) <= (r * r))
                    {
                        punktyWKole++;
                    }
                    else
                    {
                        punktyPozaKolem++;
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

        static void sumNumber()
        {
            int userNumber;
            int i = 0, suma = 0;
            Console.WriteLine("Wpisz liczbe ktorej sume cyfr chcesz obliczyc: ");

            try
            {
                userNumber = Utils.GetUserInputInt("Wpisz liczbe ktorej sume cyfr chcesz obliczyc: ", "Podano tekst");
            }
            catch { return; }


            // zrobione jak for'em, zeby while mial sen zadanie musialo by zabronic string
            // wtedy number / 10 i number % 10
            while (i < userNumber.ToString().Length)
            {
                suma += userNumber.ToString()[i];
                i++;
            }
            Console.WriteLine("Suma cyfr: " + suma);

        }
        //zadanie6zestaw1();

        static void isPrime()
        {
            int userNumber;
            try
            {
                userNumber = Utils.GetUserInputInt("Podaj liczbe aby sprawdzic czy to liczba pierwsza", "Podano tekst");
            }
            catch { return; }

            if (userNumber < 0)
            {
                Console.WriteLine("To nie jest liczba naturalna");
                return;
            }
            if (userNumber == 0 || userNumber == 1)
            {
                Console.WriteLine("To nie jest liczba pierwsza");
                return;
            }
            if (userNumber == 2)
            {
                Console.WriteLine("To jest liczba naturalna");
                return;
            }

            for (int i = 2; i < userNumber; i++)  // mozey zatrzymac sie na pierwiastku z numeru lub urzyc erastotelesa
            {
                if (userNumber % i == 0)
                {
                    Console.WriteLine("To nie jest liczba pierwsza da sie ja podzielic przez: " + i);
                    return;
                }
            }
            Console.WriteLine("To jest liczba pierwsza nie da sie ja podzielic przez inne liczby bez reszty");

        }
        //zadanie7zestaw1();

        static void reverseNumer()
        {
            string reversedNumber = "";
            int userNumber;

            try
            {
                userNumber = Utils.GetUserInputInt("Wpisz liczbe w ktorej chcesz odwrocic cyfry: ", "podano text");
            }
            catch { return; }

            string userNumberString = userNumber.ToString(); // meh nazewnictow
            int i = userNumberString.Length - 1;

            do
            {
                reversedNumber += userNumberString;
                i--;
            } while (i >= 0);

            i = 0;
            string reversStripNumber = "";
            bool startWriting = false;
            do
            {
                if (reversedNumber[i] != '0')
                {
                    startWriting = true;
                }
                if (startWriting)
                {
                    reversStripNumber += reversedNumber[i];
                }

                Console.WriteLine("Liczba odwrocona: " + reversedNumber);
                Console.ReadLine();
                i++;
            } while (i < reversedNumber.Length);

        }
        //zadanie8zestaw1();
    }
}
