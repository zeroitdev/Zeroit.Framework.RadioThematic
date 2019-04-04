// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {

        /// <summary>
        /// vs the radiobutton.
        /// </summary>
        private void VRadiobutton()
        {
            Size = new Size(50, 17);
        }


        /// <summary>
        /// vs the on click.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void VOnClick(System.EventArgs e)
        {
            foreach (Control C in Parent.Controls)
            {
                if (C.GetType().ToString() == String.Format(Application.ProductName, " ", "_") + ".VRadiobutton")
                {
                    ZeroitRadioThematic CC = null;
                    CC = (ZeroitRadioThematic)C;
                    CC.Checked = false;
                }
            }
            Checked = true;
        }


        /// <summary>
        /// vs the paint hook.
        /// </summary>
        private void VPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.AntiAlias;

            if (Checked == false)
            {
                G.FillEllipse(new SolidBrush(Color.Black), 0, 0, 16, 16);
                LinearGradientBrush Gbrush = new LinearGradientBrush(new Rectangle(1, 1, 14, 14), Color.FromArgb(24, 30, 36), Color.FromArgb(25, 25, 25), 90f);
                G.FillEllipse(Gbrush, new Rectangle(1, 1, 14, 14));
                Gbrush = new LinearGradientBrush(new Rectangle(2, 2, 12, 12), Color.FromArgb(12, 12, 12), Color.FromArgb(25, 25, 25), 90f);
                G.FillEllipse(Gbrush, new Rectangle(2, 2, 12, 12));
            }
            else
            {
                G.FillEllipse(new SolidBrush(Color.Black), 0, 0, 16, 16);
                LinearGradientBrush Gbrush = new LinearGradientBrush(new Rectangle(1, 1, 14, 14), Color.FromArgb(45, 45, 45), Color.FromArgb(10, 10, 10), 90f);
                G.FillEllipse(Gbrush, new Rectangle(1, 1, 14, 14));
                Gbrush = new LinearGradientBrush(new Rectangle(2, 2, 12, 12), Color.FromArgb(25, 25, 25), Color.FromArgb(20, 20, 20), 90f);
                G.FillEllipse(Gbrush, new Rectangle(2, 2, 12, 12));
                G.FillEllipse(Brushes.Black, new Rectangle(5, 6, 5, 5));
                LinearGradientBrush Gbrush2 = new LinearGradientBrush(new Rectangle(1, 1, 14, 14), Color.FromArgb(130, 130, 130), Color.FromArgb(20, 20, 20), LinearGradientMode.ForwardDiagonal);
                G.FillEllipse(Gbrush2, new Rectangle(3, 3, 10, 10));
            }
            G.DrawString(Text, Font, Brushes.White, 22, 2);
        }


    }

}

