using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicTasks.Tasks
{
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
            var valuesOccurences = new Dictionary<int, int>();

            foreach (var number in liczby)
            {
                if (valuesOccurences.Keys.Contains(number)) valuesOccurences[number]++;
                else valuesOccurences[number] = 1;
            }

            return valuesOccurences.FirstOrDefault(x => x.Value == valuesOccurences.Values.Max()).Key;
        }
    }
}
