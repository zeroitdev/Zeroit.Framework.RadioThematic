// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MonoFlat.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
