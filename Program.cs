using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samlingsklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ut menyalternativ
            Console.WriteLine("1. integer-lista.");
            Console.WriteLine("2. double-lista.");
            Console.WriteLine("3. Dictionary-exempel.");
            Console.WriteLine("4. Tärningskast med Dictionary.");
            Console.WriteLine("5. Stack-exempel.");
            Console.WriteLine("6. Queue-exempel.");
            Console.WriteLine("7. Övning 1");
            Console.WriteLine("8. Övning 2");
            Console.WriteLine("9. Övning 3");
            Console.WriteLine("10. Övning 4");
            Console.WriteLine("11. Övning 5");
            // Läs in menyval
            Console.Write("Ange siffra för vad du vill göra: ");
            string val = Console.ReadLine();
            // Använd en switch-sats för att anropa den metod som hör ihop med menyvalet.
            switch(val){
                case "1":
                    IntegerLista();
                    break;
                case "2":
                    DoubleLista();
                    break;
                case "3":
                    DictionaryExempel();
                    break;
                case "4":
                    DiceDictionary();
                    break;
                case "5":
                    StackExempel();
                    break;
                case "6":
                    QueueExempel();
                    break;
                case "7":
                    Övning_1();
                    break;
                case "8":
                    Övning_2();
                    break;
                case "9":
                    Övning_3();
                    break;
                case "10":
                    Övning_4();
                    break;
                case "11":
                    Övning_5();
                    break;
            }
            Console.ReadKey();
        }
        static void DictionaryExempel()
        {
            // Skapa en dictionary med string som nyckel och int som värde
            Dictionary<string, int> personer = new Dictionary<string, int>();
            // Lägg till
            personer.Add("Kalle", 10);
            personer.Add("Sven", 12);
            personer.Add("Oskar", 10);
            personer.Add("Viggo", 13);
            Console.WriteLine("Kalles ålder är: " + personer["Kalle"]);
            // "Iterera" genom samlingen
            foreach (KeyValuePair<string, int> kvp in personer)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }
        }
        static void DiceDictionary()
        {
            // Skapa en dictionary med int som nyckel och int som värde
            Dictionary<int, int> resultat = new Dictionary<int, int>();
            // Skapa ett Random objekt för att slumpa
            Random random = new Random();
            // Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                // Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);
                // Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);
                // Öka förekomsten av tal
                resultat[tal]++;
            }
            // Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

        }
        static void QueueExempel()
        {
            Queue<string> nummer = new Queue<string>();
            nummer.Enqueue("ett");
            nummer.Enqueue("två");
            nummer.Enqueue("tre");
            nummer.Enqueue("fyra");
            nummer.Enqueue("fem");
            // "Iteration" utan att ändra innehållet i kön
            foreach (string number in nummer)
            {
                Console.WriteLine(number);
            }
            // "Iteration" samtidigt som kön töms
            while (nummer.Count > 0)
            {
                Console.WriteLine(nummer.Dequeue());
            }
        }

        static void StackExempel()
        {
            Stack<string> nummer = new Stack<string>();
            nummer.Push("ett");
            nummer.Push("två");
            nummer.Push("tre");
            nummer.Push("fyra");
            nummer.Push("fem");
            // "Iteration" utan att ändra innehållet i stacken
            foreach (string number in nummer)
            {
                Console.WriteLine(number);
            }
            // "Iteration" samtidigt som stacken töms
            while (nummer.Count > 0)
            {
                Console.WriteLine(nummer.Pop());
            }
        }
        static void IntegerLista()
        {
            // Skapa en lista av int
            List<int> lista = new List<int>();
            // Fyll listan med några enstaka värden
            lista.Add(5);
            lista.Add(15);
            lista.Add(25);
            // Lägg till flera tal samtidigt genom att använda en Array med värden
            lista.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            // "Iterera" genom listan och skriv ut varje enskilt värde och index.
            // Indexeringen är precis som med Array men istället för .Length finns det en .Count
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Index: {0} Tal: {1}", i, lista[i]);
            }
            // Undersök om ett visst värde finns i listan
            Console.WriteLine("Finns talet 5 i listan? " + lista.Contains(5));
            Console.WriteLine("Finns talet 7 i listan? " + lista.Contains(7));
            // Ta bort första förekomst av ett värde
            lista.Remove(5);
            // Ta bort värde på ett angivet index
            lista.RemoveAt(3);
            // "Iterera" igen, denna gång med en foreach loop
            foreach (int tal in lista)
            {
                Console.WriteLine("Tal: {0}", tal);
            }
        }
        static void DoubleLista()
        {
            // Skapa en lista av double
            List<double> dLista = new List<double>();
            // Lägg till flera tal samtidigt genom att använda en Array med värden
            dLista.AddRange(new double[] { 3.2, 5.1, 13, 7.4, 8.2, 2.8, 14.1 });
            // Skriv ut lite information om innehållet i listan
            Console.WriteLine("Summan av alla element: " + dLista.Sum());
            Console.WriteLine("Medelvärdet: " + dLista.Average().ToString("0.00"));
            Console.WriteLine("Största värdet: " + dLista.Max());
            Console.WriteLine("Minsta värdet: " + dLista.Min());
            // Vilket index hade det minsta värdet...?
            Console.WriteLine("Minsta värdet fanns på index: " + dLista.IndexOf(dLista.Min()));
            // Sortera listan
            dLista.Sort();
            foreach (double d in dLista)
            {
                Console.WriteLine("Värde: " + d);
            }
        }
        static void Övning_1()
        {
            // Skapa en SortedList med int som nyckel och int som värde
            SortedList<int, int> resultat = new SortedList<int, int>();
            // Skapa ett Random objekt för att slumpa
            Random random = new Random();
            // Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                // Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);
                // Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);
                // Öka förekomsten av tal
                resultat[tal]++;
            }
            // Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

        }
        static void Övning_2()
        {
            // Skapa en lista av double
            List<double> Lista = new List<double>();
            // Upprepa för alltid eller vid visa conditioner
            while (true)
            {
                // Skriv ut information
                Console.WriteLine("Skriv ett tal: ");
                // Mata in talets värde
                double tal = Convert.ToDouble(Console.ReadLine());
                // Ifall talet är 0 avslutas programmet
                if (tal == 0)
                {
                    break;
                }
                else
                {
                    //Lägg till det senaste talet i listan
                    Lista.Add(tal);
                    //Få ut listans medelvärde
                    Console.WriteLine("Medelvärde: " + Lista.Average());
                }
            }
        }
        static void Övning_3()
        {
            // Skapa ett Random objekt för att slumpa
            Random random = new Random();
            // Skapa en List med string
            List<string> Kortlek = new List<string>();
            // Skapa en ny array med hjärta, ruter, klöver och spader
            var typ = new string[] { "h", "r", "k", "s" };
            // För 1 till 4
            for (int i = 0; i < 4; i++)
            {
                // Lägg till ess i kortleken
                Kortlek.Add(typ[i] + "E");
                // För 2 till 10
                for (int a = 2; a <= 10; a++)
                {
                    // Lägg till alla siffor i kortleken
                    Kortlek.Add(typ[i] + a.ToString());
                }
                // Lägg till knekt, dam och kung i kortleken
                Kortlek.Add(typ[i] + "Kn");
                Kortlek.Add(typ[i] + "D");
                Kortlek.Add(typ[i] + "K");
            }
            // Så länga den finns kort i kortleken
            while (Kortlek.Count != 0)
            {
                // En slumpad siffra
                int slump = random.Next(0, Kortlek.Count);
                // Skriv ut vilket kort du drog
                Console.WriteLine("Du drog: " + Kortlek[slump]);
                // Ta bort kortet du drog ur kortleken
                Kortlek.RemoveAt(slump);
            }
        }
        static void Övning_4()
        {
            // Skapa ett Random objekt för att slumpa
            Random random = new Random();
            // Skapa en Dictionary med string som nyckel och int som värde
            Dictionary<string, int> Kortlek = new Dictionary<string, int>();
            // Skapa en ny array med hjärta, ruter, klöver och spader
            var typ = new string[] { "h", "r", "k", "s" };
            // För 1 till 4
            for (int i = 0; i < 4; i++)
            {
                // Lägg till ess i kortleken
                Kortlek.Add(typ[i] + "E", 1);
                // För 2 till 10
                for (int a = 2; a <= 10; a++)
                {
                    // Lägg till alla siffor i kortleken
                    Kortlek.Add(typ[i] + a.ToString(), a);
                }
                // Lägg till knekt, dam och kung i kortleken
                Kortlek.Add(typ[i] + "Kn", 11);
                Kortlek.Add(typ[i] + "D", 12);
                Kortlek.Add(typ[i] + "K", 13);
            }
            // Ny varibel för att räkna antal par
            int antalPar = 0;
            // Upprepa tusen gånger
            for (int i = 0; i < 1000; i++)
            {
                // Slumpar två kort
                int slump1 = random.Next(0, Kortlek.Keys.ToArray().Length);
                int slump2 = random.Next(0, Kortlek.Keys.ToArray().Length);
                if (Kortlek[Kortlek.Keys.ToArray()[slump1]] == Kortlek[Kortlek.Keys.ToArray()[slump2]])
                {
                    // Skriv ut när du får par
                    Console.WriteLine("Par!");
                    // Addera paret till antal par
                    antalPar++;
                }
            }
            // Skriv ut antal par 
            Console.WriteLine(antalPar);
        }
        static void Övning_5()
        {
            // Skriv ut information
            Console.WriteLine("Mata in texten: ");
            // Mata in texten
            string text = Console.ReadLine();
            // Skapa ett StringBuilder objekt för att modifera texten
            StringBuilder sb = new StringBuilder();
            // För alla karaktärer i texten
            for (int i = 0; i < text.Length; i++)
            {
                // Ha bara kvar ord i texten
                if (text[i] >= 'A' && text[i] <= 'z' || (text[i] == ' '))
                {
                    // Lägg tillbaka de tillåtna orden
                    sb.Append(text[i]);
                }
            }
            // Bygg upp texten igen
            text = sb.ToString();

            // Skapa en List med string
            List<string> Lista = new List<string>();
            // Dela upp alla ställen vid mellanslag (orden) och lägg i ett fält
            string[] splittedStringArray = text.Split(' ');
            // För varje ord i fältet
            foreach (string stringInArray in splittedStringArray)
            {
                // Lägg in orden i listan
                Lista.Add(stringInArray);
            }

            // Gruppera orden efter antal förekomster
            var förekomster = Lista.GroupBy(i => i);
            // För varje antal i förekomster
            foreach (var antal in förekomster)
            {
                // Skriv ut orden efter antal förekomster
                Console.WriteLine("{0} {1}", antal.Key, antal.Count());
            }
        }
    }
}
