// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

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
        /// The high colour
        /// </summary>
        private Color _HighColour = Color.FromArgb(125, 200, 255);
        /// <summary>
        /// The second border colour
        /// </summary>
        private Color _SecondBorderColour = Color.FromArgb(114, 207, 249);
        /// <summary>
        /// The checked colour
        /// </summary>
        private Color _CheckedColour = Color.FromArgb(103, 215, 243);
        /// <summary>
        /// The border colour
        /// </summary>
        private Color _BorderColour = Color.FromArgb(207, 211, 220);
        /// <summary>
        /// The back colour
        /// </summary>
        private Color _BackColour = Color.FromArgb(237, 239, 244);
        #endregion
        /// <summary>
        /// The text colour
        /// </summary>
        private Color _TextColour = Color.FromArgb(65, 73, 80);

        #region "Colour & Other Properties"

        /// <summary>
        /// Gets or sets the highlight colour.
        /// </summary>
        /// <value>The highlight colour.</value>
        [Category("Colours")]
        public Color HighlightColour
        {
            get { return _HighColour; }
            set { _HighColour = value; }
        }

        /// <summary>
        /// Gets or sets the base colour.
        /// </summary>
        /// <value>The base colour.</value>
        [Category("Colours")]
        public Color BaseColour
        {
            get { return _BackColour; }
            set { _BackColour = value; }
        }

        /// <summary>
        /// Gets or sets the border colour.
        /// </summary>
        /// <value>The border colour.</value>
        [Category("Colours")]
        public Color BorderColour
        {
            get { return _BorderColour; }
            set { _BorderColour = value; }
        }

        /// <summary>
        /// Gets or sets the checked colour.
        /// </summary>
        /// <value>The checked colour.</value>
        [Category("Colours")]
        public Color CheckedColour
        {
            get { return _CheckedColour; }
            set { _CheckedColour = value; }
        }

        /// <summary>
        /// Gets or sets the second circle colour.
        /// </summary>
        /// <value>The second circle colour.</value>
        [Category("Colours")]
        public Color SecondCircleColour
        {
            get { return _SecondBorderColour; }
            set { _SecondBorderColour = value; }
        }

        /// <summary>
        /// Gets or sets the font colour.
        /// </summary>
        /// <value>The font colour.</value>
        [Category("Colours")]
        public Color FontColour
        {
            get { return _TextColour; }
            set { _TextColour = value; }
        }


        /// <summary>
        /// Facebooks the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FacebookOnResize(EventArgs e)
        {
            Height = 22;
        }
        #endregion

        #region "Mouse States"


        #endregion

        #region "Draw Control"
        /// <summary>
        /// Facebooks the RadioButton.
        /// </summary>
        private void FacebookRadioButton()
        {
            Cursor = Cursors.Hand;
            Size = new Size(100, 22);
        }

        /// <summary>
        /// Facebooks the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void FacebookOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle Base = new Rectangle(1, 2, Height - 4, Height - 4);
            Rectangle Circle = new Rectangle(7, 8, Height - 16, Height - 16);
            Rectangle SecondBorder = new Rectangle(4, 5, 14, 14);

            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = Smoothing;
            G.PixelOffsetMode = PixelOffsetMode;
            G.Clear(BackColor);
            G.FillEllipse(new SolidBrush(_BackColour), Base);
            G.DrawEllipse(new Pen(_BorderColour), Base);
            switch (State)
            {
                case MouseState.Over:
                    G.DrawEllipse(new Pen(_HighColour), Base);
                    break;
                case MouseState.Down:
                    G.DrawEllipse(new Pen(_HighColour), Base);
                    break;
            }
            if (Checked)
            {
                G.FillEllipse(new SolidBrush(_CheckedColour), Circle);
                G.DrawEllipse(new Pen(_HighColour), Base);
                G.DrawEllipse(new Pen(_SecondBorderColour), SecondBorder);
            }
            G.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(24, 4, Width, Height), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });
            e.Graphics.InterpolationMode = InterpolationMode;
            e.Graphics.DrawImage(B, 0, 0);
            
        }
        #endregion

    }

}

