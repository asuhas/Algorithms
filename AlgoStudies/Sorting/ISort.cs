using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgoStudies
{
    public interface ISort
    {
        IList<T> Sort<T>(IList<T> input) where T : IComparable<T>;
    }
}