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
    public partial class ÅterlämningUI : Form
    {

        BookingSystem bookingSystem;
        private DataTable table;

        public ÅterlämningUI()
        {
            InitializeComponent();
            bookingSystem = BookingSystem.GetBs();
            dataGridViewÅterlämnade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewÅterlämnade.MultiSelect = false;
            dataGridViewÅterlämnade.AllowUserToResizeRows = false;
            dataGridViewÅterlämnade.AllowUserToAddRows = false;
        }
        private void Andra_Load(object sender, EventArgs e)
        {
            updateTable();

            dataGridViewÅterlämnade.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewÅterlämnade.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewÅterlämnade.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {

            //Ganska lat lösning egentligen, men det får bli så.
            if (checkBox1.Checked)
            {
                ReturnTextBoxError.Text = "Klicka bort checkboxen för utlånade böcker först";
                return;
            }
            ReturnTextBoxError.Text = "";

            foreach(DataRow row in table.Rows)
            {
                if ((bool)row["Återlämna"])
                {
                    //TODO behövs nog ej try-catch. Fixar sen.
                    try
                    {
                        bookingSystem.ReturnBook(Convert.ToString(row["Ref."]));
                    }
                    catch (ArgumentException)
                    {
                        ErrorMessageLabel.Text = "All bookings cannot be found.";
                    }
                }
            }
            updateTable();
        }


        private void checkbox_StatusBookings(object sender, EventArgs e)
        {
            //Amending Table Columns
            if (checkBox1.Checked)
            {
                table.Columns.Add("Återlämnad", typeof(DateTime));
                table.Columns.Add("Faktura", typeof(string));
                dataGridViewÅterlämnade.Columns["Återlämna"].DisplayIndex = (table.Columns.Count - 1);
            }
            else
            {
                table.Columns.Remove("Återlämnad");
                table.Columns.Remove("Faktura");
            }
            updateTable();
        }

        public void updateTable()
        {
            //Create Table
            if (table == null)
            {
                table = new DataTable();

                //Adding Columns
                table.Columns.Add("Ref.", typeof(string));
                table.Columns.Add("AdminID", typeof(string));
                table.Columns.Add("MedlemID", typeof(string));
                table.Columns.Add("Titel", typeof(string));
                table.Columns.Add("ISBN", typeof(long));
                table.Columns.Add("Datum", typeof(DateTime));
                table.Columns.Add("FörfalloDatum", typeof(DateTime));
                table.Columns.Add("Återlämna", typeof(bool));


                //Read Only
                table.Columns["Ref."].ReadOnly = true;
                table.Columns["AdminID"].ReadOnly = true;
                table.Columns["MedlemID"].ReadOnly = true;
                table.Columns["Titel"].ReadOnly = true;
                table.Columns["ISBN"].ReadOnly = true;
                table.Columns["Datum"].ReadOnly = true;
                table.Columns["FörfalloDatum"].ReadOnly = true;
                table.Columns["Återlämna"].ReadOnly = false;
            }
            else
                table.Clear();

            //Amending Table For Booking Record
            if (checkBox1.Checked)
            {
                var bookings = bookingSystem.AllBookings();

                //Input All Booking Data
                foreach (Booking booking in bookings)
                {
                    DataRow row = table.NewRow();
                    row["Ref."] = booking.BookingReference;
                    row["AdminID"] = booking.UserID;
                    row["MedlemID"] = booking.MemberID;
                    row["Titel"] = booking.Title;
                    row["ISBN"] = booking.ISBN;
                    row["Datum"] = booking.Date;
                    row["FörfalloDatum"] = booking.ExpiryDate;
                    if (booking.Returned != null)
                        row["Återlämnad"] = booking.Returned;
                    row["Faktura"] = Convert.ToString(booking.OustandingPayment) + " SEK";
                    table.Rows.Add(row);
                }
                dataGridViewÅterlämnade.DataSource = table;

                for(int i=0; i< bookingSystem.AllBookings().Count; i++)
                {
                    var bookingStatus = bookingSystem.bookingStatus(bookings[i]);
                    switch (bookingStatus)
                    {
                        case "active": dataGridViewÅterlämnade.Rows[i].DefaultCellStyle.BackColor = Color.White; break;
                        case "delayed": dataGridViewÅterlämnade.Rows[i].DefaultCellStyle.BackColor = Color.PaleVioletRed; break;
                        case "paid": dataGridViewÅterlämnade.Rows[i].DefaultCellStyle.BackColor = Color.LightGray; break;
                        case "pending": dataGridViewÅterlämnade.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    }
                }
            }
            else
            {
                //Input Existing Booking Data
                foreach (Booking booking in bookingSystem.ExistingBookings())
                {
                    DataRow row = table.NewRow();
                    row["Ref."] = booking.BookingReference;
                    row["AdminID"] = booking.UserID;
                    row["MedlemID"] = booking.MemberID;
                    row["Titel"] = booking.Title;
                    row["ISBN"] = booking.ISBN;
                    row["Datum"] = booking.Date;
                    row["FörfalloDatum"] = booking.ExpiryDate;
                    row["Återlämna"] = false;
                    table.Rows.Add(row);
                }
                dataGridViewÅterlämnade.DataSource = table;
            }
        }

        //Löste tidigare detta med eventet "shown" men den slutade fungera
        //googlade på det och det verkar vara vanligt i windows forms.
        //Nu kallar jag på denna metoden när man trycker på meny-knappen.
        public void RefreshForm()
        {
            updateTable();
        }

        private void dataGridViewÅterlämnade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //Selection
            if (!checkBox1.Checked)
            {
                if (Convert.ToBoolean(table.Rows[e.RowIndex]["Återlämna"]) == false)
                {
                    table.Rows[e.RowIndex]["Återlämna"] = true;
                    dataGridViewÅterlämnade.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(158, 232, 170);
                }
                else
                {
                    table.Rows[e.RowIndex]["Återlämna"] = false;
                    dataGridViewÅterlämnade.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
            

            //AutoFill
            bokningsNummerTextBox.Text = "";
            medlemsNummerTextBox.Text = Convert.ToString(dataGridViewÅterlämnade.Rows[e.RowIndex].Cells[2].Value);
        }

        private void filterByRef(string bookingRef)
        {
            IList<int> indexList = new List<int>();
            for (int i=0; i < dataGridViewÅterlämnade.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridViewÅterlämnade.Rows[i].Cells[0].Value).ToUpper() != bookingRef)
                    indexList.Add(i);
            }

            for (int i = indexList.Count-1; i >= 0; i--)
            {
                dataGridViewÅterlämnade.Rows.RemoveAt(indexList[i]);
            }
        }

        private void filterByMember(string memberId)
        {
            IList<int> indexList = new List<int>();
            for (int i = 0; i < dataGridViewÅterlämnade.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridViewÅterlämnade.Rows[i].Cells[2].Value).ToUpper() != memberId)
                    indexList.Add(i);
            }

            for (int i = indexList.Count - 1; i >= 0; i--)
            {
                dataGridViewÅterlämnade.Rows.RemoveAt(indexList[i]);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            updateTable();
            if (bokningsNummerTextBox.Text.Length > 0)
            {
                if (bokningsNummerTextBox.Text.All(c => Char.IsLetterOrDigit(c)))
                    filterByRef(bokningsNummerTextBox.Text.ToUpper());
            }

            if (medlemsNummerTextBox.Text.Length > 0)
            {
                if (medlemsNummerTextBox.Text.All(c => Char.IsLetterOrDigit(c)))
                    filterByMember(medlemsNummerTextBox.Text.ToUpper());
            }
        }

        private void dataGridViewÅterlämnade_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewÅterlämnade.ClearSelection();
        }

    }
}
