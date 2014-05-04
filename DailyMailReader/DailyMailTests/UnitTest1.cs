using DailyMailReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyMailTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void TestMethod1()
        {
            var dailyMail = new DailyMail();

            var headlines = await dailyMail.LatestHeadlines();

            Assert.AreEqual(30, headlines.Count);
        }
    }
}
