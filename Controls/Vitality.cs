// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Vitality.cs" company="Zeroit Dev Technologies">
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
        /// The bg
        /// </summary>
        Color BG = Color.FromArgb(240, 240, 240);


        /// <summary>
        /// Vitalities the radiobutton.
        /// </summary>
        private void VitalityRadiobutton()
        {
            LockHeight = 22;
            Width = 140;
            
        }

        /// <summary>
        /// Vitalities the paint hook.
        /// </summary>
        private void VitalityPaintHook()
        {
            G.Clear(Parent.BackColor);

            G.SmoothingMode = SmoothingMode.HighQuality;

            if (Checked)
                G.FillEllipse(Brushes.Gray, new Rectangle(new Point(7, 7), new Size(8, 8)));

            if (State == MouseState.Over)
            {
                G.FillEllipse(Brushes.White, new Rectangle(new Point(4, 4), new Size(14, 14)));
                if (Checked)
                    G.FillEllipse(Brushes.Gray, new Rectangle(new Point(7, 7), new Size(8, 8)));
            }

            G.DrawEllipse(Pens.White, new Rectangle(new Point(3, 3), new Size(16, 16)));
            G.DrawEllipse(Pens.LightGray, new Rectangle(new Point(2, 2), new Size(18, 18)));
            G.DrawEllipse(Pens.LightGray, new Rectangle(new Point(4, 4), new Size(14, 14)));

            G.DrawString(Text, new Font("Segoe UI", 9), Brushes.Gray, 23, 3);
        }

    }

}

