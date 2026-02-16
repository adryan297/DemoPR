namespace DemoPR.WinForms
{
    partial class FormDashboard : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnHome = new Button();
            lblAppName = new Label();
            panelHeader = new Panel();
            lblWelcome = new Label();
            panelContent = new Panel();
            panelCard3 = new Panel();
            lblCardValue3 = new Label();
            lblCardTitle3 = new Label();
            panelCard2 = new Panel();
            lblCardValue2 = new Label();
            lblCardTitle2 = new Label();
            panelCard1 = new Panel();
            lblCardValue1 = new Label();
            lblCardTitle1 = new Label();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(31, 41, 55);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnHome);
            panelSidebar.Controls.Add(lblAppName);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(210, 520);
            panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 466);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(186, 36);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(12, 175);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 36);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(12, 133);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(186, 36);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 91);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(186, 36);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(22, 28);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(166, 25);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Demo Dashboard";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(210, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(790, 78);
            panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(17, 24, 39);
            lblWelcome.Location = new Point(28, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(264, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Selamat Datang, Administrator";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(243, 244, 246);
            panelContent.Controls.Add(panelCard3);
            panelContent.Controls.Add(panelCard2);
            panelContent.Controls.Add(panelCard1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(210, 78);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(24);
            panelContent.Size = new Size(790, 442);
            panelContent.TabIndex = 2;
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.White;
            panelCard3.Controls.Add(lblCardValue3);
            panelCard3.Controls.Add(lblCardTitle3);
            panelCard3.Location = new Point(526, 24);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(240, 120);
            panelCard3.TabIndex = 2;
            // 
            // lblCardValue3
            // 
            lblCardValue3.AutoSize = true;
            lblCardValue3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCardValue3.ForeColor = Color.FromArgb(16, 185, 129);
            lblCardValue3.Location = new Point(18, 57);
            lblCardValue3.Name = "lblCardValue3";
            lblCardValue3.Size = new Size(80, 37);
            lblCardValue3.TabIndex = 1;
            lblCardValue3.Text = "89%";
            // 
            // lblCardTitle3
            // 
            lblCardTitle3.AutoSize = true;
            lblCardTitle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardTitle3.ForeColor = Color.FromArgb(75, 85, 99);
            lblCardTitle3.Location = new Point(21, 24);
            lblCardTitle3.Name = "lblCardTitle3";
            lblCardTitle3.Size = new Size(118, 17);
            lblCardTitle3.TabIndex = 0;
            lblCardTitle3.Text = "Performa Bulanan";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.White;
            panelCard2.Controls.Add(lblCardValue2);
            panelCard2.Controls.Add(lblCardTitle2);
            panelCard2.Location = new Point(275, 24);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(240, 120);
            panelCard2.TabIndex = 1;
            // 
            // lblCardValue2
            // 
            lblCardValue2.AutoSize = true;
            lblCardValue2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCardValue2.ForeColor = Color.FromArgb(37, 99, 235);
            lblCardValue2.Location = new Point(18, 57);
            lblCardValue2.Name = "lblCardValue2";
            lblCardValue2.Size = new Size(64, 37);
            lblCardValue2.TabIndex = 1;
            lblCardValue2.Text = "128";
            // 
            // lblCardTitle2
            // 
            lblCardTitle2.AutoSize = true;
            lblCardTitle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardTitle2.ForeColor = Color.FromArgb(75, 85, 99);
            lblCardTitle2.Location = new Point(21, 24);
            lblCardTitle2.Name = "lblCardTitle2";
            lblCardTitle2.Size = new Size(95, 17);
            lblCardTitle2.TabIndex = 0;
            lblCardTitle2.Text = "Total Transaksi";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.White;
            panelCard1.Controls.Add(lblCardValue1);
            panelCard1.Controls.Add(lblCardTitle1);
            panelCard1.Location = new Point(24, 24);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(240, 120);
            panelCard1.TabIndex = 0;
            // 
            // lblCardValue1
            // 
            lblCardValue1.AutoSize = true;
            lblCardValue1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCardValue1.ForeColor = Color.FromArgb(234, 88, 12);
            lblCardValue1.Location = new Point(18, 57);
            lblCardValue1.Name = "lblCardValue1";
            lblCardValue1.Size = new Size(112, 37);
            lblCardValue1.TabIndex = 1;
            lblCardValue1.Text = "24 User";
            // 
            // lblCardTitle1
            // 
            lblCardTitle1.AutoSize = true;
            lblCardTitle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardTitle1.ForeColor = Color.FromArgb(75, 85, 99);
            lblCardTitle1.Location = new Point(21, 24);
            lblCardTitle1.Name = "lblCardTitle1";
            lblCardTitle1.Size = new Size(75, 17);
            lblCardTitle1.TabIndex = 0;
            lblCardTitle1.Text = "User Aktif";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 520);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblAppName;
        private Button btnHome;
        private Button btnReports;
        private Button btnSettings;
        private Button btnLogout;
        private Panel panelHeader;
        private Label lblWelcome;
        private Panel panelContent;
        private Panel panelCard1;
        private Label lblCardTitle1;
        private Label lblCardValue1;
        private Panel panelCard2;
        private Label lblCardValue2;
        private Label lblCardTitle2;
        private Panel panelCard3;
        private Label lblCardValue3;
        private Label lblCardTitle3;
    }
}
