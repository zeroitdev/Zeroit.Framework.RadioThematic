// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Perplex.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

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
        /// Perplexes the on resize.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PerplexOnResize(System.EventArgs e)
        {
            Height = 16;
        }


        #endregion

        /// <summary>
        /// Perplexes the RadioButton.
        /// </summary>
        private void PerplexRadioButton()
        {
            Size = new Size(150, 16);
            
        }

        /// <summary>
        /// Perplexes the on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void PerplexOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            dynamic radioBtnRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.SmoothingMode = Smoothing;
            G.CompositingQuality = CompositingQuality.HighQuality;

            G.Clear(Parent.BackColor);

            LinearGradientBrush bgGrad = new LinearGradientBrush(radioBtnRectangle, Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90);
            G.FillEllipse(bgGrad, radioBtnRectangle);

            //G.DrawEllipse(New Pen(Color.Gray), New Rectangle(1, 1, Height - 3, Height - 3))
            G.DrawEllipse(new Pen(Color.Black), radioBtnRectangle);

            if (Checked)
            {
                LinearGradientBrush chkGrad = new LinearGradientBrush(new Rectangle(4, 4, Height - 9, Height - 9), Color.FromArgb(250, 15, 15, 15), Color.FromArgb(250, 15, 15, 15), 90);
                G.FillEllipse(chkGrad, new Rectangle(4, 4, Height - 9, Height - 9));
            }

            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);
            Brush nb = new SolidBrush(Color.FromArgb(205, 205, 205));

            G.DrawString(Text, drawFont, Brushes.Black, new Point(Height, (Height/2) - 7), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });
            G.DrawString(Text, drawFont, nb, new Point(Height, (Height/2) - 8), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            
        }


    }

}

