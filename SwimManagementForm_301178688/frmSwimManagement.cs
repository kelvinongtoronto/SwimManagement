using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimManagementLibrary.classes;
using SwimManagementLibrary.enums;
using SwimManagementLibrary.structs;
using SwimManagementLibrary.interfaces;

namespace SwimManagementForm_301178688
{
    public partial class frmSwimManagement : Form
    {
        public frmSwimManagement() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            IClubsRepository clbMngr = new ClubsManager();
            try
            {
                clbMngr.LoadClubs(@"C:\A2\Clubs.txt", ",");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach(Club club in clbMngr.Clubs)
            {
                ListViewItem lvi = new ListViewItem(club.ClubNumber.ToString());
                lvi.SubItems.Add(club.Name);
                lvi.SubItems.Add(club.ClubAddress.ToString());
                lvi.SubItems.Add(club.PhoneNumber.ToString());
                lvi.SubItems.Add(club.Coach != null ? club.Coach.Name : "");
                lvClubs.Items.Add(lvi);
            }

            ISwimmersRepository swmMngr = new SwimmersManager(clbMngr);
            try
            {
                swmMngr.LoadSwimmers(@"C:\A2\Swimmers.txt", ",");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach(Swimmer swimmer in swmMngr.Swimmers)
            {
                ListViewItem lvi = new ListViewItem(swimmer.Id.ToString());
                lvi.SubItems.Add(swimmer.Name);
                lvi.SubItems.Add(swimmer.DateOfBirth.ToString());
                lvi.SubItems.Add(swimmer.Address.ToString());
                lvi.SubItems.Add(swimmer.PhoneNumber.ToString());
                lvi.SubItems.Add(swimmer.Club != null ? swimmer.Club.Name : "(none)");
                lvSwimmers.Items.Add(lvi);
            }
        }
    }
}
