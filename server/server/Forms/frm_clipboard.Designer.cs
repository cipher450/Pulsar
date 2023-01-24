
namespace server
{
    partial class frm_clipboard
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formSkin1 = new FlatUI.FormSkin();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.flatButton1 = new FlatUI.FlatButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
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
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.chromiumWebBrowser1);
            this.formSkin1.Controls.Add(this.flatToggle1);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1108, 596);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Pulsar - Clipboard";
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 49);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1108, 547);
            this.chromiumWebBrowser1.TabIndex = 10;
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(161, 7);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 9;
            this.flatToggle1.Text = "flatToggle1";
            this.toolTip1.SetToolTip(this.flatToggle1, "Toggle Top most");
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(990, 7);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = true;
            this.flatButton1.Size = new System.Drawing.Size(106, 33);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Close";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // frm_clipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 596);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_clipboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_clipboard";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_clipboard_Load);
            this.formSkin1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.Timer timer1;
        private FlatUI.FlatToggle flatToggle1;
        private System.Windows.Forms.ToolTip toolTip1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}