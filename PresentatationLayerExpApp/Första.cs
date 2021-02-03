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

        // Hej Anton
        public Första()
        {
            InitializeComponent();
            //dataGridViewBöcker.AllowUserToResizeColumns = false;
            dataGridViewBöcker.AllowUserToResizeRows = false;
            dataGridViewBöcker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBöcker.MultiSelect = false;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            bookingSystem = BookingSystem.GetBs();
            AvailableOrAllBooks();

            //Man kan ändra availability direkt i datagridview, gjorde den readonly.
            dataGridViewBöcker.Columns[2].ReadOnly = true;
            //Fast å andra sidan, varför syns denna kolumnen ens? Boken försvinner ju
            //När man bokar den. Vi tar det sen. Det görs iallafall med denna:
            //dataGridViewBöcker.Columns[2].Visible = false;
            /* Jag tror att jag gör såhär:
             * Jag lägger en checkbox eller något som man måste klicka i för
             * att se utlånade böcker.
             * När man klickar i den så visas alla utlånade, kanske med en grå underton.
             * 
             * TODO: Fix.
             */
        }
        
        /* Som ni säkert märkte så betedde sig datagridviewen lite udda, ibland reagerade
         * den inte på att man klickade. Det var för att den var inställd på "CellContentClick"
         * alltså behövde man klicka exakt PÅ texten för att den skulle göra något.
         * 
         * Ändrade till CellClick istället och nu funkar det som den ska.
         */
        private void dataGridViewBöcker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            
            ISBNTextBox.Text = Convert.ToString(dataGridViewBöcker.Rows[e.RowIndex].Cells[0].Value);

        }

        private void bokaButton_Click(object sender, EventArgs e)
        {
            Book b;
            IsbnError.Text = "";
            MedlemsNrError.Text = "";

            if (ISBNTextBox.Text.Length < 1)
            {
                IsbnError.ForeColor = Color.Red;
                IsbnError.Text = "ISBN saknas.";
                return;
            }

            //Kollar så att det finns en bok med det isbn
            if ((b = bookingSystem.FindBook(ISBNTextBox.Text)) == null)
            {
                IsbnError.Text = "Felaktigt ISBN";
                return;
            }

            //Kollar om boken redan är bokad, eftersom man kan skriva in isbn själv.
            if (!b.Available)
            {
                IsbnError.Text = "Boken är redan bokad.";
                return;
            }

            if (MedlemsNrTextBox.Text.Length < 1)
            {
                MedlemsNrError.Text = "Medlemsnummer saknas.";
                return;
            }

            if (!bookingSystem.IsMember(MedlemsNrTextBox.Text.ToUpper()))
            {
                MedlemsNrError.Text = "Felaktigt Medlemsnummer.";
            }

            /* Detta känns konstigt, men vet inte om jag vill skriva om det just nu.
             * Jag gissar på att en petig lärare hade frågat varför vi kontrollerar
             * om boken uppfyller kraven genom att kolla så att felkoderna är tomma.
             * 
             * Det funkar, men det känns konstigt att typ "ignorera" datan och bara
             * lita på att felkoderna har hittat allt.
             */

            if (IsbnError.Text == "" && MedlemsNrError.Text == "")
            {
                bookingSystem.AddBooking(MedlemsNrTextBox.Text.ToUpper(), b);
                AvailableOrAllBooks();
                ISBNTextBox.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AvailableOrAllBooks();
        }


        //visar alla eller bara vissa böcker beroende på om checkboxen är iklickad.
        public void AvailableOrAllBooks()
        {
            if (checkBox1.Checked)
            {
                dataGridViewBöcker.DataSource = bookingSystem.AllBooks();
                foreach (DataGridViewRow row in dataGridViewBöcker.Rows)
                {
                    if (!(bool)row.Cells[2].Value) row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            else
            {
                dataGridViewBöcker.DataSource = bookingSystem.AvailableBooks();
            }
        }

    }
}
