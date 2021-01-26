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
    public partial class Form1 : Form
    {

        Första första;
        Andra andra;

        Form[] allaForms;

        Point p = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            allaForms = new Form[2];

            första = new Första();
            andra = new Andra();

            allaForms[0] = första;
            allaForms[1] = andra;

            foreach(Form f in allaForms)
            {
                f.MdiParent = this;
            }

            första.Show();
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
            första.Show();
            första.Location = p;
        }


        private void andraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            andra.Show();
            andra.Location = p;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
