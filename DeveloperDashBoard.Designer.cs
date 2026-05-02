namespace GameManagementSystem
{
    partial class DeveloperDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStudio = new System.Windows.Forms.Label();

            this.labelTotalGames = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();

            this.dataGridGames = new System.Windows.Forms.DataGridView();
            this.dataGridMatches = new System.Windows.Forms.DataGridView();
            this.panelManageGames = new System.Windows.Forms.Panel();
            this.labelManageGames = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxGamePrice = new System.Windows.Forms.TextBox();
            this.textBoxGameCategory = new System.Windows.Forms.TextBox();
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonDeleteGame = new System.Windows.Forms.Button();

            this.panelSocial = new System.Windows.Forms.Panel();
            this.labelSocial = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFriend = new System.Windows.Forms.TextBox();
            this.buttonAddFriend = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonRefreshSocial = new System.Windows.Forms.Button();
            this.dataGridRequests = new System.Windows.Forms.DataGridView();
            this.dataGridFriends = new System.Windows.Forms.DataGridView();

            this.btnLogout = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatches)).BeginInit();
            this.panelManageGames.SuspendLayout();
            this.panelSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriends)).BeginInit();

            this.SuspendLayout();

            // 🔹 FORM
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Text = "Developer Dashboard";
            this.Load += new System.EventHandler(this.DeveloperDashBoard_Load);

            // 🔹 PROFILE
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            labelWelcome.Location = new System.Drawing.Point(20, 20);
            labelWelcome.ForeColor = System.Drawing.Color.White;

            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelEmail.Location = new System.Drawing.Point(20, 55);
            labelEmail.ForeColor = System.Drawing.Color.White;

            labelStudio.AutoSize = true;
            labelStudio.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelStudio.Location = new System.Drawing.Point(20, 85);
            labelStudio.ForeColor = System.Drawing.Color.White;

            // 🔹 SUMMARY
            labelTotalGames.AutoSize = true;
            labelTotalGames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelTotalGames.Location = new System.Drawing.Point(400, 20);
            labelTotalGames.ForeColor = System.Drawing.Color.White;

            labelSales.AutoSize = true;
            labelSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelSales.Location = new System.Drawing.Point(400, 55);
            labelSales.ForeColor = System.Drawing.Color.White;

            labelRevenue.AutoSize = true;
            labelRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelRevenue.Location = new System.Drawing.Point(600, 20);
            labelRevenue.ForeColor = System.Drawing.Color.White;

            labelMatches.AutoSize = true;
            labelMatches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelMatches.Location = new System.Drawing.Point(600, 55);
            labelMatches.ForeColor = System.Drawing.Color.White;

            // 🔹 MY GAMES
            dataGridGames.Location = new System.Drawing.Point(20, 120);
            dataGridGames.Size = new System.Drawing.Size(650, 200);

            // 🔹 MATCH HISTORY
            dataGridMatches.Location = new System.Drawing.Point(700, 120);
            dataGridMatches.Size = new System.Drawing.Size(650, 200);

            // 🔹 MANAGE GAMES (PANEL)
            panelManageGames.BackColor = System.Drawing.Color.OliveDrab;
            panelManageGames.Location = new System.Drawing.Point(20, 340);
            panelManageGames.Size = new System.Drawing.Size(1330, 150);

            labelManageGames.AutoSize = true;
            labelManageGames.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            labelManageGames.ForeColor = System.Drawing.Color.White;
            labelManageGames.Location = new System.Drawing.Point(10, 10);
            labelManageGames.Text = "Manage Games";

            textBoxGameName.BackColor = System.Drawing.Color.DarkOliveGreen;
            textBoxGameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            textBoxGameName.Location = new System.Drawing.Point(20, 50);
            textBoxGameName.PlaceholderText = "Game Name";
            textBoxGameName.Size = new System.Drawing.Size(200, 32);

            textBoxGamePrice.BackColor = System.Drawing.Color.DarkOliveGreen;
            textBoxGamePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxGamePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            textBoxGamePrice.Location = new System.Drawing.Point(240, 50);
            textBoxGamePrice.PlaceholderText = "Price";
            textBoxGamePrice.Size = new System.Drawing.Size(150, 32);

            textBoxGameCategory.BackColor = System.Drawing.Color.DarkOliveGreen;
            textBoxGameCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxGameCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            textBoxGameCategory.Location = new System.Drawing.Point(410, 50);
            textBoxGameCategory.PlaceholderText = "Category";
            textBoxGameCategory.Size = new System.Drawing.Size(150, 32);

            buttonAddGame.BackColor = System.Drawing.Color.DarkOliveGreen;
            buttonAddGame.FlatAppearance.BorderSize = 0;
            buttonAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonAddGame.Location = new System.Drawing.Point(580, 48);
            buttonAddGame.Size = new System.Drawing.Size(100, 38);
            buttonAddGame.Text = "Add Game";
            buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);

            buttonDeleteGame.BackColor = System.Drawing.Color.Firebrick;
            buttonDeleteGame.FlatAppearance.BorderSize = 0;
            buttonDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDeleteGame.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonDeleteGame.Location = new System.Drawing.Point(690, 48);
            buttonDeleteGame.Size = new System.Drawing.Size(110, 38);
            buttonDeleteGame.Text = "Delete Game";
            buttonDeleteGame.Click += new System.EventHandler(this.buttonDeleteGame_Click);

            panelManageGames.Controls.Add(labelManageGames);
            panelManageGames.Controls.Add(textBoxGameName);
            panelManageGames.Controls.Add(textBoxGamePrice);
            panelManageGames.Controls.Add(textBoxGameCategory);
            panelManageGames.Controls.Add(buttonAddGame);
            panelManageGames.Controls.Add(buttonDeleteGame);

            // 🔹 SOCIAL SECTION (PANEL)
            panelSocial.BackColor = System.Drawing.Color.OliveDrab;
            panelSocial.Location = new System.Drawing.Point(20, 530);
            panelSocial.Size = new System.Drawing.Size(1330, 250);

            labelSocial.AutoSize = true;
            labelSocial.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            labelSocial.ForeColor = System.Drawing.Color.White;
            labelSocial.Location = new System.Drawing.Point(0, 0);
            labelSocial.Text = "Social";

            textBoxFriend.BackColor = System.Drawing.Color.DarkOliveGreen;
            textBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxFriend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            textBoxFriend.Location = new System.Drawing.Point(18, 51);
            textBoxFriend.PlaceholderText = "Enter UserID";
            textBoxFriend.Size = new System.Drawing.Size(187, 32);

            buttonAddFriend.BackColor = System.Drawing.Color.DarkOliveGreen;
            buttonAddFriend.FlatAppearance.BorderSize = 0;
            buttonAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddFriend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonAddFriend.Location = new System.Drawing.Point(220, 49);
            buttonAddFriend.Size = new System.Drawing.Size(79, 38);
            buttonAddFriend.Text = "Add";
            buttonAddFriend.Click += new System.EventHandler(this.buttonAddFriend_Click);

            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            label12.Location = new System.Drawing.Point(18, 98);
            label12.Text = "My Friends";

            dataGridFriends.Location = new System.Drawing.Point(18, 137);
            dataGridFriends.Size = new System.Drawing.Size(600, 100);

            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            label13.Location = new System.Drawing.Point(640, 98);
            label13.Text = "Incoming Requests";

            dataGridRequests.Location = new System.Drawing.Point(640, 137);
            dataGridRequests.Size = new System.Drawing.Size(600, 100);

            buttonAccept.BackColor = System.Drawing.Color.ForestGreen;
            buttonAccept.FlatAppearance.BorderSize = 0;
            buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonAccept.Location = new System.Drawing.Point(1250, 137);
            buttonAccept.Size = new System.Drawing.Size(70, 30);
            buttonAccept.Text = "Accept";
            buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);

            buttonReject.BackColor = System.Drawing.Color.Firebrick;
            buttonReject.FlatAppearance.BorderSize = 0;
            buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonReject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonReject.Location = new System.Drawing.Point(1250, 172);
            buttonReject.Size = new System.Drawing.Size(70, 30);
            buttonReject.Text = "Reject";
            buttonReject.Click += new System.EventHandler(this.buttonReject_Click);

            buttonRefreshSocial.BackColor = System.Drawing.Color.DarkOliveGreen;
            buttonRefreshSocial.FlatAppearance.BorderSize = 0;
            buttonRefreshSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefreshSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            buttonRefreshSocial.ForeColor = System.Drawing.Color.White;
            buttonRefreshSocial.Location = new System.Drawing.Point(1250, 207);
            buttonRefreshSocial.Size = new System.Drawing.Size(70, 30);
            buttonRefreshSocial.Text = "Refresh";
            buttonRefreshSocial.Click += new System.EventHandler(this.buttonRefreshSocial_Click);

            panelSocial.Controls.Add(labelSocial);
            panelSocial.Controls.Add(textBoxFriend);
            panelSocial.Controls.Add(buttonAddFriend);
            panelSocial.Controls.Add(label12);
            panelSocial.Controls.Add(dataGridFriends);
            panelSocial.Controls.Add(label13);
            panelSocial.Controls.Add(dataGridRequests);
            panelSocial.Controls.Add(buttonAccept);
            panelSocial.Controls.Add(buttonReject);
            panelSocial.Controls.Add(buttonRefreshSocial);

            // 🔹 BUTTONS

            btnLogout.Text = "Logout";
            btnLogout.Location = new System.Drawing.Point(1200, 20);
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 🔹 ADD CONTROLS

            this.Controls.Add(labelWelcome);
            this.Controls.Add(labelEmail);
            this.Controls.Add(labelStudio);

            this.Controls.Add(labelTotalGames);
            this.Controls.Add(labelSales);
            this.Controls.Add(labelRevenue);
            this.Controls.Add(labelMatches);

            this.Controls.Add(dataGridGames);
            this.Controls.Add(dataGridMatches);
            this.Controls.Add(panelManageGames);

            this.Controls.Add(panelSocial);

            this.Controls.Add(btnLogout);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatches)).EndInit();
            panelManageGames.ResumeLayout(false);
            panelManageGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFriends)).EndInit();
            panelSocial.ResumeLayout(false);
            panelSocial.PerformLayout();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStudio;

        private System.Windows.Forms.Label labelTotalGames;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.Label labelMatches;

        private System.Windows.Forms.DataGridView dataGridGames;
        private System.Windows.Forms.DataGridView dataGridMatches;
        private System.Windows.Forms.Panel panelManageGames;
        private System.Windows.Forms.Label labelManageGames;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxGamePrice;
        private System.Windows.Forms.TextBox textBoxGameCategory;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonDeleteGame;

        private System.Windows.Forms.Panel panelSocial;
        private System.Windows.Forms.Label labelSocial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxFriend;
        private System.Windows.Forms.Button buttonAddFriend;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonRefreshSocial;
        private System.Windows.Forms.DataGridView dataGridRequests;
        private System.Windows.Forms.DataGridView dataGridFriends;

        private System.Windows.Forms.Button btnLogout;
    }
}