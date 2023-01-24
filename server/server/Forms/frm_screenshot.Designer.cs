
namespace server.Forms
{
    partial class frm_screenshot
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.flatCheckBox1 = new FlatUI.FlatCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatComboBox2 = new FlatUI.FlatComboBox();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatCheckBox1);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.flatComboBox2);
            this.formSkin1.Controls.Add(this.flatComboBox1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1014, 565);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Screenshot";
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(116, 9);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style2;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 6;
            this.flatToggle1.Text = "flatToggle1";
            this.flatToggle1.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // flatCheckBox1
            // 
            this.flatCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatCheckBox1.Checked = true;
            this.flatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBox1.Location = new System.Drawing.Point(202, 14);
            this.flatCheckBox1.Name = "flatCheckBox1";
            this.flatCheckBox1.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBox1.Size = new System.Drawing.Size(112, 22);
            this.flatCheckBox1.TabIndex = 5;
            this.flatCheckBox1.Text = "Save To Folder";
            this.flatCheckBox1.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.flatCheckBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.flatComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox2.ItemHeight = 18;
            this.flatComboBox2.Location = new System.Drawing.Point(546, 14);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(121, 24);
            this.flatComboBox2.TabIndex = 3;
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
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox1.ItemHeight = 18;
            this.flatComboBox1.Location = new System.Drawing.Point(673, 14);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(121, 24);
            this.flatComboBox1.TabIndex = 2;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(812, 9);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(92, 32);
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Text = "Take";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(910, 9);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(92, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // frm_screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 565);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_screenshot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_screenshot";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_screenshot_Load);
            this.formSkin1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton2;
        public FlatUI.FlatComboBox flatComboBox2;
        public FlatUI.FlatComboBox flatComboBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public FlatUI.FlatCheckBox flatCheckBox1;
        private FlatUI.FlatToggle flatToggle1;
    }
}