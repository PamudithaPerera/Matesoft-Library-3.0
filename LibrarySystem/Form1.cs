using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Net.NetworkInformation;
using LibrarySystem.Includes;
using static log4net.Appender.ColoredConsoleAppender;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
       
        }

        SQLConfig config = new SQLConfig();
        string sql;

        public bool pingState()
        {
            bool pingStatus = false;
            string hostnameOrAddress = "Google.com";
            using (Ping p = new Ping())
            {
                string data = "Matesoft";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;

                try
                {
                    PingReply reply=p.Send(hostnameOrAddress,timeout,buffer);
                    pingStatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception)
                {
                    pingStatus = false;
                }
                return pingStatus;
            }
        }
        public void enabled_menu()
        {
            ts_login.Text = "Logout";
            ts_books.Enabled = true;
            ts_transaction.Enabled = true;
            ts_borrower.Enabled = true;
            ts_categories.Enabled = true;
            ts_musers.Enabled = true;
        }

        public void disabled_menu()
        {
            ts_login.Text = "Login";
            ts_books.Enabled = false;
            ts_transaction.Enabled = false;
            ts_borrower.Enabled = false;
            ts_categories.Enabled = false;
            ts_musers.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bw_updateChecker.RunWorkerAsync();
            lbcurrent.Text = Application.ProductVersion.ToString();
            disabled_menu();
            labelnew.Hide();
            Log.Hide();
            labelnew.Hide();
    
        }

      

        private void ts_books_Click(object sender, EventArgs e)
        {
            Form frm = new frmBooks();
            frm.ShowDialog();
        }

        private void ts_BorrowItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void ts_returnItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturned();
            frm.ShowDialog();
        }

        private void ts_overdueItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmOverdue();
            frm.ShowDialog();
        }

        private void ts_borrower_Click(object sender, EventArgs e)
        {
            Form frm = new frmBrd();
            frm.ShowDialog();
        }

        private void ts_categories_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategories();
            frm.ShowDialog(); 
        }

        private void ts_users_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.ShowDialog();
        }

        private void ts_reports_Click(object sender, EventArgs e)
        {
        
        }

        private void ts_logs_Click(object sender, EventArgs e)
        {
          
        }

        private void ts_login_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin(this);

            if (ts_login.Text == "Login")
            {
                frm.ShowDialog();
            }
            else
            {
                ts_login.Text = "Login";
                disabled_menu();
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ts_login_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void checkUpdate()
        {

            var urlVersion = "https://raw.githubusercontent.com/PamudithaPerera/MatesoftLibrary/refs/heads/main/Version.txt";
            var newVersion = (new WebClient().DownloadString(urlVersion));
            var currentVersion = Application.ProductVersion.ToString();

            newVersion = newVersion.Replace(".", "");
            currentVersion = currentVersion.Replace(".", "");

            this.Invoke(new Action(() =>
            {
                if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
                {
                    lbheader.Text = "A New Version is Available.\r\nDo you want to Update ?\r\n";
                    labelnew.Text = (new WebClient().DownloadString(urlVersion));
                    btnUpdate.Enabled = true;
                    labelnew.Show();
                    labelnew.Show();
                   UPDATE.Show();

                }
                else
                {
                    lbheader.Text = "";
                    btnUpdate.Hide();
                    UPDATE.Hide();
                    labelnew.Hide();
                    labelnew.Hide();

                }
            }));

        }
        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            initScript();
        }

        private void initScript()
        {

            string path = Application.StartupPath + @"\bat.bat";

            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);

        }
        private void bw_updateChecker_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void bw_updateChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bw_updateChecker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            checkUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Instruction up = new Update_Instruction();
            up.Show();
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.ShowDialog();
        }

        private void ts_users_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
       
        }

        private void guna2GradientTileButton1_Click_2(object sender, EventArgs e)
        {
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
 
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ts_login_Click_2(object sender, EventArgs e)
        {
            Form frm = new frmLogin(this);

            if (ts_login.Text == "Login")
            {
                Log.Show();
                Log.Enabled = true;
            }
            else
            {
                ts_login.Text = "Login";
                disabled_menu();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Update_Instruction up = new Update_Instruction();
            up.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ts_transaction_Click(object sender, EventArgs e)
        {
            frmBrd db = new frmBrd();
            db.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Main Manue close buttion
        }

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tbluser` WHERE User_name= '" + UsernameTextBox.Text + "' and Pass = sha1('" + PasswordTextBox.Text + "')";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome to Library System");
                this.enabled_menu();
                Log.Hide();
                Log.Enabled = false;
            }
            else
            {
                MessageBox.Show("Account does not exist. Please contact administrator.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //loging button
        }

        private void Cancel_Load(object sender, EventArgs e)
        {
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Log.Hide();
            Log.Enabled = false;  //login cancel lable
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingState()== true)
            {
                network.Enabled = false;
                network.Hide();
            }
            else
            {
                network.Enabled = true;
                network.Show();     //No internet realtime Updater

            }
        }
    }
}
