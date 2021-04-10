using SwimManagementLibrary.classes;
using SwimManagementLibrary.enums;
using SwimManagementLibrary.interfaces;
using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimManagementForm_301178688
{
    public partial class frmSwimManagement : Form
    {
        IClubsRepository clbMngr;
        ISwimmersRepository swmMngr;
        public frmSwimManagement() {
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
            if (String.IsNullOrEmpty(tbClubName.Text))
            {
                //clubDetails.Text = "Invalid club name";
                MessageBox.Show("Invalid club name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ulong clubPhoneNumber = 0;
            if (!ulong.TryParse(tbClubPhoneNumber.Text, out clubPhoneNumber))
            {
                //throw new Exception($"Phone number wrong format");
                MessageBox.Show("Phone number wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(tbClubStreet.Text, tbClubCity.Text, tbClubProvince.Text, tbClubPostalCode.Text);
            Club aClub = new Club(tbClubName.Text, address, clubPhoneNumber);

            listBoxClub.Items.Add(aClub.Name);
            clbMngr.AddClub(aClub);
            tbClubName.Text = "";
            tbClubPhoneNumber.Text = "";
            tbClubStreet.Text = "";
            tbClubCity.Text = "";
            tbClubProvince.Text = "";
            tbClubPostalCode.Text = "";
        }

        private void btSwimmer_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(tbSwimmerName.Text))
            {
                //clubDetails.Text = "Invalid club name";
                MessageBox.Show("Invalid club name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ulong swimmerPhoneNumber = 0;
            if (!ulong.TryParse(tbSwimmerPhoneNumber.Text, out swimmerPhoneNumber))
            {
                //throw new Exception($"Phone number wrong format");
                MessageBox.Show("Phone number wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address(tbSwimmerStreet.Text, tbSwimmerCity.Text, tbSwimmerProvince.Text, tbSwimmerPostalCode.Text);

            Swimmer registrant = new Swimmer(tbSwimmerName.Text, dtSwimmerDob.Value, address, swimmerPhoneNumber);
            swmMngr.AddSwimmer(registrant);

            listBoxSwimmer.Items.Add(registrant.Name);

            tbSwimmerName.Text = "";
            tbSwimmerPhoneNumber.Text = "";
            tbSwimmerStreet.Text = "";
            tbSwimmerCity.Text = "";
            tbSwimmerProvince.Text = "";
            tbSwimmerPostalCode.Text = "";
        }

        private void loadSwimmer_Click(object sender, EventArgs e) {
            swmMngr.Swimmers.Clear();

            openFileDialogSwimmer.Title = "Load Swimmers";
            openFileDialogSwimmer.DefaultExt = "txt";

            if (openFileDialogSwimmer.ShowDialog() == DialogResult.OK)
            {
                swimmerPath.Text = openFileDialogSwimmer.FileName;

                try
                {
                    swmMngr.LoadSwimmers(openFileDialogSwimmer.FileName, ",");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBoxSwimmer.Items.Clear();

                for (int i = 0; i < swmMngr.Swimmers.Count; i++)
                {
                    listBoxSwimmer.Items.Add(swmMngr.Swimmers[i].Name);
                }
            }
        }

        private void btLoadClubs_Click(object sender, EventArgs e) {
            clbMngr.Clubs.Clear();

            openFileDialogClub.Title = "Load Clubs";
            openFileDialogClub.DefaultExt = "txt";

            if (openFileDialogClub.ShowDialog() == DialogResult.OK)
            {
                clubPath.Text = openFileDialogClub.FileName;

                try
                {
                    clbMngr.LoadClubs(openFileDialogClub.FileName, ",");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBoxClub.Items.Clear();

                for (int i = 0; i < clbMngr.Clubs.Count; i++)
                {
                    listBoxClub.Items.Add(clbMngr.Clubs[i].Name);
                }

                btLoadSwimmers.Enabled = true;
            }
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
                listBoxClub.ClearSelected();
                listBoxSwimmer.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveSwimmer_Click(object sender, EventArgs e) {
            try
            {
                swmMngr.SaveSwimmers(swimmerPath.Text, ",");
                MessageBox.Show("Swimmers have been saved successfully.", "Save Swimmers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveClub_Click(object sender, EventArgs e) {
            try
            {
                clbMngr.SaveClubs(clubPath.Text, ",");
                MessageBox.Show("Clubs have been saved successfully.", "Save Clubs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxSwimmer_SelectedIndexChanged(object sender, EventArgs e) {
            int i = listBoxSwimmer.SelectedIndex;
            if(i >= 0 && i < swmMngr.Swimmers.Count)
                swimmerDetails.Text = swmMngr.Swimmers[i].ToString();
        }

        private void listBoxClub_SelectedIndexChanged(object sender, EventArgs e) {
            int i = listBoxClub.SelectedIndex;
            if(i >= 0 && i < clbMngr.Clubs.Count)
                clubDetails.Text = clbMngr.Clubs[i].ToString();
        }
    }
}
