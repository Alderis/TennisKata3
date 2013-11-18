using System;
using System.Linq;
using NUnit.Framework;
using TennisKata;

namespace TestTenniskata.Acceptance
{
    [TestFixture]
    public class GivenPlayerOneScores
    {
        [Test]
        public void WhenHeHasZeroPoints_ThenHeShouldGetFifteenPoints() {
            var tennisGame = new TennisGame();
            tennisGame.PlayerOneScore = 0;

            tennisGame.PlayerOneScores();

            Assert.AreEqual(15, tennisGame.PlayerOneScore);
        }

        [Test]
        public void WhenHeHasFifteenPoints_ThenHeShouldGetThirtyPoints()
        {
            var tennisGame = new TennisGame();
            tennisGame.PlayerOneScore = 15;

            tennisGame.PlayerOneScores();

            Assert.AreEqual(30, tennisGame.PlayerOneScore);
        }

        [Test]
        public void WhenHeHasThirtyPoints_ThenHeShouldGetFourtyPoints()
        {
            var tennisGame = new TennisGame();
            tennisGame.PlayerOneScore = 30;

            tennisGame.PlayerOneScores();

            Assert.AreEqual(40, tennisGame.PlayerOneScore);
        }
    }
}
