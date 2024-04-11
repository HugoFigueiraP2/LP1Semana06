using System;

namespace PlayerStats
{
    public class Player
    {
        float highScore;
        int playedGames;
        int wonGames;
        public string Name {get;}

        public float HighScore
        {
            get {return highScore;}

            set
            {
                if (value > highScore)
                {
                    highScore = value;
                    Console.WriteLine("New HighScore!!!");

                }
                else
                {
                    Console.WriteLine("HighScore wanst change...");

                }
            }
        }

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }
                else
                {
                    return (float)wonGames / playedGames;
                }
            }
        }

        public void PlayGame
        

    }
}
