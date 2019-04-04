// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Perplex.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Radio button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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

