using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListHelperLib;

namespace LinkedListHelperLibTest
{
    [TestClass]
    public class RemovingRepeatingNodes
    {
        [TestMethod]
        public void ShouldRemoveValuesAppearingMoreThanTwice()
        {
            // Arrange
            DynamicList<char> shoppingList = new DynamicList<char>();
            shoppingList.Add('E');
            shoppingList.Add('B'); //Empty List
            shoppingList.Add('E');
            shoppingList.Add('E');
            shoppingList.Add('B');
            shoppingList.Add('A');
            shoppingList.Add('B');

            //Act
            LinkedListHelpers.RemoveNodesRepeatingMoreThanTwoTimes(shoppingList);

            //Assert
            int expectedCount = 5;
            Assert.AreEqual(expectedCount, shoppingList.Count);

            //Assert individual values
            Assert.AreEqual(shoppingList[0], 'E');
            Assert.AreEqual(shoppingList[1], 'B');
            Assert.AreEqual(shoppingList[2], 'E');
            Assert.AreEqual(shoppingList[3], 'B');
            Assert.AreEqual(shoppingList[4], 'A');
        }
    }
}
