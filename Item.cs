using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_shopp
{
    public partial class forrm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-15LI0SB\SQLEXPRESS; Database=HardwareShop; Integrated Security=True;");
        private object Botton1;
        SqlConnection cmd;
        SqlDataReader dr;
        public forrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginig ss = new Loginig();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

            Customers f3 = new Customers();
            f3.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billing f5 = new Billing();
            f5.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            forrm f1 = new forrm();
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label lbl = new Label();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    SqlCommand edit = new SqlCommand("ITEM FROM [MSreplication_option] where name = '" + Edit + "'");
            //    edit.ExecuteNonQuery();
            //    MessageBox.Show("Successfully Edit");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
        }

        private void delete_Click(object sender, EventArgs e, object Con)
        {

            SqlCommand Command = new SqlCommand("Delete ProdutInfo_Tapwhere PrductId= '" + int.Parse(Hardware_shopp.textBox2.text) + "'");
            Command.ExecuteNonQuery();

            MessageBox.Show("Successfully Deleted.");
            BindData();
            object value = BindData();
        }

        private object BindData()
        {
            throw new NotImplementedException();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO item (item, Category, Price, Stock, ManyFactory) VALUES (@item, @category, @price, @stock, @manufacturer)", con);

                cmd.Parameters.AddWithValue("@item", textBox1.Text);
                cmd.Parameters.AddWithValue("@category", textBox2.Text);
                cmd.Parameters.AddWithValue("@price", textBox3.Text);
                cmd.Parameters.AddWithValue("@stock", textBox4.Text);
                cmd.Parameters.AddWithValue("@manufacturer", textBox5.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully!");
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

        private void delete_Click(object sender, EventArgs e)
        {



        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand del = new SqlCommand("DELETE FROM [MSreplication_option] where name = '" + Delete + "'");
            //    del.ExecuteNonQuery(); MessageBox.Show("Successfully deleted");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand del = new SqlCommand("ITEM FROM [MSreplication_option] where name = '" + Delete + "'");
            //    del.ExecuteNonQuery();
            //    MessageBox.Show("Successfully delet");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{

            //}

        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}