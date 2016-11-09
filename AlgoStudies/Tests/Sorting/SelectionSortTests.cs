using System.Linq;
using NUnit.Framework;

namespace AlgoStudies.Tests.Sorting
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test, TestCaseSource(typeof(DoubleTestCases), nameof(DoubleTestCases.Data))]
        public static int [] TesSelectionSort(int[] input)
        {
            var sorter = new SelectionSortMine();
            return sorter.Sort(input.ToList()).ToArray();
        }

        [Test, TestCaseSource(typeof(DoubleTestCases), nameof(DoubleTestCases.Data))]
        public static int[] TesSelectionSortTheirs(int[] input)
        {
            var sorter = new SelectionSortTheirs();
            return sorter.Sort(input.ToList()).ToArray();
        }


    }
}