namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bw_updateChecker = new System.ComponentModel.BackgroundWorker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.lbheader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelnew = new System.Windows.Forms.Label();
            this.cuiResizeGrip1 = new CuoreUI.Controls.cuiResizeGrip();
            this.lbcurrent = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ts_login = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cuiFormDrag1 = new CuoreUI.cuiFormDrag(this.components);
            this.cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cuiFormDrag2 = new CuoreUI.cuiFormDrag(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cuiTooltipHover1 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.ts_books = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ts_transaction = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ts_categories = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ts_borrower = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ts_musers = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UPDATE = new Guna.UI2.WinForms.Guna2Panel();
            this.Log = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Cancel = new CuoreUI.Controls.cuiLabel();
            this.OK = new CuoreUI.Controls.cuiButton();
            this.UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.network = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.UPDATE.SuspendLayout();
            this.Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.network.SuspendLayout();
            this.SuspendLayout();
            // 
            // bw_updateChecker
            // 
            this.bw_updateChecker.WorkerReportsProgress = true;
            this.bw_updateChecker.WorkerSupportsCancellation = true;
            this.bw_updateChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_updateChecker_DoWork_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 40F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(335, 54);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(536, 126);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "MateLibrary";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            this.guna2HtmlLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2HtmlLabel1_Paint);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Yu Gothic UI Light", 10F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(57, 254);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(834, 71);
            this.guna2HtmlLabel4.TabIndex = 22;
            this.guna2HtmlLabel4.Text = resources.GetString("guna2HtmlLabel4.Text");
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(335, 131);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(536, 48);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Matesoft Technologies Coparation";
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.EnhanceCorners = true;
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder1.Rounding = 16;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // lbheader
            // 
            this.lbheader.AutoSize = false;
            this.lbheader.BackColor = System.Drawing.Color.Transparent;
            this.lbheader.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbheader.ForeColor = System.Drawing.Color.Black;
            this.lbheader.Location = new System.Drawing.Point(126, 8);
            this.lbheader.Name = "lbheader";
            this.lbheader.Size = new System.Drawing.Size(229, 33);
            this.lbheader.TabIndex = 5;
            this.lbheader.Text = "A New Version is Available";
            // 
            // labelnew
            // 
            this.labelnew.BackColor = System.Drawing.Color.Transparent;
            this.labelnew.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnew.ForeColor = System.Drawing.Color.Black;
            this.labelnew.Location = new System.Drawing.Point(205, 26);
            this.labelnew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnew.Name = "labelnew";
            this.labelnew.Size = new System.Drawing.Size(69, 43);
            this.labelnew.TabIndex = 9;
            this.labelnew.Text = "1.0.0.0";
            this.labelnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cuiResizeGrip1
            // 
            this.cuiResizeGrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip1.BackColor = System.Drawing.Color.Transparent;
            this.cuiResizeGrip1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip1.GripColor = System.Drawing.Color.Black;
            this.cuiResizeGrip1.GripSize = 2;
            this.cuiResizeGrip1.GripTexture = true;
            this.cuiResizeGrip1.Location = new System.Drawing.Point(1158, 719);
            this.cuiResizeGrip1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cuiResizeGrip1.Name = "cuiResizeGrip1";
            this.cuiResizeGrip1.Size = new System.Drawing.Size(120, 74);
            this.cuiResizeGrip1.SkipBottomRightSquare = false;
            this.cuiResizeGrip1.TabIndex = 32;
            this.cuiResizeGrip1.TargetForm = null;
            this.cuiResizeGrip1.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // lbcurrent
            // 
            this.lbcurrent.BackColor = System.Drawing.Color.Transparent;
            this.lbcurrent.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.lbcurrent.ForeColor = System.Drawing.Color.Black;
            this.lbcurrent.Location = new System.Drawing.Point(1216, 418);
            this.lbcurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcurrent.Name = "lbcurrent";
            this.lbcurrent.Size = new System.Drawing.Size(171, 27);
            this.lbcurrent.TabIndex = 37;
            this.lbcurrent.Text = "1.0.0.0";
            this.lbcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(486, 613);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedDepth = 10;
            this.btnUpdate.Size = new System.Drawing.Size(349, 67);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update Instruction";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // ts_login
            // 
            this.ts_login.Animated = true;
            this.ts_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_login.BorderRadius = 20;
            this.ts_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.ts_login.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_login.ForeColor = System.Drawing.Color.White;
            this.ts_login.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_login.Location = new System.Drawing.Point(538, 529);
            this.ts_login.Name = "ts_login";
            this.ts_login.PressedDepth = 10;
            this.ts_login.Size = new System.Drawing.Size(258, 69);
            this.ts_login.TabIndex = 39;
            this.ts_login.Text = "Login";
            this.ts_login.Click += new System.EventHandler(this.ts_login_Click_2);
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // cuiFormAnimator1
            // 
            this.cuiFormAnimator1.AnimateOnStart = true;
            this.cuiFormAnimator1.Duration = 400;
            this.cuiFormAnimator1.EasingType = CuoreUI.Drawing.EasingTypes.QuadOut;
            this.cuiFormAnimator1.StartOpacity = 0D;
            this.cuiFormAnimator1.TargetForm = this;
            this.cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1216, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(62, 48);
            this.guna2ControlBox1.TabIndex = 42;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // cuiFormDrag2
            // 
            this.cuiFormDrag2.TargetForm = this;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1158, -2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(62, 48);
            this.guna2ControlBox2.TabIndex = 43;
            // 
            // cuiTooltipHover1
            // 
            this.cuiTooltipHover1.BackColor = System.Drawing.Color.Black;
            this.cuiTooltipHover1.Content = "Tooltip Text";
            this.cuiTooltipHover1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cuiTooltipHover1.TargetControl = null;
            // 
            // ts_books
            // 
            this.ts_books.Animated = true;
            this.ts_books.BackColor = System.Drawing.Color.White;
            this.ts_books.BorderRadius = 20;
            this.ts_books.DisabledState.BorderColor = System.Drawing.Color.White;
            this.ts_books.DisabledState.FillColor = System.Drawing.Color.White;
            this.ts_books.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.ts_books.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ts_books.FillColor = System.Drawing.Color.White;
            this.ts_books.FillColor2 = System.Drawing.Color.White;
            this.ts_books.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_books.ForeColor = System.Drawing.Color.Black;
            this.ts_books.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_books.Location = new System.Drawing.Point(0, 0);
            this.ts_books.Name = "ts_books";
            this.ts_books.PressedDepth = 10;
            this.ts_books.Size = new System.Drawing.Size(156, 85);
            this.ts_books.TabIndex = 44;
            this.ts_books.Text = "Books";
            this.ts_books.Click += new System.EventHandler(this.ts_books_Click);
            // 
            // ts_transaction
            // 
            this.ts_transaction.Animated = true;
            this.ts_transaction.BackColor = System.Drawing.Color.White;
            this.ts_transaction.BorderRadius = 20;
            this.ts_transaction.DisabledState.BorderColor = System.Drawing.Color.White;
            this.ts_transaction.DisabledState.FillColor = System.Drawing.Color.White;
            this.ts_transaction.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.ts_transaction.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ts_transaction.FillColor = System.Drawing.Color.White;
            this.ts_transaction.FillColor2 = System.Drawing.Color.White;
            this.ts_transaction.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_transaction.ForeColor = System.Drawing.Color.Black;
            this.ts_transaction.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_transaction.Location = new System.Drawing.Point(156, 0);
            this.ts_transaction.Name = "ts_transaction";
            this.ts_transaction.PressedDepth = 10;
            this.ts_transaction.Size = new System.Drawing.Size(156, 85);
            this.ts_transaction.TabIndex = 45;
            this.ts_transaction.Text = "Transaction";
            this.ts_transaction.Click += new System.EventHandler(this.ts_transaction_Click);
            // 
            // ts_categories
            // 
            this.ts_categories.Animated = true;
            this.ts_categories.BackColor = System.Drawing.Color.White;
            this.ts_categories.BorderRadius = 20;
            this.ts_categories.DisabledState.BorderColor = System.Drawing.Color.White;
            this.ts_categories.DisabledState.FillColor = System.Drawing.Color.White;
            this.ts_categories.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.ts_categories.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ts_categories.FillColor = System.Drawing.Color.White;
            this.ts_categories.FillColor2 = System.Drawing.Color.White;
            this.ts_categories.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_categories.ForeColor = System.Drawing.Color.Black;
            this.ts_categories.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_categories.Location = new System.Drawing.Point(468, 0);
            this.ts_categories.Name = "ts_categories";
            this.ts_categories.PressedDepth = 10;
            this.ts_categories.Size = new System.Drawing.Size(156, 85);
            this.ts_categories.TabIndex = 47;
            this.ts_categories.Text = "Categories";
            this.ts_categories.Click += new System.EventHandler(this.ts_categories_Click);
            // 
            // ts_borrower
            // 
            this.ts_borrower.Animated = true;
            this.ts_borrower.BackColor = System.Drawing.Color.White;
            this.ts_borrower.BorderRadius = 20;
            this.ts_borrower.DisabledState.BorderColor = System.Drawing.Color.White;
            this.ts_borrower.DisabledState.FillColor = System.Drawing.Color.White;
            this.ts_borrower.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.ts_borrower.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ts_borrower.FillColor = System.Drawing.Color.White;
            this.ts_borrower.FillColor2 = System.Drawing.Color.White;
            this.ts_borrower.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_borrower.ForeColor = System.Drawing.Color.Black;
            this.ts_borrower.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_borrower.Location = new System.Drawing.Point(312, 0);
            this.ts_borrower.Name = "ts_borrower";
            this.ts_borrower.PressedDepth = 10;
            this.ts_borrower.Size = new System.Drawing.Size(156, 85);
            this.ts_borrower.TabIndex = 46;
            this.ts_borrower.Text = "Borrower";
            this.ts_borrower.Click += new System.EventHandler(this.ts_borrower_Click);
            // 
            // ts_musers
            // 
            this.ts_musers.Animated = true;
            this.ts_musers.BackColor = System.Drawing.Color.White;
            this.ts_musers.BorderRadius = 20;
            this.ts_musers.DisabledState.BorderColor = System.Drawing.Color.White;
            this.ts_musers.DisabledState.FillColor = System.Drawing.Color.White;
            this.ts_musers.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.ts_musers.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ts_musers.FillColor = System.Drawing.Color.White;
            this.ts_musers.FillColor2 = System.Drawing.Color.White;
            this.ts_musers.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.ts_musers.ForeColor = System.Drawing.Color.Black;
            this.ts_musers.ImageSize = new System.Drawing.Size(30, 30);
            this.ts_musers.Location = new System.Drawing.Point(624, 0);
            this.ts_musers.Name = "ts_musers";
            this.ts_musers.PressedDepth = 10;
            this.ts_musers.Size = new System.Drawing.Size(156, 85);
            this.ts_musers.TabIndex = 48;
            this.ts_musers.Text = "Manage Users";
            this.ts_musers.Click += new System.EventHandler(this.ts_users_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::LibrarySystem.Properties.Resources.wArtboard_3_1;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(409, 145);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(503, 384);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 41;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::LibrarySystem.Properties.Resources.wArtboard_2_1___Copy;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(778, 101);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(757, 699);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 38;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibrarySystem.Properties.Resources.wArtboard_2_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-111, 99);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(537, 703);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Transparent;
            this.UPDATE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.UPDATE.BorderRadius = 25;
            this.UPDATE.BorderThickness = 1;
            this.UPDATE.Controls.Add(this.lbheader);
            this.UPDATE.Controls.Add(this.labelnew);
            this.UPDATE.Location = new System.Drawing.Point(432, 91);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(478, 71);
            this.UPDATE.TabIndex = 49;
            // 
            // Log
            // 
            this.Log.AutoRoundedCorners = true;
            this.Log.BackColor = System.Drawing.Color.Transparent;
            this.Log.Controls.Add(this.guna2PictureBox4);
            this.Log.Controls.Add(this.Cancel);
            this.Log.Controls.Add(this.OK);
            this.Log.Controls.Add(this.UsernameTextBox);
            this.Log.Controls.Add(this.PasswordTextBox);
            this.Log.Controls.Add(this.cuiLabel2);
            this.Log.Controls.Add(this.cuiLabel1);
            this.Log.Enabled = false;
            this.Log.Location = new System.Drawing.Point(402, 82);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(510, 674);
            this.Log.TabIndex = 50;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::LibrarySystem.Properties.Resources.wArtboard_3_1;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(42, 25);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(425, 247);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 32;
            this.guna2PictureBox4.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.Content = "Cancel\\ and\\ going\\ to\\ Softweare\\ Home\\ screen";
            this.Cancel.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.Cancel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.Cancel.Location = new System.Drawing.Point(0, 638);
            this.Cancel.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(510, 30);
            this.Cancel.TabIndex = 31;
            this.Cancel.Load += new System.EventHandler(this.Cancel_Load);
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.CheckButton = false;
            this.OK.Checked = false;
            this.OK.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.OK.CheckedForeColor = System.Drawing.Color.White;
            this.OK.CheckedImageTint = System.Drawing.Color.White;
            this.OK.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.OK.Content = "Login";
            this.OK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.OK.HoveredImageTint = System.Drawing.Color.White;
            this.OK.HoverForeColor = System.Drawing.Color.White;
            this.OK.HoverOutline = System.Drawing.Color.Empty;
            this.OK.Image = null;
            this.OK.ImageAutoCenter = true;
            this.OK.ImageExpand = new System.Drawing.Point(0, 0);
            this.OK.ImageOffset = new System.Drawing.Point(0, 0);
            this.OK.Location = new System.Drawing.Point(86, 560);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK.Name = "OK";
            this.OK.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(168)))));
            this.OK.NormalForeColor = System.Drawing.Color.White;
            this.OK.NormalImageTint = System.Drawing.Color.White;
            this.OK.NormalOutline = System.Drawing.Color.Empty;
            this.OK.OutlineThickness = 1.6F;
            this.OK.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.OK.PressedForeColor = System.Drawing.Color.White;
            this.OK.PressedImageTint = System.Drawing.Color.White;
            this.OK.PressedOutline = System.Drawing.Color.Empty;
            this.OK.Rounding = new System.Windows.Forms.Padding(20);
            this.OK.Size = new System.Drawing.Size(349, 66);
            this.OK.TabIndex = 30;
            this.OK.TextOffset = new System.Drawing.Point(0, 0);
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Animated = true;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameTextBox.BorderRadius = 10;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(42, 359);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UsernameTextBox.PlaceholderText = "";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.Size = new System.Drawing.Size(439, 48);
            this.UsernameTextBox.TabIndex = 29;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Animated = true;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextBox.BorderRadius = 10;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(42, 487);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(439, 48);
            this.PasswordTextBox.TabIndex = 28;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Loging\\ Password";
            this.cuiLabel2.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(42, 444);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(439, 29);
            this.cuiLabel2.TabIndex = 27;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Loging\\ Username";
            this.cuiLabel1.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(42, 312);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(439, 33);
            this.cuiLabel1.TabIndex = 26;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(99, 20);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(296, 33);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Network connection Is Unavalable";
            // 
            // network
            // 
            this.network.BackColor = System.Drawing.Color.Transparent;
            this.network.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.network.BorderRadius = 25;
            this.network.BorderThickness = 1;
            this.network.Controls.Add(this.guna2HtmlLabel3);
            this.network.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.network.Location = new System.Drawing.Point(432, 91);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(478, 71);
            this.network.TabIndex = 51;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 792);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.network);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.ts_musers);
            this.Controls.Add(this.ts_categories);
            this.Controls.Add(this.ts_borrower);
            this.Controls.Add(this.ts_transaction);
            this.Controls.Add(this.ts_books);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ts_login);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.lbcurrent);
            this.Controls.Add(this.cuiResizeGrip1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.UPDATE.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.network.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bw_updateChecker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbheader;
        private System.Windows.Forms.Label labelnew;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip1;
        private System.Windows.Forms.Label lbcurrent;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_login;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private CuoreUI.cuiFormDrag cuiFormDrag1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private CuoreUI.cuiFormDrag cuiFormDrag2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover1;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_musers;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_categories;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_borrower;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_transaction;
        private Guna.UI2.WinForms.Guna2GradientTileButton ts_books;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel UPDATE;
        private Guna.UI2.WinForms.Guna2Panel Log;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private CuoreUI.Controls.cuiLabel Cancel;
        private CuoreUI.Controls.cuiButton OK;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel network;
        private System.Windows.Forms.Timer timer1;
    }
}

