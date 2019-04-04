// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Deumos.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

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
        /// Deumoses the RadioButton.
        /// </summary>
        private void DeumosRadioButton()
        {
            LockHeight = 16;

            
        }



        /// <summary>
        /// The deumos c1
        /// </summary>
        private Color deumosC1 = Color.FromArgb(38, Color.White);
        /// <summary>
        /// The deumos c2
        /// </summary>
        private Color deumosC2 = Color.FromArgb(5, Color.White);
        /// <summary>
        /// The deumos c3
        /// </summary>
        private Color deumosC3 = Color.Transparent;
        /// <summary>
        /// The deumos c4
        /// </summary>
        private Color deumosC4 = Color.FromArgb(40, Color.White);
        /// <summary>
        /// The deumos c5
        /// </summary>
        private Color deumosC5 = Color.FromArgb(8, 8, 8);
        /// <summary>
        /// The deumos c6
        /// </summary>
        private Color deumosC6 = Color.FromArgb(16,16,16);
        /// <summary>
        /// The deumos p1
        /// </summary>
        private Color deumosP1 = Color.FromArgb(255, Color.Black);
        /// <summary>
        /// The deumos p2
        /// </summary>
        private Color deumosP2 = Color.FromArgb(15, Color.White);
        /// <summary>
        /// The deumos b1
        /// </summary>
        private Color deumosB1 = Color.FromArgb(5, Color.White);
        /// <summary>
        /// The deumos b2
        /// </summary>
        private Color deumosB2 = Color.FromArgb(255, Color.White);

        /// <summary>
        /// Deumoses the paint hook.
        /// </summary>
        private void DeumosPaintHook()
        {
            G.Clear(Parent.BackColor);

            G.SmoothingMode = Smoothing;
            Rectangle R1 = new Rectangle(4, 2, _Field - 8, (_Field / 2) - 1);
            Rectangle R2 = new Rectangle(4, 2, _Field - 8, (_Field / 2));

            LinearGradientBrush G1 = new LinearGradientBrush(R2, deumosC1, deumosC2, 90);
            G.FillEllipse(G1, R1);

            R1 = new Rectangle(2, 2, _Field - 4, _Field - 4);

            if (Checked)
            {
                G1 = new LinearGradientBrush(R1, deumosC3, deumosC4, 90);
            }
            else
            {
                G1 = new LinearGradientBrush(R1, deumosC5, deumosC6, 90);
            }
            G.FillEllipse(G1, R1);

            if (State == MouseState.Over)
            {
                R1 = new Rectangle(2, 2, _Field - 4, _Field - 4);
                G.FillEllipse(new SolidBrush(deumosB1), R1);
            }

            DrawText(new SolidBrush(deumosB2), HorizontalAlignment.Left, _Field + 3, 0);

            G.DrawEllipse(new Pen(deumosP1), 2, 2, _Field - 4, _Field - 4);
            G.DrawEllipse(new Pen(deumosP2), 1, 1, _Field - 2, _Field - 2);

        }

        /// <summary>
        /// The field
        /// </summary>
        private int _Field = 16;
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        public int Field
        {
            get { return _Field; }
            set
            {
                if (value < 4)
                    return;
                _Field = value;
                LockHeight = value;
                Invalidate();
            }
        }

    }

}

