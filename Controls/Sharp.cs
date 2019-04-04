﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Sharp.cs" company="Zeroit Dev Technologies">
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
        /// Sharps the RadioButton.
        /// </summary>
        private void SharpRadioButton()
        {
            Size = new Size(150, 16);
            
        }
        /// <summary>
        /// Sharps the on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void SharpOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.HighQuality;
            
            G.Clear(Parent.BackColor);


            if (Checked == false)
            {
                LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(3, 3, 12, 11), Color.FromArgb(37, 47, 57), Color.FromArgb(62, 68, 74), 90);
                G.FillEllipse(BTNLGBOver, new Rectangle(3, 3, 12, 11));
                G.DrawEllipse(new Pen(Color.FromArgb(0, 0, 0)), 2, 2, 14, 13);

            }
            else
            {
                LinearGradientBrush CKelGrd = new LinearGradientBrush(new Rectangle(3, 3, 12, 11), Color.FromArgb(65, 71, 77), Color.FromArgb(0, 0, 0), 90);
                G.FillEllipse(CKelGrd, new Rectangle(3, 3, 12, 11));
                G.DrawEllipse(new Pen(Color.FromArgb(13, 23, 33)), 2, 2, 14, 13);
            }



            G.DrawEllipse(new Pen(Color.FromArgb(93, 103, 113)), 1, 1, 15, 14);

            G.DrawEllipse(new Pen(Color.FromArgb(113, 123, 133)), 3, 3, 11, 10);
            Brush txtbrush = new SolidBrush(Color.FromArgb(210, 220, 230));
            G.DrawString(Text, Font, txtbrush, new Point(18, 2), new StringFormat
            {
                LineAlignment = StringAlignment.Near,
                Alignment = StringAlignment.Near
            });


            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            

        }


    }

}

