using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class HighScoresReadOnly : Form
    {
        public HighScoresReadOnly()
        {
            InitializeComponent();
        }

        // Dispaly database contents to data grid view
        private void HighScoresReadOnly_Load(object sender, EventArgs e)
        {
            HighScoreQuery query = new HighScoreQuery();
            highScoresBindingSource.DataSource = query.ShowTableData();
            dgv.DataSource = highScoresBindingSource;
        }
    }
}
