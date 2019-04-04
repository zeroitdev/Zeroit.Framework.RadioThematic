// ***********************************************************************
// Assembly         : Zeroit.Framework.RadioThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.RadioThematic.ThemeManagers;

namespace Zeroit.Framework.RadioThematic.Controls
{

    /// <summary>
    /// Class ZeroitRadioThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.RadioThematic.ThemeManagers.ThemeControl" />
    [Designer(typeof(ZeroitRadioThematicDesigner))]
    public partial class ZeroitRadioThematic : ThemeControl
    {


        #region Private Fields

        /// <summary>
        /// The group box style
        /// </summary>
        private RadioStyles groupBoxStyle = RadioStyles.Ambiance;
        /// <summary>
        /// The state
        /// </summary>
        private MouseState State = MouseState.None;
        /// <summary>
        /// The x
        /// </summary>
        private int X;

        #endregion

        #region Public Properties

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.HighQuality;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.ClearTypeGridFit;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }


        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }



        #endregion

        /// <summary>
        /// Gets or sets the radio style.
        /// </summary>
        /// <value>The radio style.</value>
        public RadioStyles RadioStyle
        {
            get { return groupBoxStyle; }
            set {

                groupBoxStyle = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitRadioThematic"/> class.
        /// </summary>
        public ZeroitRadioThematic()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.ContainerControl, true);

            DoubleBuffered = true;

        }

        #endregion

        #region Overrides

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void PaintHook(PaintEventArgs e)
        {

            switch (RadioStyle)
            {
                case RadioStyles.Ambiance:
                    AmbianceOnPaint();
                    break;
                case RadioStyles.Bionic:
                    BionicOnPaint();
                    break;
                case RadioStyles.Carbon:
                    CarbonFibrePaintHook();
                    break;
                case RadioStyles.Deu:
                    DeumosPaintHook();
                    break;
                case RadioStyles.Eight:
                    EightBallOnPaint();
                    break;
                case RadioStyles.Element:
                    ElementOnPaint();
                    break;
                case RadioStyles.Evolve:
                    EvolvePaintHook();
                    break;
                case RadioStyles.Facebook:
                    FacebookOnPaint(e);
                    break;
                case RadioStyles.Ghost:
                    GhostPaintHook();
                    break;
                case RadioStyles.Influence:
                    InfluenceOnPaint(e);
                    break;
                case RadioStyles.Knight:
                    KnightOnPaint();
                    break;
                case RadioStyles.Login:
                    LoginOnPaint();
                    break;
                case RadioStyles.Monoflat:
                    MonoOnPaint();
                    break;
                case RadioStyles.Mumtz:
                    MumtzPaintHook();
                    break;
                case RadioStyles.NS:
                    NSOnPaint();
                    break;
                case RadioStyles.Orains:
                    OrainsPaintHook();
                    break;
                case RadioStyles.Perplex:
                    PerplexOnPaint(e);
                    break;
                case RadioStyles.Sharp:
                    SharpOnPaint(e);
                    break;
                case RadioStyles.V:
                    VPaintHook();
                    break;
                case RadioStyles.Vitality:
                    VitalityPaintHook();
                    break;
                case RadioStyles.xVisual:
                    xVisualOnPaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            switch (RadioStyle)
            {
                case RadioStyles.Ambiance:
                    //AmbianceOnResize(e);
                    break;
                case RadioStyles.Bionic:
                    break;
                case RadioStyles.Carbon:
                    break;
                case RadioStyles.Deu:
                    break;
                case RadioStyles.Eight:
                    break;
                case RadioStyles.Element:
                    break;
                case RadioStyles.Evolve:
                    break;
                case RadioStyles.Facebook:
                    break;
                case RadioStyles.Ghost:
                    break;
                case RadioStyles.Influence:
                    break;
                case RadioStyles.Knight:
                    break;
                case RadioStyles.Login:
                    break;
                case RadioStyles.Monoflat:
                    break;
                case RadioStyles.Mumtz:
                    break;
                case RadioStyles.NS:
                    break;
                case RadioStyles.Orains:
                    break;
                case RadioStyles.Perplex:
                    break;
                case RadioStyles.Sharp:
                    break;
                case RadioStyles.V:
                    break;
                case RadioStyles.Vitality:
                    break;
                case RadioStyles.xVisual:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            State = MouseState.Down;

            if (_checked)
            {
                _checked = false;
            }
            else
            {
                _checked = true;
            }

            if (checkedChanged != null)
            {
                checkedChanged(this, EventArgs.Empty);
            }

            Focus();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            State = MouseState.Over;

            Checked = !Checked;
            Focus();


            Invalidate();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnClick(System.EventArgs e)
        {
            _checked = !_checked;
            if (checkedChanged != null)
            {
                checkedChanged(this, EventArgs.Empty);
            }

            //foreach (Control C in Parent.Controls)
            //{
            //    if (C.GetType().ToString() == String.Format(Application.ProductName.ToString(), ".ZeroitRadioThematic"))
            //    {
            //        ZeroitRadioThematic CC = null;
            //        CC = (ZeroitRadioThematic)C;
            //        CC.Checked = false;
            //    }
            //}
            //Checked = true;

            foreach (Control C in Parent.Controls)
            {
                if (C.GetType().ToString() == "Zeroit.Framework.RadioThematic.Controls.ZeroitRadioThematic")
                {
                    ZeroitRadioThematic RDT = null;
                    RDT = (ZeroitRadioThematic)C;
                    RDT.Checked = false;
                }
            }

            
            base.OnClick(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseClick" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            
        }

        /// <summary>
        /// Raises the <see cref="M:System.Windows.Forms.Control.CreateControl" /> method.
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            InvalidateControls();
        }



        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            X = e.Location.X;
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {
            base.OnAnimation();

            
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            Width = TextRenderer.MeasureText(Text, Font).Width + 16;

            
            Invalidate();
        }

        /// <summary>
        /// The checked
        /// </summary>
        private bool _checked;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitRadioThematic"/> is checked.
        /// </summary>
        /// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (value)
                {
                    InvalidateControls();
                }

                _checked = value;
                Invalidate();
                this.CheckChanged(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Event Creation

        /////Implement this in the Property you want to trigger the event///////////////////////////
        // 
        //  For Example this will be triggered by the Value Property
        //
        //  public int Value
        //   { 
        //      get { return _value;}
        //      set
        //         {
        //          
        //              _value = value;
        //
        //              this.CheckChanged(EventArgs.Empty);
        //              Invalidate();
        //          }
        //    }
        //
        ////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// The checked changed
        /// </summary>
        private CheckedChangedEventHandler checkedChanged;

        /// <summary>
        /// Delegate CheckedChangedEventHandler
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public delegate void CheckedChangedEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Triggered when the Value changes
        /// </summary>

        public event CheckedChangedEventHandler CheckedChanged
        {
            add
            {
                this.checkedChanged = this.checkedChanged + value;
            }
            remove
            {
                this.checkedChanged = this.checkedChanged - value;
            }
        }

        /// <summary>
        /// Checks the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void CheckChanged(object sender, EventArgs e)
        {
            if (this.checkedChanged == null)
                return;
            this.checkedChanged((object)this, e);
        }


        #endregion

        #region Draw Borders
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="rect">The rect.</param>
        protected void DrawBorders(Pen p1, Pen p2, Rectangle rect)
        {
            G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
            G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3);
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, int offset)
        {
            DrawBorders(G, p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, Rectangle r, int offset)
        {
            DrawBorders(G, p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(G, p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Graphics G, Pen p1)
        {
            DrawBorders(G, p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Graphics G, Pen p1, Rectangle r)
        {
            DrawBorders(G, p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Graphics G, Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Pen.</returns>
        public Pen ToPen(Color color)
        {
            return new Pen(color);
        }

        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Brush.</returns>
        public Brush ToBrush(Color color)
        {
            return new SolidBrush(color);
        }

        #endregion
        
    }
}
