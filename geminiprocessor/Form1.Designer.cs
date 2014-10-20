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
            System.Windows.Forms.Label label17;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.IRNumLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.instructionIndexLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HitsNumLabel = new System.Windows.Forms.Label();
            this.MissesNumLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delayProgressBar = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nopCountNumLabel = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(302, 353);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(138, 34);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AccLabel
            // 
            this.AccLabel.AutoSize = true;
            this.AccLabel.Location = new System.Drawing.Point(5, 27);
            this.AccLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccLabel.Name = "AccLabel";
            this.AccLabel.Size = new System.Drawing.Size(35, 16);
            this.AccLabel.TabIndex = 1;
            this.AccLabel.Text = "ACC";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(195, 353);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(99, 34);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run (buggy)";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ACCNumLabel
            // 
            this.ACCNumLabel.AutoSize = true;
            this.ACCNumLabel.Location = new System.Drawing.Point(114, 27);
            this.ACCNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACCNumLabel.Name = "ACCNumLabel";
            this.ACCNumLabel.Size = new System.Drawing.Size(20, 16);
            this.ACCNumLabel.TabIndex = 3;
            this.ACCNumLabel.Text = "---";
            // 
            // NextInstructionButton
            // 
            this.NextInstructionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextInstructionButton.Location = new System.Drawing.Point(15, 308);
            this.NextInstructionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextInstructionButton.Name = "NextInstructionButton";
            this.NextInstructionButton.Size = new System.Drawing.Size(172, 80);
            this.NextInstructionButton.TabIndex = 4;
            this.NextInstructionButton.Text = "Do One CPU Cycle";
            this.NextInstructionButton.UseVisualStyleBackColor = true;
            this.NextInstructionButton.Click += new System.EventHandler(this.NextInstructionButton_Click);
            // 
            // ZeroLabel
            // 
            this.ZeroLabel.AutoSize = true;
            this.ZeroLabel.Location = new System.Drawing.Point(5, 131);
            this.ZeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZeroLabel.Name = "ZeroLabel";
            this.ZeroLabel.Size = new System.Drawing.Size(36, 16);
            this.ZeroLabel.TabIndex = 5;
            this.ZeroLabel.Text = "Zero";
            // 
            // ZeroNumLabel
            // 
            this.ZeroNumLabel.AutoSize = true;
            this.ZeroNumLabel.Location = new System.Drawing.Point(114, 131);
            this.ZeroNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZeroNumLabel.Name = "ZeroNumLabel";
            this.ZeroNumLabel.Size = new System.Drawing.Size(15, 16);
            this.ZeroNumLabel.TabIndex = 6;
            this.ZeroNumLabel.Text = "0";
            // 
            // OneLabel
            // 
            this.OneLabel.AutoSize = true;
            this.OneLabel.Location = new System.Drawing.Point(5, 157);
            this.OneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OneLabel.Name = "OneLabel";
            this.OneLabel.Size = new System.Drawing.Size(33, 16);
            this.OneLabel.TabIndex = 7;
            this.OneLabel.Text = "One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // ANumLabel
            // 
            this.ANumLabel.AutoSize = true;
            this.ANumLabel.Location = new System.Drawing.Point(114, 183);
            this.ANumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ANumLabel.Name = "ANumLabel";
            this.ANumLabel.Size = new System.Drawing.Size(20, 16);
            this.ANumLabel.TabIndex = 10;
            this.ANumLabel.Text = "---";
            // 
            // BNumLabel
            // 
            this.BNumLabel.AutoSize = true;
            this.BNumLabel.Location = new System.Drawing.Point(114, 209);
            this.BNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BNumLabel.Name = "BNumLabel";
            this.BNumLabel.Size = new System.Drawing.Size(20, 16);
            this.BNumLabel.TabIndex = 11;
            this.BNumLabel.Text = "---";
            // 
            // PCNumLabel
            // 
            this.PCNumLabel.AutoSize = true;
            this.PCNumLabel.Location = new System.Drawing.Point(114, 53);
            this.PCNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCNumLabel.Name = "PCNumLabel";
            this.PCNumLabel.Size = new System.Drawing.Size(20, 16);
            this.PCNumLabel.TabIndex = 13;
            this.PCNumLabel.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "PC";
            // 
            // OneNumLabel
            // 
            this.OneNumLabel.AutoSize = true;
            this.OneNumLabel.Location = new System.Drawing.Point(114, 157);
            this.OneNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OneNumLabel.Name = "OneNumLabel";
            this.OneNumLabel.Size = new System.Drawing.Size(15, 16);
            this.OneNumLabel.TabIndex = 14;
            this.OneNumLabel.Text = "1";
            // 
            // MARNumLabel
            // 
            this.MARNumLabel.AutoSize = true;
            this.MARNumLabel.Location = new System.Drawing.Point(114, 79);
            this.MARNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MARNumLabel.Name = "MARNumLabel";
            this.MARNumLabel.Size = new System.Drawing.Size(20, 16);
            this.MARNumLabel.TabIndex = 16;
            this.MARNumLabel.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "MAR";
            // 
            // MDRNumLabel
            // 
            this.MDRNumLabel.AutoSize = true;
            this.MDRNumLabel.Location = new System.Drawing.Point(114, 105);
            this.MDRNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MDRNumLabel.Name = "MDRNumLabel";
            this.MDRNumLabel.Size = new System.Drawing.Size(20, 16);
            this.MDRNumLabel.TabIndex = 18;
            this.MDRNumLabel.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "MDR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "TEMP";
            // 
            // IRNumLabel
            // 
            this.IRNumLabel.AutoSize = true;
            this.IRNumLabel.Location = new System.Drawing.Point(248, 42);
            this.IRNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IRNumLabel.Name = "IRNumLabel";
            this.IRNumLabel.Size = new System.Drawing.Size(20, 16);
            this.IRNumLabel.TabIndex = 22;
            this.IRNumLabel.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "IR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 261);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "CC";
            // 
            // instructionIndexLabel
            // 
            this.instructionIndexLabel.AutoSize = true;
            this.instructionIndexLabel.Location = new System.Drawing.Point(271, 17);
            this.instructionIndexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionIndexLabel.Name = "instructionIndexLabel";
            this.instructionIndexLabel.Size = new System.Drawing.Size(37, 16);
            this.instructionIndexLabel.TabIndex = 26;
            this.instructionIndexLabel.Text = "--- / 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HitsNumLabel
            // 
            this.HitsNumLabel.AutoSize = true;
            this.HitsNumLabel.Location = new System.Drawing.Point(66, 25);
            this.HitsNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HitsNumLabel.Name = "HitsNumLabel";
            this.HitsNumLabel.Size = new System.Drawing.Size(20, 16);
            this.HitsNumLabel.TabIndex = 32;
            this.HitsNumLabel.Text = "---";
            // 
            // MissesNumLabel
            // 
            this.MissesNumLabel.AutoSize = true;
            this.MissesNumLabel.Location = new System.Drawing.Point(66, 0);
            this.MissesNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MissesNumLabel.Name = "MissesNumLabel";
            this.MissesNumLabel.Size = new System.Drawing.Size(20, 16);
            this.MissesNumLabel.TabIndex = 34;
            this.MissesNumLabel.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Misses";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(195, 308);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.AccLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MARNumLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PCNumLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ACCNumLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ZeroLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.OneLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.ANumLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.BNumLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.OneNumLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.MDRNumLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ZeroNumLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 286);
            this.tableLayoutPanel1.TabIndex = 38;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(114, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Register";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel2.CausesValidation = false;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.HitsNumLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.MissesNumLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nopCountNumLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(label17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(316, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 69);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // delayProgressBar
            // 
            this.delayProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.delayProgressBar.ForeColor = System.Drawing.Color.Black;
            this.delayProgressBar.Location = new System.Drawing.Point(302, 333);
            this.delayProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delayProgressBar.Name = "delayProgressBar";
            this.delayProgressBar.Size = new System.Drawing.Size(138, 16);
            this.delayProgressBar.Step = 1;
            this.delayProgressBar.TabIndex = 40;
            this.delayProgressBar.Click += new System.EventHandler(this.delayProgressBar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(192, 333);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Delay Progress:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::GeminiProcessor.Properties.Resources.oQqBGdm;
            this.pictureBox1.InitialImage = global::GeminiProcessor.Properties.Resources.rsz_1p2xtba;
            this.pictureBox1.Location = new System.Drawing.Point(219, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(3, 50);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(51, 16);
            label17.TabIndex = 35;
            label17.Text = "Delays";
            // 
            // nopCountNumLabel
            // 
            this.nopCountNumLabel.AutoSize = true;
            this.nopCountNumLabel.Location = new System.Drawing.Point(65, 50);
            this.nopCountNumLabel.Name = "nopCountNumLabel";
            this.nopCountNumLabel.Size = new System.Drawing.Size(20, 16);
            this.nopCountNumLabel.TabIndex = 36;
            this.nopCountNumLabel.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 407);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.delayProgressBar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instructionIndexLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IRNumLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NextInstructionButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LoadButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gemini Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label IRNumLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label instructionIndexLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HitsNumLabel;
        private System.Windows.Forms.Label MissesNumLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar delayProgressBar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label nopCountNumLabel;
    }
}

