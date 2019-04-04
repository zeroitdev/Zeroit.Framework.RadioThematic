// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MonoFlat.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {


        #region  Variables


        #endregion
        #region  Properties



        #endregion
        #region  EventArgs








        /// <summary>
        /// Monoes the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MonoOnResize(EventArgs e)
        {
            this.Height = 17;
        }

        #endregion

        /// <summary>
        /// Monoes the flat RadioButton.
        /// </summary>
        private void MonoFlat_RadioButton()
        {
            Width = 159;
            Height = 17;
            DoubleBuffered = true;
        }

        /// <summary>
        /// Monoes the invalidate controls.
        /// </summary>
        private void MonoInvalidateControls()
        {
            if (!IsHandleCreated || !Checked)
            {
                return;
            }

            foreach (Control _Control in Parent.Controls)
            {
                if (_Control != this && _Control is ZeroitRadioThematic)
                {
                    ((ZeroitRadioThematic)_Control).Checked = false;
                }
            }
        }

        /// <summary>
        /// Monoes the on paint.
        /// </summary>
        private void MonoOnPaint()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;

            G.FillEllipse(new SolidBrush(Color.FromArgb(66, 76, 85)), new Rectangle(0, 0, 16, 16));

            if (Checked)
            {
                G.DrawString("a", new Font("Marlett", 15), new SolidBrush(Color.FromArgb(181, 41, 42)), new Point(-3, -2));
            }

            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(116, 125, 132)), new Point(20, 0));
        }

    }
}
