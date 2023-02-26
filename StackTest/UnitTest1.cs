using System.Drawing;
using Stack;

namespace StackTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmptyTest_false()
        {
            //arrange
            MyStack myStack = new MyStack(2);

            //act
            myStack.push(15);
            myStack.isEmpty();

            //assert
            Assert.IsFalse(myStack.isEmpty());
        }

        [TestMethod]
        public void IsEmptyTest_true()
        {
            //arrange
            MyStack myStack = new MyStack(2);

            //act
            myStack.push(15);
            myStack.push(57);
            myStack.isEmpty();

            //assert
            Assert.IsFalse(myStack.isEmpty());
        }

        [TestMethod]
        public void PopTest_true()
        {
            //arrange
            MyStack myStack = new MyStack(2);

            //act
            myStack.push(15);
            myStack.push(57);

            //assert
            Assert.AreEqual(myStack.Pop(), 57);
        }

        [TestMethod]
        public void SwapTest_true()
        {
            //arrange
            MyStack myStack = new MyStack(8);

            //act
            myStack.push(15);
            myStack.push(57);
            myStack.push(75);
            myStack.SwappXY();

            //assert
            Assert.AreEqual(myStack.Pop(), 57);
        }

        [TestMethod]
        public void ClearTest_true()
        {
            //arrange
            MyStack myStack = new MyStack(8);

            //act
            myStack.push(15);
            myStack.push(57);
            myStack.push(75);
            myStack.Clear();

            //assert
            Assert.IsTrue(myStack.isEmpty());
        }

        [TestMethod]
        public void IsFullTest_false()
        {
            //arrange
            MyStack myStack = new MyStack(4);

            //act
            myStack.push(15);
            myStack.push(57);
            myStack.push(75);

            //assert
            Assert.IsFalse(myStack.isFull());
        }

        [TestMethod]
        public void IsFullTest_true()
        {
            //arrange
            MyStack myStack = new MyStack(4);

            //act
            myStack.push(15);
            myStack.push(57);
            myStack.push(75);
            myStack.push(84);

            //assert
            Assert.IsTrue(myStack.isFull());
        }
    }
}