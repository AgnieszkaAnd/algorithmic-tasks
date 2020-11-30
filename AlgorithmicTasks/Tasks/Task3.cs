using System;

namespace AlgorithmicTasks.Tasks
{
    public class Punkt
    {
        private int? _x;
        private int? _y;

        public int? X
        {
            set => _x = value;
        }

        public int? Y
        {
            set => _y = value;
        }

        /// <summary>
        /// Customowa implementacja metody GetHashCode, zaimplementowana zgodnie z poniższymi zasadami:
        ///  1. Porównujemy klasy po wartościach properties x i y; instancje z takimi samymi propercjami mają taki sam HashCode
        ///  2. GetHashCode zawsze zwraca wartość i nie wyrzuca exception
        ///  3. Implementacja powinna być szybka i rozłożona w sposób losowy
        /// </summary>
        /// <returns>Hashcode dla instancji klasy Punkt w typie integer</returns>
        public override int GetHashCode()
        {
            int temp;

            if (_x != null && _y != null)
            {
                var rand = new Random((int)(_x * _y));
                temp = (int) (rand.Next() * _x ^ _y);
            }
            else if (_x != null)
            {
                var rand = new Random((int)_x);
                temp = (int) (rand.Next() * _x);
            }
            else if (_y != null)
            {
                var rand = new Random((int)_y);
                temp = (int)(rand.Next() * _y);
            } else
            {
                // constant seed for both null fields values (_x and _y)
                var rand = new Random(1);
                temp = (int)(rand.Next());
            }
            
            return temp;
        }
    }
}