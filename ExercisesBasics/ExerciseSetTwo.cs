using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliInf.Exercises
{
    internal class ExerciseSetTwo
    {
        static void guessingNumber(int numberOfGuesses = 1) // wartos bazowa dla argumentu, jesli go nie podamy bedzie -1 co wylosuje nowy numer lub mozemy przekazac poprzedni numer
        {
            int userNumber;
            Random random = new Random();
            int randomNumber = random.Next(10);
            int i = 0;
            // for lepszy
            do
            {

                try
                {
                    string errorMessage = "Nie podano liczby calkowita lub podano text"; // nie obsuguje blendu zakresu zgadywania
                    userNumber = Utils.GetUserInputInt("Zgadnij liczbę od 0 do 9", errorMessage);
                }
                catch
                {
                    if (numberOfGuesses > 1)
                    {
                        Console.WriteLine("Zmarnowano jedno zgadniecie");
                    }
                    continue; //przegodzimy do nastempnej pnetli|zgadniecia
                }

                string mainMessage = $", twoja liczba to: {userNumber} a wylosowana liczba to: {randomNumber} w {i+1} prubach.";

                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"Brawo udalo ci sie odgadnac wylosowana liczbe {mainMessage}");
                    return;
                }

                if (numberOfGuesses == 1 || i + 1 == numberOfGuesses)
                {
                    Console.WriteLine("Nie udalo ci sie odgadnac wylosowanej liczby" + mainMessage);
                    return;
                }

                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Za duza.");
                }
                else
                {
                    Console.WriteLine("Za mala.");
                }
            i++;
            }
            while (i < numberOfGuesses);

            return;
        }




        static void diceRoleSimulation()
        {
            int diceRoll;
            int[] diceCount = { 0, 0, 0, 0, 0, 0 };  //int[] diceCount = new int[6];
            bool[] isCloseTo = new bool[6];  // numery srednio ale 100 nie bede pisal recznie
            Random random = new Random();

            for (int i = 0; i < 600; i++)
            {
                diceRoll = random.Next(6); // traktujemy rzuty jako przesuniente o 1, 1->0, 2->1 ...
                diceCount[diceRoll]++;

            }
            bool oneDiceOff = false;
            for (int i = 0; i < isCloseTo.Length; i++)
            {
                isCloseTo[i] = isCloseToNumer(diceCount[i]);
                if (!isCloseToNumer(diceCount[i]))
                {
                    oneDiceOff = true;
                }
            }


            if (oneDiceOff)
            {
                Console.WriteLine("Nie wszystkie ilosci wyrzuconych oczek kostka sa zblizone do 100 z bledem pomiaru 10.");
            }
            else
            {
                Console.WriteLine("Wszystkie ilosci wyrzuconych oczek kostka sa zblizone do 100 z bledem pomiaru 10.");
            }

            Console.WriteLine("Wykres dla liczby wyrzuconych oczek (jedna gwiazdka to 5 rzutow o danej wartosci):");
            for (int i = 0; i < diceCount.Length; i++)
            {
                Console.Write($" {i + 1}: ");
                grafTheAmountInChar(diceCount[i]);
            }

            return;
        }

        // funkcja sprawdzajaca czy dana liczba jest zblizona do 100 z bledem +- 10
        static bool isCloseToNumer(int testedNumber, int targetNumber = 100, int range = 10)
        {
            int diffrenc;
            diffrenc = testedNumber - targetNumber;
            return diffrenc <= range && diffrenc >= -range;      // nie potrzeba if mozemy zwrucic wynik porownania      
        }

        // rysuje wykres dla kazdej 5 rysuje 1 '*' (w zaokragleniu)
        static void grafTheAmountInChar(int count, int oneCharacterIsEquale = 5, char characret = '*')
        {
            string graf = "";
            int totalAmount;
            totalAmount = count / oneCharacterIsEquale;
            for (int i = 0; i < totalAmount; i++)
            {
                graf += characret;
            }
            Console.WriteLine(graf);
        }

        enum rpsMove
        {
            kamien, // zostaja po polsku dal prostrzej implementacji enum parse
            papier,
            nozyce
        }

        static void rockPaperScisors()
        {
            int computerMove, userScore = 0, computerScore = 0;
            rpsMove ruchGraczaEnum, ruchKomputeraEnum;
            string userMove;
            bool validMove;
            Random random = new Random();
            string manueMessage = $"""
                Punkty gracza: {userScore} punkty komputera: {computerScore}.
                Wybierz swoj ruch od 0 do 2.
                 0. Kamien.
                 1. Papier.
                 2. Nozyce.
                """;


            do
            {
                Console.WriteLine(manueMessage);
                userMove = Console.ReadLine();
                validMove = Enum.TryParse<rpsMove>(userMove, true, out ruchGraczaEnum);

                computerMove = random.Next(0, 3);
                Enum.TryParse<rpsMove>(Convert.ToString(computerMove), out ruchKomputeraEnum);
                if (!validMove)
                {
                    Console.WriteLine("Error: Zle podany ruch");
                    continue;
                }

                Console.WriteLine($"Ruch gracza: {ruchGraczaEnum}.");
                Console.WriteLine($"Ruch komputera: {ruchKomputeraEnum}.");
                if (ruchGraczaEnum == ruchKomputeraEnum)
                {
                    Console.WriteLine("Remis graj dalej.");
                    continue;
                }
                // wszystkie przypadki gdzie gracz wygrywa
                bool userWon = ruchGraczaEnum == rpsMove.nozyce && ruchKomputeraEnum == rpsMove.papier || ruchGraczaEnum == rpsMove.kamien && ruchKomputeraEnum == rpsMove.nozyce || ruchGraczaEnum == rpsMove.papier && ruchKomputeraEnum == rpsMove.kamien;

                if (userWon)
                {
                    Console.WriteLine("Wygrales ta runde.");
                    userScore += 1;
                }
                else
                {
                    Console.WriteLine("Przegrales ta runde.");
                    computerScore += 1;
                }

            } while (userScore < 3 && computerScore < 3);

            if (userScore > computerScore)
            {
                Console.WriteLine($"Wygrałeś");
            }
            else
            {
                Console.WriteLine($"Przegrałeś");
            }
            Console.WriteLine($"Punkty gracza: {userScore} punkty komputera: {computerScore}.");

        }

        static void multiplicationTableQuiz()
        {
            int numberA, numberB, anwser, usersGuess, usersScore = 0;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                numberA = random.Next(1, 11);
                numberB = random.Next(1, 11);

                anwser = numberA * numberB;
                Console.WriteLine($" {numberA} * {numberB} = ?");
                try
                {
                    string errorMessage = "Nie podano liczby calkowita lub podano text";
                    usersGuess = Utils.GetUserInputInt("Podaj wynik mnozenia tych liczb:", errorMessage);
                }
                catch
                {
                    Console.WriteLine("Nie zobywasz punktu");
                    continue;
                }


                if (usersGuess == anwser)
                {
                    usersScore += 1;
                }
            }

            string mainMessage = $", zdobyto {usersScore} punktow.";
            switch (usersScore)
            {
                case 3:
                    Console.WriteLine($"Ocena - dostateczny{mainMessage}");
                    break;
                case 4:
                    Console.WriteLine($"Ocena - dobry{mainMessage}");
                    break;
                case 5:
                    Console.WriteLine($"Ocena - bardzo dobry{mainMessage}");
                    break;
                default:
                    Console.WriteLine($"Ocena - niedostateczny{mainMessage}");
                    break;
            }
        }

        static void temperatureSimulation()
        {
            double randomTest, wholeTest, correctTest, minTest, maxTest, avrageOfTests, sumOfAllTests;
            double[] tests = new double[20];
            List<double> testsInRange = new List<double>(); // u nas 20-24 
            //lista to tablica do kturej mozna dodawac i odejmowac wartosci ma zmienna dlugosc

            Random random = new Random();

            for (int i = 0; i < tests.Length; i++)
            {
                randomTest = random.NextDouble();
                wholeTest = randomTest * 8 + 18;
                correctTest = Math.Round(wholeTest, 1);
                tests[i] = correctTest;
            }

            // Na sam poczatek za najmniejszy i za razem najwiekszy pomiar przyjmuje pierwsza wartosc tablicy oraz do sumy wszystkich pomiarow dodaje pierwsza wartosc tablicy, bo petla ja pomija
            minTest = tests[0];
            maxTest = tests[0];
            sumOfAllTests = 0;

            for (int i = 0; i < tests.Length; i++)
            {
                Console.WriteLine($"Pomiar {i + 1} {tests[i]} °C");

                if (minTest > tests[i])     // szukam najmniejszego pomiaru
                {
                    minTest = tests[i];
                }

                if (maxTest < tests[i])      // szukam najwiekszego pomiaru
                {
                    maxTest = tests[i];
                }

                if (tests[i] > 24 || tests[i] < 20)     // szukam pomiarow poza skali i dodaje je do tablicy
                {
                    testsInRange.Add(tests[i]); //dodajemy do listy
                }
                sumOfAllTests = sumOfAllTests + tests[i];
            }
            avrageOfTests = Math.Round(sumOfAllTests / 20, 1);

            Console.WriteLine("Najmniejszy pomiar to: " + minTest + "°C");
            Console.WriteLine("Najwiekszy pomiar to: " + maxTest + "°C");
            Console.WriteLine("Srednia pomiarow to: " + avrageOfTests + "°C");
            Console.WriteLine("Liczba pomiarow z poza zakresu 20-24°C to: " + testsInRange.Count);

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
                    guessingNumber(10);
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

        public static void Main()
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                continueRunning = programLoop();
            }
        }
    }
}
