using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Utils;

namespace ConsoleApp1.Utils.Tests
{
    [TestClass()]
    public class CopyHelperTests
    {
        public class TestDataA
        {
            public string AAA { get; set; }
        }

        public class TestDataB
        {
            public List<TestDataA> TestDataAList { get; set; } = new();
        }

        [TestMethod()]
        public void DeepCopyTest1()
        {
            var testData1 = new TestDataA()
            {
                AAA = "aaa"
            };

            var testData2 = testData1.DeepCopy();

            testData1.AAA = "bbb";

            Assert.AreEqual(testData2.AAA, "aaa");
        }

        [TestMethod()]
        public void DeepCopyTest2()
        {
            var testData1 = new TestDataA()
            {
                AAA = "あ値"
            };

            var testData2 = testData1.DeepCopy();

            testData1.AAA = "bbb";

            Assert.AreEqual(testData2.AAA, "あ値");
        }

        [TestMethod()]
        public void DeepCopyTest3()
        {
            var testDataB = new TestDataB();
            testDataB.TestDataAList.Add(new TestDataA() { AAA = "あ" });
            testDataB.TestDataAList.Add(new TestDataA() { AAA = "い" });

            var testDataB2 = testDataB.DeepCopy();

            testDataB.TestDataAList[0].AAA = "b";

            Assert.AreEqual(testDataB2.TestDataAList[0].AAA, "あ");
        }

        [TestMethod()]
        public void DeepCopyTest4()
        {
            var testDataAList = new List<TestDataA>();
            testDataAList.Add(new TestDataA() { AAA = "あ" });
            testDataAList.Add(new TestDataA() { AAA = "い" });

            var testDataAList2 = testDataAList.DeepCopy();

            testDataAList[0].AAA = "b";

            Assert.AreEqual(testDataAList2[0].AAA, "あ");
        }

    }
}