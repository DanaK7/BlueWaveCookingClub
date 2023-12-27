namespace BlueWaveCookingClub
{
    partial class FrmRegister2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCookClubs = new System.Windows.Forms.Label();
            this.lblPayM = new System.Windows.Forms.Label();
            this.cbPayM = new System.Windows.Forms.ComboBox();
            this.lblRegno = new System.Windows.Forms.Label();
            this.lblDateReg = new System.Windows.Forms.Label();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.dateOfReg = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisplayall = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.cbCooking = new System.Windows.Forms.ComboBox();
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
            // lblCookClubs
            // 
            this.lblCookClubs.AutoSize = true;
            this.lblCookClubs.Location = new System.Drawing.Point(348, 32);
            this.lblCookClubs.Name = "lblCookClubs";
            this.lblCookClubs.Size = new System.Drawing.Size(75, 13);
            this.lblCookClubs.TabIndex = 2;
            this.lblCookClubs.Text = "Cooking Clubs";
            // 
            // lblPayM
            // 
            this.lblPayM.AutoSize = true;
            this.lblPayM.Location = new System.Drawing.Point(348, 77);
            this.lblPayM.Name = "lblPayM";
            this.lblPayM.Size = new System.Drawing.Size(87, 13);
            this.lblPayM.TabIndex = 3;
            this.lblPayM.Text = "Payment Method";
            // 
            // cbPayM
            // 
            this.cbPayM.AutoCompleteCustomSource.AddRange(new string[] {
            "Credit/Debit Cards",
            "Paypal",
            "Stripe",
            "Bank Transfers"});
            this.cbPayM.FormattingEnabled = true;
            this.cbPayM.Items.AddRange(new object[] {
            "Credit/Debit ",
            "PayPal",
            "Bank Transfer"});
            this.cbPayM.Location = new System.Drawing.Point(469, 74);
            this.cbPayM.Name = "cbPayM";
            this.cbPayM.Size = new System.Drawing.Size(170, 21);
            this.cbPayM.TabIndex = 15;
            // 
            // lblRegno
            // 
            this.lblRegno.AutoSize = true;
            this.lblRegno.Location = new System.Drawing.Point(348, 167);
            this.lblRegno.Name = "lblRegno";
            this.lblRegno.Size = new System.Drawing.Size(80, 13);
            this.lblRegno.TabIndex = 16;
            this.lblRegno.Text = "Registration No";
            // 
            // lblDateReg
            // 
            this.lblDateReg.AutoSize = true;
            this.lblDateReg.Location = new System.Drawing.Point(346, 230);
            this.lblDateReg.Name = "lblDateReg";
            this.lblDateReg.Size = new System.Drawing.Size(67, 13);
            this.lblDateReg.TabIndex = 17;
            this.lblDateReg.Text = "Date Of Reg";
            // 
            // txtRegno
            // 
            this.txtRegno.Location = new System.Drawing.Point(469, 167);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.Size = new System.Drawing.Size(121, 20);
            this.txtRegno.TabIndex = 18;
            // 
            // dateOfReg
            // 
            this.dateOfReg.Location = new System.Drawing.Point(458, 223);
            this.dateOfReg.Name = "dateOfReg";
            this.dateOfReg.Size = new System.Drawing.Size(200, 20);
            this.dateOfReg.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(348, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDisplayall
            // 
            this.btnDisplayall.Location = new System.Drawing.Point(338, 319);
            this.btnDisplayall.Name = "btnDisplayall";
            this.btnDisplayall.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayall.TabIndex = 21;
            this.btnDisplayall.Text = "Display All";
            this.btnDisplayall.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(623, 319);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(623, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(355, 122);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(48, 13);
            this.lblPayment.TabIndex = 24;
            this.lblPayment.Text = "Payment";
            // 
            // cbPayment
            // 
            this.cbPayment.AutoCompleteCustomSource.AddRange(new string[] {
            "$9.99 Monthly (Basic)",
            "$14.99 Monthly (Premium)",
            "$19.99 Monthly (VIP)"});
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "Pay Now",
            "Pay Later",
            "Paid"});
            this.cbPayment.Location = new System.Drawing.Point(469, 122);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(170, 21);
            this.cbPayment.TabIndex = 25;
            // 
            // cbCooking
            // 
            this.cbCooking.FormattingEnabled = true;
            this.cbCooking.Items.AddRange(new object[] {
            "Cuisine",
            "Bakery",
            "Dessert"});
            this.cbCooking.Location = new System.Drawing.Point(469, 32);
            this.cbCooking.Name = "cbCooking";
            this.cbCooking.Size = new System.Drawing.Size(121, 21);
            this.cbCooking.TabIndex = 27;
            // 
            // FrmRegister2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(720, 454);
            this.Controls.Add(this.cbCooking);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDisplayall);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dateOfReg);
            this.Controls.Add(this.txtRegno);
            this.Controls.Add(this.lblDateReg);
            this.Controls.Add(this.lblRegno);
            this.Controls.Add(this.cbPayM);
            this.Controls.Add(this.lblPayM);
            this.Controls.Add(this.lblCookClubs);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegister2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCookClubs;
        private System.Windows.Forms.Label lblPayM;
        private System.Windows.Forms.ComboBox cbPayM;
        private System.Windows.Forms.Label lblRegno;
        private System.Windows.Forms.Label lblDateReg;
        private System.Windows.Forms.TextBox txtRegno;
        private System.Windows.Forms.DateTimePicker dateOfReg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDisplayall;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.ComboBox cbCooking;
    }
}