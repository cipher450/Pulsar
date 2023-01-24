
namespace server.Forms
{
    partial class frm_Stealer
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
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Browsers_treeview = new System.Windows.Forms.TreeView();
            this.Browsers_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Messangers_treeView = new System.Windows.Forms.TreeView();
            this.Messangers_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Gaming_treeView = new System.Windows.Forms.TreeView();
            this.Gaming_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.vpn_treeView = new System.Windows.Forms.TreeView();
            this.Vpns_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Browsers_TextBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Messangers_TextBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gaming_TextBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vpns_TextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(893, 450);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Stealer";
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(90, 9);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style2;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 3;
            this.flatToggle1.Text = "flatToggle1";
            this.flatToggle1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(669, 9);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Refrech";
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
            this.flatTabControl1.Controls.Add(this.tabPage4);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 23);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(890, 400);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Controls.Add(this.Browsers_treeview);
            this.tabPage1.Controls.Add(this.Browsers_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Browsers";
            // 
            // Browsers_treeview
            // 
            this.Browsers_treeview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Browsers_treeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Browsers_treeview.Dock = System.Windows.Forms.DockStyle.Right;
            this.Browsers_treeview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsers_treeview.ForeColor = System.Drawing.Color.White;
            this.Browsers_treeview.Location = new System.Drawing.Point(684, 3);
            this.Browsers_treeview.Name = "Browsers_treeview";
            this.Browsers_treeview.Size = new System.Drawing.Size(195, 363);
            this.Browsers_treeview.TabIndex = 1;
            // 
            // Browsers_TextBox
            // 
            this.Browsers_TextBox.AutoScrollMinSize = new System.Drawing.Size(33, 21);
            this.Browsers_TextBox.BackBrush = null;
            this.Browsers_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Browsers_TextBox.CharHeight = 21;
            this.Browsers_TextBox.CharWidth = 11;
            this.Browsers_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Browsers_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Browsers_TextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Browsers_TextBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.Browsers_TextBox.ForeColor = System.Drawing.Color.White;
            this.Browsers_TextBox.IsReplaceMode = false;
            this.Browsers_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Browsers_TextBox.Name = "Browsers_TextBox";
            this.Browsers_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.Browsers_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Browsers_TextBox.Size = new System.Drawing.Size(683, 363);
            this.Browsers_TextBox.TabIndex = 0;
            this.Browsers_TextBox.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Controls.Add(this.Messangers_treeView);
            this.tabPage2.Controls.Add(this.Messangers_TextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messangers";
            // 
            // Messangers_treeView
            // 
            this.Messangers_treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Messangers_treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Messangers_treeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.Messangers_treeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messangers_treeView.ForeColor = System.Drawing.Color.White;
            this.Messangers_treeView.Location = new System.Drawing.Point(684, 3);
            this.Messangers_treeView.Name = "Messangers_treeView";
            this.Messangers_treeView.Size = new System.Drawing.Size(195, 363);
            this.Messangers_treeView.TabIndex = 2;
            // 
            // Messangers_TextBox
            // 
            this.Messangers_TextBox.AutoScrollMinSize = new System.Drawing.Size(2, 21);
            this.Messangers_TextBox.BackBrush = null;
            this.Messangers_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Messangers_TextBox.CharHeight = 21;
            this.Messangers_TextBox.CharWidth = 11;
            this.Messangers_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Messangers_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Messangers_TextBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.Messangers_TextBox.ForeColor = System.Drawing.Color.White;
            this.Messangers_TextBox.IsReplaceMode = false;
            this.Messangers_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Messangers_TextBox.Name = "Messangers_TextBox";
            this.Messangers_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.Messangers_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Messangers_TextBox.Size = new System.Drawing.Size(683, 363);
            this.Messangers_TextBox.TabIndex = 0;
            this.Messangers_TextBox.Zoom = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage3.Controls.Add(this.Gaming_treeView);
            this.tabPage3.Controls.Add(this.Gaming_TextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(882, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gaming";
            // 
            // Gaming_treeView
            // 
            this.Gaming_treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Gaming_treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gaming_treeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gaming_treeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gaming_treeView.ForeColor = System.Drawing.Color.White;
            this.Gaming_treeView.Location = new System.Drawing.Point(684, 3);
            this.Gaming_treeView.Name = "Gaming_treeView";
            this.Gaming_treeView.Size = new System.Drawing.Size(195, 363);
            this.Gaming_treeView.TabIndex = 2;
            // 
            // Gaming_TextBox
            // 
            this.Gaming_TextBox.AutoScrollMinSize = new System.Drawing.Size(2, 21);
            this.Gaming_TextBox.BackBrush = null;
            this.Gaming_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Gaming_TextBox.CharHeight = 21;
            this.Gaming_TextBox.CharWidth = 11;
            this.Gaming_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gaming_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Gaming_TextBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.Gaming_TextBox.ForeColor = System.Drawing.Color.White;
            this.Gaming_TextBox.IsReplaceMode = false;
            this.Gaming_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Gaming_TextBox.Name = "Gaming_TextBox";
            this.Gaming_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.Gaming_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Gaming_TextBox.Size = new System.Drawing.Size(683, 363);
            this.Gaming_TextBox.TabIndex = 1;
            this.Gaming_TextBox.Zoom = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage4.Controls.Add(this.vpn_treeView);
            this.tabPage4.Controls.Add(this.Vpns_TextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(882, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "VPNs";
            // 
            // vpn_treeView
            // 
            this.vpn_treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.vpn_treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpn_treeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.vpn_treeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpn_treeView.ForeColor = System.Drawing.Color.White;
            this.vpn_treeView.Location = new System.Drawing.Point(684, 3);
            this.vpn_treeView.Name = "vpn_treeView";
            this.vpn_treeView.Size = new System.Drawing.Size(195, 363);
            this.vpn_treeView.TabIndex = 2;
            // 
            // Vpns_TextBox
            // 
            this.Vpns_TextBox.AutoScrollMinSize = new System.Drawing.Size(2, 21);
            this.Vpns_TextBox.BackBrush = null;
            this.Vpns_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Vpns_TextBox.CharHeight = 21;
            this.Vpns_TextBox.CharWidth = 11;
            this.Vpns_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vpns_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Vpns_TextBox.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.Vpns_TextBox.ForeColor = System.Drawing.Color.White;
            this.Vpns_TextBox.IsReplaceMode = false;
            this.Vpns_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Vpns_TextBox.Name = "Vpns_TextBox";
            this.Vpns_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.Vpns_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Vpns_TextBox.Size = new System.Drawing.Size(683, 363);
            this.Vpns_TextBox.TabIndex = 1;
            this.Vpns_TextBox.Zoom = 100;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(781, 9);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // frm_Stealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Stealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Stealer";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Browsers_TextBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Messangers_TextBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gaming_TextBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vpns_TextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FastColoredTextBoxNS.FastColoredTextBox Browsers_TextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private FastColoredTextBoxNS.FastColoredTextBox Messangers_TextBox;
        private FastColoredTextBoxNS.FastColoredTextBox Gaming_TextBox;
        private FastColoredTextBoxNS.FastColoredTextBox Vpns_TextBox;
        private System.Windows.Forms.TreeView Browsers_treeview;
        private FlatUI.FlatButton flatButton2;
        private System.Windows.Forms.TreeView Messangers_treeView;
        private System.Windows.Forms.TreeView Gaming_treeView;
        private System.Windows.Forms.TreeView vpn_treeView;
        private FlatUI.FlatToggle flatToggle1;
    }
}