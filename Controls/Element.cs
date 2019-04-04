// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Element.cs" company="Zeroit Dev Technologies">
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




        #region " Properties "


        /// <summary>
        /// The checked color
        /// </summary>
        private Color _CheckedColor = Color.FromArgb(231, 75, 60);
        /// <summary>
        /// Gets or sets the color of the checked.
        /// </summary>
        /// <value>The color of the checked.</value>
        public Color CheckedColor
        {
            get { return _CheckedColor; }
            set { _CheckedColor = value; }
        }


        #endregion

        #region " Events "


        /// <summary>
        /// Elements the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ElementOnResize(EventArgs e)
        {
            Height = 16;
        }
        #endregion

        #region " Mouse States "



        #endregion
        // Get more free themes at ThemesVB.NET
        /// <summary>
        /// Elements the on paint.
        /// </summary>
        private void ElementOnPaint()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);
            G.FillEllipse(Brushes.White, new Rectangle(1, 1, 16, 16));
            if (Checked)
            {
                G.FillEllipse(new SolidBrush(_CheckedColor), new Rectangle(3, 3, 12, 12));
            }
            G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Point(21, 1));
        }

    }

}

