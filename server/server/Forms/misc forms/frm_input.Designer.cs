
namespace server.Forms
{
    partial class frm_input
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
            this.input_prompt = new FlatUI.FlatLabel();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.Maroon;
            this.formSkin1.Controls.Add(this.input_prompt);
            this.formSkin1.Controls.Add(this.flatTextBox1);
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Maroon;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(437, 121);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Input form";
            // 
            // input_prompt
            // 
            this.input_prompt.AutoSize = true;
            this.input_prompt.BackColor = System.Drawing.Color.Transparent;
            this.input_prompt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.input_prompt.ForeColor = System.Drawing.Color.White;
            this.input_prompt.Location = new System.Drawing.Point(12, 58);
            this.input_prompt.Name = "input_prompt";
            this.input_prompt.Size = new System.Drawing.Size(88, 13);
            this.input_prompt.TabIndex = 3;
            this.input_prompt.Text = "Entre text here :";
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(12, 79);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(418, 29);
            this.flatTextBox1.TabIndex = 2;
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.Maroon;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(325, 11);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = true;
            this.flatButton2.Size = new System.Drawing.Size(105, 29);
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Text = "Cancel";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Maroon;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(214, 12);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(105, 29);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Submit";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // frm_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 121);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_input";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_input";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_input_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        public  FlatUI.FlatLabel input_prompt;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton1;
    }
}