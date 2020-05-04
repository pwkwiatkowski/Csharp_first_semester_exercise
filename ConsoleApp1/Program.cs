using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i] = array[j]; i++; // ++ and -- inside array braces for shorter code
                    array[j] = tmp; j--;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
        */
        /*
            public static void silnia_funkcja(int liczba1)
        {
            int licznik = 2, silnia = 1;
            int liczba = liczba1;

            while (licznik <= liczba)
            {
                silnia = silnia * licznik;
                licznik++;
            }
            Console.WriteLine(silnia);
        }
        */
        private static int licz_silnie(int liczba)
        {
            int silnia = 1;

            while (liczba > 1)
            {
                silnia *= liczba--;
                //silnia = silnia * liczba;
                //liczba--;
            }

            return silnia;
        }

        private static double pole_kola(int r)
        {
            double wynik = Math.PI * (r * r);

            return wynik;
        }

        private static double obwod_kola(int r)
        {
            double wynik = 2 * Math.PI * r;

            return wynik;
        }

        static void Main(string[] args)
        {
            /*           string zmienna;

                         Console.Write("Podaj imie i nazwisko: ");
                         zmienna = Console.ReadLine();
                         Console.Write("Witaj, {0}!",zmienna);
            */
            /*
                        int a;

                        Console.Write("Podaj dlugosc krawedzi szescianu: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Objetosc to {0}", a * a * a);
            */

            /*
            int liczba;

            Console.Write("Podaj liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            if(liczba%2==0)
                Console.Write("Jest parzysta");
            else
                Console.Write("Nie jest parzysta");
            */

            /*
            float l1, l2, l3;
            float min,maks;

            Console.WriteLine("Podaj 3 liczby: ");

            l1 = Convert.ToInt32(Console.ReadLine());
            l2 = Convert.ToInt32(Console.ReadLine());
            l3 = Convert.ToInt32(Console.ReadLine());

            min = l1;
            if (min > l2) min = l2;
            if (min > l3) min = l3;

            maks = l1;
            if (maks < l2) maks = l2;
            if (maks < l3) maks = l3;

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + maks);

            Console.WriteLine("Średnia: {0}", (l1 + l2 + l3) / 3);

            float med=0;
            if (l1 != min && l1 != maks) med = l1;
            if (l2 != min && l2 != maks) med = l2;
            if (l3 != min && l3 != maks) med = l3;

            Console.WriteLine("Mediana z liczb: {0},{1},{2} to {3}", min, med, maks, med);
            */

            /*
            int rok;

            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                Console.WriteLine("Rok jest przestępny");
            else
                Console.WriteLine("Rok nie jest przestępny");
            */

            /*
            int nr_mies;

            Console.Write("Podaj numer miesiąca: ");
            nr_mies = Convert.ToInt32(Console.ReadLine());
            switch (nr_mies)
            {
                case 1:
                    Console.Write("styczeń");
                    break;
                case 2:
                    Console.Write("luty");
                    break;
                case 3:
                    Console.Write("marzec");
                    break;
                case 4:
                    Console.Write("kwiecień");
                    break;
                case 5:
                    Console.Write("maj");
                    break;
                case 6:
                    Console.Write("czerwiec");
                    break;
                case 7:
                    Console.Write("lipiec");
                    break;
                case 8:
                    Console.Write("sierpień");
                    break;
                case 9:
                    Console.Write("wrzesień");
                    break;
                case 10:
                    Console.Write("październik");
                    break;
                case 11:
                    Console.Write("listopad");
                    break;
                case 12:
                    Console.Write("grudzień");
                    break;
                default:
                    Console.Write("Nie ma takiego miesiąca!");
                    break;
            }
            */

            /*
            for(int i=0; i<=1000; i=+2)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int liczba;
            
            for (int i = 0; i <= 1000; i = +2)
            {
                Console.Write("Podaj liczbę: ");
                liczba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(2,liczba));
            }
            */

            //potega = Int32.Parse(Console.ReadLine());

            /*
            Console.Write("Podaj liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            //double temp = Math.Pow(2, liczba);

            for (int i = 0; i <= liczba; i++)
            {
                Console.WriteLine("{0}", Math.Pow(2, i));
            }
            */

            /*
            int number; int pom=0;

            number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                pom += i;
            }
            Console.WriteLine(pom);
            */

            /*
            int wiersz, kolumna;

            Console.Write("Ile wierszy: ");
            wiersz = Int32.Parse(Console.ReadLine());
            Console.Write("Ile kolumn: ");
            kolumna = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= wiersz; i++)
            {
                for (int j = 1; j <= kolumna; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            */

            /*
            int wiersz, kolumna;

            Console.Write("Ile wierszy: ");
            wiersz = Int32.Parse(Console.ReadLine());
            Console.Write("Ile kolumn: ");
            kolumna = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= wiersz; i++)
            {
                for (int j = 1; j <= kolumna; j++)
                {
                    Console.Write("{0}\t",i*j);
                }
                Console.Write("\n");
            }
            */

            /*
            for(int i=1; i<=1000; i++)
            {
                if(i%3==0 || i%5==0 || i%11==0)
                    Console.Write("{0} ",i);
            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* \t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* \t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("\t");
                }
                for (int j = 0; j < (10-i); j++)
                {
                    Console.Write("*\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > (i+1); j--)
                {
                    Console.Write("\t");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            */

            /*
            int liczba = 1;

            while(liczba<=100)
            {
                Console.WriteLine(liczba);
                liczba += 3;
            }
            */

            /*
            int liczba;
            int suma = 0;

            do
            {
                liczba = Int32.Parse(Console.ReadLine());
                suma += liczba;
                //Console.WriteLine("Twoja liczba: {0}",liczba);
                Console.WriteLine("Suma: {0}",suma);
            } while (liczba!=0);
            Console.WriteLine("Koniec programu");
            */

            /*
            //v1
            int licznik = 2, silnia = 1, liczba;
            liczba = Int32.Parse(Console.ReadLine());

            while (licznik<=liczba)
            {
                silnia = silnia * licznik;
                licznik++;
            }
            Console.WriteLine(silnia);
            */

            /*
            //v2
            int liczba, silnia = 1;
            liczba = Int32.Parse(Console.ReadLine());

            while (liczba > 1)
            {
                silnia *= liczba--;
                //silnia = silnia * liczba;
                //liczba--;
            }
            Console.WriteLine(silnia);
            */

            /*
            string[] tablica = new string[4] {"w1","w2","w3","w4"};

            //tablica[0] = "w1";
            //tablica[1] = "w2";
            //tablica[2] = "w3";
            //tablica[3] = "w4";


            //for(int i=0; i<tablica.Length; i++)
                //Console.WriteLine(tablica[i]);

            foreach(string element in tablica)
                Console.WriteLine(element);
             */


            //-------------------------------------------------------------------------------
            /*
            Random generator = new Random();
            int[] tablica = new int[20];

            //Console.WriteLine(generator.Next(3));

            Console.WriteLine("Liczby w tablicy");
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.Next(20); //Next(1,21) od 1 do 20 (bez 21)
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("\nParzyste");
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                if (tablica[i] % 2 == 0)
                    Console.WriteLine(tablica[i]);
            }

            float suma = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            float srednia = suma / tablica.Length;
            Console.WriteLine("\nSrednia: {0}", srednia);

            int minimum;
            minimum = tablica[0];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (minimum > tablica[i])
                    minimum = tablica[i];
            }
            Console.WriteLine("\nMinimum: {0}", minimum);
            
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length-1; j++)
                {
                    if (tablica[j] > tablica[j+1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j+1];
                        tablica[j+1] = temp;
                    }
                }
            }
            
            Console.WriteLine("Posortowana tablica");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            */

            /*
            //quicksort
            QuickSort(tablica, 0, tablica.Length - 1);
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            */

            /*
            for(int i=0; i<tablica.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę:",i+1);
                tablica[i]= Int32.Parse(Console.ReadLine());
            }
            */


            /*
            Console.Write("\n");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.Write("\n");
            */
            //Console.Write("\n");

            /*
            for (int i = 0; i < tablica.Length; i++)
            {
                if(tablica[i]%2==0)
                    Console.WriteLine(tablica[i]);
            }
            */
            /*
            for (int i = tablica.Length-1; i >= 0; i--)
            {
                if (tablica[i] % 2 == 0)
                    Console.WriteLine(tablica[i]);
            }
            */
            //----------------------------------------------------------------------------------

            //totolotek
            /*
            Random generator = new Random();
            int[] tablica = new int[6];

            Console.Write("Ile zestawów liczb: ");
            try
            {
                int liczba = Int32.Parse(Console.ReadLine());

                if (liczba < 1)
                    throw new FormatException();

                Console.WriteLine("Liczby w tablicy");
                for (int k = 0; k < liczba; k++)
                {
                    for (int i = 0; i < tablica.Length; i++)
                    {
                        tablica[i] = generator.Next(1, 50);
                        for (int j = 0; j < i; j++)
                        {
                            if (tablica[i] == tablica[j]) i--;
                        }
                    }

                    Console.Write("Zestaw nr {0}: ", k + 1);
                    for (int i = 0; i < tablica.Length; i++)
                    {
                        Console.Write(tablica[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Podaj dodatnią liczbę");
            }

            //try { } przechwytywanie wyjątków

            

            */
            /*
            //sortowanie
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nPosortowana tablica");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i]+", ");
            }
            */


            /*
            try
            {
                Console.Write("Podaj 1. liczbe: ");
                float l1 = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj 2. liczbe: ");
                float l2 = Int32.Parse(Console.ReadLine());
                

                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.Write("Wybór: ");
                int wybor = Int32.Parse(Console.ReadLine());

                float wynik = 0;
                switch (wybor)
                {
                    case 1:
                        wynik = l1 + l2;
                        break;
                    case 2:
                        wynik = l1 - l2;
                        break;
                    case 3:
                        wynik = l1 * l2;
                        break;
                    case 4:
                    if(l2!=0)
                        wynik = l1 / l2;
                    else
                        Console.WriteLine("Nie dzielimy przez zero!");
                    break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji w menu!");
                        break;
                }

                Console.WriteLine("Wynik: {0}", wynik);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Podaj liczbę!");
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Za mała lub za duża wartość!");
            }
            catch(System.DivideByZeroException)
            {
                Console.WriteLine("Nie dzielimy przez zero!");
            }
            */

            /*
            Console.Write("Podaj liczę, dla której chcesz policzyć silnię: ");
            int liczba = Int32.Parse(Console.ReadLine());

            silnia_funkcja(liczba);
            */

            /*
            Console.Write("Podaj liczę, dla której chcesz policzyć silnię: ");
            try
            {
                int liczba = Int32.Parse(Console.ReadLine());
                //licz_silnie(liczba);
                Console.WriteLine(licz_silnie(liczba));

                if (liczba < 0)
                    throw new FormatException();
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Podaj właściwą wartość");
            }
            */

            Console.Write("Podaj promień koła: ");
            try
            {
                int promien = Int32.Parse(Console.ReadLine());
                if (promien < 0)
                    throw new FormatException();

                Console.WriteLine("Pole = {0}", Math.Round(pole_kola(promien), 4));
                Console.WriteLine("Obwód = {0}", Math.Round(obwod_kola(promien), 4));
            }
            catch (FormatException)
            {
                Console.WriteLine("Podaj właściwą wartość");
            }







            Console.ReadKey();
        }
    }
}
