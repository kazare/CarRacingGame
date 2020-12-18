using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class HighScoreForm : Form
    {
        // Initalize to reuse in this class
        HighScoreQuery query = new HighScoreQuery();

        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Input validation
            if (String.IsNullOrWhiteSpace(userName.Text))
            {
                MessageBox.Show("Please add a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Add username and score to database then update dgv
                query.AddScore(userName.Text, MainWindow.best);
                UpdateDGV();
                submitBtn.Enabled = false;
            }
        }

        // On window load dispaly database contents
        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            userScore.Text = MainWindow.best.ToString();
            UpdateDGV();
            submitBtn.Enabled = true;
        }

        // Method to dispaly databse info to data grid view
        private void UpdateDGV()
        {
            highScoresBindingSource.DataSource = query.ShowTableData();
            dgv.DataSource = highScoresBindingSource;
        }
    }
}