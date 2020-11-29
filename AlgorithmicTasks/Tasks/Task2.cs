using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmicTasks.Tasks
{
    //Znajdź wartość, która występuje największą liczbę razy w kolekcji:
    //Sygnatura funkcji:
    //int Najczestrza(IEnumerable<int> liczby)
    //{
    //...
    //}
    //Przykłady wywołania:
    //Najczestrza(int[] { 1, 2, 3, 4, 5 })   -> zwraca 1, bo wszystkie liczby występują tyle samo razy
    //Najczestrza(int[] { 3, 6, 3, 5, 4, 9 })   -> zwraca 3, bo jako jedyna liczba występuje dwukrotnie
    //Najczestrza(int[] { 3, 6, 3, 6, 6, 9 })   -> zwraca 6, bo jako jedyna liczba występuje trzykrotnie
    public static class Task2
    {
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
