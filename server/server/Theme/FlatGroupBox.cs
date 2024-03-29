﻿using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatGroupBox : ContainerControl
    {
        private int W;
        private int H;
        private bool _ShowText = true;

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        public bool ShowText
        {
            get { return _ShowText; }
            set { _ShowText = value; }
        }

        private Color _BaseColor = Color.FromArgb(60, 70, 73);
        private Color _TextColor = Color.FromArgb(0, 128, 255);

        public FlatGroupBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Size = new Size(240, 180);
            Font = new Font("Segoe ui", 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();
            GraphicsPath GP3 = new GraphicsPath();
            Rectangle Base = new Rectangle(8, 8, W - 16, H - 16);

            var _with7 = G;
            _with7.SmoothingMode = SmoothingMode.HighQuality;
            _with7.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with7.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with7.Clear(BackColor);

            //-- Base
            GP = Helpers.RoundRec(Base, 8);
            _with7.FillPath(new SolidBrush(_BaseColor), GP);

            //-- Arrows
            GP2 = Helpers.DrawArrow(28, 2, false);
            _with7.FillPath(new SolidBrush(_BaseColor), GP2);
            GP3 = Helpers.DrawArrow(28, 8, true);
            _with7.FillPath(new SolidBrush(Color.FromArgb(60, 70, 73)), GP3);

            //-- if ShowText
            if (ShowText)
            {
                _with7.DrawString(Text, Font, new SolidBrush(_TextColor), new Rectangle(16, 16, W, H), Helpers.NearSF);
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _TextColor = colors.Flat;
        }
    }
}
