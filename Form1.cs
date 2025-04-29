using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_shopp
{
    public partial class Loginig : Form
    {
        // Corrected connection string (adjust server and database names as needed)
        string connectionString = "Server=DESKTOP-15LI0SB\\SQLEXPRESS; Database=HardwareShop; Integrated Security=True;";

        public Loginig()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any additional form load logic (if needed)
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                // Use the username and password text fields, trimming any extra spaces
                string username = textUser.Text.Trim();
                string password = textPass.Text.Trim();

                // Debugging outputs to check the username and password (now without hashing)
                Console.WriteLine("Username: " + username);
                Console.WriteLine("Password: " + password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to check username and password
                    string query = "SELECT COUNT(*) FROM login1 WHERE Username = @username AND Password1 = @password";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); // Use plain password now

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!");

                        forrm f = new forrm();
                     f.Show();
                     this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any connection errors or exceptions
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Any action for label1 click (if needed)
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Close the application when label4 is clicked
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Any action for pictureBox1 click (if needed)
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the username field if needed
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in the password field if needed
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Show/hide password based on checkbox
            if (checkBox1.Checked)
            {
                textPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                textPass.PasswordChar = '*'; // Hide password
            }
        }
    }
}
