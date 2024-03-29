﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatContextMenuStrip : ContextMenuStrip
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        public FlatContextMenuStrip()
            : base()
        {
            Renderer = new ToolStripProfessionalRenderer(new TColorTable());
            ShowImageMargin = true;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 8);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }

        public class TColorTable : ProfessionalColorTable
        {
            [Category("Colors")]
            public Color _BackColor
            {
                get { return BackColor; }
                set { BackColor = value; }
            }

            [Category("Colors")]
            public Color _CheckedColor
            {
                get { return CheckedColor; }
                set { CheckedColor = value; }
            }

            [Category("Colors")]
            public Color _BorderColor
            {
                get { return BorderColor; }
                set { BorderColor = value; }
            }

            private Color BackColor = Color.FromArgb(45, 47, 49);
            private Color CheckedColor = Color.FromArgb(45, 47, 49);// Helpers.FlatColor;
            private Color BorderColor = Color.FromArgb(53, 58, 60);

            public override Color ButtonSelectedBorder
            {
                get { return BackColor; }
            }

            public override Color CheckBackground
            {
                get { return CheckedColor; }
            }

            public override Color CheckPressedBackground
            {
                get { return CheckedColor; }
            }

            public override Color CheckSelectedBackground
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return CheckedColor; }
            }

            public override Color MenuBorder
            {
                get { return BorderColor; }
            }

            public override Color MenuItemBorder
            {
                get { return BorderColor; }
            }

            public override Color MenuItemSelected
            {
                get { return CheckedColor; }
            }

            public override Color SeparatorDark
            {
                get { return BorderColor; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return BackColor; }
            }
        }
    }
}
