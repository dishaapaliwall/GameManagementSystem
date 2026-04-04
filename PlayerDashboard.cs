using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameManagementSystem
{
    public partial class PlayerDashboard : Form
    {
        string userId;

        public PlayerDashboard(string uid)
        {
            InitializeComponent();
            userId = uid;
        }

        private void PlayerDashboard_Load(object sender, EventArgs e)
        {
            if (this.DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            string connStr = "server=localhost;database=trial_1;uid=root;pwd=schetza@2005;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // USER INFO
                string query1 = "SELECT username, email FROM users WHERE user_id=@id";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@id", userId);

                MySqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    label2.Text = "Welcome, " + reader["username"].ToString();
                    label3.Text = "Email: " + reader["email"].ToString();
                }
                reader.Close();

                // BALANCE
                string query2 = "SELECT balance FROM wallet WHERE user_id=@id";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@id", userId);

                object balance = cmd2.ExecuteScalar();
                label4.Text = "Balance: ₹ " + (balance == null ? "0" : balance.ToString());

                // AVAILABLE GAMES
                DataTable dt = new DataTable();
                new MySqlDataAdapter("SELECT * FROM game WHERE approval_status='approved'", conn).Fill(dt);
                dataGridViewAvailable.DataSource = dt;

                // PURCHASED
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(
                    "SELECT g.* FROM game g JOIN purchase p ON g.game_id=p.game_id WHERE p.user_id=@id", conn);
                da2.SelectCommand.Parameters.AddWithValue("@id", userId);
                da2.Fill(dt2);
                dataGridViewPurchased.DataSource = dt2;

                // STATS
                DataTable dtStats = new DataTable();
                MySqlDataAdapter daStats = new MySqlDataAdapter(
                    @"SELECT g.title AS Game,
                             s.total_play_time AS PlayTime,
                             s.rank_level AS RankLevel,
                             s.experience AS Experience
                      FROM player_game_stats s
                      JOIN game g ON s.game_id = g.game_id
                      WHERE s.user_id = @id", conn);
                daStats.SelectCommand.Parameters.AddWithValue("@id", userId);
                daStats.Fill(dtStats);
                dataGridViewStats.DataSource = dtStats;

                // GAME HISTORY
                DataTable dtHistory = new DataTable();
                MySqlDataAdapter daHistory = new MySqlDataAdapter(
                    @"SELECT g.title AS Game,
                             p.score AS Score,
                             p.result AS Result,
                             m.duration AS Duration,
                             m.started_at AS PlayedOn
                      FROM participation p
                      JOIN match_session m ON p.match_id = m.match_id
                      JOIN game g ON m.game_id = g.game_id
                      WHERE p.user_id = @id", conn);
                daHistory.SelectCommand.Parameters.AddWithValue("@id", userId);
                daHistory.Fill(dtHistory);
                dataGridViewHistory.DataSource = dtHistory;

                // SOCIALS
                DataTable dtSocial = new DataTable();
                MySqlDataAdapter daSocial = new MySqlDataAdapter(
                    "SELECT user1, user2, status FROM socials WHERE user1=@id OR user2=@id", conn);
                daSocial.SelectCommand.Parameters.AddWithValue("@id", userId);
                daSocial.Fill(dtSocial);
                dataGridViewFriends.DataSource = dtSocial;
            }

            LoadTransactions();
        }

        private void LoadTransactions()
        {
            string connStr = "server=localhost;database=trial_1;uid=root;pwd=schetza@2005;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT transaction_id, amount, transaction_type, transaction_status FROM transaction WHERE user_id=@id", conn);
                da.SelectCommand.Parameters.AddWithValue("@id", userId);
                da.Fill(dt);
                dataGridViewTransactions.DataSource = dt;
            }
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "") return;

            decimal amount = Convert.ToDecimal(textBoxAmount.Text);

            string connStr = "server=localhost;database=trial_1;uid=root;pwd=schetza@2005;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                new MySqlCommand("UPDATE wallet SET balance = balance + @amt WHERE user_id=@id", conn)
                {
                    Parameters = {
                        new MySqlParameter("@amt", amount),
                        new MySqlParameter("@id", userId)
                    }
                }.ExecuteNonQuery();

                MessageBox.Show("Money Added ✅");
            }
        }

        private void buttonAddFriend_Click(object sender, EventArgs e)
        {
            string friendId = textBoxFriend.Text.Trim();
            if (friendId == "") return;

            string connStr = "server=localhost;database=trial_1;uid=root;pwd=schetza@2005;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                new MySqlCommand(
                    "INSERT INTO socials(user1,user2,since_date,status) VALUES(@u1,@u2,NOW(),'pending')", conn)
                {
                    Parameters = {
                        new MySqlParameter("@u1", userId),
                        new MySqlParameter("@u2", friendId)
                    }
                }.ExecuteNonQuery();

                MessageBox.Show("Friend Request Sent ✅");
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e) { }
        private void buttonReject_Click(object sender, EventArgs e) { }
        private void buybutton_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBoxAmount_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void buttonAddFriend_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void textBoxFriend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}