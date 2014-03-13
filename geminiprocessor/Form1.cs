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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        RunButton.Enabled = false;
                    }
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, int> k in myIPE.binaries)
            {
                myCPU.nextInstruction();
            }
        }

        private void NextInstructionButton_Click(object sender, EventArgs e)
        {
            myCPU.nextInstruction();
        }

        public void CPU_Done()
        {
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

    }
}
