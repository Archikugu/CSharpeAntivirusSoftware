using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace AntivirusSoftware.Custom_Controls
{
    public class MyButton : Button
    {
        private Color m_TopColor = Color.LightGreen;
        private Color m_BottomCoIor = Color.Orange;

        public Color TopColor
        {
            get
            {
                return m_TopColor;
            }

            set
            {
                m_TopColor = value;
                this.Invalidate();
            }
        }
        public Color ButtomColor
        {
            get
            {
                return m_BottomCoIor;
            }

            set
            {
                m_BottomCoIor = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, m_TopColor, m_BottomCoIor, 90.0F))
            {
                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    using (StringFormat format = new StringFormat())
                    {
                        format.Alignment = GetHorizantalAlignment();
                        format.LineAlignment = GetVerticalAlignment();
                        e.Graphics.FillRectangle(lgb, this.ClientRectangle);
                        e.Graphics.DrawString(this.Text, this.Font, textBrush, this.ClientRectangle, format);
                    }
                }
            }
        }
        private StringAlignment GetVerticalAlignment()
        {
            int alignmentValue = (int)Math.Log((double)this.TextAlign, 2D);
            return (StringAlignment)(alignmentValue / 4);
        }
        private StringAlignment GetHorizantalAlignment()
        {
            int alignmentValue = (int)Math.Log((double)this.TextAlign, 2D);
            return (StringAlignment)(alignmentValue % 4);
        }
    }
}
