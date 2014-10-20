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

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                //Stream myStream = null;

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Assembly files (*.s)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        myIPE = new IPE(openFileDialog1.FileName);
                        myCPU = new CPU();

                        myIPE.Parse();
                        myCPU.readFile(myIPE.getFileName());
                        refresh();
                        RunButton.Enabled = true;
                        NextInstructionButton.Enabled = true;
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
            HitsNumLabel.Text = Convert.ToString(myCPU.getHits());
            MissesNumLabel.Text = Convert.ToString(myCPU.getMisses());
            RunButton.Enabled = false;
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
                refresh();
            }
            else
            {
                NextInstructionButton.Enabled = false;
                HitsNumLabel.Text = Convert.ToString(myCPU.getHits());
                MissesNumLabel.Text = Convert.ToString(myCPU.getMisses());
            }
        }

        private void refresh()
        {
            NextInstructionNumLabel.Text = Convert.ToString(myCPU.getNextInstruction(), 2);
            CurrentInstructionNumLabel.Text = Convert.ToString(myCPU.getCurrentInstruction(), 2);
            PCNumLabel.Text = Convert.ToString(myCPU.getProgramCounter());
            ACCNumLabel.Text = Convert.ToString(myCPU.getAccumulator());
            instructionIndexLabel.Text = myCPU.getProgramCounter() + " / " + myCPU.getLengthOfInstructions();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
