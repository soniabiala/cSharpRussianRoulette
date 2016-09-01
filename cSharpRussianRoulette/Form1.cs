using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpRussianRoulette.classes;

namespace cSharpRussianRoulette
{

    public partial class Form1 : Form
    {
        int count, pass = 0;
        int myNum;
        bool isGameOver  = false;
        bool isPassing = false;

        gamePlay myGamePlay = new gamePlay();
        Player mysoundPlayer = new Player();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        public void btnChoice_Click(object sender, EventArgs e)
        {
            mysoundPlayer.soundPlayer(Resource1.spin);
            myNum = myGamePlay.RndNumber();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on the SPIN button to make a selection. Then click on PLAY button to play.If you want to pass to next player click on PASS button. You can only pass TWICE.");
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            count++;
            mysoundPlayer.soundPlayer(Resource1.play);

            if (myNum != count)
            {// You are under the random number
                isGameOver = false;
            }
            else if (myNum == count)
            { //you equal the random number
                mysoundPlayer.soundPlayer(Resource1.lost);
                isGameOver = true;
                panel1.BackgroundImage = Resource1.after;
                
                MessageBox.Show("You loose! Good luck next time.");
            }
            
        }

        

        private void btnPass_Click(object sender, EventArgs e)
        {
            pass++;
            count++;
            isPassing = true;
            mysoundPlayer.soundPlayer(Resource1.error);
            if (myNum == count)
            {  mysoundPlayer.soundPlayer(Resource1.fireworks);
                MessageBox.Show("You win! Congrats.");
            }
           
          else  if (pass >= 2)
            { 
                //allow to pass only 2 times
                MessageBox.Show("You can pass 2 times only!");
                btnPass.Enabled = false;
                isPassing = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {   //reset all
            panel1.BackgroundImage = Resource1.before;
            count = 0;
            pass = 0;
            isGameOver = false;
            btnPass.Enabled = true;
        }
    }


}

