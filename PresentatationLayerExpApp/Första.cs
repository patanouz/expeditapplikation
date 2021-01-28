using ExpeditApplikation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatationLayerExpApp
{
    public partial class Första : Form
    {
        public Första()
        {
            InitializeComponent();
            LoadBookList();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void LoadBookList()
        {
            BookingSystem bs = new BookingSystem();
            dataGridViewBöcker.DataSource = bs.AvailableBooks();

        }

    }
}
