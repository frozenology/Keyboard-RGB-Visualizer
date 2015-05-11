using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAudio
{
    public partial class VisualizeBasicColor : Form, IVisualizer
    {
        private Visualizer Main;

        private Color SelectedColor = Color.FromArgb(0, 0, 0);
 
        public VisualizeBasicColor()
        {
            InitializeComponent();
        }


        private Bitmap ColorMap;

        private void VisualizeBasicColor_Shown(object sender, EventArgs e)
        {
            Rectangle Rect = PanelColor.ClientRectangle;
            ColorMap = new Bitmap(Rect.Width, Rect.Height);
            Graphics Gfx = Graphics.FromImage(ColorMap);

            Rectangle TopRect = new Rectangle(0, 0, Rect.Width, Rect.Height / 2);
            Rectangle BotRect = new Rectangle(0, Rect.Height / 2, Rect.Width, Rect.Height / 2);

            LinearGradientBrush ColorBrush = RainbowBrush(Rect);
            //LinearGradientBrush LightBrush = BrightnessBrush(Rect);
            LinearGradientBrush TopLightBrush = new LinearGradientBrush(new Point(0, TopRect.Top), new Point(0, TopRect.Bottom),
                Color.FromArgb(255, 255, 255, 255), Color.FromArgb(0, 128, 128, 128));
            LinearGradientBrush BotLightBrush = new LinearGradientBrush(new Point(0, BotRect.Top), new Point(0, BotRect.Bottom),
                Color.FromArgb(0, 255, 255, 255), Color.FromArgb(255, 0, 0, 0));

            Gfx.FillRectangle(ColorBrush, Rect);
            Gfx.FillRectangle(TopLightBrush, TopRect);
            Gfx.FillRectangle(BotLightBrush, BotRect);

            ColorBrush.Dispose();
            //LightBrush.Dispose();
        }

        private void PanelColor_Paint(object sender, PaintEventArgs e)
        {
            Control Cont = (Control)sender;
            Graphics Gfx = e.Graphics;

            Gfx.DrawImageUnscaled(ColorMap, new Point(0, 0));

            

        }

        LinearGradientBrush BrightnessBrush(Rectangle rect)
        {
            return new LinearGradientBrush(new Point(0, rect.Top), new Point(0, rect.Bottom),
                Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 0, 0, 0));
        }

        LinearGradientBrush RainbowBrush(Rectangle rect)
        {
            LinearGradientBrush rainbow_brush =
                new LinearGradientBrush(new Point(rect.Left, 0), new Point(rect.Right, 0),
                    Color.Red, Color.Red);

            // Define the colors along the gradient.
            ColorBlend color_blend = new ColorBlend();
            color_blend.Colors = new Color[] { 
                Color.Red, Color.Yellow, Color.Lime, Color.Aqua,
                Color.Blue, Color.Fuchsia, Color.Red };
            color_blend.Positions = new float[] { 0, 1 / 6f, 2 / 6f, 3 / 6f, 4 / 6f, 5 / 6f, 1 };
            rainbow_brush.InterpolationColors = color_blend;
            return rainbow_brush;
        }

        #region IVisualizer Members

        public bool Init(Visualizer Host)
        {
            Main = Host;
            return true;
        }

        public void Run()
        {
            Main.Keyboard.WriteColor(SelectedColor.R, SelectedColor.G, SelectedColor.B);
        }

        public bool Done()
        {
            return true;
        }

        #endregion

        #region IVisualizer Members


        public void ShowSettings(Panel panel)
        {
            Main.ShowInPanel(panel, this);
        }

        #endregion

        private void VisualizeBasicColor_Load(object sender, EventArgs e)
        {

        }

        private void PanelColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (((Control)sender).ClientRectangle.Contains(e.Location))
                    PanelSelectedColor.BackColor = SelectedColor = ColorMap.GetPixel(e.X, e.Y);

                
            }
        }

    }
}
