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

namespace Demo1
{
    public partial class FirstDemo : Form
    {
        public FirstDemo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJ6RMN6\\SQLEXPRESS;Initial Catalog=personal_data;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into user_table values (@ID, @Name, @Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox3.Text));
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert successfully !!!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJ6RMN6\\SQLEXPRESS;Initial Catalog=personal_data;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update user_table set Name=@Name, Age=@Age where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox3.Text));
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfully !!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJ6RMN6\\SQLEXPRESS;Initial Catalog=personal_data;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete user_table where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted successfully. !!!");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJ6RMN6\\SQLEXPRESS;Initial Catalog=personal_data;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from user_table", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("susscessfully search. !!!");

        }
    }
}
