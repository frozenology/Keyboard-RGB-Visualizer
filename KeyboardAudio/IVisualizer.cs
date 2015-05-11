using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAudio
{
    interface IVisualizer
    {
        bool Init(Visualizer Host);
        void Run();
        bool Done();

        void ShowSettings(Panel P);
    }
}
