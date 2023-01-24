
namespace server.Forms
{
    partial class frm_Microphon
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
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatComboBox2 = new FlatUI.FlatComboBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(120, 9);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 8;
            this.flatToggle1.Text = "flatToggle1";
            this.toolTip1.SetToolTip(this.flatToggle1, "Toggle Top most");
            this.flatToggle1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.flatComboBox2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.flatComboBox1);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Controls.Add(this.flatButton3);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(435, 274);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Microphone";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(226, 54);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(49, 13);
            this.flatLabel2.TabIndex = 7;
            this.flatLabel2.Text = "Quality :";
            // 
            // flatComboBox2
            // 
            this.flatComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox2.ForeColor = System.Drawing.Color.White;
            this.flatComboBox2.FormattingEnabled = true;
            this.flatComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatComboBox2.ItemHeight = 18;
            this.flatComboBox2.Location = new System.Drawing.Point(226, 71);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(193, 24);
            this.flatComboBox2.TabIndex = 6;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 55);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(102, 13);
            this.flatLabel1.TabIndex = 5;
            this.flatLabel1.Text = "Recording Device :";
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
            this.flatComboBox1.Location = new System.Drawing.Point(12, 72);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(208, 24);
            this.flatComboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 116);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audio Graphe";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Enabled = false;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(120, 227);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = true;
            this.flatButton3.Size = new System.Drawing.Size(106, 32);
            this.flatButton3.TabIndex = 2;
            this.flatButton3.Text = "Stop";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Enabled = false;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(8, 227);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = true;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Text = "Recorde";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(322, 10);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // frm_Microphon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 274);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Microphon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Microphon";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_Microphon_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatToggle flatToggle1;
        private System.Windows.Forms.ToolTip toolTip1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public FlatUI.FlatComboBox flatComboBox2;
        public FlatUI.FlatComboBox flatComboBox1;
        public FlatUI.FlatButton flatButton3;
        public FlatUI.FlatButton flatButton2;
    }
}