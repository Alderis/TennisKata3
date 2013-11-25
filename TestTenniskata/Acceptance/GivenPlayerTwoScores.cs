using System;
using System.Linq;
using NUnit.Framework;
using TennisKata;

namespace TestTenniskata.Acceptance
{
    [TestFixture]
    public class GivenPlayerTwoScores
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame();
        }


        [Test]
        public void WhenHeHasZeroPoints_ThenHeShouldGetFifteenPoints() {
            _tennisGame.PlayerTwoScore = 0;

            _tennisGame.PlayerTwoScores();

            Assert.AreEqual(15, _tennisGame.PlayerTwoScore);
        }

        [Test]
        public void WhenHeHasFifteenPoints_ThenHeShouldGetThirtyPoints()
        {
            _tennisGame.PlayerTwoScore = 15;

            _tennisGame.PlayerTwoScores();

            Assert.AreEqual(30, _tennisGame.PlayerTwoScore);
        }

        [Test]
        public void WhenHeHasThirtyPoints_ThenHeShouldGetFourtyPoints()
        {
            _tennisGame.PlayerTwoScore = 30;

            _tennisGame.PlayerTwoScores();

            Assert.AreEqual(40, _tennisGame.PlayerTwoScore);
        }
    }
}
