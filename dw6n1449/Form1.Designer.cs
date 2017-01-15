namespace dw6n1449
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
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.btnLeave = new System.Windows.Forms.Button();
            this.lblIntroOutput = new System.Windows.Forms.Label();
            this.btnIntro = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlDealerCard5 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard5 = new System.Windows.Forms.Panel();
            this.pnlDealerCard4 = new System.Windows.Forms.Panel();
            this.pnlDealerCard3 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard3 = new System.Windows.Forms.Panel();
            this.pnlDealerCard2 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard2 = new System.Windows.Forms.Panel();
            this.pnlDealerCard1 = new System.Windows.Forms.Panel();
            this.pnlPlayerCard1 = new System.Windows.Forms.Panel();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.btnHelpEnd = new System.Windows.Forms.Button();
            this.btnHelpNext = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPlayerCard4 = new System.Windows.Forms.Panel();
            this.pnlIntro.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIntro
            // 
            this.pnlIntro.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIntro.Controls.Add(this.btnLeave);
            this.pnlIntro.Controls.Add(this.lblIntroOutput);
            this.pnlIntro.Controls.Add(this.btnIntro);
            this.pnlIntro.Controls.Add(this.label27);
            this.pnlIntro.Location = new System.Drawing.Point(824, 12);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(818, 550);
            this.pnlIntro.TabIndex = 32;
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(190, 323);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 35;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // lblIntroOutput
            // 
            this.lblIntroOutput.AutoSize = true;
            this.lblIntroOutput.Location = new System.Drawing.Point(125, 245);
            this.lblIntroOutput.Name = "lblIntroOutput";
            this.lblIntroOutput.Size = new System.Drawing.Size(41, 13);
            this.lblIntroOutput.TabIndex = 34;
            this.lblIntroOutput.Text = "label28";
            // 
            // btnIntro
            // 
            this.btnIntro.Location = new System.Drawing.Point(182, 279);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(75, 23);
            this.btnIntro.TabIndex = 33;
            this.btnIntro.Text = "Place Bet";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 446);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "intro panel";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlGame.BackgroundImage = global::dw6n1449.Properties.Resources.blackjackback;
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGame.Controls.Add(this.btnPlay);
            this.pnlGame.Controls.Add(this.lblPlayer1Name);
            this.pnlGame.Controls.Add(this.label18);
            this.pnlGame.Controls.Add(this.label13);
            this.pnlGame.Controls.Add(this.label11);
            this.pnlGame.Controls.Add(this.btnHelp);
            this.pnlGame.Controls.Add(this.pnlDealerCard5);
            this.pnlGame.Controls.Add(this.pnlPlayerCard5);
            this.pnlGame.Controls.Add(this.pnlDealerCard4);
            this.pnlGame.Controls.Add(this.pnlPlayerCard4);
            this.pnlGame.Controls.Add(this.pnlDealerCard3);
            this.pnlGame.Controls.Add(this.pnlPlayerCard3);
            this.pnlGame.Controls.Add(this.pnlDealerCard2);
            this.pnlGame.Controls.Add(this.pnlPlayerCard2);
            this.pnlGame.Controls.Add(this.pnlDealerCard1);
            this.pnlGame.Controls.Add(this.pnlPlayerCard1);
            this.pnlGame.Controls.Add(this.lblDealerScore);
            this.pnlGame.Controls.Add(this.btnStay);
            this.pnlGame.Controls.Add(this.btnHit);
            this.pnlGame.Controls.Add(this.lblCondition);
            this.pnlGame.Controls.Add(this.lblPlayerScore);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(818, 550);
            this.pnlGame.TabIndex = 30;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(516, 482);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 34;
            this.btnPlay.Text = "Play Again";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(13, 21);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(52, 16);
            this.lblPlayer1Name.TabIndex = 33;
            this.lblPlayer1Name.Text = "label27";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(650, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "Dealer Hand:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "\'s Hand:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "game panel";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(720, 55);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlDealerCard5
            // 
            this.pnlDealerCard5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDealerCard5.Location = new System.Drawing.Point(325, 263);
            this.pnlDealerCard5.Name = "pnlDealerCard5";
            this.pnlDealerCard5.Size = new System.Drawing.Size(40, 55);
            this.pnlDealerCard5.TabIndex = 26;
            // 
            // pnlPlayerCard5
            // 
            this.pnlPlayerCard5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayerCard5.Location = new System.Drawing.Point(549, 343);
            this.pnlPlayerCard5.Name = "pnlPlayerCard5";
            this.pnlPlayerCard5.Size = new System.Drawing.Size(75, 100);
            this.pnlPlayerCard5.TabIndex = 23;
            // 
            // pnlDealerCard4
            // 
            this.pnlDealerCard4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDealerCard4.Location = new System.Drawing.Point(369, 263);
            this.pnlDealerCard4.Name = "pnlDealerCard4";
            this.pnlDealerCard4.Size = new System.Drawing.Size(40, 55);
            this.pnlDealerCard4.TabIndex = 27;
            // 
            // pnlDealerCard3
            // 
            this.pnlDealerCard3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDealerCard3.Location = new System.Drawing.Point(412, 263);
            this.pnlDealerCard3.Name = "pnlDealerCard3";
            this.pnlDealerCard3.Size = new System.Drawing.Size(40, 55);
            this.pnlDealerCard3.TabIndex = 28;
            // 
            // pnlPlayerCard3
            // 
            this.pnlPlayerCard3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayerCard3.Location = new System.Drawing.Point(389, 343);
            this.pnlPlayerCard3.Name = "pnlPlayerCard3";
            this.pnlPlayerCard3.Size = new System.Drawing.Size(75, 100);
            this.pnlPlayerCard3.TabIndex = 23;
            // 
            // pnlDealerCard2
            // 
            this.pnlDealerCard2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDealerCard2.BackgroundImage = global::dw6n1449.Properties.Resources.cardBack;
            this.pnlDealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDealerCard2.Location = new System.Drawing.Point(455, 263);
            this.pnlDealerCard2.Name = "pnlDealerCard2";
            this.pnlDealerCard2.Size = new System.Drawing.Size(40, 55);
            this.pnlDealerCard2.TabIndex = 25;
            // 
            // pnlPlayerCard2
            // 
            this.pnlPlayerCard2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayerCard2.Location = new System.Drawing.Point(309, 343);
            this.pnlPlayerCard2.Name = "pnlPlayerCard2";
            this.pnlPlayerCard2.Size = new System.Drawing.Size(75, 100);
            this.pnlPlayerCard2.TabIndex = 22;
            // 
            // pnlDealerCard1
            // 
            this.pnlDealerCard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDealerCard1.BackgroundImage = global::dw6n1449.Properties.Resources.cardBack;
            this.pnlDealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDealerCard1.Location = new System.Drawing.Point(498, 263);
            this.pnlDealerCard1.Name = "pnlDealerCard1";
            this.pnlDealerCard1.Size = new System.Drawing.Size(40, 55);
            this.pnlDealerCard1.TabIndex = 24;
            // 
            // pnlPlayerCard1
            // 
            this.pnlPlayerCard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerCard1.BackgroundImage = global::dw6n1449.Properties.Resources.QS;
            this.pnlPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayerCard1.Location = new System.Drawing.Point(230, 343);
            this.pnlPlayerCard1.Name = "pnlPlayerCard1";
            this.pnlPlayerCard1.Size = new System.Drawing.Size(75, 100);
            this.pnlPlayerCard1.TabIndex = 21;
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(744, 21);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(51, 20);
            this.lblDealerScore.TabIndex = 16;
            this.lblDealerScore.Text = "label7";
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(377, 483);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 23);
            this.btnStay.TabIndex = 15;
            this.btnStay.Text = "STAY";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(256, 483);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(228, 80);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(112, 25);
            this.lblCondition.TabIndex = 13;
            this.lblCondition.Text = "Condition";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(128, 21);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(51, 20);
            this.lblPlayerScore.TabIndex = 12;
            this.lblPlayerScore.Text = "label7";
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlHelp.BackgroundImage = global::dw6n1449.Properties.Resources.help0;
            this.pnlHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHelp.Controls.Add(this.btnHelpEnd);
            this.pnlHelp.Controls.Add(this.btnHelpNext);
            this.pnlHelp.Controls.Add(this.label12);
            this.pnlHelp.Location = new System.Drawing.Point(842, 42);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(467, 463);
            this.pnlHelp.TabIndex = 31;
            // 
            // btnHelpEnd
            // 
            this.btnHelpEnd.Location = new System.Drawing.Point(346, 431);
            this.btnHelpEnd.Name = "btnHelpEnd";
            this.btnHelpEnd.Size = new System.Drawing.Size(75, 23);
            this.btnHelpEnd.TabIndex = 33;
            this.btnHelpEnd.Text = "Got It";
            this.btnHelpEnd.UseVisualStyleBackColor = true;
            this.btnHelpEnd.Click += new System.EventHandler(this.btnHelpEnd_Click);
            // 
            // btnHelpNext
            // 
            this.btnHelpNext.Location = new System.Drawing.Point(346, 402);
            this.btnHelpNext.Name = "btnHelpNext";
            this.btnHelpNext.Size = new System.Drawing.Size(75, 23);
            this.btnHelpNext.TabIndex = 32;
            this.btnHelpNext.Text = "Next =>";
            this.btnHelpNext.UseVisualStyleBackColor = true;
            this.btnHelpNext.Click += new System.EventHandler(this.btnHelpNext_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "help panel";
            // 
            // pnlPlayerCard4
            // 
            this.pnlPlayerCard4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayerCard4.Location = new System.Drawing.Point(469, 343);
            this.pnlPlayerCard4.Name = "pnlPlayerCard4";
            this.pnlPlayerCard4.Size = new System.Drawing.Size(75, 100);
            this.pnlPlayerCard4.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1185, 614);
            this.Controls.Add(this.pnlIntro);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlHelp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlIntro.ResumeLayout(false);
            this.pnlIntro.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Panel pnlPlayerCard1;
        private System.Windows.Forms.Panel pnlPlayerCard2;
        private System.Windows.Forms.Panel pnlPlayerCard3;
        private System.Windows.Forms.Panel pnlPlayerCard5;
        private System.Windows.Forms.Panel pnlDealerCard5;
        private System.Windows.Forms.Panel pnlDealerCard4;
        private System.Windows.Forms.Panel pnlDealerCard3;
        private System.Windows.Forms.Panel pnlDealerCard2;
        private System.Windows.Forms.Panel pnlDealerCard1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Button btnHelpEnd;
        private System.Windows.Forms.Button btnHelpNext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Panel pnlIntro;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblIntroOutput;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlPlayerCard4;
    }
}

