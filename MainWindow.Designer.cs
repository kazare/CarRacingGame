using System.Drawing;

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
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.bestScoreText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.orangeCar = new System.Windows.Forms.PictureBox();
            this.greenCar = new System.Windows.Forms.PictureBox();
            this.brownCar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(121)))), ((int)(((byte)(137)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.brownCar);
            this.panel1.Controls.Add(this.greenCar);
            this.panel1.Controls.Add(this.orangeCar);
            this.panel1.Controls.Add(this.playerCar);
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
            this.playerCar.Image = ((System.Drawing.Image)(resources.GetObject("playerCar.Image")));
            this.playerCar.Location = new System.Drawing.Point(466, 633);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(109, 203);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCar.TabIndex = 1;
            this.playerCar.TabStop = false;
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
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(391, 976);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(248, 134);
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
            this.label1.Location = new System.Drawing.Point(38, 885);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avoid all obstacles! Move left and right with the arrow keys or A and D";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(391, 1131);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(248, 134);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // orangeCar
            // 
            this.orangeCar.Image = ((System.Drawing.Image)(resources.GetObject("orangeCar.Image")));
            this.orangeCar.Location = new System.Drawing.Point(63, 194);
            this.orangeCar.Name = "orangeCar";
            this.orangeCar.Size = new System.Drawing.Size(109, 203);
            this.orangeCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangeCar.TabIndex = 9;
            this.orangeCar.TabStop = false;
            // 
            // greenCar
            // 
            this.greenCar.Image = ((System.Drawing.Image)(resources.GetObject("greenCar.Image")));
            this.greenCar.Location = new System.Drawing.Point(684, 422);
            this.greenCar.Name = "greenCar";
            this.greenCar.Size = new System.Drawing.Size(109, 203);
            this.greenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenCar.TabIndex = 10;
            this.greenCar.TabStop = false;
            // 
            // brownCar
            // 
            this.brownCar.Image = ((System.Drawing.Image)(resources.GetObject("brownCar.Image")));
            this.brownCar.Location = new System.Drawing.Point(466, -90);
            this.brownCar.Name = "brownCar";
            this.brownCar.Size = new System.Drawing.Size(109, 206);
            this.brownCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brownCar.TabIndex = 11;
            this.brownCar.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 1289);
            this.Controls.Add(this.stopBtn);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownCar)).EndInit();
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
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.PictureBox brownCar;
        private System.Windows.Forms.PictureBox greenCar;
        private System.Windows.Forms.PictureBox orangeCar;
    }
}

