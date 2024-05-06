using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class PlayerCreation : Form
    {
        public PlayerCreation()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {
            OccupationComboBox.Items.Add("Técnico");
            OccupationComboBox.Items.Add("Veterinario");
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            bool allOk = true;
            if (NameInput.Text == "")
            {
                errorProvider1.SetError(NameInput, "El nombre no puede estar vacío");
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(NameInput, "");
            }
            if (OccupationComboBox.Text == "")
            {
                errorProvider1.SetError(OccupationComboBox, "La ocupación no puede estar vacía");
                MessageBox.Show("La ocupación no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(OccupationComboBox, "");
            }
            if (allOk)
            {
                Player player = new Player(NameInput.Text, OccupationComboBox.Text, OccupationComboBox.Text == "Técnico" ? 45 : 80);
                PlayerDAO playerDAO = new PlayerDAO();
                playerDAO.SavePlayer(player);
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                this.Hide();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            TitleWindow titleWindow = new TitleWindow();
            titleWindow.Show();
            this.Hide();
        }
    }
}
