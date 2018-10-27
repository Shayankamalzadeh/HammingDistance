using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HammingUnitTest
{
    [TestClass]
    public class HammingUnitTest
    {
        Hamming.Hamming _haming = new Hamming.Hamming();

        public HammingUnitTest()
        {

        }
        /// <summary>
        /// unit test for check two parameters not null
        /// </summary>
        [TestMethod]
        public void TestNotNullCompare()
        {
            string s1 = null;
            string s2 = null;
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreNotEqual(ex, null);
        }

        /// <summary>
        /// two parameters have same length
        /// </summary>
        [TestMethod]
        public void TestLengthNotEqual()
        {
            string s1 = "1010111";
            string s2 = "110100";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.IsNotNull(ex);
        }

        [TestMethod]
        public void TestNotNullFirst()
        {
            string s1 = "11101";
            string s2 = null;
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
            }
            catch (Exception e)
            {
                ex = e;
            }

            Assert.AreNotEqual(ex, null);
        }
        [TestMethod]
        public void TestNotNullSecond()
        {
            string s1 = null;
            string s2 = "11101";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
            }
            catch (Exception e)
            {
                ex = e;
            }

            Assert.AreNotEqual(ex, null);
        }





        [TestMethod]
        public void TestTwoEqualBinaryStrings()
        {
            string s1 = "0011";
            string s2 = "0011";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 0);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }
        [TestMethod]
        public void TestOneSpaceDistanceBinaryStrings()
        {
            string s1 = "0011";
            string s2 = "0010";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 1);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }


        [TestMethod]
        public void TestTwoSpaceDistanceBinaryStrings()
        {
            string s1 = "0111";
            string s2 = "0010";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 2);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestthreeSpaceDistanceBinaryStrings()
        {
            string s1 = "1111";
            string s2 = "0010";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 3);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestFourSpaceDistanceBinaryStrings()
        {
            string s1 = "1101";
            string s2 = "0010";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 4);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestFiveSpaceDistanceBinaryStrings()
        {
            string s1 = "010100";
            string s2 = "001011";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 5);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestSixSpaceDistanceBinaryStrings()
        {
            string s1 = "011100";
            string s2 = "100011";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 6);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestSevenSpaceDistanceBinaryStrings()
        {
            string s1 = "01110011";
            string s2 = "10001000";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 7);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestEightSpaceDistanceBinaryStrings()
        {
            string s1 = "01110011001";
            string s2 = "10001001111";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 8);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestnineSpaceDistanceBinaryStrings()
        {
            string s1 = "100000000";
            string s2 = "011111111";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 9);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }

        [TestMethod]
        public void TestTeneSpaceDistanceBinaryStrings()
        {
            string s1 = "1000000001";
            string s2 = "0111111110";
            Exception ex = null;
            try
            {
                int result = _haming.HamingSpace(s1, s2);
                Assert.AreEqual(result, 10);
            }
            catch (Exception e)
            {
                ex = e;
            }
            Assert.AreEqual(ex, null);
        }
    }
}
