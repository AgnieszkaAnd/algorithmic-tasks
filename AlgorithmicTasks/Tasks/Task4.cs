using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmicTasks.Tasks
{
    //Napisz funkcję, która policzy ile elementów tablicy tab1 znajduje się w tablicy tab2:
    //Sygnatura funkcji:
    //int IleJestWDrugiejTablicy(string[] tab1, string[] tab2)
    //{
    //...
    //}

    //Przykłady wywołania:
    //IleJestWDrugiejTablicy(string[] { "abc", "def", "ghi"}, string[] { "aaaa", "def", "ddd"})   -> zwraca 1, bo tylko "def" występuje
    //IleJestWDrugiejTablicy(string[] { "abc", "def", "def"}, string[] { "aaaa", "def", "ddd"})   -> zwraca 2, bo tylko "def" występuje, ale "def" było dwa razy w tablicy pierwszej
    //IleJestWDrugiejTablicy(string[] { "abc", "def", "ghi"}, string[] { "abc", "abc", "def", "def", "ghi"})   -> zwraca 2, bo bo znaleziono "def" i "ghi"
    public static class Task4
    {
        public static int IleJestWDrugiejTablicy(string[] tab1, string[] tab2)
        {
            int counter = 0;

            foreach (var item in tab1)
            {
                if (tab2.Contains(item)) counter++;
            }

            return counter;
        }
    }
}
