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
            var tempScore = 0;
            if (player1Score == player2Score)
            {
                switch (player1Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (player1Score >= 4 || player2Score >= 4)
            {
                // Past the point of deuce and just waiting for someone to win by 2
                var minusResult = player1Score - player2Score;
                if (minusResult == 1) score = "Advantage player1"; // TODO: remove hard-coded 'player1' and 'player2'
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                // Return score in player1Score - player2Score format, e.g. 'Love-Thirty'
                switch (player1Score)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }

                score += "-";

                switch (player2Score)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }
            return score;
        }
    }
}

