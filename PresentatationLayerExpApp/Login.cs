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
        BookingSystem bookingSystem;

        public Login(BookingSystem system)
        {
            InitializeComponent();
            bookingSystem = BookingSystem.GetBs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookingSystem.LogIn(textBox1.Text, textBox2.Text) == "admin")
            {
                Form1 f = new Form1(bookingSystem);
                f.Show();
                this.Hide();
            }
            else if (bookingSystem.LogIn(textBox1.Text, textBox2.Text) == "supervisor")
            {
                Form1 f = new Form1(bookingSystem);
                f.Show();
                this.Hide();
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "AnställningsNr eller Lösenord är felaktigt.";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
