using System.Drawing;
using System.Windows.Forms;

namespace CarRacingGame
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerCar = new System.Windows.Forms.PictureBox();
            this.aiCar2 = new System.Windows.Forms.PictureBox();
            this.aiCar3 = new System.Windows.Forms.PictureBox();
            this.aiCar1 = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.bestScoreText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.viewScoresBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.playerCar);
            this.panel1.Controls.Add(this.aiCar2);
            this.panel1.Controls.Add(this.aiCar3);
            this.panel1.Controls.Add(this.aiCar1);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 859);
            this.panel1.TabIndex = 1;
            // 
            // playerCar
            // 
            this.playerCar.BackColor = System.Drawing.Color.Transparent;
            this.playerCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerCar.Image = global::CarRacingGame.Properties.Resources.playerCar;
            this.playerCar.Location = new System.Drawing.Point(466, 633);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(109, 203);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCar.TabIndex = 1;
            this.playerCar.TabStop = false;
            // 
            // aiCar2
            // 
            this.aiCar2.Image = global::CarRacingGame.Properties.Resources.brownCar1;
            this.aiCar2.Location = new System.Drawing.Point(466, -1090);
            this.aiCar2.Name = "aiCar2";
            this.aiCar2.Size = new System.Drawing.Size(109, 206);
            this.aiCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiCar2.TabIndex = 11;
            this.aiCar2.TabStop = false;
            // 
            // aiCar3
            // 
            this.aiCar3.Image = global::CarRacingGame.Properties.Resources.greenCar1;
            this.aiCar3.Location = new System.Drawing.Point(684, -422);
            this.aiCar3.Name = "aiCar3";
            this.aiCar3.Size = new System.Drawing.Size(109, 203);
            this.aiCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiCar3.TabIndex = 10;
            this.aiCar3.TabStop = false;
            // 
            // aiCar1
            // 
            this.aiCar1.Image = global::CarRacingGame.Properties.Resources.orangeCar1;
            this.aiCar1.Location = new System.Drawing.Point(63, -194);
            this.aiCar1.Name = "aiCar1";
            this.aiCar1.Size = new System.Drawing.Size(109, 203);
            this.aiCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiCar1.TabIndex = 9;
            this.aiCar1.TabStop = false;
            // 
            // road2
            // 
            this.road2.Image = ((System.Drawing.Image)(resources.GetObject("road2.Image")));
            this.road2.Location = new System.Drawing.Point(-1, -836);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(1036, 859);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 2;
            this.road2.TabStop = false;
            // 
            // road1
            // 
            this.road1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.road1.Image = ((System.Drawing.Image)(resources.GetObject("road1.Image")));
            this.road1.Location = new System.Drawing.Point(-1, -1);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(1036, 859);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 0;
            this.road1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(391, 904);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(248, 104);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(83, 965);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(170, 58);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(74, 1051);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(215, 113);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "N/A";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScoreLabel.Location = new System.Drawing.Point(707, 965);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(283, 58);
            this.bestScoreLabel.TabIndex = 5;
            this.bestScoreLabel.Text = "Best Score:";
            // 
            // bestScoreText
            // 
            this.bestScoreText.AutoSize = true;
            this.bestScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScoreText.Location = new System.Drawing.Point(746, 1051);
            this.bestScoreText.Name = "bestScoreText";
            this.bestScoreText.Size = new System.Drawing.Size(215, 113);
            this.bestScoreText.TabIndex = 6;
            this.bestScoreText.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 885);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = " ";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(391, 1044);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(248, 96);
            this.pauseBtn.TabIndex = 8;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // viewScoresBtn
            // 
            this.viewScoresBtn.Location = new System.Drawing.Point(391, 1163);
            this.viewScoresBtn.Name = "viewScoresBtn";
            this.viewScoresBtn.Size = new System.Drawing.Size(248, 114);
            this.viewScoresBtn.TabIndex = 9;
            this.viewScoresBtn.Text = "View High Scores";
            this.viewScoresBtn.UseVisualStyleBackColor = true;
            this.viewScoresBtn.Click += new System.EventHandler(this.ViewScores_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 1289);
            this.Controls.Add(this.viewScoresBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestScoreText);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1092, 1377);
            this.MinimumSize = new System.Drawing.Size(1092, 1377);
            this.Name = "MainWindow";
            this.Text = "Car Racing Game";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox playerCar;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.Label bestScoreText;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.PictureBox aiCar2;
        private System.Windows.Forms.PictureBox aiCar3;
        private System.Windows.Forms.PictureBox aiCar1;
        private Button viewScoresBtn;
    }
}

