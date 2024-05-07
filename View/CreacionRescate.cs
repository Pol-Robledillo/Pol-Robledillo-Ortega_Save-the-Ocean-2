using Pol_Robledillo_Ortega___Save_the_Ocean_2.DTOs;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Mapping;
using Pol_Robledillo_Ortega___Save_the_Ocean_2.Persistence.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class CreacionRescate : Form
    {
        public CreacionRescate()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreacionRescate_Load(object sender, EventArgs e)
        {
            CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
            List<CetaceanDTO> allAnimals = cetaceanDAO.GetCetaceans();
            IdComboBox.Items.Clear();
            foreach (CetaceanDTO animal in allAnimals)
            {
                IdComboBox.Items.Add(animal.Id);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool allOk = true;
            if (IdComboBox.Text == "")
            {
                errorProvider1.SetError(IdComboBox, "El id no puede estar vacío");
                MessageBox.Show("El id no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(IdComboBox, "");
            }
            if (IdComboBox.Text == "")
            {
                errorProvider1.SetError(IdComboBox, "La ID del animal no puede estar vacía");
                MessageBox.Show("La ID del animal no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(IdComboBox, "");
            }
            if (allOk)
            {
                CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                CetaceanDTO animal = cetaceanDAO.GetCetaceanById(Convert.ToInt32(IdComboBox.Text));
                RescueDTO rescue = new RescueDTO();
                rescue.NumRescue = RescueDTO.GenerateNumRescue();
                rescue.Date = DateTime.Now;
                rescue.SuperFamily = animal.SuperFamily;
                rescue.Location = LocationTextBox.Text;
                rescue.AnimalId = Convert.ToInt32(IdComboBox.Text);

                RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                rescueDAO.AddRescue(rescue);
                MessageBox.Show("Rescate creado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
