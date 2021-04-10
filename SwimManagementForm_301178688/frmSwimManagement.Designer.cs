
namespace SwimManagementForm_301178688
{
    partial class frmSwimManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxSwimmer = new System.Windows.Forms.ListBox();
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.swimmerGroup = new System.Windows.Forms.GroupBox();
            this.dtSwimmerDob = new System.Windows.Forms.DateTimePicker();
            this.btSaveSwimmer = new System.Windows.Forms.Button();
            this.swimmerPath = new System.Windows.Forms.Label();
            this.btLoadSwimmers = new System.Windows.Forms.Button();
            this.swimmerDetails = new System.Windows.Forms.Label();
            this.btSwimmer = new System.Windows.Forms.Button();
            this.lbSwimDob = new System.Windows.Forms.Label();
            this.lbSwimPhone = new System.Windows.Forms.Label();
            this.lvSwimPost = new System.Windows.Forms.Label();
            this.lbSwimProv = new System.Windows.Forms.Label();
            this.lbSwimCity = new System.Windows.Forms.Label();
            this.lbSwimStreet = new System.Windows.Forms.Label();
            this.lbSwimName = new System.Windows.Forms.Label();
            this.tbSwimmerStreet = new System.Windows.Forms.TextBox();
            this.tbSwimmerCity = new System.Windows.Forms.TextBox();
            this.tbSwimmerProvince = new System.Windows.Forms.TextBox();
            this.tbSwimmerPostalCode = new System.Windows.Forms.TextBox();
            this.tbSwimmerPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSwimmerName = new System.Windows.Forms.TextBox();
            this.clubGroup = new System.Windows.Forms.GroupBox();
            this.btSaveClub = new System.Windows.Forms.Button();
            this.btAssignSwimmer = new System.Windows.Forms.Button();
            this.clubPath = new System.Windows.Forms.Label();
            this.btLoadClubs = new System.Windows.Forms.Button();
            this.btAddClub = new System.Windows.Forms.Button();
            this.clubDetails = new System.Windows.Forms.Label();
            this.lbClubPhone = new System.Windows.Forms.Label();
            this.lbClubPost = new System.Windows.Forms.Label();
            this.lbClubProv = new System.Windows.Forms.Label();
            this.lbClubCity = new System.Windows.Forms.Label();
            this.lbClubStreet = new System.Windows.Forms.Label();
            this.lbClubName = new System.Windows.Forms.Label();
            this.tbClubStreet = new System.Windows.Forms.TextBox();
            this.tbClubCity = new System.Windows.Forms.TextBox();
            this.tbClubProvince = new System.Windows.Forms.TextBox();
            this.tbClubPostalCode = new System.Windows.Forms.TextBox();
            this.tbClubPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbClubName = new System.Windows.Forms.TextBox();
            this.openFileDialogSwimmer = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogClub = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSwimmer = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogClub = new System.Windows.Forms.SaveFileDialog();
            this.swimmerGroup.SuspendLayout();
            this.clubGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSwimmer
            // 
            this.listBoxSwimmer.FormattingEnabled = true;
            this.listBoxSwimmer.Location = new System.Drawing.Point(15, 63);
            this.listBoxSwimmer.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSwimmer.Name = "listBoxSwimmer";
            this.listBoxSwimmer.Size = new System.Drawing.Size(176, 121);
            this.listBoxSwimmer.TabIndex = 53;
            this.listBoxSwimmer.SelectedIndexChanged += new System.EventHandler(this.listBoxSwimmer_SelectedIndexChanged);
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.Location = new System.Drawing.Point(15, 63);
            this.listBoxClub.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(176, 121);
            this.listBoxClub.TabIndex = 3;
            this.listBoxClub.SelectedIndexChanged += new System.EventHandler(this.listBoxClub_SelectedIndexChanged);
            // 
            // swimmerGroup
            // 
            this.swimmerGroup.Controls.Add(this.dtSwimmerDob);
            this.swimmerGroup.Controls.Add(this.btSaveSwimmer);
            this.swimmerGroup.Controls.Add(this.swimmerPath);
            this.swimmerGroup.Controls.Add(this.btLoadSwimmers);
            this.swimmerGroup.Controls.Add(this.swimmerDetails);
            this.swimmerGroup.Controls.Add(this.btSwimmer);
            this.swimmerGroup.Controls.Add(this.lbSwimDob);
            this.swimmerGroup.Controls.Add(this.lbSwimPhone);
            this.swimmerGroup.Controls.Add(this.lvSwimPost);
            this.swimmerGroup.Controls.Add(this.lbSwimProv);
            this.swimmerGroup.Controls.Add(this.lbSwimCity);
            this.swimmerGroup.Controls.Add(this.lbSwimStreet);
            this.swimmerGroup.Controls.Add(this.lbSwimName);
            this.swimmerGroup.Controls.Add(this.tbSwimmerStreet);
            this.swimmerGroup.Controls.Add(this.tbSwimmerCity);
            this.swimmerGroup.Controls.Add(this.tbSwimmerProvince);
            this.swimmerGroup.Controls.Add(this.tbSwimmerPostalCode);
            this.swimmerGroup.Controls.Add(this.tbSwimmerPhoneNumber);
            this.swimmerGroup.Controls.Add(this.tbSwimmerName);
            this.swimmerGroup.Controls.Add(this.listBoxSwimmer);
            this.swimmerGroup.Location = new System.Drawing.Point(471, 10);
            this.swimmerGroup.Margin = new System.Windows.Forms.Padding(2);
            this.swimmerGroup.Name = "swimmerGroup";
            this.swimmerGroup.Padding = new System.Windows.Forms.Padding(2);
            this.swimmerGroup.Size = new System.Drawing.Size(433, 433);
            this.swimmerGroup.TabIndex = 50;
            this.swimmerGroup.TabStop = false;
            this.swimmerGroup.Text = "Swimmer";
            // 
            // dtSwimmerDob
            // 
            this.dtSwimmerDob.Location = new System.Drawing.Point(292, 205);
            this.dtSwimmerDob.Name = "dtSwimmerDob";
            this.dtSwimmerDob.Size = new System.Drawing.Size(120, 20);
            this.dtSwimmerDob.TabIndex = 60;
            // 
            // btSaveSwimmer
            // 
            this.btSaveSwimmer.Location = new System.Drawing.Point(15, 199);
            this.btSaveSwimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveSwimmer.Name = "btSaveSwimmer";
            this.btSaveSwimmer.Size = new System.Drawing.Size(120, 20);
            this.btSaveSwimmer.TabIndex = 52;
            this.btSaveSwimmer.Text = "Save Swimmers";
            this.btSaveSwimmer.UseVisualStyleBackColor = true;
            this.btSaveSwimmer.Click += new System.EventHandler(this.btSaveSwimmer_Click);
            // 
            // swimmerPath
            // 
            this.swimmerPath.AutoSize = true;
            this.swimmerPath.Location = new System.Drawing.Point(138, 28);
            this.swimmerPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swimmerPath.Name = "swimmerPath";
            this.swimmerPath.Size = new System.Drawing.Size(0, 13);
            this.swimmerPath.TabIndex = 98;
            // 
            // btLoadSwimmers
            // 
            this.btLoadSwimmers.Location = new System.Drawing.Point(15, 24);
            this.btLoadSwimmers.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadSwimmers.Name = "btLoadSwimmers";
            this.btLoadSwimmers.Size = new System.Drawing.Size(120, 20);
            this.btLoadSwimmers.TabIndex = 51;
            this.btLoadSwimmers.Text = "Load Swimmers";
            this.btLoadSwimmers.UseVisualStyleBackColor = true;
            this.btLoadSwimmers.Click += new System.EventHandler(this.loadSwimmer_Click);
            // 
            // swimmerDetails
            // 
            this.swimmerDetails.AutoSize = true;
            this.swimmerDetails.Location = new System.Drawing.Point(15, 240);
            this.swimmerDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.swimmerDetails.Name = "swimmerDetails";
            this.swimmerDetails.Size = new System.Drawing.Size(0, 13);
            this.swimmerDetails.TabIndex = 99;
            // 
            // btSwimmer
            // 
            this.btSwimmer.Location = new System.Drawing.Point(292, 267);
            this.btSwimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btSwimmer.Name = "btSwimmer";
            this.btSwimmer.Size = new System.Drawing.Size(120, 20);
            this.btSwimmer.TabIndex = 61;
            this.btSwimmer.Text = "Add Swimmer";
            this.btSwimmer.UseVisualStyleBackColor = true;
            this.btSwimmer.Click += new System.EventHandler(this.btSwimmer_Click);
            // 
            // lbSwimDob
            // 
            this.lbSwimDob.AutoSize = true;
            this.lbSwimDob.Location = new System.Drawing.Point(210, 206);
            this.lbSwimDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimDob.Name = "lbSwimDob";
            this.lbSwimDob.Size = new System.Drawing.Size(66, 13);
            this.lbSwimDob.TabIndex = 97;
            this.lbSwimDob.Text = "Date of Birth";
            // 
            // lbSwimPhone
            // 
            this.lbSwimPhone.AutoSize = true;
            this.lbSwimPhone.Location = new System.Drawing.Point(210, 183);
            this.lbSwimPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimPhone.Name = "lbSwimPhone";
            this.lbSwimPhone.Size = new System.Drawing.Size(78, 13);
            this.lbSwimPhone.TabIndex = 96;
            this.lbSwimPhone.Text = "Phone Number";
            // 
            // lvSwimPost
            // 
            this.lvSwimPost.AutoSize = true;
            this.lvSwimPost.Location = new System.Drawing.Point(210, 159);
            this.lvSwimPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvSwimPost.Name = "lvSwimPost";
            this.lvSwimPost.Size = new System.Drawing.Size(64, 13);
            this.lvSwimPost.TabIndex = 95;
            this.lvSwimPost.Text = "Postal Code";
            // 
            // lbSwimProv
            // 
            this.lbSwimProv.AutoSize = true;
            this.lbSwimProv.Location = new System.Drawing.Point(210, 136);
            this.lbSwimProv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimProv.Name = "lbSwimProv";
            this.lbSwimProv.Size = new System.Drawing.Size(49, 13);
            this.lbSwimProv.TabIndex = 94;
            this.lbSwimProv.Text = "Province";
            // 
            // lbSwimCity
            // 
            this.lbSwimCity.AutoSize = true;
            this.lbSwimCity.Location = new System.Drawing.Point(210, 113);
            this.lbSwimCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimCity.Name = "lbSwimCity";
            this.lbSwimCity.Size = new System.Drawing.Size(24, 13);
            this.lbSwimCity.TabIndex = 93;
            this.lbSwimCity.Text = "City";
            // 
            // lbSwimStreet
            // 
            this.lbSwimStreet.AutoSize = true;
            this.lbSwimStreet.Location = new System.Drawing.Point(210, 89);
            this.lbSwimStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimStreet.Name = "lbSwimStreet";
            this.lbSwimStreet.Size = new System.Drawing.Size(35, 13);
            this.lbSwimStreet.TabIndex = 92;
            this.lbSwimStreet.Text = "Street";
            // 
            // lbSwimName
            // 
            this.lbSwimName.AutoSize = true;
            this.lbSwimName.Location = new System.Drawing.Point(210, 66);
            this.lbSwimName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSwimName.Name = "lbSwimName";
            this.lbSwimName.Size = new System.Drawing.Size(80, 13);
            this.lbSwimName.TabIndex = 91;
            this.lbSwimName.Text = "Swimmer Name";
            // 
            // tbSwimmerStreet
            // 
            this.tbSwimmerStreet.Location = new System.Drawing.Point(292, 87);
            this.tbSwimmerStreet.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerStreet.Name = "tbSwimmerStreet";
            this.tbSwimmerStreet.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerStreet.TabIndex = 55;
            // 
            // tbSwimmerCity
            // 
            this.tbSwimmerCity.Location = new System.Drawing.Point(292, 110);
            this.tbSwimmerCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerCity.Name = "tbSwimmerCity";
            this.tbSwimmerCity.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerCity.TabIndex = 56;
            // 
            // tbSwimmerProvince
            // 
            this.tbSwimmerProvince.Location = new System.Drawing.Point(292, 133);
            this.tbSwimmerProvince.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerProvince.Name = "tbSwimmerProvince";
            this.tbSwimmerProvince.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerProvince.TabIndex = 57;
            // 
            // tbSwimmerPostalCode
            // 
            this.tbSwimmerPostalCode.Location = new System.Drawing.Point(292, 157);
            this.tbSwimmerPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerPostalCode.Name = "tbSwimmerPostalCode";
            this.tbSwimmerPostalCode.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerPostalCode.TabIndex = 58;
            // 
            // tbSwimmerPhoneNumber
            // 
            this.tbSwimmerPhoneNumber.Location = new System.Drawing.Point(292, 180);
            this.tbSwimmerPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerPhoneNumber.Name = "tbSwimmerPhoneNumber";
            this.tbSwimmerPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerPhoneNumber.TabIndex = 59;
            // 
            // tbSwimmerName
            // 
            this.tbSwimmerName.Location = new System.Drawing.Point(292, 63);
            this.tbSwimmerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSwimmerName.Name = "tbSwimmerName";
            this.tbSwimmerName.Size = new System.Drawing.Size(120, 20);
            this.tbSwimmerName.TabIndex = 54;
            // 
            // clubGroup
            // 
            this.clubGroup.Controls.Add(this.btSaveClub);
            this.clubGroup.Controls.Add(this.btAssignSwimmer);
            this.clubGroup.Controls.Add(this.clubPath);
            this.clubGroup.Controls.Add(this.btLoadClubs);
            this.clubGroup.Controls.Add(this.btAddClub);
            this.clubGroup.Controls.Add(this.clubDetails);
            this.clubGroup.Controls.Add(this.lbClubPhone);
            this.clubGroup.Controls.Add(this.lbClubPost);
            this.clubGroup.Controls.Add(this.lbClubProv);
            this.clubGroup.Controls.Add(this.lbClubCity);
            this.clubGroup.Controls.Add(this.lbClubStreet);
            this.clubGroup.Controls.Add(this.lbClubName);
            this.clubGroup.Controls.Add(this.tbClubStreet);
            this.clubGroup.Controls.Add(this.tbClubCity);
            this.clubGroup.Controls.Add(this.tbClubProvince);
            this.clubGroup.Controls.Add(this.tbClubPostalCode);
            this.clubGroup.Controls.Add(this.tbClubPhoneNumber);
            this.clubGroup.Controls.Add(this.tbClubName);
            this.clubGroup.Controls.Add(this.listBoxClub);
            this.clubGroup.Location = new System.Drawing.Point(9, 10);
            this.clubGroup.Margin = new System.Windows.Forms.Padding(2);
            this.clubGroup.Name = "clubGroup";
            this.clubGroup.Padding = new System.Windows.Forms.Padding(2);
            this.clubGroup.Size = new System.Drawing.Size(433, 433);
            this.clubGroup.TabIndex = 0;
            this.clubGroup.TabStop = false;
            this.clubGroup.Text = "Club";
            // 
            // btSaveClub
            // 
            this.btSaveClub.Location = new System.Drawing.Point(15, 199);
            this.btSaveClub.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveClub.Name = "btSaveClub";
            this.btSaveClub.Size = new System.Drawing.Size(120, 20);
            this.btSaveClub.TabIndex = 2;
            this.btSaveClub.Text = "Save Clubs";
            this.btSaveClub.UseVisualStyleBackColor = true;
            this.btSaveClub.Click += new System.EventHandler(this.btSaveClub_Click);
            // 
            // btAssignSwimmer
            // 
            this.btAssignSwimmer.Location = new System.Drawing.Point(296, 242);
            this.btAssignSwimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btAssignSwimmer.Name = "btAssignSwimmer";
            this.btAssignSwimmer.Size = new System.Drawing.Size(120, 20);
            this.btAssignSwimmer.TabIndex = 10;
            this.btAssignSwimmer.Text = "Assign Swimmer";
            this.btAssignSwimmer.UseVisualStyleBackColor = true;
            this.btAssignSwimmer.Click += new System.EventHandler(this.assignSwimmer_Click);
            // 
            // clubPath
            // 
            this.clubPath.AutoSize = true;
            this.clubPath.Location = new System.Drawing.Point(139, 28);
            this.clubPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clubPath.Name = "clubPath";
            this.clubPath.Size = new System.Drawing.Size(0, 13);
            this.clubPath.TabIndex = 48;
            // 
            // btLoadClubs
            // 
            this.btLoadClubs.Location = new System.Drawing.Point(15, 24);
            this.btLoadClubs.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadClubs.Name = "btLoadClubs";
            this.btLoadClubs.Size = new System.Drawing.Size(120, 20);
            this.btLoadClubs.TabIndex = 1;
            this.btLoadClubs.Text = "Load Clubs";
            this.btLoadClubs.UseVisualStyleBackColor = true;
            this.btLoadClubs.Click += new System.EventHandler(this.btLoadClubs_Click);
            // 
            // btAddClub
            // 
            this.btAddClub.Location = new System.Drawing.Point(296, 271);
            this.btAddClub.Margin = new System.Windows.Forms.Padding(2);
            this.btAddClub.Name = "btAddClub";
            this.btAddClub.Size = new System.Drawing.Size(120, 20);
            this.btAddClub.TabIndex = 11;
            this.btAddClub.Text = "Add  Club";
            this.btAddClub.UseVisualStyleBackColor = true;
            this.btAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // clubDetails
            // 
            this.clubDetails.AutoSize = true;
            this.clubDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clubDetails.Location = new System.Drawing.Point(15, 240);
            this.clubDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clubDetails.Name = "clubDetails";
            this.clubDetails.Size = new System.Drawing.Size(0, 13);
            this.clubDetails.TabIndex = 49;
            // 
            // lbClubPhone
            // 
            this.lbClubPhone.AutoSize = true;
            this.lbClubPhone.Location = new System.Drawing.Point(211, 183);
            this.lbClubPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubPhone.Name = "lbClubPhone";
            this.lbClubPhone.Size = new System.Drawing.Size(78, 13);
            this.lbClubPhone.TabIndex = 47;
            this.lbClubPhone.Text = "Phone Number";
            // 
            // lbClubPost
            // 
            this.lbClubPost.AutoSize = true;
            this.lbClubPost.Location = new System.Drawing.Point(211, 160);
            this.lbClubPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubPost.Name = "lbClubPost";
            this.lbClubPost.Size = new System.Drawing.Size(64, 13);
            this.lbClubPost.TabIndex = 46;
            this.lbClubPost.Text = "Postal Code";
            // 
            // lbClubProv
            // 
            this.lbClubProv.AutoSize = true;
            this.lbClubProv.Location = new System.Drawing.Point(211, 136);
            this.lbClubProv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubProv.Name = "lbClubProv";
            this.lbClubProv.Size = new System.Drawing.Size(49, 13);
            this.lbClubProv.TabIndex = 45;
            this.lbClubProv.Text = "Province";
            // 
            // lbClubCity
            // 
            this.lbClubCity.AutoSize = true;
            this.lbClubCity.Location = new System.Drawing.Point(211, 113);
            this.lbClubCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubCity.Name = "lbClubCity";
            this.lbClubCity.Size = new System.Drawing.Size(24, 13);
            this.lbClubCity.TabIndex = 44;
            this.lbClubCity.Text = "City";
            // 
            // lbClubStreet
            // 
            this.lbClubStreet.AutoSize = true;
            this.lbClubStreet.Location = new System.Drawing.Point(211, 89);
            this.lbClubStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubStreet.Name = "lbClubStreet";
            this.lbClubStreet.Size = new System.Drawing.Size(35, 13);
            this.lbClubStreet.TabIndex = 43;
            this.lbClubStreet.Text = "Street";
            // 
            // lbClubName
            // 
            this.lbClubName.AutoSize = true;
            this.lbClubName.Location = new System.Drawing.Point(211, 66);
            this.lbClubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClubName.Name = "lbClubName";
            this.lbClubName.Size = new System.Drawing.Size(59, 13);
            this.lbClubName.TabIndex = 42;
            this.lbClubName.Text = "Club Name";
            // 
            // tbClubStreet
            // 
            this.tbClubStreet.Location = new System.Drawing.Point(296, 87);
            this.tbClubStreet.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubStreet.Name = "tbClubStreet";
            this.tbClubStreet.Size = new System.Drawing.Size(120, 20);
            this.tbClubStreet.TabIndex = 5;
            // 
            // tbClubCity
            // 
            this.tbClubCity.Location = new System.Drawing.Point(296, 110);
            this.tbClubCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubCity.Name = "tbClubCity";
            this.tbClubCity.Size = new System.Drawing.Size(120, 20);
            this.tbClubCity.TabIndex = 6;
            // 
            // tbClubProvince
            // 
            this.tbClubProvince.Location = new System.Drawing.Point(296, 133);
            this.tbClubProvince.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubProvince.Name = "tbClubProvince";
            this.tbClubProvince.Size = new System.Drawing.Size(120, 20);
            this.tbClubProvince.TabIndex = 7;
            // 
            // tbClubPostalCode
            // 
            this.tbClubPostalCode.Location = new System.Drawing.Point(296, 157);
            this.tbClubPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubPostalCode.Name = "tbClubPostalCode";
            this.tbClubPostalCode.Size = new System.Drawing.Size(120, 20);
            this.tbClubPostalCode.TabIndex = 8;
            // 
            // tbClubPhoneNumber
            // 
            this.tbClubPhoneNumber.Location = new System.Drawing.Point(296, 180);
            this.tbClubPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubPhoneNumber.Name = "tbClubPhoneNumber";
            this.tbClubPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.tbClubPhoneNumber.TabIndex = 9;
            // 
            // tbClubName
            // 
            this.tbClubName.Location = new System.Drawing.Point(296, 63);
            this.tbClubName.Margin = new System.Windows.Forms.Padding(2);
            this.tbClubName.Name = "tbClubName";
            this.tbClubName.Size = new System.Drawing.Size(120, 20);
            this.tbClubName.TabIndex = 4;
            // 
            // frmSwimManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.clubGroup);
            this.Controls.Add(this.swimmerGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSwimManagement";
            this.Text = "Swimmers Management";
            this.swimmerGroup.ResumeLayout(false);
            this.swimmerGroup.PerformLayout();
            this.clubGroup.ResumeLayout(false);
            this.clubGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSwimmer;
        private System.Windows.Forms.ListBox listBoxClub;
        private System.Windows.Forms.GroupBox swimmerGroup;
        private System.Windows.Forms.GroupBox clubGroup;
        private System.Windows.Forms.Button btAddClub;
        private System.Windows.Forms.Label clubDetails;
        private System.Windows.Forms.Label lbClubPhone;
        private System.Windows.Forms.Label lbClubPost;
        private System.Windows.Forms.Label lbClubProv;
        private System.Windows.Forms.Label lbClubCity;
        private System.Windows.Forms.Label lbClubStreet;
        private System.Windows.Forms.Label lbClubName;
        private System.Windows.Forms.TextBox tbClubStreet;
        private System.Windows.Forms.TextBox tbClubCity;
        private System.Windows.Forms.TextBox tbClubProvince;
        private System.Windows.Forms.TextBox tbClubPostalCode;
        private System.Windows.Forms.TextBox tbClubPhoneNumber;
        private System.Windows.Forms.TextBox tbClubName;
        private System.Windows.Forms.Label swimmerDetails;
        private System.Windows.Forms.Button btSwimmer;
        private System.Windows.Forms.Label lbSwimDob;
        private System.Windows.Forms.Label lbSwimPhone;
        private System.Windows.Forms.Label lvSwimPost;
        private System.Windows.Forms.Label lbSwimProv;
        private System.Windows.Forms.Label lbSwimCity;
        private System.Windows.Forms.Label lbSwimStreet;
        private System.Windows.Forms.Label lbSwimName;
        private System.Windows.Forms.TextBox tbSwimmerStreet;
        private System.Windows.Forms.TextBox tbSwimmerCity;
        private System.Windows.Forms.TextBox tbSwimmerProvince;
        private System.Windows.Forms.TextBox tbSwimmerPostalCode;
        private System.Windows.Forms.TextBox tbSwimmerPhoneNumber;
        private System.Windows.Forms.TextBox tbSwimmerName;
        private System.Windows.Forms.Button btLoadSwimmers;
        private System.Windows.Forms.OpenFileDialog openFileDialogSwimmer;
        private System.Windows.Forms.Label swimmerPath;
        private System.Windows.Forms.Label clubPath;
        private System.Windows.Forms.Button btLoadClubs;
        private System.Windows.Forms.OpenFileDialog openFileDialogClub;
        private System.Windows.Forms.Button btAssignSwimmer;
        private System.Windows.Forms.Button btSaveSwimmer;
        private System.Windows.Forms.Button btSaveClub;
        private System.Windows.Forms.DateTimePicker dtSwimmerDob;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSwimmer;
        private System.Windows.Forms.SaveFileDialog saveFileDialogClub;
    }
}

