using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmicTasks.Tasks
{
    /// <summary>
    /// Time complexity of the solution: O(n)
    /// Rewrite items of tab2 to HashSet + later iterate over tab1 array: O(n + n) = O(2n) = O(n)
    /// Contains in Hashset is O(1)
    /// </summary>
    public static class Task4
    {
        /// <summary>
        /// Funkcję, która zwraca wartość oznaczającą, ile elementów tablicy tab1 znajduje się w tablicy tab2
        /// //Przykłady wywołania:
        /// IleJestWDrugiejTablicy(string[] { "abc", "def", "ghi"}, string[] { "aaaa", "def", "ddd"})   -> zwraca 1, bo tylko "def" występuje
        /// IleJestWDrugiejTablicy(string[] { "abc", "def", "def"}, string[] { "aaaa", "def", "ddd"})   -> zwraca 2, bo tylko "def" występuje, ale "def" było dwa razy w tablicy pierwszej
        /// IleJestWDrugiejTablicy(string[] { "abc", "def", "ghi"}, string[] { "abc", "abc", "def", "def", "ghi"})
        ///     w zadaniu: -> zwraca 2, bo bo znaleziono "def" i "ghi", natomiast tutaj wkradł się błąd: powinno być:
        ///     -> zwraca 3, bo bo znaleziono "def" i "ghi" ale także "abc" - tak też wygląda implementacja
        /// </summary>
        /// <param name="tab1"></param>
        /// <param name="tab2"></param>
        /// <returns>Liczba elementów tablicy tab1, które znajduja się także w tablicy tab2 w typie integer</returns>
        public static int IleJestWDrugiejTablicy(string[] tab1, string[] tab2)
        {
            if (tab1.Length != 0)
            {
                var tab2HashSet = new HashSet<string>(tab2);
                int counter = 0;

                foreach (var item in tab1)
                {
                    if (tab2HashSet.Contains(item)) counter++;
                }

                return counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
