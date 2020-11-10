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
            Random r = new Random();
            int computerChoice = r.Next(1,3);

            if (computerChoice == 1)
            {
                (grpPlayerChoice = radRock);

            }








            if (grpPlayerChoice = radRock){
                msg1.Text = ("");
            }

        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            int radRock = 1;
            imgPlayer.Image = Properties.Resources.Rock;
            msg1.Text = "You chose rock.";
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            int radPaper = 2;
            imgPlayer.Image = Properties.Resources.Paper;
            msg1.Text = "You chose paper.";
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            int radScissors = 3;
            imgPlayer.Image = Properties.Resources.Scissors;
            msg1.Text = "You chose scissors";
        }

        private void grpPlayerChoice_Enter(object sender, EventArgs e)
        {

        }
    }
}
