using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeranClassLibrary.Test1
{
    [TestClass]
    public class LeranClassLibraryTest1
    {
        [TestMethod]
        public void TimeInSeconds()
        {
            //arrage
            int seconds = 3600;
            int expected = 1;

            //act
            LearnClass test = new LearnClass();
            test.AddSeconds(seconds);
            int actual = test.GetFullTime()[0];


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
