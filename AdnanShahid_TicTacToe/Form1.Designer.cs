namespace AdnanShahid_TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.lblPlayerLabel = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerLabel = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbTurnSelect = new System.Windows.Forms.GroupBox();
            this.rbPlayerStart = new System.Windows.Forms.RadioButton();
            this.rbComputerStart = new System.Windows.Forms.RadioButton();
            this.lblLevelIndicate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlRed.SuspendLayout();
            this.gbTurnSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(202, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TicTacToe";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.GhostWhite;
            this.btn1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 16);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(149, 112);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.mnuOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEasy,
            this.mnuHard});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // mnuEasy
            // 
            this.mnuEasy.Name = "mnuEasy";
            this.mnuEasy.Size = new System.Drawing.Size(152, 22);
            this.mnuEasy.Text = "Easy";
            this.mnuEasy.Click += new System.EventHandler(this.mnuEasy_Click);
            // 
            // mnuHard
            // 
            this.mnuHard.Name = "mnuHard";
            this.mnuHard.Size = new System.Drawing.Size(152, 22);
            this.mnuHard.Text = "Hard";
            this.mnuHard.Click += new System.EventHandler(this.mnuHard_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.MnuRestart});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(110, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // MnuRestart
            // 
            this.MnuRestart.Name = "MnuRestart";
            this.MnuRestart.Size = new System.Drawing.Size(110, 22);
            this.MnuRestart.Text = "Restart";
            this.MnuRestart.Click += new System.EventHandler(this.MnuRestart_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.GhostWhite;
            this.btn2.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(167, 16);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(149, 112);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.GhostWhite;
            this.btn3.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(322, 16);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(149, 112);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.GhostWhite;
            this.btn4.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 140);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(149, 112);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.GhostWhite;
            this.btn5.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(167, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(149, 112);
            this.btn5.TabIndex = 6;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.GhostWhite;
            this.btn6.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(322, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(149, 112);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.GhostWhite;
            this.btn7.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 264);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(149, 112);
            this.btn7.TabIndex = 8;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.GhostWhite;
            this.btn9.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(322, 264);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(149, 112);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.GhostWhite;
            this.btn8.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(167, 264);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(149, 112);
            this.btn8.TabIndex = 10;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // lblPlayerLabel
            // 
            this.lblPlayerLabel.AutoSize = true;
            this.lblPlayerLabel.BackColor = System.Drawing.Color.DarkRed;
            this.lblPlayerLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerLabel.Location = new System.Drawing.Point(504, 103);
            this.lblPlayerLabel.Name = "lblPlayerLabel";
            this.lblPlayerLabel.Size = new System.Drawing.Size(79, 18);
            this.lblPlayerLabel.TabIndex = 11;
            this.lblPlayerLabel.Text = "Player Score:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.DarkRed;
            this.lblPlayerScore.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.lblPlayerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerScore.Location = new System.Drawing.Point(609, 103);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(0, 18);
            this.lblPlayerScore.TabIndex = 12;
            this.lblPlayerScore.Click += new System.EventHandler(this.lblPlayerScore_Click);
            // 
            // lblComputerLabel
            // 
            this.lblComputerLabel.AutoSize = true;
            this.lblComputerLabel.BackColor = System.Drawing.Color.DarkRed;
            this.lblComputerLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.lblComputerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComputerLabel.Location = new System.Drawing.Point(504, 143);
            this.lblComputerLabel.Name = "lblComputerLabel";
            this.lblComputerLabel.Size = new System.Drawing.Size(99, 18);
            this.lblComputerLabel.TabIndex = 13;
            this.lblComputerLabel.Text = "Computer Score:";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.Color.DarkRed;
            this.lblComputerScore.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.lblComputerScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComputerScore.Location = new System.Drawing.Point(609, 143);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(0, 18);
            this.lblComputerScore.TabIndex = 14;
            this.lblComputerScore.Click += new System.EventHandler(this.lblComputerScore_Click);
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.DarkRed;
            this.pnlRed.Controls.Add(this.pnl4);
            this.pnlRed.Controls.Add(this.pnl3);
            this.pnlRed.Controls.Add(this.pnl2);
            this.pnlRed.Controls.Add(this.pnl1);
            this.pnlRed.Controls.Add(this.btn6);
            this.pnlRed.Controls.Add(this.btn9);
            this.pnlRed.Controls.Add(this.btn8);
            this.pnlRed.Controls.Add(this.btn5);
            this.pnlRed.Controls.Add(this.btn2);
            this.pnlRed.Controls.Add(this.btn3);
            this.pnlRed.Controls.Add(this.btn7);
            this.pnlRed.Controls.Add(this.btn1);
            this.pnlRed.Controls.Add(this.btn4);
            this.pnlRed.Location = new System.Drawing.Point(12, 75);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(486, 388);
            this.pnlRed.TabIndex = 16;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.Gray;
            this.pnl4.Location = new System.Drawing.Point(13, 253);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(458, 10);
            this.pnl4.TabIndex = 20;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Gray;
            this.pnl3.Location = new System.Drawing.Point(12, 129);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(458, 10);
            this.pnl3.TabIndex = 19;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Gray;
            this.pnl2.Location = new System.Drawing.Point(314, 19);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(10, 356);
            this.pnl2.TabIndex = 12;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Gray;
            this.pnl1.Location = new System.Drawing.Point(159, 19);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(10, 356);
            this.pnl1.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(524, 355);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 85);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbTurnSelect
            // 
            this.gbTurnSelect.Controls.Add(this.rbComputerStart);
            this.gbTurnSelect.Controls.Add(this.rbPlayerStart);
            this.gbTurnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbTurnSelect.Location = new System.Drawing.Point(507, 215);
            this.gbTurnSelect.Name = "gbTurnSelect";
            this.gbTurnSelect.Size = new System.Drawing.Size(200, 100);
            this.gbTurnSelect.TabIndex = 18;
            this.gbTurnSelect.TabStop = false;
            this.gbTurnSelect.Text = "Who will start?";
            // 
            // rbPlayerStart
            // 
            this.rbPlayerStart.AutoSize = true;
            this.rbPlayerStart.Location = new System.Drawing.Point(7, 28);
            this.rbPlayerStart.Name = "rbPlayerStart";
            this.rbPlayerStart.Size = new System.Drawing.Size(67, 17);
            this.rbPlayerStart.TabIndex = 0;
            this.rbPlayerStart.TabStop = true;
            this.rbPlayerStart.Text = "You start";
            this.rbPlayerStart.UseVisualStyleBackColor = true;
            this.rbPlayerStart.CheckedChanged += new System.EventHandler(this.rbPlayerStart_CheckedChanged);
            // 
            // rbComputerStart
            // 
            this.rbComputerStart.AutoSize = true;
            this.rbComputerStart.Location = new System.Drawing.Point(7, 63);
            this.rbComputerStart.Name = "rbComputerStart";
            this.rbComputerStart.Size = new System.Drawing.Size(122, 17);
            this.rbComputerStart.TabIndex = 1;
            this.rbComputerStart.TabStop = true;
            this.rbComputerStart.Text = "The Computer Starts";
            this.rbComputerStart.UseVisualStyleBackColor = true;
            this.rbComputerStart.CheckedChanged += new System.EventHandler(this.rbComputerStart_CheckedChanged);
            // 
            // lblLevelIndicate
            // 
            this.lblLevelIndicate.AutoSize = true;
            this.lblLevelIndicate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelIndicate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevelIndicate.Location = new System.Drawing.Point(21, 486);
            this.lblLevelIndicate.Name = "lblLevelIndicate";
            this.lblLevelIndicate.Size = new System.Drawing.Size(707, 18);
            this.lblLevelIndicate.TabIndex = 19;
            this.lblLevelIndicate.Text = "Change the level of the computer at any time by clicking the level option in the " +
                "menu bar!";
            this.lblLevelIndicate.Click += new System.EventHandler(this.label1_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 534);
            this.Controls.Add(this.lblLevelIndicate);
            this.Controls.Add(this.gbTurnSelect);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblComputerLabel);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerLabel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRed);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRed.ResumeLayout(false);
            this.gbTurnSelect.ResumeLayout(false);
            this.gbTurnSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEasy;
        private System.Windows.Forms.ToolStripMenuItem mnuHard;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Label lblPlayerLabel;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerLabel;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ToolStripMenuItem MnuRestart;
        private System.Windows.Forms.GroupBox gbTurnSelect;
        private System.Windows.Forms.RadioButton rbComputerStart;
        private System.Windows.Forms.RadioButton rbPlayerStart;
        private System.Windows.Forms.Label lblLevelIndicate;
    }
}

