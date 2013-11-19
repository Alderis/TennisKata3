using System;
using System.Linq;
using NUnit.Framework;
using TennisKata;

namespace TestTenniskata.Unit.ScoreCalculatorTests
{
    [TestFixture]
    class ScorePointShould
    {
        [Test]
        public void ReturnFifteenWhenGivenZero()
        {
            var currentPoints = 0;

            var scoreCalculator = new ScoreCalculator();
            var newPoints = scoreCalculator.ScorePoint(currentPoints);

            Assert.AreEqual(15, newPoints);
        }

        [Test]
        public void ReturnThirtyWhenGivenFifteen()
        {
            var currentPoints = 15;

            var scoreCalculator = new ScoreCalculator();
            var newPoints = scoreCalculator.ScorePoint(currentPoints);

            Assert.AreEqual(30, newPoints);
        }
    }
}
