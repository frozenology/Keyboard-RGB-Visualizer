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
    public partial class VisualizeRainbow : Form, IVisualizer
    {
        public VisualizeRainbow()
        {
            InitializeComponent();
        }

        #region IVisualizer Members

        Visualizer Main;

        public bool Init(Visualizer Host)
        {
            Main = Host;
            return true;
        }

        byte red, grn, blu;

        public void Run()
        {           
            // Rainbow to key lights
            for (int x = 0; x < 91; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    this.red = (byte)(128.0f * (Math.Sin((x / 92.0f) * 2 * 3.14f) + 1));
                    this.grn = (byte)(128.5f * (Math.Sin(((x / 92.0f) * 2 * 3.14f) - (6.28f / 3)) + 1));
                    this.blu = (byte)(128.5f * (Math.Sin(((x / 92.0f) * 2 * 3.14f) + (6.28f / 3)) + 1));

                    //Main.Keyboard.SetLed(x % 92, y, red, grn, blu);
                }
            } 
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
