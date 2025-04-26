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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int counter;
        private void Loading_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 500)
            {
                timer1.Enabled = false;
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
        }
    }
}
