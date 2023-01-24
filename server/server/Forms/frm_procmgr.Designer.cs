
namespace server.Forms
{
    partial class frm_procmgr
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.Refrech = new System.Windows.Forms.Timer(this.components);
            this.ColoreChange = new System.Windows.Forms.Timer(this.components);
            this.formSkin1 = new FlatUI.FormSkin();
            this.StatusBar1 = new FlatUI.FlatStatusBar();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbRunningProcesses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flatContextMenuStrip1 = new FlatUI.FlatContextMenuStrip();
            this.refrechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.Ram_value = new CircularProgressBar.CircularProgressBar();
            this.flatLabel22 = new FlatUI.FlatLabel();
            this.flatLabel21 = new FlatUI.FlatLabel();
            this.CPU_Value = new CircularProgressBar.CircularProgressBar();
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flatContextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(183, 9);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style2;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 3;
            this.flatToggle1.Text = "flatToggle1";
            this.toolTip1.SetToolTip(this.flatToggle1, "Toggle Top Most");
            // 
            // Refrech
            // 
            this.Refrech.Enabled = true;
            this.Refrech.Interval = 5000;
            this.Refrech.Tick += new System.EventHandler(this.Refrech_Tick);
            // 
            // ColoreChange
            // 
            this.ColoreChange.Enabled = true;
            this.ColoreChange.Interval = 1;
            this.ColoreChange.Tick += new System.EventHandler(this.ColoreChange_Tick);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.StatusBar1);
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(920, 506);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Pulsar -  TaskManger";
            // 
            // StatusBar1
            // 
            this.StatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.StatusBar1.ForeColor = System.Drawing.Color.White;
            this.StatusBar1.Location = new System.Drawing.Point(0, 484);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StatusBar1.ShowTimeDate = false;
            this.StatusBar1.Size = new System.Drawing.Size(920, 22);
            this.StatusBar1.TabIndex = 6;
            this.StatusBar1.Text = "CPU Usage : <> | Memory Usage : <>  | Processe:   ";
            this.StatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(690, 9);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Refrech";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(802, 9);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 23);
            this.flatTabControl1.Location = new System.Drawing.Point(1, 51);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(919, 433);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.lbRunningProcesses);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processes";
            // 
            // lbRunningProcesses
            // 
            this.lbRunningProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lbRunningProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRunningProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lbRunningProcesses.ContextMenuStrip = this.flatContextMenuStrip1;
            this.lbRunningProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRunningProcesses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRunningProcesses.ForeColor = System.Drawing.Color.White;
            this.lbRunningProcesses.HideSelection = false;
            this.lbRunningProcesses.Location = new System.Drawing.Point(3, 3);
            this.lbRunningProcesses.MultiSelect = false;
            this.lbRunningProcesses.Name = "lbRunningProcesses";
            this.lbRunningProcesses.Size = new System.Drawing.Size(905, 396);
            this.lbRunningProcesses.TabIndex = 0;
            this.lbRunningProcesses.UseCompatibleStateImageBehavior = false;
            this.lbRunningProcesses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Window Name";
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Private bytes";
            this.columnHeader4.Width = 162;
            // 
            // flatContextMenuStrip1
            // 
            this.flatContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.flatContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrechToolStripMenuItem,
            this.killToolStripMenuItem});
            this.flatContextMenuStrip1.Name = "flatContextMenuStrip1";
            this.flatContextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            this.flatContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.flatContextMenuStrip1_Opening);
            // 
            // refrechToolStripMenuItem
            // 
            this.refrechToolStripMenuItem.Image = global::server.Properties.Resources._003_refresh_button;
            this.refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            this.refrechToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refrechToolStripMenuItem.Text = "Refrech";
            this.refrechToolStripMenuItem.Click += new System.EventHandler(this.refrechToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Image = global::server.Properties.Resources._002_close;
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.flatLabel3);
            this.tabPage2.Controls.Add(this.flatLabel2);
            this.tabPage2.Controls.Add(this.Ram_value);
            this.tabPage2.Controls.Add(this.flatLabel22);
            this.tabPage2.Controls.Add(this.flatLabel21);
            this.tabPage2.Controls.Add(this.CPU_Value);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "System Resources";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(636, 203);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(32, 21);
            this.flatLabel3.TabIndex = 32;
            this.flatLabel3.Text = "0%";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(623, 164);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(66, 32);
            this.flatLabel2.TabIndex = 31;
            this.flatLabel2.Text = "RAM";
            // 
            // Ram_value
            // 
            this.Ram_value.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Ram_value.AnimationSpeed = 500;
            this.Ram_value.BackColor = System.Drawing.Color.Transparent;
            this.Ram_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Ram_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ram_value.InnerColor = System.Drawing.Color.Transparent;
            this.Ram_value.InnerMargin = 2;
            this.Ram_value.InnerWidth = -1;
            this.Ram_value.Location = new System.Drawing.Point(557, 108);
            this.Ram_value.MarqueeAnimationSpeed = 2000;
            this.Ram_value.Name = "Ram_value";
            this.Ram_value.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Ram_value.OuterMargin = -25;
            this.Ram_value.OuterWidth = 26;
            this.Ram_value.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ram_value.ProgressWidth = 25;
            this.Ram_value.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Ram_value.Size = new System.Drawing.Size(195, 174);
            this.Ram_value.StartAngle = 270;
            this.Ram_value.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Ram_value.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Ram_value.SubscriptText = "";
            this.Ram_value.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Ram_value.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Ram_value.SuperscriptText = "";
            this.Ram_value.TabIndex = 30;
            this.Ram_value.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Ram_value.Value = 50;
            // 
            // flatLabel22
            // 
            this.flatLabel22.AutoSize = true;
            this.flatLabel22.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel22.ForeColor = System.Drawing.Color.White;
            this.flatLabel22.Location = new System.Drawing.Point(210, 208);
            this.flatLabel22.Name = "flatLabel22";
            this.flatLabel22.Size = new System.Drawing.Size(32, 21);
            this.flatLabel22.TabIndex = 29;
            this.flatLabel22.Text = "0%";
            // 
            // flatLabel21
            // 
            this.flatLabel21.AutoSize = true;
            this.flatLabel21.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel21.ForeColor = System.Drawing.Color.White;
            this.flatLabel21.Location = new System.Drawing.Point(197, 168);
            this.flatLabel21.Name = "flatLabel21";
            this.flatLabel21.Size = new System.Drawing.Size(59, 32);
            this.flatLabel21.TabIndex = 28;
            this.flatLabel21.Text = "CPU";
            // 
            // CPU_Value
            // 
            this.CPU_Value.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPU_Value.AnimationSpeed = 500;
            this.CPU_Value.BackColor = System.Drawing.Color.Transparent;
            this.CPU_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.CPU_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPU_Value.InnerColor = System.Drawing.Color.Transparent;
            this.CPU_Value.InnerMargin = 2;
            this.CPU_Value.InnerWidth = -1;
            this.CPU_Value.Location = new System.Drawing.Point(131, 108);
            this.CPU_Value.MarqueeAnimationSpeed = 2000;
            this.CPU_Value.Name = "CPU_Value";
            this.CPU_Value.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.CPU_Value.OuterMargin = -25;
            this.CPU_Value.OuterWidth = 26;
            this.CPU_Value.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CPU_Value.ProgressWidth = 25;
            this.CPU_Value.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPU_Value.Size = new System.Drawing.Size(195, 174);
            this.CPU_Value.StartAngle = 270;
            this.CPU_Value.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_Value.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPU_Value.SubscriptText = "";
            this.CPU_Value.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_Value.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPU_Value.SuperscriptText = "";
            this.CPU_Value.TabIndex = 27;
            this.CPU_Value.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPU_Value.Value = 50;
            // 
            // frm_procmgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 506);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_procmgr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_procmgr";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_procmgr_Load);
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flatContextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatUI.FlatButton flatButton1;
        public System.Windows.Forms.ListView lbRunningProcesses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatToggle flatToggle1;
        private System.Windows.Forms.ToolTip toolTip1;
        private FlatUI.FlatContextMenuStrip flatContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refrechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        public CircularProgressBar.CircularProgressBar Ram_value;
        private FlatUI.FlatLabel flatLabel21;
        public CircularProgressBar.CircularProgressBar CPU_Value;
        public System.Windows.Forms.Timer Refrech;
        public FlatUI.FlatStatusBar StatusBar1;
        public FlatUI.FlatLabel flatLabel22;
        public System.Windows.Forms.Timer ColoreChange;
    }
}