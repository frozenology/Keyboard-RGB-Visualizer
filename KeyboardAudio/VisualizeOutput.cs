using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAudio
{
    public partial class VisualizeOutput : Form, IVisualizer
    {
        public VisualizeOutput()
        {
            InitializeComponent();
        }

        private void VisualizeOutput_Load(object sender, EventArgs e)
        {

        }

        #region IVisualizer Members

        private Visualizer Main;

        public bool Init(Visualizer Host)
        {
            Main = Host;
            return true;
        }

        public void Run()
        {
            Graphics Gfx = PanelOutput.CreateGraphics();

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 92; x++)
                {
                    Brush B = new SolidBrush(Main.Keyboard.GetLed(x, y));
                    Gfx.FillRectangle(B, new Rectangle(x * 15, y * 30, 15, 30));
                    B.Dispose();
                }

            }

            Gfx.Dispose();
        }

        public bool Done()
        {
            return true;
        }

        public void ShowSettings(Panel P)
        {
            Main.ShowInPanel(P, this);
        }

        #endregion
    }
}
