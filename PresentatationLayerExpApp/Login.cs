using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpeditApplikation;

namespace PresentatationLayerExpApp
{
    public partial class Login : Form
    {

        private string username = "Admin";
        private string password = "hunter2";
        BookingSystem bs;


        public Login()
        {
            bs = new BookingSystem();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (bs.LogIn(int.Parse(textBox1.Text), textBox2.Text)) 
            //{
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            //}
            //else
            //{
                
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
