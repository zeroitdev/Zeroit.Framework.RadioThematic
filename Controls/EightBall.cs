// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="EightBall.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    public partial class ZeroitRadioThematic
    {


        /// <summary>
        /// Eights the ball RadioButton.
        /// </summary>
        private void EightBallRadioButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            Size = new Size(140, 20);
            
        }


        /// <summary>
        /// Eights the ball on paint.
        /// </summary>
        private void EightBallOnPaint()
        {
            G.SmoothingMode = Smoothing;
            G.Clear(Parent.BackColor);

            Rectangle circleRect = new Rectangle(0, 0, Height - 1, Height - 1);
            LinearGradientBrush bgBrush = new LinearGradientBrush(circleRect, Color.FromArgb(120, 120, 120), Color.FromArgb(100, 100, 100), 90f);
            G.FillEllipse(bgBrush, circleRect);
            G.DrawEllipse(new Pen(Color.FromArgb(50, 50, 50)), circleRect);

            int textY = ((this.Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2) + 1);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point((Height - 1) + 4, textY));

            if (Checked)
            {
                Rectangle checkedRect = new Rectangle(5, 5, Height - 11, Height - 11);
                LinearGradientBrush checkedBrush = new LinearGradientBrush(checkedRect, Color.LightGray, Color.Gray, 90f);
                G.FillEllipse(checkedBrush, checkedRect);
                G.DrawEllipse(new Pen(Color.FromArgb(70, 70, 70)), checkedRect);
            }

        }


    }

}

