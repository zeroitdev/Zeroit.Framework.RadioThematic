// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

