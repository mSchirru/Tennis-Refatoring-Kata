namespace Tennis
{
    public class TennisGame : ITennisGame
    {

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public TennisGame(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public void WonPoint(Player player)
        {
            if (player.name == "player1")
                player.score += 1;
            else
                player.score += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (Player1.score == Player2.score)
            {
                switch (Player1.score)
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
            else if (Player1.score >= 4 || Player2.score >= 4)
            {
                var minusResult = Player1.score - Player2.score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = Player1.score;
                    else { score += "-"; tempScore = Player2.score; }
                    switch (tempScore)
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
            }
            return score;
        }
    }
}


