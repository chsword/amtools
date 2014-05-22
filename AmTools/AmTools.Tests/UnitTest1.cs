using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var p = 2;
            var ret = MyClass.A(p);
            //Assert.AreEqual(3, ret);
            Console.WriteLine(ret);
        }
    }
    class MyClass
    {
        public static int A(int a) { return a +2; }

    }
}
