//Matthew Wuttke
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using System.Resources;
using System.Media;
using System.Diagnostics;

namespace HomerGUI
{
    public partial class frmMain : Form
    {
        const int ONE = 1;
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        
        Homer thelogic;
        string Choice = "";  //holds the string of what the user clicked on.

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            DisableItems();
            thelogic = new Homer();
            
            //builds the current game state
            DisplayHomer();
            DisplayNorthBank();
            DisplaySouthBank();

            Sound_Effects(ONE);             //plays a sound from the sound effect method
        }       

        private void pbMaggieN_Click(object sender, EventArgs e)
        {
            Choice = "Maggie";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }

        private void pbPoisonN_Click(object sender, EventArgs e)
        {
            Choice = "Poison";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }

        private void pbDogN_Click(object sender, EventArgs e)
        {
            Choice = "Dog";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }

        private void pbMaggieS_Click(object sender, EventArgs e)
        {
            Choice = "Maggie";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }

        private void pbPoisonS_Click(object sender, EventArgs e)
        {
            Choice = "Poison";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }

        private void pbDogS_Click(object sender, EventArgs e)
        {
            Choice = "Dog";

            thelogic.Move(Choice);  //moves the choice          
            DisableItems();         //Disables all the items on the screen
            DisplayHomer();
            DisplaySouthBank();
            DisplayNorthBank();
            GameOverCheck();
        }
        private void pbHomerS_Click(object sender, EventArgs e)
        {
            thelogic.Move("");      //Moves Homer to other bank
            DisplayHomer();
            GameOverCheck();
        }

        private void pbHomerN_Click(object sender, EventArgs e)
        {
            thelogic.Move("");      //Moves Homer to other bank
            DisplayHomer();
            GameOverCheck();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain_Load(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sound_Effects(TWO); //plays a sound clip from the sound effect method
            AboutBox1 theform = new AboutBox1();  //create instance of form.
            theform.ShowDialog();
            Sound_Effects(ONE);//plays a sound clip from the sound effect method
        }       

        //methods
        private void DisableItems()
        {
            lblDescription.Visible = false;
            lblNorth.Visible = false;
            lblSouth.Visible = false;
            pbHomerN.Visible = false;
            pbDogN.Visible = false;
            pbMaggieN.Visible = false;
            pbPoisonN.Visible = false;
            pbHomerS.Visible = false;
            pbDogS.Visible = false;
            pbMaggieS.Visible = false;
            pbPoisonS.Visible = false;
            pbLose.Visible = false;
            pbWin.Visible = false;
        }
        private void DisplayHomer()
        {
            if (thelogic.Location == Direction.North) //Homer is at North
            {
                pbHomerN.Visible = true;
                pbHomerS.Visible = false;
            }
            else                                     //Homer is at South
            {
                pbHomerS.Visible = true;
                pbHomerN.Visible = false;
            }
        }
        private void DisplayNorthBank()
        {
            ArrayList north = thelogic.North;  //get north bank after move...
            DisplayBankLabels();
            
            //check to see what is on the North Bank. If so, make it visible
            if (north.Contains("Maggie"))
            {
                pbMaggieN.Visible = true;
            }
            if (north.Contains("Dog"))
            {
                pbDogN.Visible = true;
            }
            if (north.Contains("Poison"))
            {
                pbPoisonN.Visible = true;
            }
        }

        private void DisplaySouthBank()
        {
            DisplayBankLabels();
            ArrayList south = thelogic.South;  //get south bank after move...
            
            //check to see what is on the South Bank. If so, make it visible
            if (south.Contains("Maggie"))
            {
                pbMaggieS.Visible = true;
            }
            if (south.Contains("Dog"))
            {
                pbDogS.Visible = true;
            }
            if (south.Contains("Poison"))
            {
                pbPoisonS.Visible = true;
            }
        }
        private void DisplayBankLabels()
        {
            lblNorth.Visible = true;
            lblSouth.Visible = true;
        }
        private void GameOverCheck()
        {
            //check for game over
            if (thelogic.GameOver() == true)
            {
                DisableItems();
                lblDescription.Visible = true;

                //if game did end, display label with reason, a picturebox, and a sound effect.
                if (thelogic.MaggieAtePoison() == true) //if game ended on Maggie eating poison
                {
                    
                    pbLose.Visible = true;
                    lblDescription.Text = "\nGAMEOVER!!\n\nYou lose - Maggie got a hold of poison";                 
                    Sound_Effects(THREE);
                }
                if (thelogic.DogAttackedMaggie() == true)//if game ended on Dog attacked Maggie
                {
                    pbLose.Visible = true;
                    lblDescription.Text = "\nGAMEOVER!!\n\nYou lose -  Dog attacked Maggie";
                    Sound_Effects(THREE);
                    
                }
                if (thelogic.HomerAlone() == true)
                {
                    pbLose.Visible = true;
                    lblDescription.Text = "\nGAMEOVER!!\n\nYou lose -  Maggie ate the poison and\n                  Dog attacked Maggie";
                    Sound_Effects(THREE);
                }
                if (thelogic.DetermineWin() == true)//if game ended on Player won
                {
                    pbWin.Visible = true;
                    lblDescription.Text = "\nGAMEOVER!!\n\nYou win -  Everyone has made it to\n                 the South Bank";
                    Sound_Effects(FOUR);
                }                
            }

        }

        private void Sound_Effects(int soundNumber)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            SoundPlayer sp;
            //checks to see which sound is wanted and plays it.
            switch (soundNumber)
            {
                case 1:
                    {
                        sp = new SoundPlayer(myAssembly.GetManifestResourceStream("HomerGUI.river-3.wav"));
                        sp.PlayLooping();
                        break;
                    }
                case 2:
                    {
                        sp = new SoundPlayer(myAssembly.GetManifestResourceStream("HomerGUI.cmputers.wav"));
                        sp.Play();
                        break;
                    }
                case 3:
                    {
                        sp = new SoundPlayer(myAssembly.GetManifestResourceStream("HomerGUI.whyyou.wav"));
                        sp.Play();
                        break;
                    }
                case 4:
                    {
                        sp = new SoundPlayer(myAssembly.GetManifestResourceStream("HomerGUI.smrt.wav"));
                        sp.Play();                       
                        break;
                    }
                default:
                    { break; }
            }
        }    
    }
}
