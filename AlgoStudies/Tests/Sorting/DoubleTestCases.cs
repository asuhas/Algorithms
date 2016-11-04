using System.Collections;
using NUnit.Framework;

namespace AlgoStudies.Tests.Sorting
{
    public class DoubleTestCases
    {
     public  static  IEnumerable Data
        {
            get
            {
                yield return new TestCaseData(new [] {3,4,9,2,1}).Returns(new [] {1,2,3,4,9});
                yield return new TestCaseData(new[] { 13, 54, 9, 2, 10000 }).Returns(new[] { 2, 9, 13, 54, 10000 });
                //yield return new TestCaseData(new[] { 3, 4, 9, 2, 1 }).Returns(new[] { 1, 2, 3, 4, 9 });
                //yield return new TestCaseData(new[] { 3, 4, 9, 2, 1 }).Returns(new[] { 1, 2, 3, 4, 9 });
                //yield return new TestCaseData(new[] { 3, 4, 9, 2, 1 }).Returns(new[] { 1, 2, 3, 4, 9 });
                //yield return new TestCaseData(new[] { 3, 4, 9, 2, 1 }).Returns(new[] { 1, 2, 3, 4, 9 });
            }

        }
    }
}