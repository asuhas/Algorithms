using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AlgoStudies
{
    public class SelectionSortMine:ISort
    {
        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            for (int i = 0; i < input.Count() ; i++)                // c1 n
            {
                T key = input[i];                                   // 0  n
                for (int j = i + 1; j < input.Count() ; j++)        //Sum from 2 to n ( c2 n-1)
                {
                    if (key.CompareTo(input[j]) > 0)                // c2 n-1
                    {

                        T interim = key;
                        input[i] = key = input[j];
                        input[j] = interim;
                    }
                }
            }

            return input;
        }
    }

    public class SelectionSortTheirs : ISort
    {
        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            for (int j = 0; j < input.Count(); j++)
            {
                int index = j;
                for (int i = j+1; i < input.Count(); i++)
                {
                    if (input[i].CompareTo(input[index])<0)
                    {
                        index = i;
                    }
                }
                T interim = input[j];
                input[j] = input[index];
                input[index] = interim;
            }
            return input;
        }
    }
}
