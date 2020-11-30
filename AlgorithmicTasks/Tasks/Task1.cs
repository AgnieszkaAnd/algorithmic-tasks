using System;
using System.ComponentModel;
using System.Linq;

namespace AlgorithmicTasks.Tasks
{
    /// <summary>
    /// Time complexity of the solution for .NET Core 3.1: O(n),
    /// ponieważ używam metod LINQ OrderBy (Order By: używa z tego co wiem algorytmu sortowania Quicksort, który ma w średnim przypadku złożoność O(n log(n)),
    /// Skip - złożoność O(1) stała, ponieważ sprawdzi najpierw, czy obiekt implementuje IList<T>, First bez warunku: podobnie O(1)),
    /// natomiast widzę na stronie: https://docs.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/5.0/orderby-firstordefault-complexity-increase
    /// że dla .NET Core 3.x .OrderBy().First() działa ze złożonością O(n)
    /// </summary>
    public static class Task1
    {
        private const int _index = 3;

        /// <summary>
        /// Funkcja zwracająca trzeci najmniejszy element tablicy, bez pomijania powtarzających sie wartości (zobacz drugi przykład wywołania)
        /// (nazwa: Największa - ponieważ tak było podane w zadaniu)
        /// Przykłady wywołania:
        /// Najwiekszy(int[] { 3, 2, 1, 5, 6, 7 })   -> zwraca 3
        /// Najwiekszy(int[] { 1,6, 1, 5, 4, 9 })   -> zwraca 4
        /// </summary>
        /// <param name="tablica">Tablica z elementami typu positive integer</param>
        /// <returns>Trzeci najmniejszy element z tablicy</returns>
        public static int Najwiekszy(int[] tablica)
        {
            if (tablica.Length >= _index)
            {
                int thirdLowest = tablica.OrderBy(x => x)
                    .Skip(_index-1)
                    .First();

                return thirdLowest;
            }
            else
            {
                Console.WriteLine("Invalid argument provided, please check method input");
                return Int32.MinValue;
            }
        }
    }
}
