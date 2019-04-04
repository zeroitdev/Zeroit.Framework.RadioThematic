// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Influence.cs" company="Zeroit Dev Technologies">
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

        #endregion

        /// <summary>
        /// Influences the RadioButton.
        /// </summary>
        private void InfluenceRadioButton()
        {
            Size = new Size(150, 16);
            
        }

        /// <summary>
        /// Influences the on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void InfluenceOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            dynamic radioBtnRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(BackColor);

            switch (Checked)
            {
                case false:
                    LinearGradientBrush g1 = new LinearGradientBrush(radioBtnRectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90);
                    G.FillEllipse(g1, radioBtnRectangle);
                    G.DrawEllipse(new Pen(Color.FromArgb(80, 97, 94, 90)), new Rectangle(1, 1, Height - 3, Height - 3));
                    G.DrawEllipse(Pens.Black, radioBtnRectangle);
                    break;
                case true:
                    LinearGradientBrush g11 = new LinearGradientBrush(radioBtnRectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90);
                    G.FillEllipse(g11, radioBtnRectangle);
                    HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
                    G.FillEllipse(h1, radioBtnRectangle);
                    LinearGradientBrush s1 = new LinearGradientBrush(new Rectangle(0, 1, Height - 1, Height / 2 - 1), Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90);
                    G.FillEllipse(s1, s1.Rectangle);

                    G.FillEllipse(new SolidBrush(Color.FromArgb(15, 15, 15)), new Rectangle(4, 4, Height - 9, Height - 9));
                    G.FillEllipse(new SolidBrush(Color.FromArgb(250, 255, 255, 255)), new Rectangle(5, 5, Height - 11, Height - 11));

                    G.DrawEllipse(new Pen(Color.FromArgb(80, 97, 94, 90)), new Rectangle(1, 1, Height - 3, Height - 3));
                    G.DrawEllipse(Pens.Black, radioBtnRectangle);
                    break;
            }

            G.DrawString(Text, Font, Brushes.White, new Point(Height, (Height/2) - 6), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            
        }


    }

}

