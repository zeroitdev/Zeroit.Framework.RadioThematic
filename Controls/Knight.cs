// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Knight.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {


        #region " Variables"
        #endregion

        #region " Properties"

        /// <summary>
        /// Knights the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void KnightOnResize(EventArgs e)
        {
            Height = 16;
        }

        #endregion

        /// <summary>
        /// Knights the on paint.
        /// </summary>
        private void KnightOnPaint()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);
            if (Parent.BackColor == Color.FromArgb(46, 49, 61))
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(37, 39, 48)), new Rectangle(0, 0, 15, 15));
            }
            else
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(24, 25, 31)), new Rectangle(0, 0, 15, 15));
            }
            if (Checked)
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(236, 73, 99)), new Rectangle(4, 4, 7, 7));
            }
            G.DrawString(Text, new Font("Segoe UI", 10), Brushes.White, new Point(18, -2));
        }


    }

}

