using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using BinaryFind;
namespace BinaryFindTests
{
    [TestClass]
    public class BinaryFindTests
    {
        [TestMethod]
        public void SearchTest()
        {
            List<int> numbersTo15000 = Enumerable.Range(0, 15001).ToList();
            foreach (int n in numbersTo15000)
            {
                int? index = Binary.Find(numbersTo15000, n);
                if (index == null || numbersTo15000[(int)index] != n)
                    Assert.Fail();
            }
            Assert.IsTrue(true); 
        }
    }
}
