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

        BookingSystem bs;

        public Andra()
        {
            InitializeComponent();
            bs = BookingSystem.GetBs();
            dataGridViewÅterlämnade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewÅterlämnade.MultiSelect = false;
            dataGridViewÅterlämnade.AllowUserToResizeRows = false;

        }
        private void Andra_Load(object sender, EventArgs e)
        {
            dataGridViewÅterlämnade.DataSource = bs.ExistingBookings();

            //Väljer att dölja userid, ni får säga vad ni tycker om det men det känns onödigt.
            //Det borde ändå vara kvar, det blir användbart i chefsapplikationen som jag
            //kanske vill göra :)
            dataGridViewÅterlämnade.Columns[1].Visible = false;

            /* Resize'ar alla kolumner så att dom ska bli så små som det behövs 
             * för att dom ska passa. Sen ändrar jag en (titel) till att bli size fill
             * så tar den upp resterande plats. 
             */
            dataGridViewÅterlämnade.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewÅterlämnade.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.ReturnBook(bokningsNummerTextBox.Text.ToUpper());
            ReturnedOrNotBooks();
            
        }

        //Löste tidigare detta med eventet "shown" men den slutade fungera
        //googlade på det och det verkar vara vanligt i windows forms.
        //Nu kallar jag på denna metoden när man trycker på meny-knappen.
        public void RefreshForm()
        {
            ReturnedOrNotBooks();

        }

        
        private void dataGridViewÅterlämnade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bokningsNummerTextBox.Text = Convert.ToString(dataGridViewÅterlämnade.Rows[e.RowIndex].Cells[0].Value);
            medlemsNummerTextBox.Text = Convert.ToString(dataGridViewÅterlämnade.Rows[e.RowIndex].Cells[3].Value);
            bokTitelTextBox.Text = Convert.ToString(dataGridViewÅterlämnade.Rows[e.RowIndex].Cells[2].Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ReturnedOrNotBooks();
        }


        //visar alla bokningar eller bara dom som inte är inlämnade.
        public void ReturnedOrNotBooks()
        {
            if(checkBox1.Checked)
            {
                dataGridViewÅterlämnade.DataSource = bs.ExistingBookings();
                foreach (DataGridViewRow row in dataGridViewÅterlämnade.Rows)
                {
                    if ((bool)row.Cells[7].Value) row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            } else
            {
                dataGridViewÅterlämnade.DataSource = bs.NonReturnedBookings();
                
            }

        }
    }
}
