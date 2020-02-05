using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Demo1
{
    public partial class LoginProject : Form
    {
        public LoginProject()
        {
            InitializeComponent();
        }

        private void LofinProject_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJ6RMN6\\SQLEXPRESS;Initial Catalog=personal_data;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM user_login WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                
                this.Hide();
                MessageBox.Show("successfully login");
                FirstDemo ss = new FirstDemo();
                ss.Show();

            }
            else
            {
                MessageBox.Show("check your user name and password.");
            }


        }
    }
}
