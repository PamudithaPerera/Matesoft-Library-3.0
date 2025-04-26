using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmBrd : Form
    {
        public frmBrd()
        {
            InitializeComponent();
        }

        private void ts_login_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturned();
            frm.ShowDialog();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Form frm = new frmOverdue();
            frm.ShowDialog();
        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Close();
        }
    }
}
