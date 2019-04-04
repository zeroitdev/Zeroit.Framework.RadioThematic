// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Evolve.cs" company="Zeroit Dev Technologies">
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
        /// Evolves the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void EvolveOnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            X = e.Location.X;
            
        }

        /// <summary>
        /// Evolves the paint hook.
        /// </summary>
        private void EvolvePaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.Clear(Parent.BackColor);
            if (Checked == false)
            {
                G.FillEllipse(new SolidBrush(Color.Black), 0, 0, 16, 16);
                LinearGradientBrush Gbrush = new LinearGradientBrush(new Rectangle(1, 1, 14, 14), Color.FromArgb(112, 112, 112), Color.FromArgb(25, 25, 25), 90f);
                G.FillEllipse(Gbrush, new Rectangle(1, 1, 14, 14));
                Gbrush = new LinearGradientBrush(new Rectangle(2, 2, 12, 12), Color.FromArgb(76, 76, 76), Color.FromArgb(25, 25, 25), 90f);
                G.FillEllipse(Gbrush, new Rectangle(2, 2, 12, 12));
            }
            else
            {
                G.FillEllipse(new SolidBrush(Color.Black), 0, 0, 16, 16);
                LinearGradientBrush Gbrush = new LinearGradientBrush(new Rectangle(1, 1, 14, 14), Color.FromArgb(181, 93, 93), Color.FromArgb(80, 10, 10), 90f);
                G.FillEllipse(Gbrush, new Rectangle(1, 1, 14, 14));
                Gbrush = new LinearGradientBrush(new Rectangle(2, 2, 12, 12), Color.FromArgb(160, 53, 53), Color.FromArgb(100, 13, 13), 90f);
                G.FillEllipse(Gbrush, new Rectangle(2, 2, 12, 12));
                G.FillEllipse(Brushes.Black, new Rectangle(5, 6, 5, 5));
                G.FillEllipse(Brushes.White, new Rectangle(5, 5, 5, 5));
            }

            G.DrawString(Text, Font, Brushes.Black, 18, 2);
            G.DrawString(Text, Font, Brushes.White, 18, 1);
        }

    }

}

