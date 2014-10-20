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
        bool cpuDone;
        int delayMax;
        int delays;

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
                        myIPE.Parse();
                        myCPU = new CPU(myIPE.getFileName());
                        cpuDone = false;
                        progressBar1.Maximum = myCPU.getLengthOfInstructions() + 2;
                        progressBar1.Value = 0;
                        delayProgressBar.Value = 0;
                        delays = 0;
                        refresh();
                        RunButton.Enabled = true;
                        NextInstructionButton.Enabled = true;

                        myCPU.barrierDone += myCPU_barrierDone;
                        myCPU.programDone += myCPU_programDone;
                        myCPU.PCIncremented += myCPU_PCIncremented;
                        myCPU.delayCycle += myCPU_delayCycle;
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

        void myCPU_delayCycle(object sender, DelayCycleArgs args)
        { 
            MethodInvoker method = delegate
            {
                delayMax = args.delayAmount;
                delayProgressBar.Maximum = args.delayAmount;
                delayProgressBar.Increment(1);
                delays++;
                nopCountNumLabel.Text = delays.ToString();
            };

            //copy and paste this for all the events
            if (this.InvokeRequired)
            {
                this.Invoke(method);
            }
            else
            {
                method.Invoke();
            }
        }

        void myCPU_PCIncremented(object sender, PCIncrementEventArgs args)
        {
            MethodInvoker method = delegate
            {
                PCNumLabel.Text = args.PC.ToString();
                instructionIndexLabel.Text = args.PC.ToString() + " / " + myCPU.getLengthOfInstructions();

            };

            //copy and paste this for all the events
            if (this.InvokeRequired)
            {
                this.Invoke(method);
            }
            else
            {
                method.Invoke();
            }
        }

        void myCPU_programDone(object sender, EventArgs args)
        {
            MethodInvoker method = delegate
            {
                this.NextInstructionButton.Enabled = false;
                this.RunButton.Enabled = false;
                cpuDone = true;
                HitsNumLabel.Text = Convert.ToString(myCPU.getHits());
                MissesNumLabel.Text = Convert.ToString(myCPU.getMisses());
                Console.WriteLine("PROGRAM DONE");
            };

            //copy and paste this for all the events
            if (this.InvokeRequired)
            {
                this.Invoke(method);
            }
            else
            {
                method.Invoke();
            }
        }

        private void myCPU_barrierDone(object sender, GeminiEventArgs args)
        {
            MethodInvoker method = delegate
            {
                this.PCNumLabel.Text = args.PC.ToString();
                this.IRNumLabel.Text = args.IR.ToString();
                this.ACCNumLabel.Text = args.ACC.ToString();
                instructionIndexLabel.Text = args.PC.ToString() + " / " + myCPU.getLengthOfInstructions();
                if (args.isDelay == false)
                {
                    progressBar1.Increment(1);

                    if (delayProgressBar.Value >= delayMax)
                    {
                        delayProgressBar.Value = 0;
                    }
                }
                Console.WriteLine("--- BARRIER ---");
            };

            //copy and paste this for all the events
            if (this.InvokeRequired)
            {
                this.Invoke(method);
            }
            else
            {
                method.Invoke();
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            while (cpuDone == false)
            {
                if (cpuDone) break;
                clickInstructionButton();
            }
            RunButton.Enabled = false;
        }

        private void NextInstructionButton_Click(object sender, EventArgs e)
        {
            clickInstructionButton();
        }

        private void clickInstructionButton()
        {
            myCPU.nextInstruction();
        }

        private void refresh()
        {
            HitsNumLabel.Text = Convert.ToString(myCPU.getHits());
            MissesNumLabel.Text = Convert.ToString(myCPU.getMisses());
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

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void delayProgressBar_Click(object sender, EventArgs e)
        {

        }

    }
}
