
namespace SwimManagementForm_301178688
{
    partial class FormSwimManagement
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swimmerDetails = new System.Windows.Forms.Label();
            this.txtSwimmerSavePath = new System.Windows.Forms.TextBox();
            this.txtSwimmerLoadPath = new System.Windows.Forms.TextBox();
            this.txtSwimmerDob = new System.Windows.Forms.DateTimePicker();
            this.btSaveSwimmer = new System.Windows.Forms.Button();
            this.swimmerPath = new System.Windows.Forms.Label();
            this.btLoadSwimmers = new System.Windows.Forms.Button();
            this.btSwimmer = new System.Windows.Forms.Button();
            this.lbSwimDob = new System.Windows.Forms.Label();
            this.lbSwimPhone = new System.Windows.Forms.Label();
            this.lvSwimPost = new System.Windows.Forms.Label();
            this.lbSwimProv = new System.Windows.Forms.Label();
            this.lbSwimCity = new System.Windows.Forms.Label();
            this.lbSwimStreet = new System.Windows.Forms.Label();
            this.lbSwimName = new System.Windows.Forms.Label();
            this.txtSwimmerStreet = new System.Windows.Forms.TextBox();
            this.txtSwimmerCity = new System.Windows.Forms.TextBox();
            this.txtSwimmerProvince = new System.Windows.Forms.TextBox();
            this.txtSwimmerPostalCode = new System.Windows.Forms.TextBox();
            this.txtSwimmerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSwimmerName = new System.Windows.Forms.TextBox();
            this.clubGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clubDetails = new System.Windows.Forms.Label();
            this.txtClubSavePath = new System.Windows.Forms.TextBox();
            this.txtClubLoadPath = new System.Windows.Forms.TextBox();
            this.btSaveClub = new System.Windows.Forms.Button();
            this.btAssignSwimmer = new System.Windows.Forms.Button();
            this.clubPath = new System.Windows.Forms.Label();
            this.btLoadClubs = new System.Windows.Forms.Button();
            this.btAddClub = new System.Windows.Forms.Button();
            this.lbClubPhone = new System.Windows.Forms.Label();
            this.lbClubPost = new System.Windows.Forms.Label();
            this.lbClubProv = new System.Windows.Forms.Label();
            this.lbClubCity = new System.Windows.Forms.Label();
            this.lbClubStreet = new System.Windows.Forms.Label();
            this.lbClubName = new System.Windows.Forms.Label();
            this.txtClubStreet = new System.Windows.Forms.TextBox();
            this.txtClubCity = new System.Windows.Forms.TextBox();
            this.txtClubProvince = new System.Windows.Forms.TextBox();
            this.txtClubPostalCode = new System.Windows.Forms.TextBox();
            this.txtClubPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.openFileDialogSwimmer = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogClub = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSwimmer = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogClub = new System.Windows.Forms.SaveFileDialog();
            this.swimmerGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.clubGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSwimmer
            // 
            this.listBoxSwimmer.FormattingEnabled = true;
            this.listBoxSwimmer.ItemHeight = 24;
            this.listBoxSwimmer.Location = new System.Drawing.Point(28, 116);
            this.listBoxSwimmer.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSwimmer.Name = "listBoxSwimmer";
            this.listBoxSwimmer.Size = new System.Drawing.Size(362, 220);
            this.listBoxSwimmer.TabIndex = 53;
            this.listBoxSwimmer.SelectedIndexChanged += new System.EventHandler(this.listBoxSwimmer_SelectedIndexChanged);
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.ItemHeight = 24;
            this.listBoxClub.Location = new System.Drawing.Point(28, 116);
            this.listBoxClub.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(373, 220);
            this.listBoxClub.TabIndex = 3;
            this.listBoxClub.SelectedIndexChanged += new System.EventHandler(this.listBoxClub_SelectedIndexChanged);
            // 
            // swimmerGroup
            // 
            this.swimmerGroup.Controls.Add(this.groupBox2);
            this.swimmerGroup.Controls.Add(this.txtSwimmerSavePath);
            this.swimmerGroup.Controls.Add(this.txtSwimmerLoadPath);
            this.swimmerGroup.Controls.Add(this.txtSwimmerDob);
            this.swimmerGroup.Controls.Add(this.btSaveSwimmer);
            this.swimmerGroup.Controls.Add(this.swimmerPath);
            this.swimmerGroup.Controls.Add(this.btLoadSwimmers);
            this.swimmerGroup.Controls.Add(this.btSwimmer);
            this.swimmerGroup.Controls.Add(this.lbSwimDob);
            this.swimmerGroup.Controls.Add(this.lbSwimPhone);
            this.swimmerGroup.Controls.Add(this.lvSwimPost);
            this.swimmerGroup.Controls.Add(this.lbSwimProv);
            this.swimmerGroup.Controls.Add(this.lbSwimCity);
            this.swimmerGroup.Controls.Add(this.lbSwimStreet);
            this.swimmerGroup.Controls.Add(this.lbSwimName);
            this.swimmerGroup.Controls.Add(this.txtSwimmerStreet);
            this.swimmerGroup.Controls.Add(this.txtSwimmerCity);
            this.swimmerGroup.Controls.Add(this.txtSwimmerProvince);
            this.swimmerGroup.Controls.Add(this.txtSwimmerPostalCode);
            this.swimmerGroup.Controls.Add(this.txtSwimmerPhoneNumber);
            this.swimmerGroup.Controls.Add(this.txtSwimmerName);
            this.swimmerGroup.Controls.Add(this.listBoxSwimmer);
            this.swimmerGroup.Location = new System.Drawing.Point(864, 18);
            this.swimmerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.swimmerGroup.Name = "swimmerGroup";
            this.swimmerGroup.Padding = new System.Windows.Forms.Padding(4);
            this.swimmerGroup.Size = new System.Drawing.Size(773, 867);
            this.swimmerGroup.TabIndex = 50;
            this.swimmerGroup.TabStop = false;
            this.swimmerGroup.Text = "Swimmer";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.swimmerDetails);
            this.groupBox2.Location = new System.Drawing.Point(427, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 612);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swimmer Info";
            // 
            // swimmerDetails
            // 
            this.swimmerDetails.AutoSize = true;
            this.swimmerDetails.Location = new System.Drawing.Point(21, 25);
            this.swimmerDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.swimmerDetails.Name = "swimmerDetails";
            this.swimmerDetails.Size = new System.Drawing.Size(0, 25);
            this.swimmerDetails.TabIndex = 99;
            // 
            // txtSwimmerSavePath
            // 
            this.txtSwimmerSavePath.Location = new System.Drawing.Point(277, 790);
            this.txtSwimmerSavePath.Name = "txtSwimmerSavePath";
            this.txtSwimmerSavePath.Size = new System.Drawing.Size(395, 29);
            this.txtSwimmerSavePath.TabIndex = 52;
            // 
            // txtSwimmerLoadPath
            // 
            this.txtSwimmerLoadPath.Location = new System.Drawing.Point(277, 48);
            this.txtSwimmerLoadPath.Name = "txtSwimmerLoadPath";
            this.txtSwimmerLoadPath.Size = new System.Drawing.Size(395, 29);
            this.txtSwimmerLoadPath.TabIndex = 100;
            // 
            // txtSwimmerDob
            // 
            this.txtSwimmerDob.Location = new System.Drawing.Point(172, 634);
            this.txtSwimmerDob.Margin = new System.Windows.Forms.Padding(6);
            this.txtSwimmerDob.Name = "txtSwimmerDob";
            this.txtSwimmerDob.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerDob.TabIndex = 60;
           
            // 
            // btSaveSwimmer
            // 
            this.btSaveSwimmer.Location = new System.Drawing.Point(18, 790);
            this.btSaveSwimmer.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveSwimmer.Name = "btSaveSwimmer";
            this.btSaveSwimmer.Size = new System.Drawing.Size(220, 37);
            this.btSaveSwimmer.TabIndex = 52;
            this.btSaveSwimmer.Text = "Save Swimmers";
            this.btSaveSwimmer.UseVisualStyleBackColor = true;
            this.btSaveSwimmer.Click += new System.EventHandler(this.btSaveSwimmer_Click);
            // 
            // swimmerPath
            // 
            this.swimmerPath.AutoSize = true;
            this.swimmerPath.Location = new System.Drawing.Point(253, 52);
            this.swimmerPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.swimmerPath.Name = "swimmerPath";
            this.swimmerPath.Size = new System.Drawing.Size(0, 25);
            this.swimmerPath.TabIndex = 98;
            // 
            // btLoadSwimmers
            // 
            this.btLoadSwimmers.Location = new System.Drawing.Point(28, 44);
            this.btLoadSwimmers.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadSwimmers.Name = "btLoadSwimmers";
            this.btLoadSwimmers.Size = new System.Drawing.Size(220, 37);
            this.btLoadSwimmers.TabIndex = 51;
            this.btLoadSwimmers.Text = "Load Swimmers";
            this.btLoadSwimmers.UseVisualStyleBackColor = true;
            this.btLoadSwimmers.Click += new System.EventHandler(this.loadSwimmer_Click);
            // 
            // btSwimmer
            // 
            this.btSwimmer.Location = new System.Drawing.Point(21, 699);
            this.btSwimmer.Margin = new System.Windows.Forms.Padding(4);
            this.btSwimmer.Name = "btSwimmer";
            this.btSwimmer.Size = new System.Drawing.Size(220, 37);
            this.btSwimmer.TabIndex = 61;
            this.btSwimmer.Text = "Add Swimmer";
            this.btSwimmer.UseVisualStyleBackColor = true;
            this.btSwimmer.Click += new System.EventHandler(this.btSwimmer_Click);
            // 
            // lbSwimDob
            // 
            this.lbSwimDob.AutoSize = true;
            this.lbSwimDob.Location = new System.Drawing.Point(22, 636);
            this.lbSwimDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimDob.Name = "lbSwimDob";
            this.lbSwimDob.Size = new System.Drawing.Size(118, 25);
            this.lbSwimDob.TabIndex = 97;
            this.lbSwimDob.Text = "Date of Birth";
            // 
            // lbSwimPhone
            // 
            this.lbSwimPhone.AutoSize = true;
            this.lbSwimPhone.Location = new System.Drawing.Point(22, 594);
            this.lbSwimPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimPhone.Name = "lbSwimPhone";
            this.lbSwimPhone.Size = new System.Drawing.Size(143, 25);
            this.lbSwimPhone.TabIndex = 96;
            this.lbSwimPhone.Text = "Phone Number";
            // 
            // lvSwimPost
            // 
            this.lvSwimPost.AutoSize = true;
            this.lvSwimPost.Location = new System.Drawing.Point(22, 550);
            this.lvSwimPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvSwimPost.Name = "lvSwimPost";
            this.lvSwimPost.Size = new System.Drawing.Size(119, 25);
            this.lvSwimPost.TabIndex = 95;
            this.lvSwimPost.Text = "Postal Code";
            // 
            // lbSwimProv
            // 
            this.lbSwimProv.AutoSize = true;
            this.lbSwimProv.Location = new System.Drawing.Point(22, 507);
            this.lbSwimProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimProv.Name = "lbSwimProv";
            this.lbSwimProv.Size = new System.Drawing.Size(88, 25);
            this.lbSwimProv.TabIndex = 94;
            this.lbSwimProv.Text = "Province";
            // 
            // lbSwimCity
            // 
            this.lbSwimCity.AutoSize = true;
            this.lbSwimCity.Location = new System.Drawing.Point(22, 465);
            this.lbSwimCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimCity.Name = "lbSwimCity";
            this.lbSwimCity.Size = new System.Drawing.Size(46, 25);
            this.lbSwimCity.TabIndex = 93;
            this.lbSwimCity.Text = "City";
            // 
            // lbSwimStreet
            // 
            this.lbSwimStreet.AutoSize = true;
            this.lbSwimStreet.Location = new System.Drawing.Point(22, 420);
            this.lbSwimStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimStreet.Name = "lbSwimStreet";
            this.lbSwimStreet.Size = new System.Drawing.Size(64, 25);
            this.lbSwimStreet.TabIndex = 92;
            this.lbSwimStreet.Text = "Street";
            // 
            // lbSwimName
            // 
            this.lbSwimName.AutoSize = true;
            this.lbSwimName.Location = new System.Drawing.Point(22, 378);
            this.lbSwimName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSwimName.Name = "lbSwimName";
            this.lbSwimName.Size = new System.Drawing.Size(150, 25);
            this.lbSwimName.TabIndex = 91;
            this.lbSwimName.Text = "Swimmer Name";
            // 
            // txtSwimmerStreet
            // 
            this.txtSwimmerStreet.Location = new System.Drawing.Point(172, 417);
            this.txtSwimmerStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerStreet.Name = "txtSwimmerStreet";
            this.txtSwimmerStreet.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerStreet.TabIndex = 55;
            // 
            // txtSwimmerCity
            // 
            this.txtSwimmerCity.Location = new System.Drawing.Point(172, 459);
            this.txtSwimmerCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerCity.Name = "txtSwimmerCity";
            this.txtSwimmerCity.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerCity.TabIndex = 56;
            // 
            // txtSwimmerProvince
            // 
            this.txtSwimmerProvince.Location = new System.Drawing.Point(172, 502);
            this.txtSwimmerProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerProvince.Name = "txtSwimmerProvince";
            this.txtSwimmerProvince.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerProvince.TabIndex = 57;
            // 
            // txtSwimmerPostalCode
            // 
            this.txtSwimmerPostalCode.Location = new System.Drawing.Point(172, 546);
            this.txtSwimmerPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerPostalCode.Name = "txtSwimmerPostalCode";
            this.txtSwimmerPostalCode.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerPostalCode.TabIndex = 58;
            // 
            // txtSwimmerPhoneNumber
            // 
            this.txtSwimmerPhoneNumber.Location = new System.Drawing.Point(172, 588);
            this.txtSwimmerPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerPhoneNumber.Name = "txtSwimmerPhoneNumber";
            this.txtSwimmerPhoneNumber.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerPhoneNumber.TabIndex = 59;
            // 
            // txtSwimmerName
            // 
            this.txtSwimmerName.Location = new System.Drawing.Point(172, 372);
            this.txtSwimmerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSwimmerName.Name = "txtSwimmerName";
            this.txtSwimmerName.Size = new System.Drawing.Size(217, 29);
            this.txtSwimmerName.TabIndex = 54;
            // 
            // clubGroup
            // 
            this.clubGroup.Controls.Add(this.groupBox1);
            this.clubGroup.Controls.Add(this.txtClubSavePath);
            this.clubGroup.Controls.Add(this.txtClubLoadPath);
            this.clubGroup.Controls.Add(this.btSaveClub);
            this.clubGroup.Controls.Add(this.btAssignSwimmer);
            this.clubGroup.Controls.Add(this.clubPath);
            this.clubGroup.Controls.Add(this.btLoadClubs);
            this.clubGroup.Controls.Add(this.btAddClub);
            this.clubGroup.Controls.Add(this.lbClubPhone);
            this.clubGroup.Controls.Add(this.lbClubPost);
            this.clubGroup.Controls.Add(this.lbClubProv);
            this.clubGroup.Controls.Add(this.lbClubCity);
            this.clubGroup.Controls.Add(this.lbClubStreet);
            this.clubGroup.Controls.Add(this.lbClubName);
            this.clubGroup.Controls.Add(this.txtClubStreet);
            this.clubGroup.Controls.Add(this.txtClubCity);
            this.clubGroup.Controls.Add(this.txtClubProvince);
            this.clubGroup.Controls.Add(this.txtClubPostalCode);
            this.clubGroup.Controls.Add(this.txtClubPhoneNumber);
            this.clubGroup.Controls.Add(this.txtClubName);
            this.clubGroup.Controls.Add(this.listBoxClub);
            this.clubGroup.Location = new System.Drawing.Point(17, 18);
            this.clubGroup.Margin = new System.Windows.Forms.Padding(4);
            this.clubGroup.Name = "clubGroup";
            this.clubGroup.Padding = new System.Windows.Forms.Padding(4);
            this.clubGroup.Size = new System.Drawing.Size(794, 867);
            this.clubGroup.TabIndex = 0;
            this.clubGroup.TabStop = false;
            this.clubGroup.Text = "Club";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.clubDetails);
            this.groupBox1.Location = new System.Drawing.Point(440, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 612);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Club Info";
            // 
            // clubDetails
            // 
            this.clubDetails.AutoSize = true;
            this.clubDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clubDetails.Location = new System.Drawing.Point(36, 35);
            this.clubDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clubDetails.Name = "clubDetails";
            this.clubDetails.Size = new System.Drawing.Size(0, 25);
            this.clubDetails.TabIndex = 49;
            // 
            // txtClubSavePath
            // 
            this.txtClubSavePath.Location = new System.Drawing.Point(281, 780);
            this.txtClubSavePath.Name = "txtClubSavePath";
            this.txtClubSavePath.Size = new System.Drawing.Size(395, 29);
            this.txtClubSavePath.TabIndex = 51;
            // 
            // txtClubLoadPath
            // 
            this.txtClubLoadPath.Location = new System.Drawing.Point(272, 47);
            this.txtClubLoadPath.Name = "txtClubLoadPath";
            this.txtClubLoadPath.Size = new System.Drawing.Size(395, 29);
            this.txtClubLoadPath.TabIndex = 50;
            // 
            // btSaveClub
            // 
            this.btSaveClub.Location = new System.Drawing.Point(23, 777);
            this.btSaveClub.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveClub.Name = "btSaveClub";
            this.btSaveClub.Size = new System.Drawing.Size(220, 37);
            this.btSaveClub.TabIndex = 2;
            this.btSaveClub.Text = "Save Clubs";
            this.btSaveClub.UseVisualStyleBackColor = true;
            this.btSaveClub.Click += new System.EventHandler(this.btSaveClub_Click);
            // 
            // btAssignSwimmer
            // 
            this.btAssignSwimmer.Location = new System.Drawing.Point(27, 352);
            this.btAssignSwimmer.Margin = new System.Windows.Forms.Padding(4);
            this.btAssignSwimmer.Name = "btAssignSwimmer";
            this.btAssignSwimmer.Size = new System.Drawing.Size(220, 37);
            this.btAssignSwimmer.TabIndex = 10;
            this.btAssignSwimmer.Text = "Assign Swimmer";
            this.btAssignSwimmer.UseVisualStyleBackColor = true;
            this.btAssignSwimmer.Click += new System.EventHandler(this.assignSwimmer_Click);
            // 
            // clubPath
            // 
            this.clubPath.AutoSize = true;
            this.clubPath.Location = new System.Drawing.Point(255, 52);
            this.clubPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clubPath.Name = "clubPath";
            this.clubPath.Size = new System.Drawing.Size(0, 25);
            this.clubPath.TabIndex = 48;
            // 
            // btLoadClubs
            // 
            this.btLoadClubs.Location = new System.Drawing.Point(28, 44);
            this.btLoadClubs.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadClubs.Name = "btLoadClubs";
            this.btLoadClubs.Size = new System.Drawing.Size(220, 37);
            this.btLoadClubs.TabIndex = 1;
            this.btLoadClubs.Text = "Load Clubs";
            this.btLoadClubs.UseVisualStyleBackColor = true;
            this.btLoadClubs.Click += new System.EventHandler(this.btLoadClubs_Click);
            // 
            // btAddClub
            // 
            this.btAddClub.Location = new System.Drawing.Point(23, 691);
            this.btAddClub.Margin = new System.Windows.Forms.Padding(4);
            this.btAddClub.Name = "btAddClub";
            this.btAddClub.Size = new System.Drawing.Size(220, 37);
            this.btAddClub.TabIndex = 11;
            this.btAddClub.Text = "Add  Club";
            this.btAddClub.UseVisualStyleBackColor = true;
            this.btAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // lbClubPhone
            // 
            this.lbClubPhone.AutoSize = true;
            this.lbClubPhone.Location = new System.Drawing.Point(23, 630);
            this.lbClubPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubPhone.Name = "lbClubPhone";
            this.lbClubPhone.Size = new System.Drawing.Size(143, 25);
            this.lbClubPhone.TabIndex = 47;
            this.lbClubPhone.Text = "Phone Number";
            // 
            // lbClubPost
            // 
            this.lbClubPost.AutoSize = true;
            this.lbClubPost.Location = new System.Drawing.Point(23, 587);
            this.lbClubPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubPost.Name = "lbClubPost";
            this.lbClubPost.Size = new System.Drawing.Size(119, 25);
            this.lbClubPost.TabIndex = 46;
            this.lbClubPost.Text = "Postal Code";
            // 
            // lbClubProv
            // 
            this.lbClubProv.AutoSize = true;
            this.lbClubProv.Location = new System.Drawing.Point(23, 543);
            this.lbClubProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubProv.Name = "lbClubProv";
            this.lbClubProv.Size = new System.Drawing.Size(88, 25);
            this.lbClubProv.TabIndex = 45;
            this.lbClubProv.Text = "Province";
            // 
            // lbClubCity
            // 
            this.lbClubCity.AutoSize = true;
            this.lbClubCity.Location = new System.Drawing.Point(23, 501);
            this.lbClubCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubCity.Name = "lbClubCity";
            this.lbClubCity.Size = new System.Drawing.Size(46, 25);
            this.lbClubCity.TabIndex = 44;
            this.lbClubCity.Text = "City";
            // 
            // lbClubStreet
            // 
            this.lbClubStreet.AutoSize = true;
            this.lbClubStreet.Location = new System.Drawing.Point(23, 456);
            this.lbClubStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubStreet.Name = "lbClubStreet";
            this.lbClubStreet.Size = new System.Drawing.Size(64, 25);
            this.lbClubStreet.TabIndex = 43;
            this.lbClubStreet.Text = "Street";
            // 
            // lbClubName
            // 
            this.lbClubName.AutoSize = true;
            this.lbClubName.Location = new System.Drawing.Point(23, 414);
            this.lbClubName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubName.Name = "lbClubName";
            this.lbClubName.Size = new System.Drawing.Size(110, 25);
            this.lbClubName.TabIndex = 42;
            this.lbClubName.Text = "Club Name";
            // 
            // txtClubStreet
            // 
            this.txtClubStreet.Location = new System.Drawing.Point(179, 453);
            this.txtClubStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubStreet.Name = "txtClubStreet";
            this.txtClubStreet.Size = new System.Drawing.Size(217, 29);
            this.txtClubStreet.TabIndex = 5;
            // 
            // txtClubCity
            // 
            this.txtClubCity.Location = new System.Drawing.Point(179, 495);
            this.txtClubCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubCity.Name = "txtClubCity";
            this.txtClubCity.Size = new System.Drawing.Size(217, 29);
            this.txtClubCity.TabIndex = 6;
            // 
            // txtClubProvince
            // 
            this.txtClubProvince.Location = new System.Drawing.Point(179, 538);
            this.txtClubProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubProvince.Name = "txtClubProvince";
            this.txtClubProvince.Size = new System.Drawing.Size(217, 29);
            this.txtClubProvince.TabIndex = 7;
            // 
            // txtClubPostalCode
            // 
            this.txtClubPostalCode.Location = new System.Drawing.Point(179, 582);
            this.txtClubPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubPostalCode.Name = "txtClubPostalCode";
            this.txtClubPostalCode.Size = new System.Drawing.Size(217, 29);
            this.txtClubPostalCode.TabIndex = 8;
            // 
            // txtClubPhoneNumber
            // 
            this.txtClubPhoneNumber.Location = new System.Drawing.Point(179, 624);
            this.txtClubPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubPhoneNumber.Name = "txtClubPhoneNumber";
            this.txtClubPhoneNumber.Size = new System.Drawing.Size(217, 29);
            this.txtClubPhoneNumber.TabIndex = 9;
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(179, 408);
            this.txtClubName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(217, 29);
            this.txtClubName.TabIndex = 4;
            // 
            // FormSwimManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1814, 969);
            this.Controls.Add(this.clubGroup);
            this.Controls.Add(this.swimmerGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSwimManagement";
            this.Text = "Swimmers Management";
            this.swimmerGroup.ResumeLayout(false);
            this.swimmerGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.clubGroup.ResumeLayout(false);
            this.clubGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtClubStreet;
        private System.Windows.Forms.TextBox txtClubCity;
        private System.Windows.Forms.TextBox txtClubProvince;
        private System.Windows.Forms.TextBox txtClubPostalCode;
        private System.Windows.Forms.TextBox txtClubPhoneNumber;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Label swimmerDetails;
        private System.Windows.Forms.Button btSwimmer;
        private System.Windows.Forms.Label lbSwimDob;
        private System.Windows.Forms.Label lbSwimPhone;
        private System.Windows.Forms.Label lvSwimPost;
        private System.Windows.Forms.Label lbSwimProv;
        private System.Windows.Forms.Label lbSwimCity;
        private System.Windows.Forms.Label lbSwimStreet;
        private System.Windows.Forms.Label lbSwimName;
        private System.Windows.Forms.TextBox txtSwimmerStreet;
        private System.Windows.Forms.TextBox txtSwimmerCity;
        private System.Windows.Forms.TextBox txtSwimmerProvince;
        private System.Windows.Forms.TextBox txtSwimmerPostalCode;
        private System.Windows.Forms.TextBox txtSwimmerPhoneNumber;
        private System.Windows.Forms.TextBox txtSwimmerName;
        private System.Windows.Forms.Button btLoadSwimmers;
        private System.Windows.Forms.OpenFileDialog openFileDialogSwimmer;
        private System.Windows.Forms.Label swimmerPath;
        private System.Windows.Forms.Label clubPath;
        private System.Windows.Forms.Button btLoadClubs;
        private System.Windows.Forms.OpenFileDialog openFileDialogClub;
        private System.Windows.Forms.Button btAssignSwimmer;
        private System.Windows.Forms.Button btSaveSwimmer;
        private System.Windows.Forms.Button btSaveClub;
        private System.Windows.Forms.DateTimePicker txtSwimmerDob;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSwimmer;
        private System.Windows.Forms.SaveFileDialog saveFileDialogClub;
        private System.Windows.Forms.TextBox txtSwimmerSavePath;
        private System.Windows.Forms.TextBox txtSwimmerLoadPath;
        private System.Windows.Forms.TextBox txtClubSavePath;
        private System.Windows.Forms.TextBox txtClubLoadPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

