namespace BlueWaveCookingClub
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panMembers = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotMembers = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.lblClubs = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblBakery = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPayLater = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPayNow = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panMembers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 458);
            this.panel1.TabIndex = 0;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblDashboard.Location = new System.Drawing.Point(372, 18);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(284, 16);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "BlueWave Cooking Club  Dashboard";
            // 
            // panMembers
            // 
            this.panMembers.BackColor = System.Drawing.Color.White;
            this.panMembers.Controls.Add(this.lblFemale);
            this.panMembers.Controls.Add(this.lblMale);
            this.panMembers.Controls.Add(this.lblTotMembers);
            this.panMembers.Location = new System.Drawing.Point(375, 55);
            this.panMembers.Name = "panMembers";
            this.panMembers.Size = new System.Drawing.Size(281, 106);
            this.panMembers.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDessert);
            this.panel3.Controls.Add(this.lblCuisine);
            this.panel3.Controls.Add(this.lblBakery);
            this.panel3.Controls.Add(this.lblClubs);
            this.panel3.Location = new System.Drawing.Point(375, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 105);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblPayLater);
            this.panel4.Controls.Add(this.lblPaid);
            this.panel4.Controls.Add(this.lblPayNow);
            this.panel4.Controls.Add(this.lblPayment);
            this.panel4.Location = new System.Drawing.Point(375, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 103);
            this.panel4.TabIndex = 5;
            // 
            // lblTotMembers
            // 
            this.lblTotMembers.AutoSize = true;
            this.lblTotMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotMembers.ForeColor = System.Drawing.Color.Black;
            this.lblTotMembers.Location = new System.Drawing.Point(82, 15);
            this.lblTotMembers.Name = "lblTotMembers";
            this.lblTotMembers.Size = new System.Drawing.Size(98, 13);
            this.lblTotMembers.TabIndex = 0;
            this.lblTotMembers.Text = "Total Members :";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.Location = new System.Drawing.Point(28, 36);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(42, 13);
            this.lblMale.TabIndex = 1;
            this.lblMale.Text = "Male :";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.Location = new System.Drawing.Point(28, 74);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(55, 13);
            this.lblFemale.TabIndex = 2;
            this.lblFemale.Text = "Female :";
            // 
            // lblClubs
            // 
            this.lblClubs.AutoSize = true;
            this.lblClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubs.ForeColor = System.Drawing.Color.Black;
            this.lblClubs.Location = new System.Drawing.Point(101, 11);
            this.lblClubs.Name = "lblClubs";
            this.lblClubs.Size = new System.Drawing.Size(79, 13);
            this.lblClubs.TabIndex = 3;
            this.lblClubs.Text = "Total Clubs :";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDessert.Location = new System.Drawing.Point(149, 38);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(58, 13);
            this.lblDessert.TabIndex = 3;
            this.lblDessert.Text = "Dessert :";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuisine.Location = new System.Drawing.Point(14, 38);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(56, 13);
            this.lblCuisine.TabIndex = 4;
            this.lblCuisine.Text = "Cuisine :";
            // 
            // lblBakery
            // 
            this.lblBakery.AutoSize = true;
            this.lblBakery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakery.Location = new System.Drawing.Point(14, 75);
            this.lblBakery.Name = "lblBakery";
            this.lblBakery.Size = new System.Drawing.Size(54, 13);
            this.lblBakery.TabIndex = 5;
            this.lblBakery.Text = "Bakery :";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Black;
            this.lblPayment.Location = new System.Drawing.Point(105, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(59, 13);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment ";
            // 
            // lblPayLater
            // 
            this.lblPayLater.AutoSize = true;
            this.lblPayLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayLater.Location = new System.Drawing.Point(14, 70);
            this.lblPayLater.Name = "lblPayLater";
            this.lblPayLater.Size = new System.Drawing.Size(69, 13);
            this.lblPayLater.TabIndex = 6;
            this.lblPayLater.Text = "Pay Later :";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(149, 37);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(40, 13);
            this.lblPaid.TabIndex = 7;
            this.lblPaid.Text = "Paid :";
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayNow.Location = new System.Drawing.Point(13, 37);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(65, 13);
            this.lblPayNow.TabIndex = 8;
            this.lblPayNow.Text = "Pay Now :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(378, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(581, 419);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(720, 454);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panMembers);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panMembers.ResumeLayout(false);
            this.panMembers.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panMembers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblTotMembers;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Label lblCuisine;
        private System.Windows.Forms.Label lblBakery;
        private System.Windows.Forms.Label lblClubs;
        private System.Windows.Forms.Label lblPayLater;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPayNow;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
    }
}