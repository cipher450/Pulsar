
namespace server.Forms
{
    partial class frm_Network
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.Hostlist = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(802, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Network";
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(98, 9);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style2;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 2;
            this.flatToggle1.Text = "flatToggle1";
            this.flatToggle1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
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
            this.flatTabControl1.Location = new System.Drawing.Point(3, 52);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(799, 395);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.fastColoredTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.fastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.ReadOnly = true;
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ShowLineNumbers = false;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(785, 358);
            this.fastColoredTextBox1.TabIndex = 2;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connections";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 358);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Protocol";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Local Adresse";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Foreign Adresse";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Statue";
            this.columnHeader4.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Process name";
            this.columnHeader6.Width = 112;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.flatButton2);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.Hostlist);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scanner";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flatTextBox1);
            this.panel2.Controls.Add(this.flatTextBox2);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Location = new System.Drawing.Point(74, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 34);
            this.panel2.TabIndex = 11;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(579, 332);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = true;
            this.flatButton2.Size = new System.Drawing.Size(108, 27);
            this.flatButton2.TabIndex = 3;
            this.flatButton2.Text = "Start";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(30, 3);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(203, 29);
            this.flatTextBox1.TabIndex = 7;
            this.flatTextBox1.Text = "192.168.1.1";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Location = new System.Drawing.Point(260, 3);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(203, 29);
            this.flatTextBox2.TabIndex = 8;
            this.flatTextBox2.Text = "192.168.255.255";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(237, 10);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(19, 13);
            this.flatLabel3.TabIndex = 9;
            this.flatLabel3.Text = "To";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flatLabel4);
            this.panel1.Controls.Add(this.flatLabel2);
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Location = new System.Drawing.Point(232, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 146);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(97, 84);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(104, 25);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "192.168.1.1";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(49, 25);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(196, 50);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Scanning...";
            // 
            // Hostlist
            // 
            this.Hostlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Hostlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hostlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader9});
            this.Hostlist.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hostlist.ForeColor = System.Drawing.Color.White;
            this.Hostlist.FullRowSelect = true;
            this.Hostlist.HideSelection = false;
            this.Hostlist.Location = new System.Drawing.Point(3, 3);
            this.Hostlist.MultiSelect = false;
            this.Hostlist.Name = "Hostlist";
            this.Hostlist.Size = new System.Drawing.Size(785, 322);
            this.Hostlist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Hostlist.TabIndex = 5;
            this.Hostlist.UseCompatibleStateImageBehavior = false;
            this.Hostlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IP Addresse";
            this.columnHeader5.Width = 218;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hostname";
            this.columnHeader7.Width = 173;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Statue";
            this.columnHeader9.Width = 246;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(685, 10);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(108, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(65, 129);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(170, 17);
            this.flatLabel4.TabIndex = 3;
            this.flatLabel4.Text = "Don\'t worry if it looks stuck ";
            // 
            // frm_Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Network";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Network";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_Network_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private FlatUI.FlatToggle flatToggle1;
        public FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        public System.Windows.Forms.ListView Hostlist;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.Panel panel1;
        private FlatUI.FlatLabel flatLabel1;
        public FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatTextBox flatTextBox1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private FlatUI.FlatLabel flatLabel4;
    }
}