﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="GhostV2.cs" company="Zeroit Dev Technologies">
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
        /// Ghosts the radiobutton.
        /// </summary>
        private void GhostRadiobutton()
        {
            this.Size = new Size(50, 14);
        }

        /// <summary>
        /// Ghosts the paint hook.
        /// </summary>
        private void GhostPaintHook()
        {
            G.Clear(Color.FromArgb(60, 60, 60));
            HatchBrush asdf = default(HatchBrush);
            asdf = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, Width, Height));
            asdf = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray);
            G.FillRectangle(asdf, 0, 0, Width, Height);
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, Width, Height);

            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.FillEllipse(new SolidBrush(Color.Black), 2, 2, 11, 11);
            G.DrawEllipse(Pens.Black, 0, 0, 13, 13);
            G.DrawEllipse(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 11, 11);

            if (Checked == false)
            {
                HatchBrush hatch = default(HatchBrush);
                hatch = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(20, Color.White), Color.FromArgb(0, Color.Gray));
                G.FillEllipse(hatch, 2, 2, 10, 10);
            }
            else
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(80, 80, 80)), 3, 3, 7, 7);
                HatchBrush hatch = default(HatchBrush);
                hatch = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(60, Color.Black), Color.FromArgb(0, Color.Gray));
                G.FillRectangle(hatch, 3, 3, 7, 7);
            }

            if (State == MouseState.Over & X < 13)
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 11, 11);
            }

            G.DrawString(Text, Font, Brushes.White, 18, 0);
        }

        

    }

}

