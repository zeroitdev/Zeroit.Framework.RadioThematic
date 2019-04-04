// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.RadioThematic.ThemeManagers;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {

        /// <summary>
        /// Carbons the fibre paint hook.
        /// </summary>
        private void CarbonFibrePaintHook()
        {
            G.Clear(Color.FromArgb(22, 22, 22));
            G.SmoothingMode = Smoothing;

            if (State == MouseState.Over)
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(29, 29, 29)), new Rectangle(3, 3, 10, 10));
                G.DrawEllipse(new Pen(Color.FromArgb(22, 22, 22)), 5, 5, 6, 6);
            }

            if (Checked)
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(255, 150, 0)), 5, 5, 6, 6);
            }
            else
            {
            }

            G.DrawEllipse(new Pen(Color.FromArgb(6, 6, 6)), 0, 0, 16, 16);
            G.DrawEllipse(new Pen(Color.FromArgb(29, 29, 29)), 1, 1, 14, 14);
            G.DrawEllipse(new Pen(Color.FromArgb(6, 6, 6)), new Rectangle(2, 2, 12, 12));

            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(0, 0, 0)), 17, 0);
            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 150, 0)), 18, 1);
        }

        /// <summary>
        /// Carbons the fiber RadioButton.
        /// </summary>
        private void CarbonFiberRadioButton()
        {
            this.Size = new Size(50, 17);
            //MinimumSize = new Size(50, 17);
            //MaximumSize = new Size(600, 17);
        }

    }

}

