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
    public partial class Första : Form
    {
        BookingSystem bookingSystem;
        public Första()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            bookingSystem = BookingSystem.GetBs();
            dataGridViewBöcker.DataSource = bookingSystem.AvailableBooks();
        }

        private void dataGridViewBöcker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            ISBNTextBox.Text = Convert.ToString(dataGridViewBöcker.Rows[row].Cells[0].Value);
        }

        private void bokaButton_Click(object sender, EventArgs e)
        {
            if (ISBNTextBox.Text.Length < 1){
                IsbnError.ForeColor = Color.Red;
                IsbnError.Text = "ISBN saknas.";
            }
            else{
                IsbnError.Text = " ";
            }

            if (MedlemsNrTextBox.Text.Length < 1){
                MedlemsNrError.ForeColor = Color.Red;
                MedlemsNrError.Text = "Medlemsnummer saknas.";
            }
            else
            {
                if (!bookingSystem.IsMember(MedlemsNrTextBox.Text)){
                    MedlemsNrError.ForeColor = Color.Red;
                    MedlemsNrError.Text = "Felaktigt Medlemsnummer.";
                }
                else
                {
                    MedlemsNrError.Text = " ";
                }

            if (IsbnError.Text == " " && MedlemsNrError.Text == " ")
                {
                    bookingSystem.AddBooking(MedlemsNrTextBox.Text, ISBNTextBox.Text);
                    dataGridViewBöcker.DataSource = bookingSystem.AvailableBooks();
                }
            }
        }
    }
}
