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
    public partial class Billing : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-15LI0SB\SQLEXPRESS; Database=HardwareShop; Integrated Security=True;");
        SqlConnection cmd;
        SqlDataReader dr;
        public Billing()
        {
            InitializeComponent();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginig ss = new Loginig();
            ss.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            forrm f1 = new forrm();
            f1.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Customers f3 = new Customers();
            f3.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billing f5 = new Billing();
            f5.Show();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand additem = new SqlCommand("BILLING FROM [MSreplication_option] where name = '" + delete + "'");
            //    additem.ExecuteNonQuery();
            //    MessageBox.Show("Successfully additem");
            //    } 
            //catch (Exception )
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}

        }

        private void additem_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        SqlCommand Reset = new SqlCommand("BILLING [MSreplication_option] where name = '" + delete + "'");
        //        Reset.ExecuteNonQuery();
        //        MessageBox.Show("Successfully Reset");
        //            }
        //    catch (Exception )

        //    {
        //        MessageBox.Show("Error");
        //    }
        //    finally
        //    {

        //    }
        
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT item FROM item", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["item"].ToString());
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
