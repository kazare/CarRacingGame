
namespace CarRacingGame
{
    partial class HighScoresReadOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoresReadOnly));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.highScoresDataSet1 = new CarRacingGame.HighScoresDataSet1();
            this.highScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highScoresTableAdapter = new CarRacingGame.HighScoresDataSet1TableAdapters.HighScoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 102;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(800, 1266);
            this.dgv.TabIndex = 0;
            // 
            // highScoresDataSet1
            // 
            this.highScoresDataSet1.DataSetName = "HighScoresDataSet1";
            this.highScoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highScoresBindingSource
            // 
            this.highScoresBindingSource.DataMember = "HighScores";
            this.highScoresBindingSource.DataSource = this.highScoresDataSet1;
            // 
            // highScoresTableAdapter
            // 
            this.highScoresTableAdapter.ClearBeforeFill = true;
            // 
            // HighScoresReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 1266);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScoresReadOnly";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.HighScoresReadOnly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private HighScoresDataSet1 highScoresDataSet1;
        private System.Windows.Forms.BindingSource highScoresBindingSource;
        private HighScoresDataSet1TableAdapters.HighScoresTableAdapter highScoresTableAdapter;
    }
}