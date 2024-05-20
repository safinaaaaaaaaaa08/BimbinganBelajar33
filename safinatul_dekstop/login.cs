using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace safinatul_dekstop
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "321")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textBox1.Text == "Siswa" && textBox2.Text == "123")
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna / kata sandi salah");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
