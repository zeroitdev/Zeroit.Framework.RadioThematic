// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Ambiance.cs" company="Zeroit Dev Technologies">
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


        #region Enums


        #endregion
        #region Variables


        #endregion
        #region Properties


        #endregion
        #region EventArgs



        /// <summary>
        /// Ambiances the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AmbianceOnResize(EventArgs e)
        {
            Height = 15;
        }


        #endregion

        /// <summary>
        /// Ambiances the RadioButton.
        /// </summary>
        private void Ambiance_RadioButton()
        {
            Width = 193;
        }

        /// <summary>
        /// Invalidates the controls.
        /// </summary>
        private void InvalidateControls()
        {
            if (!IsHandleCreated || !_checked)
                return;

            if (Parent == null)
                return;

            foreach (Control _Control in Parent.Controls)
            {
                if (!object.ReferenceEquals(_Control, this) && _Control is ZeroitRadioThematic)
                {
                    ((ZeroitRadioThematic)_Control).Checked = false;
                }
            }
        }

        /// <summary>
        /// Ambiances the on paint.
        /// </summary>
        private void AmbianceOnPaint()
        {
            
            
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;

            // Fill the body of the ellipse with a gradient
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 14)), Color.FromArgb(213, 85, 32), Color.FromArgb(224, 123, 82), 90);
            G.FillEllipse(LGB, new Rectangle(new Point(0, 0), new Size(14, 14)));

            GraphicsPath GP = new GraphicsPath();
            GP.AddEllipse(new Rectangle(0, 0, 14, 14));
            G.SetClip(GP);
            G.ResetClip();

            // Draw ellipse border
            G.DrawEllipse(new Pen(Color.FromArgb(182, 88, 55)), new Rectangle(new Point(0, 0), new Size(14, 14)));

            // Draw an ellipse inside the body
            if (Checked)
            {
                SolidBrush EllipseColor = new SolidBrush(Color.FromArgb(255, 255, 255));
                G.FillEllipse(EllipseColor, new Rectangle(new Point(4, 4), new Size(6, 6)));
            }
            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(76, 76, 95)), 16, 7, new StringFormat { LineAlignment = StringAlignment.Center });
            
        }

    }
}
