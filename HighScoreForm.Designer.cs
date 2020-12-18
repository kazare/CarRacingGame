
namespace CarRacingGame
{
    partial class HighScoreForm
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
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.highScoresDataSet = new CarRacingGame.HighScoresDataSet();
            this.highScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highScoresTableAdapter = new CarRacingGame.HighScoresDataSetTableAdapters.HighScoresTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.userScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(179, 332);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(329, 38);
            this.userName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // submitBtn
            // 
            this.submitBtn.AutoSize = true;
            this.submitBtn.Location = new System.Drawing.Point(524, 332);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(121, 42);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add your name to the high score list";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-1, 415);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 102;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(756, 806);
            this.dgv.TabIndex = 6;
            // 
            // highScoresDataSet
            // 
            this.highScoresDataSet.DataSetName = "HighScoresDataSet";
            this.highScoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highScoresBindingSource
            // 
            this.highScoresBindingSource.DataMember = "HighScores";
            this.highScoresBindingSource.DataSource = this.highScoresDataSet;
            // 
            // highScoresTableAdapter
            // 
            this.highScoresTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 113);
            this.label3.TabIndex = 7;
            this.label3.Text = "High Score:";
            // 
            // userScore
            // 
            this.userScore.AutoSize = true;
            this.userScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScore.Location = new System.Drawing.Point(298, 118);
            this.userScore.Name = "userScore";
            this.userScore.Size = new System.Drawing.Size(104, 113);
            this.userScore.TabIndex = 8;
            this.userScore.Text = "0";
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(759, 1223);
            this.Controls.Add(this.userScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Name = "HighScoreForm";
            this.ShowIcon = false;
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.HighScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private HighScoresDataSet highScoresDataSet;
        private System.Windows.Forms.BindingSource highScoresBindingSource;
        private HighScoresDataSetTableAdapters.HighScoresTableAdapter highScoresTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userScore;
    }
}