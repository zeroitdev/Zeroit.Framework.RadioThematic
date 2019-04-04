// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Login.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Radio button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
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


        #region "Declarations"
        /// <summary>
        /// The hover colour
        /// </summary>
        private Color _HoverColour = Color.FromArgb(50, 49, 51);
        /// <summary>
        /// The login checked color
        /// </summary>
        private Color loginCheckedColor = Color.FromArgb(173, 173, 174);
        /// <summary>
        /// The login border color
        /// </summary>
        private Color loginBorderColor = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The login back color
        /// </summary>
        private Color loginBackColor = Color.FromArgb(54, 54, 54);
        #endregion
        /// <summary>
        /// The login text color
        /// </summary>
        private Color loginTextColor = Color.FromArgb(255, 255, 255);

        #region "Colour & Other Properties"

        /// <summary>
        /// Gets or sets the color of the login highlight.
        /// </summary>
        /// <value>The color of the login highlight.</value>
        [Category("Colours")]
        public Color LoginHighlightColor
        {
            get { return _HoverColour; }
            set { _HoverColour = value; }
        }

        /// <summary>
        /// Gets or sets the color of the login base.
        /// </summary>
        /// <value>The color of the login base.</value>
        [Category("Colours")]
        public Color LoginBaseColor
        {
            get { return loginBackColor; }
            set { loginBackColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the login border.
        /// </summary>
        /// <value>The color of the login border.</value>
        [Category("Colours")]
        public Color LoginBorderColor
        {
            get { return loginBorderColor; }
            set { loginBorderColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the login checked.
        /// </summary>
        /// <value>The color of the login checked.</value>
        [Category("Colours")]
        public Color LoginCheckedColor
        {
            get { return loginCheckedColor; }
            set { loginCheckedColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the login font.
        /// </summary>
        /// <value>The color of the login font.</value>
        [Category("Colours")]
        public Color LoginFontColor
        {
            get { return loginTextColor; }
            set { loginTextColor = value; }
        }


        /// <summary>
        /// Logins the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LoginOnResize(EventArgs e)
        {
            Height = 22;
        }
        #endregion

        #region "Mouse States"


        #endregion

        #region "Draw Control"
        /// <summary>
        /// Logs the in RadioButton.
        /// </summary>
        private void LogInRadioButton()
        {
            Size = new Size(100, 22);
        }

        /// <summary>
        /// Logins the on paint.
        /// </summary>
        private void LoginOnPaint()
        {
            Rectangle Base = new Rectangle(1, 1, Height - 2, Height - 2);
            Rectangle Circle = new Rectangle(6, 6, Height - 12, Height - 12);
            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = Smoothing;
            G.PixelOffsetMode = PixelOffsetMode;
            G.Clear(Parent.BackColor);
            G.FillEllipse(new SolidBrush(loginBackColor), Base);
            G.DrawEllipse(new Pen(loginBorderColor, 2), Base);
            if (Checked)
            {
                switch (State)
                {
                    case MouseState.Over:
                        G.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(2, 2, Height - 4, Height - 4));
                        break;
                }
                G.FillEllipse(new SolidBrush(loginCheckedColor), Circle);
            }
            else
            {
                switch (State)
                {
                    case MouseState.Over:
                        G.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(2, 2, Height - 4, Height - 4));
                        break;
                }
            }
            //G.DrawString(Text, Font, new SolidBrush(loginTextColor), new Rectangle(24, 3, Width, Height), new StringFormat
            //{
            //    Alignment = StringAlignment.Near,
            //    LineAlignment = StringAlignment.Near
            //});

            G.DrawString(Text, Font, Brushes.White, new Point(Height, (Height / 2) - 6), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            G.InterpolationMode = InterpolationMode;
        }
        #endregion


    }

}

