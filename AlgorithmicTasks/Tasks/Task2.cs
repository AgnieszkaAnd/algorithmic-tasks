using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicTasks.Tasks
{
    /// <summary>
    /// Time complexity of the solution: O(n^3 log(n)),
    /// GroupBy: O(n),
    /// OrderBy: O(n log(n)),
    /// Last: IOrderedEnumerable does not implement IList<T> so complexity is O(n)
    /// </summary>
    public static class Task2
    {
        /// <summary>
        /// Funkcja zwracająca liczbę najczęściej występującą w podanej kolekcji
        /// Przykłady wywołania:
        /// Najczestsza(int[] { 1, 2, 3, 4, 5 })   -> zwraca 1, bo wszystkie liczby występują tyle samo razy
        /// Najczestsza(int[] { 3, 6, 3, 5, 4, 9 })   -> zwraca 3, bo jako jedyna liczba występuje dwukrotnie
        /// Najczestsza(int[] { 3, 6, 3, 6, 6, 9 })   -> zwraca 6, bo jako jedyna liczba występuje trzykrotnie
        /// </summary>
        /// <param name="liczby">Kolekcja/typ wyliczeniowy z elementami typu positive integer</param>
        /// <returns>Element z kolekcji "liczby", który występuje największą ilość razy, jeśli więcej niż jeden element występuje tą samą największą liczbę razy,
        /// wtedy funkcja zwraca ten, który wcześniej występuje w kolekcji (ma niższy indeks)</returns>
        public static int Najczestsza(IEnumerable<int> liczby)
        {
            if (liczby.Count() != 0)
            {
                int topOccurence = liczby.GroupBy(x => x)
                    .OrderBy(x => x.Count())
                    .Last().Key;

                return topOccurence;
            }
            else
            {
                Console.WriteLine("Input collection cannot be empty");
                return Int32.MinValue;
            }
        }
    }
}
