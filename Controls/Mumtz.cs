// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Mumtz.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

