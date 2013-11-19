using System;
using System.Linq;
using NUnit.Framework;
using TennisKata;

namespace TestTenniskata.Acceptance
{
    [TestFixture]
    public class GivenPlayerOneScores
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }


        [Test]
        public void WhenHeHasZeroPoints_ThenHeShouldGetFifteenPoints() {
            _tennisGame.PlayerOneScore = 0;

            _tennisGame.PlayerOneScores();

            Assert.AreEqual(15, _tennisGame.PlayerOneScore);
        }

        [Test]
        public void WhenHeHasFifteenPoints_ThenHeShouldGetThirtyPoints()
        {
            _tennisGame.PlayerOneScore = 15;

            _tennisGame.PlayerOneScores();

            Assert.AreEqual(30, _tennisGame.PlayerOneScore);
        }

        [Test]
        public void WhenHeHasThirtyPoints_ThenHeShouldGetFourtyPoints()
        {
            _tennisGame.PlayerOneScore = 30;

            _tennisGame.PlayerOneScores();

            Assert.AreEqual(40, _tennisGame.PlayerOneScore);
        }
    }
}
