using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameManagementSystem
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox4.Text.Trim();

            // ❗ validation
            if (userId == "" || username == "" || email == "" || password == "")
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            string connStr = "server=localhost;database=trial_2;uid=root;pwd=gyanesh@2006;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 🔹 1. INSERT INTO USERS
                    string q1 = "INSERT INTO users(user_id, username, email, password) VALUES(@id,@name,@email,@pass)";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn, trans);

                    cmd1.Parameters.AddWithValue("@id", userId);
                    cmd1.Parameters.AddWithValue("@name", username);
                    cmd1.Parameters.AddWithValue("@email", email);
                    cmd1.Parameters.AddWithValue("@pass", password);

                    cmd1.ExecuteNonQuery();

                    // 🔹 2. INSERT INTO WALLET
                    string q2 = "INSERT INTO wallet(user_id, balance) VALUES(@id, 0)";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn, trans);

                    cmd2.Parameters.AddWithValue("@id", userId);
                    cmd2.ExecuteNonQuery();

                    // 🔹 3. ROLE LOGIC (PREFIX BASED)
                    if (userId.StartsWith("p_"))
                    {
                        string q3 = "INSERT INTO player(user_id) VALUES(@id)";
                        MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                        cmd3.Parameters.AddWithValue("@id", userId);
                        cmd3.ExecuteNonQuery();
                    }
                    else if (userId.StartsWith("d_"))
                    {
                        string q3 = "INSERT INTO developer(user_id, studio_name) VALUES(@id, 'New Studio')";
                        MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                        cmd3.Parameters.AddWithValue("@id", userId);
                        cmd3.ExecuteNonQuery();
                    }
                    else if (userId.StartsWith("a_"))
                    {
                        string q3 = "INSERT INTO admin(user_id, role) VALUES(@id, 'admin')";
                        MySqlCommand cmd3 = new MySqlCommand(q3, conn, trans);
                        cmd3.Parameters.AddWithValue("@id", userId);
                        cmd3.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new Exception("UserID must start with p_, d_, or a_ ❌");
                    }

                    // ✅ SAVE ALL
                    trans.Commit();

                    MessageBox.Show("Account Created Successfully!");

                    // back to login
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOliveGreen;
            CenterControls();
        }

        private void CenterControls()
        {
            this.WindowState = FormWindowState.Maximized;
            
            Panel p = new Panel();
            int minX = int.MaxValue, minY = int.MaxValue, maxX = 0, maxY = 0;
            
            foreach (Control c in this.Controls)
            {
                if (c.Left < minX) minX = c.Left;
                if (c.Top < minY) minY = c.Top;
                if (c.Right > maxX) maxX = c.Right;
                if (c.Bottom > maxY) maxY = c.Bottom;
            }
            
            p.Size = new Size(maxX - minX, maxY - minY);
            
            Control[] ctrls = new Control[this.Controls.Count];
            this.Controls.CopyTo(ctrls, 0);
            
            foreach (Control c in ctrls)
            {
                c.Left -= minX;
                c.Top -= minY;
                p.Controls.Add(c);
            }
            
            p.Location = new Point((this.ClientSize.Width - p.Width) / 2, (this.ClientSize.Height - p.Height) / 2);
            p.Anchor = AnchorStyles.None;
            this.Controls.Add(p);

            this.Resize += (s, ev) => {
                p.Location = new Point((this.ClientSize.Width - p.Width) / 2, (this.ClientSize.Height - p.Height) / 2);
            };
        }
    }
}
