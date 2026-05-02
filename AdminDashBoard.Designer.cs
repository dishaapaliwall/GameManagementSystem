namespace GameManagementSystem
{
    partial class AdminDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvBackground = new DataGridView();
            panelHeader = new Panel();
            btnSeedData = new Button();
            labelBalance = new Label();
            labelRole = new Label();
            labelEmail = new Label();
            labelWelcome = new Label();
            labelLogo = new Label();
            panelPendingRequests = new Panel();
            btnRejectGame = new Button();
            btnApproveGame = new Button();
            dgvPendingGames = new DataGridView();
            labelPendingRequests = new Label();
            panelGameApprovals = new Panel();
            dgvGameHistory = new DataGridView();
            labelGameApprovals = new Label();
            panelWallet = new Panel();
            dgvAdminTransactions = new DataGridView();
            labelWalletTransactions = new Label();
            labelWalletBalance = new Label();
            labelWallet = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBackground).BeginInit();
            panelHeader.SuspendLayout();
            panelPendingRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingGames).BeginInit();
            panelGameApprovals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGameHistory).BeginInit();
            panelWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminTransactions).BeginInit();
            SuspendLayout();
            // 
            // dgvBackground
            // 
            dgvBackground.BackgroundColor = Color.DarkOliveGreen;
            dgvBackground.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBackground.Dock = DockStyle.Fill;
            dgvBackground.GridColor = Color.DarkOliveGreen;
            dgvBackground.Location = new Point(0, 0);
            dgvBackground.Name = "dgvBackground";
            dgvBackground.RowHeadersWidth = 62;
            dgvBackground.Size = new Size(1920, 1080);
            dgvBackground.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.OliveDrab;
            panelHeader.Controls.Add(btnSeedData);
            panelHeader.Controls.Add(labelBalance);
            panelHeader.Controls.Add(labelRole);
            panelHeader.Controls.Add(labelEmail);
            panelHeader.Controls.Add(labelWelcome);
            panelHeader.Location = new Point(12, 100);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1896, 120);
            panelHeader.TabIndex = 2;
            // 
            // btnSeedData
            // 
            btnSeedData.BackColor = Color.DarkOliveGreen;
            btnSeedData.FlatAppearance.BorderSize = 0;
            btnSeedData.FlatStyle = FlatStyle.Flat;
            btnSeedData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeedData.ForeColor = Color.Yellow;
            btnSeedData.Location = new Point(1350, 40);
            btnSeedData.Name = "btnSeedData";
            btnSeedData.Size = new Size(150, 40);
            btnSeedData.TabIndex = 4;
            btnSeedData.Text = "Seed Test Games";
            btnSeedData.UseVisualStyleBackColor = false;
            btnSeedData.Click += btnSeedData_Click;
            // 
            // labelBalance
            // 
            labelBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelBalance.ForeColor = Color.White;
            labelBalance.Location = new Point(1600, 14);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(166, 38);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "Balance: ₹0";
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(1600, 70);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(200, 30);
            labelRole.TabIndex = 2;
            labelRole.Text = "Role: super_admin";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(14, 70);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(108, 30);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email: ---";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI Black", 17F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(14, 14);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(357, 46);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome, Admin!";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.BackColor = Color.DarkOliveGreen;
            labelLogo.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            labelLogo.ForeColor = Color.DarkSeaGreen;
            labelLogo.Location = new Point(12, 10);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(372, 74);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "GAMEVERSE";
            // 
            // panelPendingRequests
            // 
            panelPendingRequests.BackColor = Color.OliveDrab;
            panelPendingRequests.Controls.Add(btnRejectGame);
            panelPendingRequests.Controls.Add(btnApproveGame);
            panelPendingRequests.Controls.Add(dgvPendingGames);
            panelPendingRequests.Controls.Add(labelPendingRequests);
            panelPendingRequests.Location = new Point(12, 230);
            panelPendingRequests.Name = "panelPendingRequests";
            panelPendingRequests.Size = new Size(935, 400);
            panelPendingRequests.TabIndex = 4;
            // 
            // btnRejectGame
            // 
            btnRejectGame.BackColor = Color.Firebrick;
            btnRejectGame.FlatAppearance.BorderSize = 0;
            btnRejectGame.FlatStyle = FlatStyle.Flat;
            btnRejectGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRejectGame.ForeColor = Color.White;
            btnRejectGame.Location = new Point(170, 340);
            btnRejectGame.Name = "btnRejectGame";
            btnRejectGame.Size = new Size(140, 45);
            btnRejectGame.TabIndex = 3;
            btnRejectGame.Text = "Reject";
            btnRejectGame.UseVisualStyleBackColor = false;
            btnRejectGame.Click += btnRejectGame_Click;
            // 
            // btnApproveGame
            // 
            btnApproveGame.BackColor = Color.ForestGreen;
            btnApproveGame.FlatAppearance.BorderSize = 0;
            btnApproveGame.FlatStyle = FlatStyle.Flat;
            btnApproveGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApproveGame.ForeColor = Color.White;
            btnApproveGame.Location = new Point(14, 340);
            btnApproveGame.Name = "btnApproveGame";
            btnApproveGame.Size = new Size(140, 45);
            btnApproveGame.TabIndex = 2;
            btnApproveGame.Text = "Approve";
            btnApproveGame.UseVisualStyleBackColor = false;
            btnApproveGame.Click += btnApproveGame_Click;
            // 
            // dgvPendingGames
            // 
            dgvPendingGames.BackgroundColor = Color.DarkOliveGreen;
            dgvPendingGames.BorderStyle = BorderStyle.None;
            dgvPendingGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingGames.Location = new Point(14, 55);
            dgvPendingGames.Name = "dgvPendingGames";
            dgvPendingGames.RowHeadersWidth = 62;
            dgvPendingGames.Size = new Size(907, 270);
            dgvPendingGames.TabIndex = 1;
            // 
            // labelPendingRequests
            // 
            labelPendingRequests.AutoSize = true;
            labelPendingRequests.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            labelPendingRequests.ForeColor = Color.White;
            labelPendingRequests.Location = new Point(0, 0);
            labelPendingRequests.Name = "labelPendingRequests";
            labelPendingRequests.Size = new Size(346, 48);
            labelPendingRequests.TabIndex = 0;
            labelPendingRequests.Text = "Pending Requests";
            // 
            // panelGameApprovals
            // 
            panelGameApprovals.BackColor = Color.OliveDrab;
            panelGameApprovals.Controls.Add(dgvGameHistory);
            panelGameApprovals.Controls.Add(labelGameApprovals);
            panelGameApprovals.Location = new Point(963, 230);
            panelGameApprovals.Name = "panelGameApprovals";
            panelGameApprovals.Size = new Size(945, 400);
            panelGameApprovals.TabIndex = 5;
            // 
            // dgvGameHistory
            // 
            dgvGameHistory.BackgroundColor = Color.DarkOliveGreen;
            dgvGameHistory.BorderStyle = BorderStyle.None;
            dgvGameHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGameHistory.Location = new Point(14, 55);
            dgvGameHistory.Name = "dgvGameHistory";
            dgvGameHistory.RowHeadersWidth = 62;
            dgvGameHistory.Size = new Size(917, 330);
            dgvGameHistory.TabIndex = 1;
            // 
            // labelGameApprovals
            // 
            labelGameApprovals.AutoSize = true;
            labelGameApprovals.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            labelGameApprovals.ForeColor = Color.White;
            labelGameApprovals.Location = new Point(0, 0);
            labelGameApprovals.Name = "labelGameApprovals";
            labelGameApprovals.Size = new Size(326, 48);
            labelGameApprovals.TabIndex = 0;
            labelGameApprovals.Text = "Game Approvals";
            // 
            // panelWallet
            // 
            panelWallet.BackColor = Color.OliveDrab;
            panelWallet.Controls.Add(dgvAdminTransactions);
            panelWallet.Controls.Add(labelWalletTransactions);
            panelWallet.Controls.Add(labelWalletBalance);
            panelWallet.Controls.Add(labelWallet);
            panelWallet.Location = new Point(12, 645);
            panelWallet.Name = "panelWallet";
            panelWallet.Size = new Size(1896, 420);
            panelWallet.TabIndex = 6;
            // 
            // dgvAdminTransactions
            // 
            dgvAdminTransactions.BackgroundColor = Color.DarkOliveGreen;
            dgvAdminTransactions.BorderStyle = BorderStyle.None;
            dgvAdminTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminTransactions.Location = new Point(14, 110);
            dgvAdminTransactions.Name = "dgvAdminTransactions";
            dgvAdminTransactions.RowHeadersWidth = 62;
            dgvAdminTransactions.Size = new Size(1868, 295);
            dgvAdminTransactions.TabIndex = 4;
            // 
            // labelWalletTransactions
            // 
            labelWalletTransactions.AutoSize = true;
            labelWalletTransactions.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelWalletTransactions.ForeColor = Color.White;
            labelWalletTransactions.Location = new Point(14, 70);
            labelWalletTransactions.Name = "labelWalletTransactions";
            labelWalletTransactions.Size = new Size(265, 36);
            labelWalletTransactions.TabIndex = 3;
            labelWalletTransactions.Text = "Admin Transactions";
            // 
            // labelWalletBalance
            // 
            labelWalletBalance.AutoSize = true;
            labelWalletBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelWalletBalance.ForeColor = Color.White;
            labelWalletBalance.Location = new Point(14, 40);
            labelWalletBalance.Name = "labelWalletBalance";
            labelWalletBalance.Size = new Size(166, 38);
            labelWalletBalance.TabIndex = 1;
            labelWalletBalance.Text = "Balance: ₹0";
            // 
            // labelWallet
            // 
            labelWallet.AutoSize = true;
            labelWallet.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            labelWallet.ForeColor = Color.White;
            labelWallet.Location = new Point(0, 0);
            labelWallet.Name = "labelWallet";
            labelWallet.Size = new Size(281, 48);
            labelWallet.TabIndex = 0;
            labelWallet.Text = "Admin Wallet";
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelWallet);
            Controls.Add(panelGameApprovals);
            Controls.Add(panelPendingRequests);
            Controls.Add(labelLogo);
            Controls.Add(panelHeader);
            Controls.Add(dgvBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashBoard";
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBackground).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelPendingRequests.ResumeLayout(false);
            panelPendingRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingGames).EndInit();
            panelGameApprovals.ResumeLayout(false);
            panelGameApprovals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGameHistory).EndInit();
            panelWallet.ResumeLayout(false);
            panelWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBackground;
        private Panel panelHeader;
        private Label labelBalance;
        private Label labelRole;
        private Label labelEmail;
        private Label labelWelcome;
        private Label labelLogo;
        private Panel panelPendingRequests;
        private Label labelPendingRequests;
        private DataGridView dgvPendingGames;
        private Button btnRejectGame;
        private Button btnApproveGame;
        private Panel panelGameApprovals;
        private Label labelGameApprovals;
        private DataGridView dgvGameHistory;
        private Panel panelWallet;
        private Label labelWallet;
        private Label labelWalletBalance;
        private DataGridView dgvAdminTransactions;
        private Label labelWalletTransactions;
        private Button btnSeedData;
    }
}