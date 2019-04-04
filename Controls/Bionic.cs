// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Bionic.cs" company="Zeroit Dev Technologies">
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
        /// Bionics the on paint.
        /// </summary>
        private void BionicOnPaint()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);

            G.FillEllipse(new SolidBrush(Color.FromArgb(29, 29, 29)), new Rectangle(0, 0, 15, 15));
            switch (State)
            {
                case MouseState.Over:
                    G.FillEllipse(new SolidBrush(Color.FromArgb(5, Color.White)), new Rectangle(0, 0, 15, 15));
                    break;
            }
            if (Checked)
            {
                G.FillEllipse(new LinearGradientBrush(new Point(4, 4), new Point(4, 11), Color.FromArgb(252, 132, 19), Color.FromArgb(212, 75, 31)), new Rectangle(4, 4, 7, 7));
            }
            G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Point(18, 0));
        }


    }

}
