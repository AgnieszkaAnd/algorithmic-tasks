//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace AlgorithmicTasks.Tasks
//{
//    //Napisz funkcję GetHashCode w klasie Punkt:
//    //public class Punkt
//    //{
//    //    private int? _x;
//    //    private int? _y;
//    //    public override int GetHashCode()
//    //    {
//    //        ....
//    //    }
//    //}
//    public class Task3
//    {
//        public class Punkt
//        {
//            private int? _x;
//            private int? _y;

//            public int? X { get; set; }
//            public int? Y { get; set; }

//            //Guideline: the integer returned by GetHashCode should never change
//            //Guideline: the implementation of GetHashCode must be extremely fast
//            //Guideline: the implementation of GetHashCode must be performant
//            //Guideline: the distribution of hash codes must be “random”

//            //Rule: equal items have equal hashes
//            //Rule: the integer returned by GetHashCode must never change while the object
//            //is contained in a data structure that depends on the hash code remaining stable
//            //Rule: Consumers of GetHashCode cannot rely upon it being stable over time or across appdomains
//            //Rule: GetHashCode must never throw an exception, and must return
//            //public override int GetHashCode()
//            //{
//            //    if (_x != null && _y != null) return ;
//            //}
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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