// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NS.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {

        /// <summary>
        /// The ns p1
        /// </summary>
        Color nsP1 = Color.FromArgb(55, 55, 55);
        /// <summary>
        /// The ns p2
        /// </summary>
        Color nsP2 = Color.FromArgb(24, 24, 24);

        /// <summary>
        /// The p b1
        /// </summary>
        private PathGradientBrush PB1;
        /// <summary>
        /// Nses the on paint.
        /// </summary>
        private void NSOnPaint()
        {
            G.TextRenderingHint = TextRendering;

            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath GP1 = new GraphicsPath();
            GP1.AddEllipse(0, 2, Height - 5, Height - 5);

            PB1 = new PathGradientBrush(GP1);
            PB1.CenterColor = Color.FromArgb(50, 50, 50);
            PB1.SurroundColors = new Color[] { Color.FromArgb(45, 45, 45) };
            PB1.FocusScales = new PointF(0.3f, 0.3f);

            G.FillPath(PB1, GP1);

            G.DrawEllipse(new Pen(nsP1), 0, 2, Height - 5, Height - 5);
            G.DrawEllipse(new Pen(nsP2), 1, 3, Height - 7, Height - 7);

            if (Checked)
            {
                G.FillEllipse(Brushes.Black, 6, 8, Height - 15, Height - 15);
                G.FillEllipse(Brushes.WhiteSmoke, 5, 7, Height - 15, Height - 15);
            }

            SizeF SZ1 = G.MeasureString(Text, Font);
            PointF PT1 = new PointF(Height - 3, Height / 2 - SZ1.Height / 2);

            G.DrawString(Text, Font, Brushes.Black, PT1.X + 1, PT1.Y + 1);
            G.DrawString(Text, Font, Brushes.WhiteSmoke, PT1);
        }


    }

}

