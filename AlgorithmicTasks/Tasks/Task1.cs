using System;
using System.Linq;

namespace AlgorithmicTasks.Tasks
{
    //Napisz funkcję zwracającą trzeci najmniejszy element tablicy:
    //Sygnatura funkcji:
    //int Najwiekszy(int[] tablica)
    //    {
    //        ...
    //}
    //    Przykłady wywołania:
    //Najwiekszy(int[] { 3, 2, 1, 5, 6, 7 })   -> zwraca 3
    //Najwiekszy(int[] { 1,6, 1, 5, 4, 9 })   -> zwraca 4

    public static class Task1
    {
        private const int _index = 3;

        /// <summary>
        /// Funkcję zwracająca trzeci najmniejszy element tablicy
        /// </summary>
        /// <param name="tablica"></param>
        /// <returns></returns>
        public static int Najwiekszy(int[] tablica)
        {
            int result = 0;

            for (int i = 0; i < _index; i++)
            {
                result = tablica.Min();

                int toRemoveIndex = Array.IndexOf(tablica, result);
                tablica = tablica.Where((value, index) => index != toRemoveIndex).ToArray();
            }

            return result;
        }
    }
}
