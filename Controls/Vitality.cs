// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Vitality.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

