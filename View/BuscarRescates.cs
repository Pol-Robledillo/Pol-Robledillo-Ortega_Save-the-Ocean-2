using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Utils;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class BuscarRescates : Form
    {
        public BuscarRescates()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {
            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<RescueDTO> allRescues = rescueDAO.GetRescues();
            IdComboBox.Items.Clear();
            IdComboBox.Items.Add(" ");
            foreach (RescueDTO rescue in allRescues)
            {
                IdComboBox.Items.Add(rescue.Id);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (IdComboBox.Text == "" || IdComboBox.Text == " ")
            {
                RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                List<RescueDTO> allRescues = rescueDAO.GetRescues();
                RescuesDataGrid.Rows.Clear();
                foreach (RescueDTO rescue in allRescues)
                {
                    int rowIndex = RescuesDataGrid.Rows.Add();
                    DataGridViewRow row = RescuesDataGrid.Rows[rowIndex];
                    row.Cells["NumRescate"].Value = rescue.NumRescue;
                    row.Cells["Fecha"].Value = rescue.Date;
                    row.Cells["Localizacion"].Value = rescue.Location;
                }
            }
            else
            {
                RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                RescueDTO rescue = rescueDAO.GetRescueById(int.Parse(IdComboBox.Text));
                RescuesDataGrid.Rows.Clear();
                int rowIndex = RescuesDataGrid.Rows.Add();
                DataGridViewRow row = RescuesDataGrid.Rows[rowIndex];
                row.Cells["NumRescate"].Value = rescue.NumRescue;
                row.Cells["Fecha"].Value = rescue.Date;
                row.Cells["Localizacion"].Value = rescue.Location;
            }
        }

        private void BuscarRescates_Load(object sender, EventArgs e)
        {
            RescuesDataGrid.Columns.Add("NumRescate", "NumRescate");
            RescuesDataGrid.Columns.Add("Fecha", "Fecha");
            RescuesDataGrid.Columns.Add("Localizacion", "Localizacion");
        }
    }
}
