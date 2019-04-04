// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Mumtz.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {
        /// <summary>
        /// The text color
        /// </summary>
        Color TextColor = Color.Black;
        /// <summary>
        /// The circle color
        /// </summary>
        Color CircleColor = Color.MediumTurquoise;

        /// <summary>
        /// Mumtzs the radiobutton.
        /// </summary>
        private void MumtzRadiobutton()
        {
            this.Size = new Size(50, 14);
        }

        /// <summary>
        /// Mumtzs the paint hook.
        /// </summary>
        private void MumtzPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;
            if (Checked)
            {
                G.DrawEllipse(new Pen(CircleColor), new Rectangle(0, 0, 16, 16));
                G.FillEllipse(new SolidBrush(Color.MediumTurquoise), new Rectangle(4, 4, 8, 8));

            }
            else
            {
                G.DrawEllipse(new Pen(CircleColor), new Rectangle(0, 0, 16, 16));

            }
            G.DrawString(Text, Font, new SolidBrush(TextColor), new Point(22, 2));

        }

        

    }

}

