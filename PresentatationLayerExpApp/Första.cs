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
        public DataTable table;

        public Första()
        {
            InitializeComponent();
            dataGridViewBöcker.AllowUserToResizeRows = false;
            dataGridViewBöcker.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBöcker.MultiSelect = false;
            dataGridViewBöcker.AllowUserToAddRows = false;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            bookingSystem = BookingSystem.GetBs();
            UpdateTable();
        }
        private void bokaButton_Click(object sender, EventArgs e)
        {
            Book b;
            bookingErrorMessage.Text = "";

            if (MedlemsNrTextBox.Text.Length < 1)
            {
                bookingErrorMessage.Text = "Medlemsnummer saknas.";
                return;
            }

            if (!bookingSystem.IsMember(MedlemsNrTextBox.Text.ToUpper()))
            {
                bookingErrorMessage.Text = "Felaktigt Medlemsnummer.";
            }

            if (bookingErrorMessage.Text == "")
            {
                var activeBooking = false;

                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToBoolean(row["Låna"]) == true)
                    {
                        Book book = new Book((long)Convert.ToInt64(row["ISBN"]), Convert.ToString(row["Titel"]));
                        bookingSystem.AddBooking(MedlemsNrTextBox.Text.ToUpper(), book);
                        activeBooking = true;
                    }
                }

                //Error Messages
                if (activeBooking == false)
                {
                    bookingErrorMessage.ForeColor = Color.Red;
                    bookingErrorMessage.Text = "Ingen bokning har markerats.";
                }
                else
                {
                    bookingErrorMessage.Text = "";
                }
                UpdateTable();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        //visar alla eller bara vissa böcker beroende på om checkboxen är iklickad.
        public void UpdateTable()
        {
            //Create Table
            if (table == null)
            {
                table = new DataTable();
                table.Columns.Add("ISBN", typeof(long));
                table.Columns.Add("Titel", typeof(string));
                table.Columns.Add("Dagar", typeof(string));
                table.Columns.Add("Låna", typeof(bool));

                table.Columns["ISBN"].ReadOnly = true;
                table.Columns["Titel"].ReadOnly = true;
                table.Columns["Dagar"].ReadOnly = true;
                table.Columns["Låna"].ReadOnly = false;
            }
            else
                table.Clear();

            //Input Data
            if (checkBox1.Checked)
            {
                var reColorIndex = new List<int>();
                foreach (Book book in bookingSystem.AllBooks())
                {                    
                    //Add Data
                    DataRow row = table.NewRow();
                    row["ISBN"] = book.ISBN;
                    row["Titel"] = book.Title;
                    row["Dagar"] = book.Days;
                    row["Låna"] = false;

                    table.Rows.Add(row);

                    if (!bookingSystem.IsAvailable(book, dateTimePicker.Value))
                    {
                        reColorIndex.Add(table.Rows.Count - 1);
                    }
                }

                dataGridViewBöcker.DataSource = table;

                //Color
                foreach (int index in reColorIndex)
                {
                    dataGridViewBöcker.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                    dataGridViewBöcker.Rows[index].Cells[3].ReadOnly = true;
                }
            }
            else
            {
                foreach (Book book in bookingSystem.AvailableBooks(dateTimePicker.Value))
                {
                    DataRow row = table.NewRow();
                    row["ISBN"] = book.ISBN;
                    row["Titel"] = book.Title;
                    row["Dagar"] = book.Days;
                    row["Låna"] = false;

                    dataGridViewBöcker.RowsDefaultCellStyle.BackColor = Color.White;
                    table.Rows.Add(row);
                }
                dataGridViewBöcker.DataSource = table;
            }
        }

        private void dataGridViewBöcker_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewBöcker.ClearSelection();
        }
    }
}
