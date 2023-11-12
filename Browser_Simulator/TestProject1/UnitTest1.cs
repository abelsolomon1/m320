using NUnit.Framework;
using Browser_Simulator;

namespace TestProject1
{
    [TestFixture]
    public class StringStackTests
    {
        [Test]
        public void Push_Pop_Test()
        {
            StringStack stack = new StringStack(3);

            stack.Push("Wert1");
            stack.Push("Wert2");
            stack.Push("Wert3");

            Assert.AreEqual("Wert3", stack.Pop());
            Assert.AreEqual("Wert2", stack.Pop());
            Assert.AreEqual("Wert1", stack.Pop());
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Swap_Test()
        {
            StringStack stack = new StringStack(3);

            stack.Push("Wert1");
            stack.Push("Wert2");
            stack.Push("Wert3");

            stack.Swap();

            Assert.AreEqual("Wert3", stack.Pop());
            Assert.AreEqual("Wert1", stack.Pop());
            Assert.AreEqual("Wert2", stack.Pop());
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Peak_Test()
        {
            StringStack stack = new StringStack(3);

            stack.Push("Wert1");
            stack.Push("Wert2");
            stack.Push("Wert3");

            Assert.AreEqual("Wert3", stack.Peak());
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Clear_Test()
        {
            StringStack stack = new StringStack(3);

            stack.Push("Wert1");
            stack.Push("Wert2");
            stack.Push("Wert3");

            stack.Clear();

            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void IsEmpty_Test()
        {
            StringStack stack = new StringStack(3);

            Assert.IsTrue(stack.IsEmpty);

            stack.Push("Wert1");

            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Count_Test()
        {
            StringStack stack = new StringStack(3);

            Assert.AreEqual(0, stack.Count);

            stack.Push("Wert1");
            stack.Push("Wert2");

            Assert.AreEqual(2, stack.Count);
        }

        [Test]
        public void IsFull_Test()
        {
            StringStack stack = new StringStack(3);

            Assert.IsFalse(stack.IsFull);

            stack.Push("Wert1");
            stack.Push("Wert2");
        }
    }
}
    
