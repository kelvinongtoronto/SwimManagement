
namespace SwimManagementForm_301178688
{
    partial class frmSwimManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvClubs = new System.Windows.Forms.ListView();
            this.clubId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clubName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clubAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clubPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clubCoach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvSwimmers = new System.Windows.Forms.ListView();
            this.swimmerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.swimmerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.swimmerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.swimmerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.swimmerClub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.swimmerDob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvClubs
            // 
            this.lvClubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clubId,
            this.clubName,
            this.clubAddress,
            this.clubPhone,
            this.clubCoach});
            this.lvClubs.HideSelection = false;
            this.lvClubs.Location = new System.Drawing.Point(12, 25);
            this.lvClubs.Name = "lvClubs";
            this.lvClubs.Size = new System.Drawing.Size(500, 250);
            this.lvClubs.TabIndex = 0;
            this.lvClubs.UseCompatibleStateImageBehavior = false;
            this.lvClubs.View = System.Windows.Forms.View.Details;
            // 
            // clubId
            // 
            this.clubId.Text = "Club ID";
            this.clubId.Width = 50;
            // 
            // clubName
            // 
            this.clubName.Text = "Name";
            // 
            // clubAddress
            // 
            this.clubAddress.Text = "Address";
            this.clubAddress.Width = 200;
            // 
            // clubPhone
            // 
            this.clubPhone.Text = "Phone Number";
            this.clubPhone.Width = 100;
            // 
            // clubCoach
            // 
            this.clubCoach.Text = "Coach";
            this.clubCoach.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clubs:";
            // 
            // lvSwimmers
            // 
            this.lvSwimmers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.swimmerId,
            this.swimmerName,
            this.swimmerDob,
            this.swimmerAddress,
            this.swimmerPhone,
            this.swimmerClub});
            this.lvSwimmers.HideSelection = false;
            this.lvSwimmers.Location = new System.Drawing.Point(12, 309);
            this.lvSwimmers.Name = "lvSwimmers";
            this.lvSwimmers.Size = new System.Drawing.Size(500, 250);
            this.lvSwimmers.TabIndex = 0;
            this.lvSwimmers.UseCompatibleStateImageBehavior = false;
            this.lvSwimmers.View = System.Windows.Forms.View.Details;
            // 
            // swimmerId
            // 
            this.swimmerId.Text = "ID";
            this.swimmerId.Width = 35;
            // 
            // swimmerName
            // 
            this.swimmerName.Text = "Name";
            this.swimmerName.Width = 80;
            // 
            // swimmerAddress
            // 
            this.swimmerAddress.Text = "Address";
            this.swimmerAddress.Width = 200;
            // 
            // swimmerPhone
            // 
            this.swimmerPhone.Text = "Phone Number";
            this.swimmerPhone.Width = 90;
            // 
            // swimmerClub
            // 
            this.swimmerClub.Text = "Club";
            this.swimmerClub.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Swimmers:";
            // 
            // swimmerDob
            // 
            this.swimmerDob.Text = "Date Of Birth";
            this.swimmerDob.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSwimmers);
            this.Controls.Add(this.lvClubs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvClubs;
        private System.Windows.Forms.ColumnHeader clubId;
        private System.Windows.Forms.ColumnHeader clubName;
        private System.Windows.Forms.ColumnHeader clubAddress;
        private System.Windows.Forms.ColumnHeader clubPhone;
        private System.Windows.Forms.ColumnHeader clubCoach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSwimmers;
        private System.Windows.Forms.ColumnHeader swimmerId;
        private System.Windows.Forms.ColumnHeader swimmerName;
        private System.Windows.Forms.ColumnHeader swimmerAddress;
        private System.Windows.Forms.ColumnHeader swimmerPhone;
        private System.Windows.Forms.ColumnHeader swimmerClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader swimmerDob;
    }
}

