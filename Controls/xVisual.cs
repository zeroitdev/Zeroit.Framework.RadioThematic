// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="xVisual.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.RadioThematic.ThemeManagers;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {


        #region " Control Help - MouseState & Flicker Control"
        /// <summary>
        /// The r1
        /// </summary>
        private Rectangle R1;

        /// <summary>
        /// The g1
        /// </summary>
        private LinearGradientBrush G1;

        /// <summary>
        /// xes the visual on resize.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void xVisualOnResize(System.EventArgs e)
        {
            Height = 21;
        }

        #endregion

        /// <summary>
        /// xes the visual RadioButton.
        /// </summary>
        private void xVisualRadioButton()
        {
            Size = new Size(150, 21);
            
        }

        /// <summary>
        /// The inner texture
        /// </summary>
        TextureBrush InnerTexture = Draw.NoiseBrush(new Color[]{
        Color.FromArgb(55, 52, 48),
        Color.FromArgb(57, 50, 50),
        Color.FromArgb(53, 50, 46)
        });


        /// <summary>
        /// xes the visual on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void xVisualOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle radioBtnRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.SmoothingMode = Smoothing;
            G.CompositingQuality = CompositingQuality.HighQuality;
            G.TextRenderingHint = TextRendering;

            G.Clear(BackColor);

            G.FillEllipse(InnerTexture, radioBtnRectangle);
            G.DrawEllipse(new Pen(Color.Black), radioBtnRectangle);
            G.DrawEllipse(new Pen(Color.FromArgb(99, 97, 94)), new Rectangle(1, 1, Height - 3, Height - 3));

            if (Checked)
            {
                G.DrawString("a", new Font("Marlett", 12, FontStyle.Regular), Brushes.White, new Point((Width/10) / 2, (Height/2) -10));
            }

            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            Brush nb = new SolidBrush(Color.FromArgb(250, 250, 250));
            G.DrawString(Text, drawFont, nb, new Point(Height, (Height / 2) - 3), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            
        }


    }

}

