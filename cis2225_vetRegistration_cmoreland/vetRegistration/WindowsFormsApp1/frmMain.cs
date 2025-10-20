using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cis2255_vetRegistration_cmoreland
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] animalType = { "Dog", "Cat", "Horse", "Pig", "Rabbit" };
            foreach (string animal in animalType)
            {
                cmbAnimalType.Items.Add(animal);
            }

            string[] visitReason = { "Not Well", "Vaccinations", "Infection", "Check-Up" };
            foreach (string visit in visitReason)
            {
                cmbReason.Items.Add(visit);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtPetName.TextLength == 0 || this.cmbAnimalType.SelectedIndex == -1 || this.cmbReason.SelectedIndex == -1 || this.txtPhoneNum.TextLength == 0)
            {
                MessageBox.Show("Error missing fields.");
            } else
            {
                Registration reg = new Registration(txtPetName.Text, cmbAnimalType.Text, dtpBirth.Text, cmbReason.Text, txtPhoneNum.Text);
                Registration.allRegistrations.Add(reg);

                lstAppointments.Items.Clear();
                foreach (Registration r in Registration.allRegistrations)
                {
                    lstAppointments.Items.Add(r.ToString());
                }

                txtPetName.Clear();
                cmbAnimalType.SelectedIndex = -1;
                dtpBirth.Value = DateTime.Now;
                cmbReason.SelectedIndex = -1;
                txtPhoneNum.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Registration.allRegistrations = null;
            lstAppointments.Items.Clear();
        }
    }
}
