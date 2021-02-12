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
    public partial class BokningUI : Form
    {
        BookingSystem bookingSystem;
        public DataTable table;

        public BokningUI()
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

            dataGridViewBöcker.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewBöcker.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                        
                        Book book = bookingSystem.FindBook((long)Convert.ToInt64(row["ISBN"]));
                        bookingSystem.AddBooking(MedlemsNrTextBox.Text.ToUpper(), book, dateTimePicker.Value);
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

                    if (!book.IsAvailable(dateTimePicker.Value))
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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dataGridViewBöcker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //Selection
            if (dataGridViewBöcker.Rows[e.RowIndex].Cells[3].ReadOnly == false && e.ColumnIndex != 3)
            {
                if (Convert.ToBoolean(table.Rows[e.RowIndex]["Låna"]) == false)
                {
                    table.Rows[e.RowIndex]["Låna"] = true;
                    dataGridViewBöcker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(158, 232, 170);

                }
                else
                {
                    table.Rows[e.RowIndex]["Låna"] = false;
                    dataGridViewBöcker.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

                }
            }
        }

      
    }
}
