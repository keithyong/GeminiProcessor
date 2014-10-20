namespace GeminiProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.AccLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.ACCNumLabel = new System.Windows.Forms.Label();
            this.NextInstructionButton = new System.Windows.Forms.Button();
            this.ZeroLabel = new System.Windows.Forms.Label();
            this.ZeroNumLabel = new System.Windows.Forms.Label();
            this.OneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ANumLabel = new System.Windows.Forms.Label();
            this.BNumLabel = new System.Windows.Forms.Label();
            this.PCNumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OneNumLabel = new System.Windows.Forms.Label();
            this.MARNumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MDRNumLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.instructionIndexLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NextInstructionNumLabel = new System.Windows.Forms.Label();
            this.CurrentInstructionNumLabel = new System.Windows.Forms.Label();
            this.currentInstructionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HitsNumLabel = new System.Windows.Forms.Label();
            this.MissesNumLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(18, 282);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AccLabel
            // 
            this.AccLabel.AutoSize = true;
            this.AccLabel.Location = new System.Drawing.Point(16, 59);
            this.AccLabel.Name = "AccLabel";
            this.AccLabel.Size = new System.Drawing.Size(28, 13);
            this.AccLabel.TabIndex = 1;
            this.AccLabel.Text = "ACC";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(98, 282);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ACCNumLabel
            // 
            this.ACCNumLabel.AutoSize = true;
            this.ACCNumLabel.Location = new System.Drawing.Point(50, 59);
            this.ACCNumLabel.Name = "ACCNumLabel";
            this.ACCNumLabel.Size = new System.Drawing.Size(16, 13);
            this.ACCNumLabel.TabIndex = 3;
            this.ACCNumLabel.Text = "---";
            // 
            // NextInstructionButton
            // 
            this.NextInstructionButton.Location = new System.Drawing.Point(19, 12);
            this.NextInstructionButton.Name = "NextInstructionButton";
            this.NextInstructionButton.Size = new System.Drawing.Size(156, 32);
            this.NextInstructionButton.TabIndex = 4;
            this.NextInstructionButton.Text = "Do Current Instruction";
            this.NextInstructionButton.UseVisualStyleBackColor = true;
            this.NextInstructionButton.Click += new System.EventHandler(this.NextInstructionButton_Click);
            // 
            // ZeroLabel
            // 
            this.ZeroLabel.AutoSize = true;
            this.ZeroLabel.Location = new System.Drawing.Point(16, 151);
            this.ZeroLabel.Name = "ZeroLabel";
            this.ZeroLabel.Size = new System.Drawing.Size(29, 13);
            this.ZeroLabel.TabIndex = 5;
            this.ZeroLabel.Text = "Zero";
            // 
            // ZeroNumLabel
            // 
            this.ZeroNumLabel.AutoSize = true;
            this.ZeroNumLabel.Location = new System.Drawing.Point(51, 151);
            this.ZeroNumLabel.Name = "ZeroNumLabel";
            this.ZeroNumLabel.Size = new System.Drawing.Size(13, 13);
            this.ZeroNumLabel.TabIndex = 6;
            this.ZeroNumLabel.Text = "0";
            // 
            // OneLabel
            // 
            this.OneLabel.AutoSize = true;
            this.OneLabel.Location = new System.Drawing.Point(16, 174);
            this.OneLabel.Name = "OneLabel";
            this.OneLabel.Size = new System.Drawing.Size(27, 13);
            this.OneLabel.TabIndex = 7;
            this.OneLabel.Text = "One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // ANumLabel
            // 
            this.ANumLabel.AutoSize = true;
            this.ANumLabel.Location = new System.Drawing.Point(151, 59);
            this.ANumLabel.Name = "ANumLabel";
            this.ANumLabel.Size = new System.Drawing.Size(16, 13);
            this.ANumLabel.TabIndex = 10;
            this.ANumLabel.Text = "---";
            // 
            // BNumLabel
            // 
            this.BNumLabel.AutoSize = true;
            this.BNumLabel.Location = new System.Drawing.Point(151, 82);
            this.BNumLabel.Name = "BNumLabel";
            this.BNumLabel.Size = new System.Drawing.Size(16, 13);
            this.BNumLabel.TabIndex = 11;
            this.BNumLabel.Text = "---";
            // 
            // PCNumLabel
            // 
            this.PCNumLabel.AutoSize = true;
            this.PCNumLabel.Location = new System.Drawing.Point(51, 82);
            this.PCNumLabel.Name = "PCNumLabel";
            this.PCNumLabel.Size = new System.Drawing.Size(16, 13);
            this.PCNumLabel.TabIndex = 13;
            this.PCNumLabel.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PC";
            // 
            // OneNumLabel
            // 
            this.OneNumLabel.AutoSize = true;
            this.OneNumLabel.Location = new System.Drawing.Point(51, 174);
            this.OneNumLabel.Name = "OneNumLabel";
            this.OneNumLabel.Size = new System.Drawing.Size(13, 13);
            this.OneNumLabel.TabIndex = 14;
            this.OneNumLabel.Text = "1";
            // 
            // MARNumLabel
            // 
            this.MARNumLabel.AutoSize = true;
            this.MARNumLabel.Location = new System.Drawing.Point(51, 105);
            this.MARNumLabel.Name = "MARNumLabel";
            this.MARNumLabel.Size = new System.Drawing.Size(16, 13);
            this.MARNumLabel.TabIndex = 16;
            this.MARNumLabel.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "MAR";
            // 
            // MDRNumLabel
            // 
            this.MDRNumLabel.AutoSize = true;
            this.MDRNumLabel.Location = new System.Drawing.Point(52, 128);
            this.MDRNumLabel.Name = "MDRNumLabel";
            this.MDRNumLabel.Size = new System.Drawing.Size(16, 13);
            this.MDRNumLabel.TabIndex = 18;
            this.MDRNumLabel.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "MDR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "TEMP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "IR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "CC";
            // 
            // instructionIndexLabel
            // 
            this.instructionIndexLabel.AutoSize = true;
            this.instructionIndexLabel.Location = new System.Drawing.Point(108, 197);
            this.instructionIndexLabel.Name = "instructionIndexLabel";
            this.instructionIndexLabel.Size = new System.Drawing.Size(33, 13);
            this.instructionIndexLabel.TabIndex = 26;
            this.instructionIndexLabel.Text = "--- / 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Instruction Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Next Instruction";
            // 
            // NextInstructionNumLabel
            // 
            this.NextInstructionNumLabel.AutoSize = true;
            this.NextInstructionNumLabel.Location = new System.Drawing.Point(15, 266);
            this.NextInstructionNumLabel.Name = "NextInstructionNumLabel";
            this.NextInstructionNumLabel.Size = new System.Drawing.Size(64, 13);
            this.NextInstructionNumLabel.TabIndex = 28;
            this.NextInstructionNumLabel.Text = "-------------------";
            // 
            // CurrentInstructionNumLabel
            // 
            this.CurrentInstructionNumLabel.AutoSize = true;
            this.CurrentInstructionNumLabel.Location = new System.Drawing.Point(16, 240);
            this.CurrentInstructionNumLabel.Name = "CurrentInstructionNumLabel";
            this.CurrentInstructionNumLabel.Size = new System.Drawing.Size(64, 13);
            this.CurrentInstructionNumLabel.TabIndex = 30;
            this.CurrentInstructionNumLabel.Text = "-------------------";
            // 
            // currentInstructionLabel
            // 
            this.currentInstructionLabel.AutoSize = true;
            this.currentInstructionLabel.Location = new System.Drawing.Point(16, 225);
            this.currentInstructionLabel.Name = "currentInstructionLabel";
            this.currentInstructionLabel.Size = new System.Drawing.Size(93, 13);
            this.currentInstructionLabel.TabIndex = 29;
            this.currentInstructionLabel.Text = "Current Instruction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HitsNumLabel
            // 
            this.HitsNumLabel.AutoSize = true;
            this.HitsNumLabel.Location = new System.Drawing.Point(247, 59);
            this.HitsNumLabel.Name = "HitsNumLabel";
            this.HitsNumLabel.Size = new System.Drawing.Size(16, 13);
            this.HitsNumLabel.TabIndex = 32;
            this.HitsNumLabel.Text = "---";
            // 
            // MissesNumLabel
            // 
            this.MissesNumLabel.AutoSize = true;
            this.MissesNumLabel.Location = new System.Drawing.Point(261, 82);
            this.MissesNumLabel.Name = "MissesNumLabel";
            this.MissesNumLabel.Size = new System.Drawing.Size(16, 13);
            this.MissesNumLabel.TabIndex = 34;
            this.MissesNumLabel.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(216, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Misses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 335);
            this.Controls.Add(this.MissesNumLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.HitsNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentInstructionNumLabel);
            this.Controls.Add(this.currentInstructionLabel);
            this.Controls.Add(this.NextInstructionNumLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.instructionIndexLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MDRNumLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MARNumLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OneNumLabel);
            this.Controls.Add(this.PCNumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BNumLabel);
            this.Controls.Add(this.ANumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OneLabel);
            this.Controls.Add(this.AccLabel);
            this.Controls.Add(this.ZeroNumLabel);
            this.Controls.Add(this.ZeroLabel);
            this.Controls.Add(this.NextInstructionButton);
            this.Controls.Add(this.ACCNumLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Gemini Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label AccLabel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label ACCNumLabel;
        private System.Windows.Forms.Button NextInstructionButton;
        private System.Windows.Forms.Label ZeroLabel;
        private System.Windows.Forms.Label ZeroNumLabel;
        private System.Windows.Forms.Label OneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ANumLabel;
        private System.Windows.Forms.Label BNumLabel;
        private System.Windows.Forms.Label PCNumLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OneNumLabel;
        private System.Windows.Forms.Label MARNumLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MDRNumLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label instructionIndexLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NextInstructionNumLabel;
        private System.Windows.Forms.Label CurrentInstructionNumLabel;
        private System.Windows.Forms.Label currentInstructionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HitsNumLabel;
        private System.Windows.Forms.Label MissesNumLabel;
        private System.Windows.Forms.Label label16;
    }
}

