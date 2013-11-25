using System;
using System.Linq;

namespace TennisKata
{
    public class TennisGame
    {
        private ScoreCalculator _scoreCalculator;

        public TennisGame()
        {
            _scoreCalculator = new ScoreCalculator();
        }

        public int PlayerOneScore;
        public int PlayerTwoScore;

        public void PlayerOneScores() {
            PlayerOneScore = _scoreCalculator.ScorePoint(PlayerOneScore);
        }

        public void PlayerTwoScores()
        {
            throw new NotImplementedException();
        }
    }
}
