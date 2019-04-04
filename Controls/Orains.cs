// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
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
        /// The orains text color
        /// </summary>
        Color orainsTextColor = Color.Orange;
        /// <summary>
        /// The orains circle color
        /// </summary>
        Color orainsCircleColor = Color.Black;
        /// <summary>
        /// The circle inner
        /// </summary>
        Color CircleInner  = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// Orainses the RadioButton.
        /// </summary>
        private void OrainsRadioButton()
        {
            this.Size = new Size(50, 17);
            
        }

        /// <summary>
        /// Orainses the paint hook.
        /// </summary>
        private void OrainsPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;

            if (Checked)
            {
                G.DrawEllipse(new Pen(orainsCircleColor), new Rectangle(0, 0, 16, 16));
                G.DrawEllipse(new Pen(CircleInner), new Rectangle(1, 1, 14, 14));
                G.FillEllipse(new SolidBrush(Color.DarkOrange), new Rectangle(5, 5, 6, 6));

            }
            else
            {
                G.DrawEllipse(new Pen(orainsCircleColor), new Rectangle(0, 0, 16, 16));
                G.DrawEllipse(new Pen(CircleInner), new Rectangle(1, 1, 14, 14));
            }

            if (State == MouseState.Over)
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(20, Color.Orange)), 5, 5, 6, 6);
            }

            G.DrawString(Text, Font, new SolidBrush(orainsTextColor), new Point(22, 2));
        }

        
    }

}

