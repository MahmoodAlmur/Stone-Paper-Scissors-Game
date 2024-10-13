namespace Stone_Paper_Scissors
{
    partial class frmStartGame
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
            this.pbPlayer1Picture = new System.Windows.Forms.PictureBox();
            this.pbComputerPicture = new System.Windows.Forms.PictureBox();
            this.btnScissors = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblFinalWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlayer1Picture
            // 
            this.pbPlayer1Picture.BackgroundImage = global::Stone_Paper_Scissors.Properties.Resources.question_mark;
            this.pbPlayer1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer1Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer1Picture.Location = new System.Drawing.Point(68, 76);
            this.pbPlayer1Picture.Name = "pbPlayer1Picture";
            this.pbPlayer1Picture.Size = new System.Drawing.Size(177, 177);
            this.pbPlayer1Picture.TabIndex = 0;
            this.pbPlayer1Picture.TabStop = false;
            // 
            // pbComputerPicture
            // 
            this.pbComputerPicture.BackgroundImage = global::Stone_Paper_Scissors.Properties.Resources.question_mark;
            this.pbComputerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbComputerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbComputerPicture.Location = new System.Drawing.Point(551, 76);
            this.pbComputerPicture.Name = "pbComputerPicture";
            this.pbComputerPicture.Size = new System.Drawing.Size(177, 177);
            this.pbComputerPicture.TabIndex = 1;
            this.pbComputerPicture.TabStop = false;
            // 
            // btnScissors
            // 
            this.btnScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(435, 272);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(60, 34);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Stone_Paper_Scissors.Properties.Resources.scissors;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(435, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Stone_Paper_Scissors.Properties.Resources.paper;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(369, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Stone_Paper_Scissors.Properties.Resources.stone;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(303, 312);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // btnPaper
            // 
            this.btnPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(369, 272);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(60, 34);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Text = "paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnStone
            // 
            this.btnStone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStone.Location = new System.Drawing.Point(303, 272);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(60, 34);
            this.btnStone.TabIndex = 8;
            this.btnStone.Text = "stone";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Computer";
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.Transparent;
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScore.Controls.Add(this.lblPlayer1Score);
            this.pnlScore.Controls.Add(this.lblComputerScore);
            this.pnlScore.Controls.Add(this.label5);
            this.pnlScore.Controls.Add(this.label4);
            this.pnlScore.Controls.Add(this.label3);
            this.pnlScore.Location = new System.Drawing.Point(303, 124);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(192, 118);
            this.pnlScore.TabIndex = 11;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(30, 70);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(14, 16);
            this.lblPlayer1Score.TabIndex = 15;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(139, 70);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(14, 16);
            this.lblComputerScore.TabIndex = 14;
            this.lblComputerScore.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Computer";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = " Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = " Round : ";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.Location = new System.Drawing.Point(431, 86);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(18, 20);
            this.lblRoundNumber.TabIndex = 16;
            this.lblRoundNumber.Text = "1";
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(636, 408);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(151, 36);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinner.ForeColor = System.Drawing.Color.White;
            this.lblFinalWinner.Location = new System.Drawing.Point(12, 408);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(176, 33);
            this.lblFinalWinner.TabIndex = 18;
            this.lblFinalWinner.Text = "ttru6tru6w65";
            // 
            // frmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinalWinner);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.pbComputerPicture);
            this.Controls.Add(this.pbPlayer1Picture);
            this.Name = "frmStartGame";
            this.Text = "stone paper scissors GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer1Picture;
        private System.Windows.Forms.PictureBox pbComputerPicture;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblFinalWinner;
    }
}