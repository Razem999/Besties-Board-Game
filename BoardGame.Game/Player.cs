namespace BoardGame.Game
{
    public class Player
    {
        public string playerId { get; set; }
        public string playerUsername { get; set; }
        public string playerType { get; set; }
        public int totalScore { get; set; }

        public Player(string playerId, string playerUsername, string playerType)
        {
            this.playerId = playerId;
            this.playerUsername = playerUsername;
            this.playerType = playerType;
            this.totalScore = 0;
        }

        public void updateUsername(string newUsername)
        {
            this.playerUsername = newUsername;
        }

        public void addScore(int score)
        {
            this.totalScore += score;
        }

        public void deductScore(int score)
        {
            int temp = this.totalScore;
            temp -= score;
            if (temp < 0)
            {
                this.totalScore = 0;
            } else
            {
                this.totalScore = temp;
            }
        }

        public override string ToString() {
            return $"PlayerId: {playerId}, PlayerUsername: {playerUsername}, PlayerType: {playerType}, PlayerScore: {totalScore}";
        }


    }
}
