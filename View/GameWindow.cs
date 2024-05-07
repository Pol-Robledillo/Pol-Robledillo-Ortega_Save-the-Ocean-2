using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Utils;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class GameWindow : Form
    {
        public static List<RescueDTO> rescues = new List<RescueDTO>();
        public static bool rescued = false;
        public static PlayerDTO player = new PlayerDTO();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TitleWindow titleWindow = new TitleWindow();
            rescues.Clear();
            rescued = false;
            titleWindow.Show();
            this.Hide();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            PlayerDAO playerDAO = new PlayerDAO();
            List<PlayerDTO> players = playerDAO.GetPlayers();
            player = players[players.Count - 1];
            GameExpValueLbl.Text = Convert.ToString(player.Exp);

            RescuesDataGrid.Columns.Add("NumRescate", "NumRescate");
            RescuesDataGrid.Columns.Add("Fecha", "Fecha");
            RescuesDataGrid.Columns.Add("Localizacion", "Localizacion");
            LoadRandomRescue();

            AnimalsInfoDataGrid.Columns.Add("Nombre", "Nombre");
            AnimalsInfoDataGrid.Columns.Add("SuperFamilia", "SuperFamilia");
            AnimalsInfoDataGrid.Columns.Add("Especie", "Especie");
            AnimalsInfoDataGrid.Columns.Add("GA", "GA");
            AnimalsInfoDataGrid.Columns.Add("Peso", "Peso");
            LoadAnimal();
        }
        private void LoadRandomRescue()
        {
            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<RescueDTO> allRescues = rescueDAO.GetRescues();

            Random random = new Random();
            int randomIndex = random.Next(0, allRescues.Count);
            RescueDTO randomRescue = allRescues[randomIndex];

            RescuesDataGrid.Rows.Clear();
            int rowIndex = RescuesDataGrid.Rows.Add();
            DataGridViewRow row = RescuesDataGrid.Rows[rowIndex];
            row.Cells["NumRescate"].Value = randomRescue.NumRescue;
            row.Cells["Fecha"].Value = randomRescue.Date;
            row.Cells["Localizacion"].Value = randomRescue.Location;

            rescues.Add(randomRescue);
        }
        private void LoadAnimal()
        {
            AnimalsInfoDataGrid.Rows.Clear();
            int rowIndex = AnimalsInfoDataGrid.Rows.Add();
            DataGridViewRow row = AnimalsInfoDataGrid.Rows[rowIndex];

            switch (rescues[rescues.Count - 1].SuperFamily)
            {
                case "Cetaceo":
                    CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                    CetaceanDTO cetacean = cetaceanDAO.GetCetaceanById(rescues[rescues.Count - 1].AnimalId);

                    row.Cells["Nombre"].Value = cetacean.Name;
                    row.Cells["SuperFamilia"].Value = cetacean.SuperFamily;
                    row.Cells["Especie"].Value = cetacean.Species;
                    row.Cells["GA"].Value = cetacean.GA;
                    row.Cells["Peso"].Value = cetacean.Weight;
                    break;
                case "Tortuga Marina":
                    SeaTurtleDAO seaTurtleDAO = new SeaTurtleDAO(NpgsqlUtils.OpenConnection());
                    SeaTurtleDTO seaTurtle = seaTurtleDAO.GetSeaTurtleById(rescues[rescues.Count - 1].AnimalId);

                    row.Cells["Nombre"].Value = seaTurtle.Name;
                    row.Cells["SuperFamilia"].Value = seaTurtle.SuperFamily;
                    row.Cells["Especie"].Value = seaTurtle.Species;
                    row.Cells["GA"].Value = seaTurtle.GA;
                    row.Cells["Peso"].Value = seaTurtle.Weight;
                    break;
                case "Ave Marina":
                    SeaBirdDAO seaBirdDAO = new SeaBirdDAO(NpgsqlUtils.OpenConnection());
                    SeaBirdDTO seaBird = seaBirdDAO.GetSeaBirdById(rescues[rescues.Count - 1].AnimalId);

                    row.Cells["Nombre"].Value = seaBird.Name;
                    row.Cells["SuperFamilia"].Value = seaBird.SuperFamily;
                    row.Cells["Especie"].Value = seaBird.Species;
                    row.Cells["GA"].Value = seaBird.GA;
                    row.Cells["Peso"].Value = seaBird.Weight;
                    break;
            }
        }

        private void SearchRescuesButton_Click(object sender, EventArgs e)
        {
            BuscarRescates buscarRescates = new BuscarRescates();
            buscarRescates.Show();
        }

        private void SearchAnimalsButton_Click(object sender, EventArgs e)
        {
            BuscarAnimales buscarAnimales = new BuscarAnimales();
            buscarAnimales.Show();
        }

        private void NewRescueButton_Click(object sender, EventArgs e)
        {
            CreacionRescate creacionRescate = new CreacionRescate();
            creacionRescate.Show();
        }

        private void MoveAnimalButton_Click(object sender, EventArgs e)
        {
            if (rescued == false)
            {
                if (rescues[rescues.Count() - 1].SuperFamily == "Cetaceo")
                {
                    MessageBox.Show("No puedes trasladar un cetaceo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    switch (rescues[rescues.Count() - 1].SuperFamily)
                    {
                        case "Tortuga Marina":
                            SeaTurtleDAO seaTurtleDAO = new SeaTurtleDAO(NpgsqlUtils.OpenConnection());
                            SeaTurtleDTO seaTurtle = seaTurtleDAO.GetSeaTurtleById(rescues[rescues.Count() - 1].AnimalId);
                            if (seaTurtle.CalcNewGA())
                            {
                                MessageBox.Show("El rescate ha sido un exito. Ganas 50 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player.Exp += 50;
                            }
                            else
                            {
                                MessageBox.Show("El rescate ha sido un fracaso. Pierdes 20 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player.Exp -= 20;
                            }
                            break;
                        case "Ave Marina":
                            SeaBirdDAO seaBirdDAO = new SeaBirdDAO(NpgsqlUtils.OpenConnection());
                            SeaBirdDTO seaBird = seaBirdDAO.GetSeaBirdById(rescues[rescues.Count() - 1].AnimalId);
                            if (seaBird.CalcNewGA())
                            {
                                MessageBox.Show("El rescate ha sido un exito. Ganas 50 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player.Exp += 50;
                            }
                            else
                            {
                                MessageBox.Show("El rescate ha sido un fracaso. Pierdes 20 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                player.Exp -= 20;
                            }
                            break;
                    }
                    PlayerDAO playerDAO = new PlayerDAO();
                    playerDAO.UpdatePlayer(player);
                    rescued = true;
                    GameExpValueLbl.Text = Convert.ToString(player.Exp);
                }
            }
            else
            {
                MessageBox.Show("Ya has finalizado este rescate", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            if (rescued == false)
            {
                switch (rescues[rescues.Count() - 1].SuperFamily)
                {
                    case "Tortuga Marina":
                        SeaTurtleDAO seaTurtleDAO = new SeaTurtleDAO(NpgsqlUtils.OpenConnection());
                        SeaTurtleDTO seaTurtle = seaTurtleDAO.GetSeaTurtleById(rescues[rescues.Count() - 1].AnimalId);
                        if (seaTurtle.CalcNewGA())
                        {
                            MessageBox.Show("El rescate ha sido un exito. Ganas 50 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp += 50;
                        }
                        else
                        {
                            MessageBox.Show("El rescate ha sido un fracaso. Pierdes 20 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp -= 20;
                        }
                        break;
                    case "Ave Marina":
                        SeaBirdDAO seaBirdDAO = new SeaBirdDAO(NpgsqlUtils.OpenConnection());
                        SeaBirdDTO seaBird = seaBirdDAO.GetSeaBirdById(rescues[rescues.Count() - 1].AnimalId);
                        if (seaBird.CalcNewGA())
                        {
                            MessageBox.Show("El rescate ha sido un exito. Ganas 50 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp += 50;
                        }
                        else
                        {
                            MessageBox.Show("El rescate ha sido un fracaso. Pierdes 20 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp -= 20;
                        }
                        break;
                    case "Cetaceo":
                        CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                        CetaceanDTO cetacean = cetaceanDAO.GetCetaceanById(rescues[rescues.Count() - 1].AnimalId);
                        if (cetacean.CalcNewGA())
                        {
                            MessageBox.Show("El rescate ha sido un exito. Ganas 50 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp += 50;
                        }
                        else
                        {
                            MessageBox.Show("El rescate ha sido un fracaso. Pierdes 20 puntos de experiencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player.Exp -= 20;
                        }
                        break;
                }
                PlayerDAO playerDAO = new PlayerDAO();
                playerDAO.UpdatePlayer(player);
                rescued = true;
                GameExpValueLbl.Text = Convert.ToString(player.Exp);
            }
            else
            {
                MessageBox.Show("Ya has finalizado este rescate", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NextRescueButton_Click(object sender, EventArgs e)
        {
            if (rescued == true)
            {
                LoadRandomRescue();
                LoadAnimal();
                rescued = false;
            }
            else
            {
                MessageBox.Show("Debes finalizar el rescate actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NewAnimalButton_Click(object sender, EventArgs e)
        {
            CreacionAnimal creacionAnimal = new CreacionAnimal();
            creacionAnimal.Show();
        }
    }
}
