using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaper
{
    public partial class Form1 : Form
    {
        private Game game; 

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            //game.StartGame();
            
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            game.User.PlayerChoice = Choice.Paper;
            game.Play();
            showGamePlay();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            game.User.PlayerChoice = Choice.Rock;
            game.Play();
            showGamePlay();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            game.User.PlayerChoice = Choice.Scissors;
            game.Play();
            showGamePlay();

        }

        private void showGamePlay()
        {
            textResoult.Text = game.User.PlayerChoice + " / " + game.Computer.PlayerChoice + " / " +
                game.UserStat;
            textUser.Text = game.User.Points.ToString();
            textComputer.Text = game.Computer.Points.ToString();

        }

        private void textResoult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
