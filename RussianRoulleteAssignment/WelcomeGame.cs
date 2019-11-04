using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulleteAssignment
{
    public partial class WelcomeGame : Form
    {
        VariableClass variableClass = new VariableClass();
        Random r = new Random();
        public WelcomeGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RussianRoulleteAssignment.Properties.Resources.gunloading;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteAssignment.Properties.Resources.Loadings);//adding the sound
            soundPlayer.Play();//this sound playing function
            button1.Enabled = false;//Here disable the button of load
            variableClass.LoadGun = 1;//set the value of load gun variable is 1.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RussianRoulleteAssignment.Properties.Resources.spinn;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteAssignment.Properties.Resources.Loadings);//adding the sound
            soundPlayer.Play();//this sound playing function
            button2.Enabled = false;//Here disable the button of load
            variableClass.SpinGun = r.Next(1,6);//set the value of spin gun as randomly number b\w 1 to 6.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RussianRoulleteAssignment.Properties.Resources.gunimageshot;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteAssignment.Properties.Resources.Shot);//adding the sound
            soundPlayer.Play();//this sound playing function
            button2.Enabled = false;//Here disable the button of load
            if (variableClass.totalChances > 0 && variableClass.SpinGun == 1)
            {
                MessageBox.Show("Shoot You loose");
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (variableClass.totalChances > 0 && variableClass.SpinGun != 1)
            {
                MessageBox.Show("Blank Fire");
                variableClass.totalChances = variableClass.totalChances - 1;//minus one from total
                variableClass.SpinGun = variableClass.LoopShot(variableClass.SpinGun);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RussianRoulleteAssignment.Properties.Resources.gunimageshot;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteAssignment.Properties.Resources.Shot);//adding the sound
            soundPlayer.Play();//this sound playing function
            button2.Enabled = false;//Here disable the button of load
            if (variableClass.totalChances > 0 && variableClass.SpinGun == 1 && variableClass.tryTheGun == 2)
            {
                MessageBox.Show("your score is 200");
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (variableClass.totalChances > 0 && variableClass.SpinGun == 1 && variableClass.tryTheGun == 1)
            {
                MessageBox.Show("you win you score is 100");
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (variableClass.totalChances > 0 && variableClass.SpinGun != 1)
            {
                MessageBox.Show("Blank Fire");
                variableClass.totalChances = variableClass.totalChances - 1;//minus one from total
                variableClass.SpinGun = variableClass.LoopShot(variableClass.SpinGun);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeGame welcomeGame = new WelcomeGame();
            welcomeGame.Show();
            this.Hide();
        }
    }
}
