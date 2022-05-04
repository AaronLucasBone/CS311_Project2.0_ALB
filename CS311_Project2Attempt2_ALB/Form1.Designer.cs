namespace CS311_Project2Attempt2_ALB
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
            this.lblYouLose = new System.Windows.Forms.Label();
            this.lblRollAgain = new System.Windows.Forms.Label();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.btnRoil = new System.Windows.Forms.Button();
            this.lblBetEnter = new System.Windows.Forms.Label();
            this.txtbBet = new System.Windows.Forms.TextBox();
            this.lblBalanceTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pbDie2 = new System.Windows.Forms.PictureBox();
            this.pbDie1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentPoint = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYouLose
            // 
            this.lblYouLose.AutoSize = true;
            this.lblYouLose.BackColor = System.Drawing.Color.LightCoral;
            this.lblYouLose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouLose.Location = new System.Drawing.Point(354, 164);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(75, 19);
            this.lblYouLose.TabIndex = 34;
            this.lblYouLose.Text = "You Lose!";
            this.lblYouLose.Visible = false;
            // 
            // lblRollAgain
            // 
            this.lblRollAgain.AutoSize = true;
            this.lblRollAgain.BackColor = System.Drawing.Color.Silver;
            this.lblRollAgain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollAgain.Location = new System.Drawing.Point(344, 115);
            this.lblRollAgain.Name = "lblRollAgain";
            this.lblRollAgain.Size = new System.Drawing.Size(91, 19);
            this.lblRollAgain.TabIndex = 33;
            this.lblRollAgain.Text = "Roll Again...";
            this.lblRollAgain.Visible = false;
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblYouWin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.Location = new System.Drawing.Point(354, 71);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(69, 19);
            this.lblYouWin.TabIndex = 32;
            this.lblYouWin.Text = "You Win!";
            this.lblYouWin.Visible = false;
            // 
            // btnRoil
            // 
            this.btnRoil.BackColor = System.Drawing.Color.Gold;
            this.btnRoil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoil.Location = new System.Drawing.Point(408, 332);
            this.btnRoil.Name = "btnRoil";
            this.btnRoil.Size = new System.Drawing.Size(139, 65);
            this.btnRoil.TabIndex = 31;
            this.btnRoil.Text = "ROLL!";
            this.btnRoil.UseVisualStyleBackColor = false;
            this.btnRoil.Click += new System.EventHandler(this.btnRoil_Click);
            // 
            // lblBetEnter
            // 
            this.lblBetEnter.AutoSize = true;
            this.lblBetEnter.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetEnter.Location = new System.Drawing.Point(239, 274);
            this.lblBetEnter.Name = "lblBetEnter";
            this.lblBetEnter.Size = new System.Drawing.Size(163, 27);
            this.lblBetEnter.TabIndex = 30;
            this.lblBetEnter.Text = "Enter Your Bet:";
            // 
            // txtbBet
            // 
            this.txtbBet.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbBet.Location = new System.Drawing.Point(408, 264);
            this.txtbBet.Name = "txtbBet";
            this.txtbBet.Size = new System.Drawing.Size(100, 44);
            this.txtbBet.TabIndex = 29;
            // 
            // lblBalanceTotal
            // 
            this.lblBalanceTotal.AutoSize = true;
            this.lblBalanceTotal.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTotal.Location = new System.Drawing.Point(402, 216);
            this.lblBalanceTotal.Name = "lblBalanceTotal";
            this.lblBalanceTotal.Size = new System.Drawing.Size(79, 36);
            this.lblBalanceTotal.TabIndex = 28;
            this.lblBalanceTotal.Text = "$100";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(294, 224);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(102, 27);
            this.lblBalance.TabIndex = 27;
            this.lblBalance.Text = "Balance: ";
            // 
            // pbDie2
            // 
            this.pbDie2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbDie2.Image = global::CS311_Project2Attempt2_ALB.Properties.Resources.dice1;
            this.pbDie2.Location = new System.Drawing.Point(441, 71);
            this.pbDie2.Name = "pbDie2";
            this.pbDie2.Size = new System.Drawing.Size(112, 112);
            this.pbDie2.TabIndex = 26;
            this.pbDie2.TabStop = false;
            // 
            // pbDie1
            // 
            this.pbDie1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbDie1.Image = global::CS311_Project2Attempt2_ALB.Properties.Resources.dice1;
            this.pbDie1.Location = new System.Drawing.Point(225, 71);
            this.pbDie1.Name = "pbDie1";
            this.pbDie1.Size = new System.Drawing.Size(113, 112);
            this.pbDie1.TabIndex = 35;
            this.pbDie1.TabStop = false;
            // 
            // lblCurrentPoint
            // 
            this.lblCurrentPoint.AutoSize = true;
            this.lblCurrentPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoint.Location = new System.Drawing.Point(231, 355);
            this.lblCurrentPoint.Name = "lblCurrentPoint";
            this.lblCurrentPoint.Size = new System.Drawing.Size(93, 19);
            this.lblCurrentPoint.TabIndex = 36;
            this.lblCurrentPoint.Text = "Current Point:";
            this.lblCurrentPoint.Click += new System.EventHandler(this.lblCurrentPoint_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.Location = new System.Drawing.Point(330, 324);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(64, 73);
            this.lblPoint.TabIndex = 37;
            this.lblPoint.Text = "0";
            this.lblPoint.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblCurrentPoint);
            this.Controls.Add(this.pbDie1);
            this.Controls.Add(this.lblYouLose);
            this.Controls.Add(this.lblRollAgain);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.btnRoil);
            this.Controls.Add(this.lblBetEnter);
            this.Controls.Add(this.txtbBet);
            this.Controls.Add(this.lblBalanceTotal);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.pbDie2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYouLose;
        private System.Windows.Forms.Label lblRollAgain;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Button btnRoil;
        private System.Windows.Forms.Label lblBetEnter;
        private System.Windows.Forms.TextBox txtbBet;
        private System.Windows.Forms.Label lblBalanceTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pbDie2;
        private System.Windows.Forms.PictureBox pbDie1;
        private System.Windows.Forms.Label lblCurrentPoint;
        private System.Windows.Forms.Label lblPoint;
    }
}

