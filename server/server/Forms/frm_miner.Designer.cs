
namespace server.Forms
{
    partial class frm_miner
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
            this.Refrech = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.flatLabel22 = new FlatUI.FlatLabel();
            this.flatLabel21 = new FlatUI.FlatLabel();
            this.cpu_prog = new CircularProgressBar.CircularProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatButton5 = new FlatUI.FlatButton();
            this.user_idl = new FlatUI.FlatLabel();
            this.flatLabel18 = new FlatUI.FlatLabel();
            this.pool_lbl = new FlatUI.FlatLabel();
            this.flatLabel12 = new FlatUI.FlatLabel();
            this.flatLabel10 = new FlatUI.FlatLabel();
            this.algo_lbl = new FlatUI.FlatLabel();
            this.flatLabel9 = new FlatUI.FlatLabel();
            this.miner = new FlatUI.FlatLabel();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.wallet_lbl = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.statue = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.isinstaled = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatTabControl2 = new FlatUI.FlatTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flatLabel13 = new FlatUI.FlatLabel();
            this.Wall = new FlatUI.FlatTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloaded = new FlatUI.FlatLabel();
            this.progress = new FlatUI.FlatProgressBar();
            this.flatLabel11 = new FlatUI.FlatLabel();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.Args = new FlatUI.FlatTextBox();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatLabel23 = new FlatUI.FlatLabel();
            this.Link1 = new FlatUI.FlatTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flatContextMenuStrip1 = new FlatUI.FlatContextMenuStrip();
            this.refrechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loges_cmd = new System.Windows.Forms.RichTextBox();
            this.flatContextMenuStrip2 = new FlatUI.FlatContextMenuStrip();
            this.refrechToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flatTabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.flatContextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flatContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refrech
            // 
            this.Refrech.Interval = 5000;
            this.Refrech.Tick += new System.EventHandler(this.Refrech_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatButton3);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Minner";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(578, 4);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(106, 32);
            this.flatButton3.TabIndex = 2;
            this.flatButton3.Text = "Refrech";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(690, 4);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Text = "Close";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 23);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 41);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(800, 406);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.flatLabel3);
            this.tabPage1.Controls.Add(this.flatLabel2);
            this.tabPage1.Controls.Add(this.circularProgressBar1);
            this.tabPage1.Controls.Add(this.flatLabel22);
            this.tabPage1.Controls.Add(this.flatLabel21);
            this.tabPage1.Controls.Add(this.cpu_prog);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(554, 288);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(50, 13);
            this.flatLabel3.TabIndex = 26;
            this.flatLabel3.Text = "<value>";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(572, 245);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(66, 32);
            this.flatLabel2.TabIndex = 25;
            this.flatLabel2.Text = "RAM";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(506, 185);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(195, 174);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 24;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 50;
            // 
            // flatLabel22
            // 
            this.flatLabel22.AutoSize = true;
            this.flatLabel22.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel22.ForeColor = System.Drawing.Color.White;
            this.flatLabel22.Location = new System.Drawing.Point(585, 103);
            this.flatLabel22.Name = "flatLabel22";
            this.flatLabel22.Size = new System.Drawing.Size(32, 21);
            this.flatLabel22.TabIndex = 23;
            this.flatLabel22.Text = "0%";
            // 
            // flatLabel21
            // 
            this.flatLabel21.AutoSize = true;
            this.flatLabel21.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel21.ForeColor = System.Drawing.Color.White;
            this.flatLabel21.Location = new System.Drawing.Point(572, 66);
            this.flatLabel21.Name = "flatLabel21";
            this.flatLabel21.Size = new System.Drawing.Size(59, 32);
            this.flatLabel21.TabIndex = 22;
            this.flatLabel21.Text = "CPU";
            // 
            // cpu_prog
            // 
            this.cpu_prog.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpu_prog.AnimationSpeed = 500;
            this.cpu_prog.BackColor = System.Drawing.Color.Transparent;
            this.cpu_prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpu_prog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpu_prog.InnerColor = System.Drawing.Color.Transparent;
            this.cpu_prog.InnerMargin = 2;
            this.cpu_prog.InnerWidth = -1;
            this.cpu_prog.Location = new System.Drawing.Point(506, 6);
            this.cpu_prog.MarqueeAnimationSpeed = 2000;
            this.cpu_prog.Name = "cpu_prog";
            this.cpu_prog.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.cpu_prog.OuterMargin = -25;
            this.cpu_prog.OuterWidth = 26;
            this.cpu_prog.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cpu_prog.ProgressWidth = 25;
            this.cpu_prog.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpu_prog.Size = new System.Drawing.Size(195, 174);
            this.cpu_prog.StartAngle = 270;
            this.cpu_prog.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpu_prog.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpu_prog.SubscriptText = "";
            this.cpu_prog.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpu_prog.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpu_prog.SuperscriptText = "";
            this.cpu_prog.TabIndex = 2;
            this.cpu_prog.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpu_prog.Value = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flatButton4);
            this.groupBox1.Controls.Add(this.flatButton5);
            this.groupBox1.Controls.Add(this.user_idl);
            this.groupBox1.Controls.Add(this.flatLabel18);
            this.groupBox1.Controls.Add(this.pool_lbl);
            this.groupBox1.Controls.Add(this.flatLabel12);
            this.groupBox1.Controls.Add(this.flatLabel10);
            this.groupBox1.Controls.Add(this.algo_lbl);
            this.groupBox1.Controls.Add(this.flatLabel9);
            this.groupBox1.Controls.Add(this.miner);
            this.groupBox1.Controls.Add(this.flatLabel7);
            this.groupBox1.Controls.Add(this.wallet_lbl);
            this.groupBox1.Controls.Add(this.flatLabel6);
            this.groupBox1.Controls.Add(this.statue);
            this.groupBox1.Controls.Add(this.flatLabel4);
            this.groupBox1.Controls.Add(this.isinstaled);
            this.groupBox1.Controls.Add(this.flatLabel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(23, 293);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = true;
            this.flatButton4.Size = new System.Drawing.Size(160, 32);
            this.flatButton4.TabIndex = 4;
            this.flatButton4.Text = "Start";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(196, 293);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = true;
            this.flatButton5.Size = new System.Drawing.Size(160, 32);
            this.flatButton5.TabIndex = 3;
            this.flatButton5.Text = "Stop";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // user_idl
            // 
            this.user_idl.AutoSize = true;
            this.user_idl.BackColor = System.Drawing.Color.Transparent;
            this.user_idl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_idl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.user_idl.Location = new System.Drawing.Point(257, 36);
            this.user_idl.Name = "user_idl";
            this.user_idl.Size = new System.Drawing.Size(57, 15);
            this.user_idl.TabIndex = 19;
            this.user_idl.Text = "<VALUE>";
            // 
            // flatLabel18
            // 
            this.flatLabel18.AutoSize = true;
            this.flatLabel18.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel18.ForeColor = System.Drawing.Color.White;
            this.flatLabel18.Location = new System.Drawing.Point(199, 36);
            this.flatLabel18.Name = "flatLabel18";
            this.flatLabel18.Size = new System.Drawing.Size(52, 15);
            this.flatLabel18.TabIndex = 18;
            this.flatLabel18.Text = "User Idl :";
            // 
            // pool_lbl
            // 
            this.pool_lbl.AutoSize = true;
            this.pool_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pool_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pool_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pool_lbl.Location = new System.Drawing.Point(96, 170);
            this.pool_lbl.Name = "pool_lbl";
            this.pool_lbl.Size = new System.Drawing.Size(57, 15);
            this.pool_lbl.TabIndex = 13;
            this.pool_lbl.Text = "<VALUE>";
            // 
            // flatLabel12
            // 
            this.flatLabel12.AutoSize = true;
            this.flatLabel12.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel12.ForeColor = System.Drawing.Color.White;
            this.flatLabel12.Location = new System.Drawing.Point(50, 170);
            this.flatLabel12.Name = "flatLabel12";
            this.flatLabel12.Size = new System.Drawing.Size(37, 15);
            this.flatLabel12.TabIndex = 12;
            this.flatLabel12.Text = "Pool :";
            // 
            // flatLabel10
            // 
            this.flatLabel10.AutoSize = true;
            this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel10.ForeColor = System.Drawing.Color.White;
            this.flatLabel10.Location = new System.Drawing.Point(6, 103);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(377, 15);
            this.flatLabel10.TabIndex = 11;
            this.flatLabel10.Text = "__________________________________________________________________________";
            // 
            // algo_lbl
            // 
            this.algo_lbl.AutoSize = true;
            this.algo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.algo_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.algo_lbl.Location = new System.Drawing.Point(96, 144);
            this.algo_lbl.Name = "algo_lbl";
            this.algo_lbl.Size = new System.Drawing.Size(57, 15);
            this.algo_lbl.TabIndex = 10;
            this.algo_lbl.Text = "<VALUE>";
            // 
            // flatLabel9
            // 
            this.flatLabel9.AutoSize = true;
            this.flatLabel9.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel9.ForeColor = System.Drawing.Color.White;
            this.flatLabel9.Location = new System.Drawing.Point(20, 144);
            this.flatLabel9.Name = "flatLabel9";
            this.flatLabel9.Size = new System.Drawing.Size(67, 15);
            this.flatLabel9.TabIndex = 9;
            this.flatLabel9.Text = "Algorithm :";
            // 
            // miner
            // 
            this.miner.AutoSize = true;
            this.miner.BackColor = System.Drawing.Color.Transparent;
            this.miner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.miner.Location = new System.Drawing.Point(79, 36);
            this.miner.Name = "miner";
            this.miner.Size = new System.Drawing.Size(57, 15);
            this.miner.TabIndex = 8;
            this.miner.Text = "<VALUE>";
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(36, 36);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(44, 15);
            this.flatLabel7.TabIndex = 7;
            this.flatLabel7.Text = "Miner :";
            // 
            // wallet_lbl
            // 
            this.wallet_lbl.BackColor = System.Drawing.Color.Transparent;
            this.wallet_lbl.FocusOnHover = false;
            this.wallet_lbl.Location = new System.Drawing.Point(73, 208);
            this.wallet_lbl.MaxLength = 32767;
            this.wallet_lbl.Multiline = false;
            this.wallet_lbl.Name = "wallet_lbl";
            this.wallet_lbl.ReadOnly = true;
            this.wallet_lbl.Size = new System.Drawing.Size(279, 29);
            this.wallet_lbl.TabIndex = 6;
            this.wallet_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.wallet_lbl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wallet_lbl.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(21, 213);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(46, 15);
            this.flatLabel6.TabIndex = 4;
            this.flatLabel6.Text = "Wallet :";
            // 
            // statue
            // 
            this.statue.AutoSize = true;
            this.statue.BackColor = System.Drawing.Color.Transparent;
            this.statue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.statue.Location = new System.Drawing.Point(79, 81);
            this.statue.Name = "statue";
            this.statue.Size = new System.Drawing.Size(57, 15);
            this.statue.TabIndex = 3;
            this.statue.Text = "<VALUE>";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(28, 81);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(51, 15);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Runing :";
            // 
            // isinstaled
            // 
            this.isinstaled.AutoSize = true;
            this.isinstaled.BackColor = System.Drawing.Color.Transparent;
            this.isinstaled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isinstaled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.isinstaled.Location = new System.Drawing.Point(79, 57);
            this.isinstaled.Name = "isinstaled";
            this.isinstaled.Size = new System.Drawing.Size(57, 15);
            this.isinstaled.TabIndex = 1;
            this.isinstaled.Text = "<VALUE>";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 57);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(68, 15);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Is installed :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.flatTabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            // 
            // flatTabControl2
            // 
            this.flatTabControl2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatTabControl2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl2.Controls.Add(this.tabPage4);
            this.flatTabControl2.Controls.Add(this.tabPage5);
            this.flatTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTabControl2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl2.ItemSize = new System.Drawing.Size(120, 23);
            this.flatTabControl2.Location = new System.Drawing.Point(3, 3);
            this.flatTabControl2.Name = "flatTabControl2";
            this.flatTabControl2.SelectedIndex = 0;
            this.flatTabControl2.Size = new System.Drawing.Size(786, 369);
            this.flatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl2.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.flatButton1);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(778, 338);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Installe";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flatLabel13);
            this.groupBox2.Controls.Add(this.Wall);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.flatLabel8);
            this.groupBox2.Controls.Add(this.Args);
            this.groupBox2.Controls.Add(this.flatLabel5);
            this.groupBox2.Controls.Add(this.flatComboBox1);
            this.groupBox2.Controls.Add(this.flatLabel23);
            this.groupBox2.Controls.Add(this.Link1);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 332);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // flatLabel13
            // 
            this.flatLabel13.AutoSize = true;
            this.flatLabel13.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel13.ForeColor = System.Drawing.Color.White;
            this.flatLabel13.Location = new System.Drawing.Point(333, 102);
            this.flatLabel13.Name = "flatLabel13";
            this.flatLabel13.Size = new System.Drawing.Size(46, 13);
            this.flatLabel13.TabIndex = 8;
            this.flatLabel13.Text = "Wallet :";
            // 
            // Wall
            // 
            this.Wall.BackColor = System.Drawing.Color.Transparent;
            this.Wall.FocusOnHover = false;
            this.Wall.Location = new System.Drawing.Point(338, 118);
            this.Wall.MaxLength = 32767;
            this.Wall.Multiline = false;
            this.Wall.Name = "Wall";
            this.Wall.ReadOnly = false;
            this.Wall.Size = new System.Drawing.Size(305, 29);
            this.Wall.TabIndex = 9;
            this.Wall.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Wall.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Wall.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downloaded);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.flatLabel11);
            this.panel1.Location = new System.Drawing.Point(359, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 115);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // downloaded
            // 
            this.downloaded.AutoSize = true;
            this.downloaded.BackColor = System.Drawing.Color.Transparent;
            this.downloaded.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloaded.ForeColor = System.Drawing.Color.White;
            this.downloaded.Location = new System.Drawing.Point(127, 32);
            this.downloaded.Name = "downloaded";
            this.downloaded.Size = new System.Drawing.Size(18, 20);
            this.downloaded.TabIndex = 2;
            this.downloaded.Text = "...";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.progress.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.progress.Location = new System.Drawing.Point(22, 59);
            this.progress.Maximum = 100;
            this.progress.Name = "progress";
            this.progress.Pattern = false;
            this.progress.PercentSign = false;
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progress.ShowBalloon = false;
            this.progress.Size = new System.Drawing.Size(222, 42);
            this.progress.TabIndex = 1;
            this.progress.Value = 0;
            // 
            // flatLabel11
            // 
            this.flatLabel11.AutoSize = true;
            this.flatLabel11.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel11.ForeColor = System.Drawing.Color.White;
            this.flatLabel11.Location = new System.Drawing.Point(18, 30);
            this.flatLabel11.Name = "flatLabel11";
            this.flatLabel11.Size = new System.Drawing.Size(110, 21);
            this.flatLabel11.TabIndex = 0;
            this.flatLabel11.Text = "Downloading :";
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(6, 83);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(36, 13);
            this.flatLabel8.TabIndex = 6;
            this.flatLabel8.Text = "Args :";
            // 
            // Args
            // 
            this.Args.BackColor = System.Drawing.Color.Transparent;
            this.Args.FocusOnHover = false;
            this.Args.Location = new System.Drawing.Point(9, 99);
            this.Args.MaxLength = 32767;
            this.Args.Multiline = true;
            this.Args.Name = "Args";
            this.Args.ReadOnly = false;
            this.Args.Size = new System.Drawing.Size(323, 216);
            this.Args.TabIndex = 5;
            this.Args.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Args.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Args.UseSystemPasswordChar = false;
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(6, 33);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(85, 13);
            this.flatLabel5.TabIndex = 4;
            this.flatLabel5.Text = "Minner to use :";
            // 
            // flatComboBox1
            // 
            this.flatComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox1.ForeColor = System.Drawing.Color.White;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatComboBox1.ItemHeight = 18;
            this.flatComboBox1.Items.AddRange(new object[] {
            "xmrig",
            "ethminer",
            "ccminer"});
            this.flatComboBox1.Location = new System.Drawing.Point(6, 51);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(239, 24);
            this.flatComboBox1.TabIndex = 3;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged);
            // 
            // flatLabel23
            // 
            this.flatLabel23.AutoSize = true;
            this.flatLabel23.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel23.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel23.ForeColor = System.Drawing.Color.White;
            this.flatLabel23.Location = new System.Drawing.Point(247, 30);
            this.flatLabel23.Name = "flatLabel23";
            this.flatLabel23.Size = new System.Drawing.Size(189, 13);
            this.flatLabel23.TabIndex = 1;
            this.flatLabel23.Text = "Direct download link (zip file only) :";
            // 
            // Link1
            // 
            this.Link1.BackColor = System.Drawing.Color.Transparent;
            this.Link1.FocusOnHover = false;
            this.Link1.Location = new System.Drawing.Point(250, 49);
            this.Link1.MaxLength = 32767;
            this.Link1.Multiline = false;
            this.Link1.Name = "Link1";
            this.Link1.ReadOnly = false;
            this.Link1.Size = new System.Drawing.Size(398, 29);
            this.Link1.TabIndex = 2;
            this.Link1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Link1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Link1.UseSystemPasswordChar = false;
            this.Link1.TextChanged += new System.EventHandler(this.Link1_TextChanged);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(666, 300);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Installe";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage5.Controls.Add(this.fastColoredTextBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(778, 338);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Json";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.ContextMenuStrip = this.flatContextMenuStrip1;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(772, 332);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // flatContextMenuStrip1
            // 
            this.flatContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.flatContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrechToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.flatContextMenuStrip1.Name = "flatContextMenuStrip1";
            this.flatContextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // refrechToolStripMenuItem
            // 
            this.refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            this.refrechToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.refrechToolStripMenuItem.Text = "Load";
            this.refrechToolStripMenuItem.Click += new System.EventHandler(this.refrechToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.loges_cmd);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cmd";
            // 
            // loges_cmd
            // 
            this.loges_cmd.BackColor = System.Drawing.Color.Black;
            this.loges_cmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loges_cmd.ContextMenuStrip = this.flatContextMenuStrip2;
            this.loges_cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loges_cmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loges_cmd.ForeColor = System.Drawing.Color.White;
            this.loges_cmd.Location = new System.Drawing.Point(3, 3);
            this.loges_cmd.Name = "loges_cmd";
            this.loges_cmd.ReadOnly = true;
            this.loges_cmd.Size = new System.Drawing.Size(786, 369);
            this.loges_cmd.TabIndex = 1;
            this.loges_cmd.Text = "";
            // 
            // flatContextMenuStrip2
            // 
            this.flatContextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatContextMenuStrip2.ForeColor = System.Drawing.Color.White;
            this.flatContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrechToolStripMenuItem1});
            this.flatContextMenuStrip2.Name = "flatContextMenuStrip2";
            this.flatContextMenuStrip2.Size = new System.Drawing.Size(114, 26);
            // 
            // refrechToolStripMenuItem1
            // 
            this.refrechToolStripMenuItem1.Name = "refrechToolStripMenuItem1";
            this.refrechToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.refrechToolStripMenuItem1.Text = "Refrech";
            this.refrechToolStripMenuItem1.Click += new System.EventHandler(this.refrechToolStripMenuItem1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frm_miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_miner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_miner";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_miner_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flatTabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.flatContextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.flatContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlatUI.FlatLabel flatLabel10;
        public FlatUI.FlatLabel algo_lbl;
        private FlatUI.FlatLabel flatLabel9;
        public FlatUI.FlatLabel miner;
        private FlatUI.FlatLabel flatLabel7;
        public FlatUI.FlatTextBox wallet_lbl;
        private FlatUI.FlatLabel flatLabel6;
        public FlatUI.FlatLabel statue;
        private FlatUI.FlatLabel flatLabel4;
        public FlatUI.FlatLabel isinstaled;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        public FlatUI.FlatLabel user_idl;
        private FlatUI.FlatLabel flatLabel18;
        public FlatUI.FlatLabel pool_lbl;
        private FlatUI.FlatLabel flatLabel12;
        public CircularProgressBar.CircularProgressBar cpu_prog;
        private System.Windows.Forms.TabPage tabPage3;
        private FlatUI.FlatLabel flatLabel22;
        private FlatUI.FlatLabel flatLabel21;
        public System.Windows.Forms.RichTextBox loges_cmd;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatTextBox Link1;
        private FlatUI.FlatLabel flatLabel23;
        private System.Windows.Forms.GroupBox groupBox2;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatLabel flatLabel2;
        public CircularProgressBar.CircularProgressBar circularProgressBar1;
        private FlatUI.FlatTabControl flatTabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FlatUI.FlatContextMenuStrip flatContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refrechToolStripMenuItem;
        private FlatUI.FlatContextMenuStrip flatContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refrechToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatButton flatButton5;
        public FlatUI.FlatLabel flatLabel3;
        private System.Windows.Forms.Timer timer1;
        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel8;
        private FlatUI.FlatTextBox Args;
        private FlatUI.FlatLabel flatLabel11;
        public FlatUI.FlatLabel downloaded;
        public System.Windows.Forms.Panel panel1;
        public FlatUI.FlatProgressBar progress;
        private FlatUI.FlatLabel flatLabel13;
        private FlatUI.FlatTextBox Wall;
        public System.Windows.Forms.Timer Refrech;
        private System.Windows.Forms.Timer timer2;
    }
}