
namespace server.Forms
{
    partial class frm_cmd
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loges_cmd = new System.Windows.Forms.RichTextBox();
            this.cmd_commands = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatButton3 = new FlatUI.FlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Loges_Powershell = new System.Windows.Forms.RichTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.ResRefresh = new System.Windows.Forms.Timer(this.components);
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(140, 8);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 9;
            this.flatToggle1.Text = "flatToggle1";
            this.toolTip1.SetToolTip(this.flatToggle1, "Toggle Top most");
            this.flatToggle1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatLabel6);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1154, 575);
            this.formSkin1.TabIndex = 1;
            this.formSkin1.Text = "Command line";
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(561, 281);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(0, 13);
            this.flatLabel6.TabIndex = 16;
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 23);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 51);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(1151, 521);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 10;
            this.flatTabControl1.SelectedIndexChanged += new System.EventHandler(this.flatTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cmd";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loges_cmd);
            this.panel1.Controls.Add(this.cmd_commands);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 484);
            this.panel1.TabIndex = 0;
            // 
            // loges_cmd
            // 
            this.loges_cmd.BackColor = System.Drawing.Color.Black;
            this.loges_cmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loges_cmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.loges_cmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loges_cmd.ForeColor = System.Drawing.Color.Lime;
            this.loges_cmd.Location = new System.Drawing.Point(0, 0);
            this.loges_cmd.Name = "loges_cmd";
            this.loges_cmd.ReadOnly = true;
            this.loges_cmd.Size = new System.Drawing.Size(1135, 454);
            this.loges_cmd.TabIndex = 0;
            this.loges_cmd.Text = "Microsoft Windows [Version 10.0.19043.1526]";
            this.loges_cmd.TextChanged += new System.EventHandler(this.loges_cmd_TextChanged);
            // 
            // cmd_commands
            // 
            this.cmd_commands.BackColor = System.Drawing.Color.Black;
            this.cmd_commands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmd_commands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmd_commands.Font = new System.Drawing.Font("Consolas", 12F);
            this.cmd_commands.ForeColor = System.Drawing.Color.Lime;
            this.cmd_commands.Location = new System.Drawing.Point(0, 456);
            this.cmd_commands.Name = "cmd_commands";
            this.cmd_commands.Size = new System.Drawing.Size(1135, 26);
            this.cmd_commands.TabIndex = 4;
            this.cmd_commands.TextChanged += new System.EventHandler(this.cmd_commands_TextChanged);
            this.cmd_commands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_commands_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Powershell";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flatButton3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Loges_Powershell);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 484);
            this.panel2.TabIndex = 1;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(1034, 459);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(97, 22);
            this.flatButton3.TabIndex = 17;
            this.flatButton3.Text = "Script";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1032, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Loges_Powershell
            // 
            this.Loges_Powershell.BackColor = System.Drawing.Color.Navy;
            this.Loges_Powershell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loges_Powershell.Dock = System.Windows.Forms.DockStyle.Top;
            this.Loges_Powershell.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loges_Powershell.ForeColor = System.Drawing.Color.White;
            this.Loges_Powershell.Location = new System.Drawing.Point(0, 0);
            this.Loges_Powershell.Name = "Loges_Powershell";
            this.Loges_Powershell.ReadOnly = true;
            this.Loges_Powershell.Size = new System.Drawing.Size(1135, 454);
            this.Loges_Powershell.TabIndex = 0;
            this.Loges_Powershell.Text = "";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(783, 8);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(179, 32);
            this.flatButton1.TabIndex = 6;
            this.flatButton1.Text = "Save";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(968, 8);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(179, 32);
            this.flatButton2.TabIndex = 5;
            this.flatButton2.Text = "Close";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // ResRefresh
            // 
            this.ResRefresh.Interval = 3000;
            this.ResRefresh.Tick += new System.EventHandler(this.ResRefresh_Tick);
            // 
            // frm_cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 575);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cmd";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_cmd_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox loges_cmd;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton2;
        private System.Windows.Forms.TextBox cmd_commands;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatToggle flatToggle1;
        private System.Windows.Forms.ToolTip toolTip1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Loges_Powershell;
        private System.Windows.Forms.TextBox textBox1;
        private FlatUI.FlatLabel flatLabel6;
        private System.Windows.Forms.Timer ResRefresh;
        private FlatUI.FlatButton flatButton3;
    }
}