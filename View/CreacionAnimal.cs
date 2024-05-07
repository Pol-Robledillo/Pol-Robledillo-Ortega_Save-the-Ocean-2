using Pol_Robledillo_Ortega___Save_the_Ocean_2.Business.Helpers;
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

namespace Pol_Robledillo_Ortega___Save_the_Ocean_2.View
{
    public partial class CreacionAnimal : Form
    {
        public CreacionAnimal()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreacionAnimal_Load(object sender, EventArgs e)
        {
            SuperFamilySelect.Items.Clear();
            SuperFamilySelect.Items.Add("Cetaceo");
            SuperFamilySelect.Items.Add("Tortuga Marina");
            SuperFamilySelect.Items.Add("Ave Marina");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
            if (SuperFamilySelect.Text == "")
            {
                errorProvider1.SetError(SuperFamilySelect, "La super familia no puede estar vacía");
                MessageBox.Show("La super familia no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(SuperFamilySelect, "");
            }
            if (SpeciesInput.Text == "")
            {
                errorProvider1.SetError(SpeciesInput, "La especie no puede estar vacía");
                MessageBox.Show("La especie no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(SpeciesInput, "");
            }
            if (WeightInput.Text == "")
            {
                errorProvider1.SetError(WeightInput, "El peso no puede estar vacío");
                MessageBox.Show("El peso no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allOk = false;
            }
            else
            {
                errorProvider1.SetError(WeightInput, "");
            }
            if (allOk)
            {
                Random random = new Random();
                CetaceanDTO animal = new CetaceanDTO();
                animal.Name = NameInput.Text;
                animal.SuperFamily = SuperFamilySelect.Text;
                animal.Species = SpeciesInput.Text;
                animal.GA = random.Next(1, 100);
                animal.Weight = Convert.ToInt32(WeightInput.Text);

                CetaceanDAO cetaceanDAO = new CetaceanDAO(NpgsqlUtils.OpenConnection());
                cetaceanDAO.AddCetacean(animal);
                MessageBox.Show("Animal creado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
