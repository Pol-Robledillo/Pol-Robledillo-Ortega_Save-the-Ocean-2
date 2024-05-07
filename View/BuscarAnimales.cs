using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Utils;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class BuscarAnimales : Form
    {
        public BuscarAnimales()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
            List<CetaceanDTO> allAnimals = cetaceanDAO.GetCetaceans();
            IdComboBox.Items.Clear();
            IdComboBox.Items.Add(" ");
            foreach (CetaceanDTO animal in allAnimals)
            {
                IdComboBox.Items.Add(animal.Id);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (IdComboBox.Text == "" || IdComboBox.Text == " ")
            {
                CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                List<CetaceanDTO> allAnimals = cetaceanDAO.GetCetaceans();
                AnimalsDataGrid.Rows.Clear();
                foreach (CetaceanDTO animal in allAnimals)
                {
                    int rowIndex = AnimalsDataGrid.Rows.Add();
                    DataGridViewRow row = AnimalsDataGrid.Rows[rowIndex];
                    row.Cells["Nombre"].Value = animal.Name;
                    row.Cells["SuperFamilia"].Value = animal.SuperFamily;
                    row.Cells["Especie"].Value = animal.Species;
                    row.Cells["GA"].Value = animal.GA;
                    row.Cells["Peso"].Value = animal.Weight;
                }
            }
            else
            {
                CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                CetaceanDTO animal = cetaceanDAO.GetCetaceanById(int.Parse(IdComboBox.Text));
                AnimalsDataGrid.Rows.Clear();
                int rowIndex = AnimalsDataGrid.Rows.Add();
                DataGridViewRow row = AnimalsDataGrid.Rows[rowIndex];
                row.Cells["Nombre"].Value = animal.Name;
                row.Cells["SuperFamilia"].Value = animal.SuperFamily;
                row.Cells["Especie"].Value = animal.Species;
                row.Cells["GA"].Value = animal.GA;
                row.Cells["Peso"].Value = animal.Weight;
            }
        }

        private void BuscarAnimales_Load(object sender, EventArgs e)
        {
            AnimalsDataGrid.Columns.Add("Nombre", "Nombre");
            AnimalsDataGrid.Columns.Add("SuperFamilia", "SuperFamilia");
            AnimalsDataGrid.Columns.Add("Especie", "Especie");
            AnimalsDataGrid.Columns.Add("GA", "GA");
            AnimalsDataGrid.Columns.Add("Peso", "Peso");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
