using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBubbleSort;

namespace BubbleSortTests
{
    [TestClass]
    public class ClassLibraryBubbleTest
    {
        [TestMethod]
        public void TestMethodSortAscending()
        {
            // Arrange
            int[] array = new int[]{ 0, 2, 5, 9, 10 };
            string[] expected = new string[] { "ZeRo", "two", "FIVE", "NINE", "10" };
            BubbleSortCollectionSorter bubbleSortCollectionSorter = new BubbleSortCollectionSorter();
            // Act
            bubbleSortCollectionSorter.SortAscending(array);

            // Assert
           
            Assert.AreEqual(expected, array,"Array not valid");
        }
        [TestMethod]
        public void TestMethodSortDescending()
        {
            // Arrange
            int[] array = new int[] { 10, 9, 5, 2, 0 };
            string[] expected = new string[] { "10", "NINE", "FIVE", "two", "ZeRo" };
            BubbleSortCollectionSorter bubbleSortCollectionSorter = new BubbleSortCollectionSorter();
            // Act
            bubbleSortCollectionSorter.SortDescending(array);

            // Assert

            Assert.AreEqual(expected, array, "Array not valid");
        }
    }
}
