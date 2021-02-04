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
    public partial class ControllerUI : Form
    {
        BookingSystem bookingSystem { get; set; }

        BokningUI BokningUI;
        ÅterlämningUI ÅterlämningUI;

        Form[] allaForms;

        Point p = new Point(0, 0);

        public ControllerUI(BookingSystem system)
        {
            InitializeComponent();

            bookingSystem = system;
            allaForms = new Form[2];

            BokningUI = new BokningUI();
            ÅterlämningUI = new ÅterlämningUI();

            allaForms[0] = BokningUI;
            allaForms[1] = ÅterlämningUI;

            foreach(Form f in allaForms)
            {
                f.MdiParent = this;
            }

            BokningUI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        protected override void OnLoad(EventArgs e)
        {
            var mdiclient = this.Controls.OfType<MdiClient>().Single();
            this.SuspendLayout();
            mdiclient.SuspendLayout();
            var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
            var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
            var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
            var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
            mdiclient.Dock = DockStyle.None;
            mdiclient.Size = size;
            mdiclient.Location = location;
            mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            mdiclient.ResumeLayout(true);
            this.ResumeLayout(true);
            base.OnLoad(e);
        }

        private void Reset()
        {
            foreach (Form form in allaForms)
            {
                form.Hide();
            }
        }
        private void förstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            BokningUI.Show();
            BokningUI.Location = p;
            BokningUI.UpdateTable();
        }


        private void andraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            ÅterlämningUI.Show();
            ÅterlämningUI.Location = p;
            ÅterlämningUI.updateTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
