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
    public partial class Andra : Form
    {
        BookingSystem bookingSystem { get; set; }
        public Andra(BookingSystem system)
        {
            InitializeComponent();
            bookingSystem = system;
            var test = bookingSystem.GetAvailableBooks();
            dataGridViewÅterlämnade.DataSource = test;
        }
        private void Andra_Load(object sender, EventArgs e)
        {
            var test = bookingSystem.GetAvailableBooks();
            dataGridViewÅterlämnade.DataSource = test;
        }

        private void dataGridViewÅterlämnade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
