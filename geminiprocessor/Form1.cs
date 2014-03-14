using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeminiProcessor
{
    public partial class Form1 : Form
    {
        CPU myCPU;
        IPE myIPE;


        public Form1()
        {
            InitializeComponent();
            RunButton.Enabled = false;
            NextInstructionButton.Enabled = false;
            myCPU = new CPU();

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                Stream myStream = null;

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Assembly files (*.s)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        myIPE = new IPE(openFileDialog1.FileName);
                        myIPE.Parse();
                        myCPU.readFile(myIPE.getFileName());
                        RunButton.Enabled = true;
                        NextInstructionButton.Enabled = true;
                        NextInstructionNumLabel.Text = Convert.ToString(myCPU.getNextInstruction(), 2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        RunButton.Enabled = false;
                        NextInstructionButton.Enabled = false;
                    }
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            while (myCPU.isCPUDone() == false)
            {
                clickInstructionButton();
            }
        }

        private void NextInstructionButton_Click(object sender, EventArgs e)
        {
            clickInstructionButton();
        }

        private void clickInstructionButton()
        {
            if (myCPU.isCPUDone() == false)
            {
                myCPU.nextInstruction();
                PCNumLabel.Text = Convert.ToString(myCPU.getProgramCounter());
                ACCNumLabel.Text = Convert.ToString(myCPU.getAccumulator());
                refreshNextInstructionLabel();
                refreshInstructionIndex();
            }
            else
            {
                NextInstructionButton.Enabled = false;
            }
        }

        private void refreshNextInstructionLabel()
        {
            NextInstructionNumLabel.Text = Convert.ToString(myCPU.getNextInstruction(), 2);
        }
        private void refreshInstructionIndex()
        {
            instructionIndexLabel.Text = myCPU.getProgramCounter() + " / " + myCPU.getLengthOfInstructions();
        }

        private void AccLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void OneNumLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
