using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AlgoStudies
{
    public class SelectionSort:ISort
    {
        public IList<T> Sort<T>(IList<T> input) where T : IComparable<T>
        {
            for (int i = 0; i < input.Count() ; i++)
            {
                T key = input[i];
                for (int j = i + 1; j < input.Count() ; j++)
                {
                    if (key.CompareTo(input[j]) > 0)
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
}
