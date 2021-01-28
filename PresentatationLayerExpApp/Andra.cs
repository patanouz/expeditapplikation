using ExpeditApplikation;
using ExpeditApplikation.Model;
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
        }
        private void Andra_Load(object sender, EventArgs e)
        {
            BookingSystem bs = new BookingSystem();
            dataGridViewÅterlämnade.DataSource = bs.ExistingBookings();
        }
    }
}
