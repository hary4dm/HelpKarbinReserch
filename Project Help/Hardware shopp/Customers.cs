using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hardware_shopp
{
    public partial class Customers : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-15LI0SB\SQLEXPRESS; Database=HardwareShop; Integrated Security=True;");
        SqlConnection cmd;
        SqlDataReader dr;
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear(); // clear existing items
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT username FROM login1", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["username"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Customers f3 = new Customers();
            f3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            forrm f1 = new forrm();
            this.Hide();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Close();
            Loginig ss = new Loginig();
            ss.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billing f5 = new Billing();
            f5.Show();
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand del = new SqlCommand("CUSTOMERS [MSreplication_option] where name = '" + Edit+ "'");
            //    int v = del.ExecuteNonQuery(); MessageBox.Show("Successfully edit");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM login1 WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", listBox1.Text); 

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Item Deleted Successfully!");
                else
                    MessageBox.Show("Item not found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Deleting: " + ex.Message);
            }
            finally
            {
                con.Close();
               // LoadItemNames(); // or LoadTableData() if you're using DataGridView
            }
        }

        private void additem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO login1 (username, password1)Values(@username,@password)", con);

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added User");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Adding: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
