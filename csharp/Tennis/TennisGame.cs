namespace Tennis
{
    class TennisGame : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        /**
         * Increase points for given player.
         */
        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score += 1;
            else
                player2Score += 1;
        }

        /**
         * Returns the current game's score.
         * 
         * Code currently considers three cases:
         * 1. Scores are equal
         * 2. We've passed four or more points (deuce hell)
         * 3. Anything else
         */
        public string GetScore()
        {
            string score = "";
            if (player1Score == player2Score)
            {
                score = player1Score switch
                {
                    0 => "Love-All",
                    1 => "Fifteen-All",
                    2 => "Thirty-All",
                    _ => "Deuce",
                };
            }
            else if (player1Score >= 4 || player2Score >= 4)
            {
                // Past the point of deuce and just waiting for someone to win by 2
                var minusResult = player1Score - player2Score;
                if (minusResult == 1) score = $"Advantage {player1Name}";
                else if (minusResult == -1) score = $"Advantage {player2Name}";
                else if (minusResult >= 2) score = $"Win for {player1Name}";
                else score = $"Win for {player2Name}";
            }
            else
            {
                // Return score in player1Score - player2Score format, e.g. 'Love-Thirty'
                score += GetScoreString(player1Score);
                score += "-";
                score += GetScoreString(player2Score);
            }
            return score;
        }

        /**
         * Returns the tennis term for the current 
         * number of points given.
         */
        private string GetScoreString(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => ""
            };
        }
    }
}

