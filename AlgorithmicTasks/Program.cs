using System;
using AlgorithmicTasks.Tasks;

namespace AlgorithmicTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution by Agnieszka Andrzejczuk");

            // Poniższych wywołań napisanych metod użyłam dla celów testowych

            // TASK 1
            var tablica11 = new int[] { 3, 2, 1, 5, 6, 7 };
            var tablica12 = new int[] { 1, 6, 1, 5, 4, 9 };

            Console.WriteLine("Task 1");
            Console.WriteLine($"Task1: tablica 1 - result: {Task1.Najwiekszy(tablica11)}");
            Console.WriteLine($"Task1: tablica 2 - result: {Task1.Najwiekszy(tablica12)}");

            // TASK 2
            //Najczestrza(int[] { 1, 2, 3, 4, 5 })   -> zwraca 1, bo wszystkie liczby występują tyle samo razy
            //Najczestrza(int[] { 3, 6, 3, 5, 4, 9 })   -> zwraca 3, bo jako jedyna liczba występuje dwukrotnie
            //Najczestrza(int[] { 3, 6, 3, 6, 6, 9 })   -> zwraca 6, bo jako jedyna liczba występuje trzykrotnie
            var tablica21 = new int[] { 1, 2, 3, 4, 5 };
            var tablica22 = new int[] { 3, 6, 3, 5, 4, 9 };
            var tablica23 = new int[] { 3, 6, 3, 6, 6, 9 };
            
            Console.WriteLine("Task 2");
            Console.WriteLine($"Task2: tablica 1 - result: {Task2.Najczestsza(tablica21)}");
            Console.WriteLine($"Task2: tablica 2 - result: {Task2.Najczestsza(tablica22)}");
            Console.WriteLine($"Task2: tablica 3 - result: {Task2.Najczestsza(tablica23)}");

            // TASK 3
            var punkt1 = new Punkt()
            {
                X = 14,
                Y = 3
            };
            var punkt2 = new Punkt()
            {
                X = 14,
                Y = null
            };
            var punkt3 = new Punkt()
            {
                X = null,
                Y = 3
            };
            var punkt4 = new Punkt()
            {
                X = Int32.MaxValue,
                Y = Int32.MaxValue
            };
            var punkt5 = new Punkt()
            {
                X = Int32.MinValue,
                Y = Int32.MinValue
            };
            var punkt6 = new Punkt()
            {
                X = null,
                Y = null
            };
            var punkt7 = new Punkt()
            {
                X = 14,
                Y = 3
            };
            var punkt8 = new Punkt()
            {
                X = 14,
                Y = null
            };

            Console.WriteLine("Task 3");
            Console.WriteLine(punkt1.GetHashCode());
            Console.WriteLine(punkt2.GetHashCode());
            Console.WriteLine(punkt3.GetHashCode());
            Console.WriteLine(punkt4.GetHashCode());
            Console.WriteLine(punkt5.GetHashCode());
            Console.WriteLine(punkt6.GetHashCode());
            Console.WriteLine(punkt7.GetHashCode());
            Console.WriteLine(punkt8.GetHashCode());

            // TASK 4
            var tablica411 = new string[] { "abc", "def", "ghi"};
            var tablica412 = new string[] { "aaaa", "def", "ddd"}; //   -> zwraca 1, bo tylko "def" występuje
            var tablica421 = new string[] { "abc", "def", "def" };
            var tablica422 = new string[] {"aaaa", "def", "ddd"}; // zwraca 2, bo tylko "def" występuje, ale "def" było dwa razy w tablicy pierwsze
            var tablica431 = new string[] { "abc", "def", "ghi" };
            var tablica432 = new string[] {"abc", "abc", "def", "def", "ghi"}; //-> zwraca 2, bo bo znaleziono "def" i "ghi"; błąd w opisie zadania: powinno zwrócić 3, bo znaleziono "abc", "def" oraz "ghi"

            Console.WriteLine("Task 4");
            Console.WriteLine(Task4.IleJestWDrugiejTablicy(tablica411, tablica412));
            Console.WriteLine(Task4.IleJestWDrugiejTablicy(tablica421, tablica422));
            Console.WriteLine(Task4.IleJestWDrugiejTablicy(tablica431, tablica432));

            // TASK 5
            // Rozwiązanie znajduje się w projekcie testowym nUnit w tej samej solucji
        }
    }
}
