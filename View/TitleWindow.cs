using Pol_Robledillo_Ortega___Save_the_Ocean_2.View;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2
{
    public partial class TitleWindow : Form
    {
        public TitleWindow()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlayerCreation playerCreationWindow = new PlayerCreation();
            playerCreationWindow.Show();
            this.Hide();
        }

        private void TitleWindow_Load(object sender, EventArgs e)
        {
            BestGamesGrid.Columns.Add("Name", "Name");
            BestGamesGrid.Columns.Add("Exp", "Exp");
            BestGamesGrid.Columns.Add("Occupation", "Occupation");
            FillGrid();
        }

        private void FillGrid()
        {
            PlayerDAO playerDAO = new PlayerDAO();
            List<Player> players = playerDAO.GetPlayers();
            players.Sort((x, y) => y.Exp.CompareTo(x.Exp));
            for (int i = 0; i < (players.Count() >= 5 ? 5 : players.Count()); i++)
            {
                int rowIndex = BestGamesGrid.Rows.Add();
                DataGridViewRow row = BestGamesGrid.Rows[rowIndex];
                row.Cells["Name"].Value = players[i].Name;
                row.Cells["Exp"].Value = players[i].Exp;
                row.Cells["Occupation"].Value = players[i].Occupation;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
