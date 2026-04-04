using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using System.Drawing;
namespace GameManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;

            // 🔥 CLEAN INPUT (IMPORTANT)
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // ❗ block placeholder / empty
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                username.Equals("Enter Username", StringComparison.OrdinalIgnoreCase) ||
                password.Equals("Enter Password", StringComparison.OrdinalIgnoreCase))
            {
                labelError.Text = "Invalid Credentials";
                labelError.Visible = true;
                return;
            }

            string connStr = "server=localhost;database=trial_1;uid=root;pwd=schetza@2005;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT user_id FROM users WHERE username=@u AND password=@p LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);   // use cleaned value
                    cmd.Parameters.AddWithValue("@p", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // SUCCESS
                        string uid = result.ToString();

                        MessageBox.Show("Login Successful!");

                        // OPEN PLAYER DASHBOARD
                        if (uid.StartsWith("p_"))
                        {
                            PlayerDashboard p = new PlayerDashboard(uid);
                            p.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Only Player Dashboard available right now");
                        }
                    }
                    else
                    {
                        // INVALID
                        labelError.Text = "Invalid Credentials";
                        labelError.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    // show diagnostic information to help debugging
                    labelError.Text = "Invalid Credentials";
                    labelError.Visible = true;
                    MessageBox.Show(ex.ToString(), "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignUp s = new FormSignUp();
            s.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
