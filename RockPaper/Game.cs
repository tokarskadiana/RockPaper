using System;

namespace RockPaper
{
    enum Choice { Rock, Paper, Scissors }

    enum GameStat { Win, Loose, Draw }

    class Game
    {
        public Player User { set; get; }
        public Player Computer { set; get; }
        public GameStat UserStat { set; get; }

        public Game()
        {
            this.User = new Player();
            this.Computer = new Player();
        }
        
        public void Play()
        {
            this.Computer.PlayerChoice = RandomChoice();
            this.UserStat = CompareChoices();
        }

        private Choice RandomChoice()
        {
            Array values = Enum.GetValues(typeof(Choice));
            return (Choice)values.GetValue(new Random().Next(values.Length));
        }

        private GameStat CompareChoices()
        {
            if ((User.PlayerChoice == Choice.Rock && Computer.PlayerChoice == Choice.Scissors) ||
                (User.PlayerChoice == Choice.Scissors && Computer.PlayerChoice == Choice.Paper) ||
                (User.PlayerChoice == Choice.Paper && Computer.PlayerChoice == Choice.Rock ))
            {
                User.Points += 1;
                return GameStat.Win;
            }
            else if (User.PlayerChoice == Computer.PlayerChoice)
            {
                return GameStat.Draw;
            }

            Computer.Points += 1;
            return GameStat.Loose;
        }
    }
}
