using System;
using System.Linq;

namespace TennisKata
{
    public class ScoreCalculator
    {
        public int ScorePoint(int currentScore) {
            if(currentScore < 30)
                return currentScore + 15;
            return 40;
        }
    }
}
