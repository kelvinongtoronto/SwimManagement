using SwimManagementLibrary.classes;
using SwimManagementLibrary.enums;
using SwimManagementLibrary.interfaces;
using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimManagementForm_301178688
{
    public partial class FormSwimManagement : Form
    {
        IClubsRepository clbMngr;
        ISwimmersRepository swmMngr;
        int selectedClubIndex = -1;
        int selectedSwimmerIndex = -1;
        public FormSwimManagement() {
            InitializeComponent();
            clbMngr = new ClubsManager();
            swmMngr = new SwimmersManager(clbMngr);
            //listBoxSwimmer.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            btLoadSwimmers.Enabled = false;
        }

        //private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
        //    if (listBoxSwimmer.SelectedIndex >= 0)
        //    {
        //        swimmerDetails.Text = swmMngr.Swimmers[listBoxSwimmer.SelectedIndex].ToString();
        //    }
        //}

        private void btnAddClub_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtClubName.Text))
            {
                //clubDetails.Text = "Invalid club name";
                MessageBox.Show("Invalid club name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ulong clubPhoneNumber = 0;
            if (!ulong.TryParse(txtClubPhoneNumber.Text, out clubPhoneNumber))
            {
                //throw new Exception($"Phone number wrong format");
                MessageBox.Show("Phone number wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(txtClubStreet.Text, txtClubCity.Text, txtClubProvince.Text, txtClubPostalCode.Text);
            Club aClub = new Club(txtClubName.Text, address, clubPhoneNumber);

            listBoxClub.Items.Add(aClub.Name);
            clbMngr.AddClub(aClub);
            txtClubName.Text = "";
            txtClubPhoneNumber.Text = "";
            txtClubStreet.Text = "";
            txtClubCity.Text = "";
            txtClubProvince.Text = "";
            txtClubPostalCode.Text = "";
        }

        private void btSwimmer_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(txtSwimmerName.Text))
            {
                //clubDetails.Text = "Invalid club name";
                MessageBox.Show("Invalid club name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ulong swimmerPhoneNumber = 0;
            if (!ulong.TryParse(txtSwimmerPhoneNumber.Text, out swimmerPhoneNumber))
            {
                //throw new Exception($"Phone number wrong format");
                MessageBox.Show("Phone number wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(txtSwimmerStreet.Text, txtSwimmerCity.Text, txtSwimmerProvince.Text, txtSwimmerPostalCode.Text);

            Swimmer registrant = new Swimmer(txtSwimmerName.Text, txtSwimmerDob.Value, address, swimmerPhoneNumber);
            swmMngr.AddSwimmer(registrant);

            listBoxSwimmer.Items.Add(registrant.Name);

            txtSwimmerName.Text = "";
            txtSwimmerPhoneNumber.Text = "";
            txtSwimmerStreet.Text = "";
            txtSwimmerCity.Text = "";
            txtSwimmerProvince.Text = "";
            txtSwimmerPostalCode.Text = "";
        }

        private void loadSwimmer_Click(object sender, EventArgs e) {
            swmMngr.Swimmers.Clear();

            if (String.IsNullOrEmpty(txtSwimmerLoadPath.Text))
            {
                MessageBox.Show("Please enter valid swimmer file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(txtSwimmerLoadPath.Text))
            {
                MessageBox.Show("File does not exists. Please enter correct path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                swmMngr.LoadSwimmers(txtSwimmerLoadPath.Text, ",");
                displayClubInfo();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxSwimmer.Items.Clear();

            for (int i = 0; i < swmMngr.Swimmers.Count; i++)
            {
                listBoxSwimmer.Items.Add(swmMngr.Swimmers[i].Name);
            }
        }

        private void btLoadClubs_Click(object sender, EventArgs e) {
            clbMngr.Clubs.Clear();

          
            if (String.IsNullOrEmpty(txtClubLoadPath.Text))
            {
                MessageBox.Show("Please enter valid club file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(txtClubLoadPath.Text))
            {
                MessageBox.Show("File does not exists. Please enter correct path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                clbMngr.LoadClubs(txtClubLoadPath.Text, ",");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxClub.Items.Clear();

            for (int i = 0; i < clbMngr.Clubs.Count; i++)
            {
                listBoxClub.Items.Add(clbMngr.Clubs[i].Name);
            }

            btLoadSwimmers.Enabled = true;
        }

        private void assignSwimmer_Click(object sender, EventArgs e) {
            if (listBoxClub.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a club.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxSwimmer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a swimmer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Club selectedClub = clbMngr.Clubs[listBoxClub.SelectedIndex];
            Swimmer selectedSwimmer = swmMngr.Swimmers[listBoxSwimmer.SelectedIndex];

            try
            {
                selectedClub.AddSwimmer(selectedSwimmer);
                MessageBox.Show("Swimmer has been assigned successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                displayClubInfo();
                displaySwimmerInfo();
                listBoxClub.ClearSelected();
                listBoxSwimmer.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveSwimmer_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(txtSwimmerSavePath.Text))
            {
                MessageBox.Show("Please enter valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
              
                swmMngr.SaveSwimmers(txtSwimmerSavePath.Text, "|");
                MessageBox.Show("Swimmers have been saved successfully.", "Save Swimmers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveClub_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(txtClubSavePath.Text))
            {
                MessageBox.Show("Please enter valid file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                clbMngr.SaveClubs(txtClubSavePath.Text, "|");
                MessageBox.Show("Clubs have been saved successfully.", "Save Clubs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxSwimmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySwimmerInfo();
        }

        private void displaySwimmerInfo()
        {
            selectedSwimmerIndex= listBoxSwimmer.SelectedIndex;
            if (selectedSwimmerIndex >= 0 && selectedSwimmerIndex < swmMngr.Swimmers.Count)
            {
                swimmerDetails.Text = swmMngr.Swimmers[selectedSwimmerIndex].ToString();
            }
        }

        private void listBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayClubInfo();
        }

        private void displayClubInfo()
        {
            selectedClubIndex = listBoxClub.SelectedIndex;
            if (selectedClubIndex >= 0 && selectedClubIndex < clbMngr.Clubs.Count)
            {
                clubDetails.Text = clbMngr.Clubs[selectedClubIndex].ToString();
            }
               
        }

      
    }
}
