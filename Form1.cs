using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors____WinForm____Part_6._5
{
    public partial class Form1 : Form

    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerChoice = r.Next(1,4);

            label1.Text = computerChoice + "";

            //TIES//

            if (computerChoice == 1)
            {
                msg1.Text = "The computer chose rock!";
                if (radRock.Checked)
                    msg1.Text += " It is a tie.";
            }

            else if (computerChoice == 2)
            {
                msg1.Text = "The computer chose paper!";
                if (radPaper.Checked) 
                    msg1.Text += " It is a tie.";
            }

            else if (computerChoice == 3)
            {
                msg1.Text = "The computer chose scissors!";
                if (radScissors.Checked)
                    msg1.Text += " It is a tie.";
            }

            //USER WINS//

            if (computerChoice == 1)
            {
                if (radPaper.Checked) 
                    msg1.Text += " You have won!";
            }

            else if (computerChoice == 2)
            {
                if (radScissors.Checked) 
                    msg1.Text += " You have won!";
            }

            else if (computerChoice == 3)
            {
                if (radRock.Checked)
                    msg1.Text += " You have won!";
            }

            //COMPUTER WINS//

            if (computerChoice == 1)
            {
                if (radScissors.Checked) 
                    msg1.Text += " The computer has won!";
            }

            else if (computerChoice == 2)
            {
                if (radRock.Checked) 
                    msg1.Text += " The computer has won!";
            }

            else if (computerChoice == 3)
            {
                if (radPaper.Checked)
                    msg1.Text += " The computer has won!";
            }
        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            int radRock = 1;
            imgPlayer.Image = Properties.Resources.Rock;
            msg1.Text = "You chose rock. Submit to confirm your selection.";
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            int radPaper = 2;
            imgPlayer.Image = Properties.Resources.Paper;
            msg1.Text = "You chose paper. Submit to confirm your selection.";
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            int radScissors = 3;
            imgPlayer.Image = Properties.Resources.Scissors;
            msg1.Text = "You chose scissors. Submit to confirm your selection.";
        }

        private void grpPlayerChoice_Enter(object sender, EventArgs e)
        {

        }
    }
}
