using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeybaordAudio;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

namespace KeyboardAudio
{
    public partial class Visualizer : Form
    {
        private List<IVisualizer> Visuals = new List<IVisualizer>();

        private Stopwatch Timer = new Stopwatch();
        private NotifyIcon TrayIcon;
        private bool Running = false;
        private long Update_Msec = 50;

        public KeyboardWriter Keyboard; 

        public Visualizer()
        {
            InitializeComponent();
        }

        private void VisualizeSetup_Load(object sender, EventArgs e)
        {
            TrayIcon = new NotifyIcon();

            TrayIcon.Click += TrayIcon_Click;
            TrayIcon.Icon = this.Icon;
            TrayIcon.Text = this.Text;

            var TrayIconMenu = new ContextMenu();

            TrayIcon.ContextMenu = TrayIconMenu;
            TrayIcon.Visible = true;


        }

        private void Visualizer_Add(IVisualizer Vis)
        {
            LsVisualizers.Items.Add(Vis, true);
        }

 

        private void VisualizeSetup_Shown(object sender, EventArgs e)
        {
            Timer.Start();

            Keyboard = new KeyboardWriter();

            Keyboard.InitKeyboard();

            Visualizer_Add(new VisualizeBasicColor());
            Visualizer_Add(new VisualizeRainbow());
            Visualizer_Add(new VisualizeAudio());
            Visualizer_Add(new VisualizeOutput());

            foreach (var vis in LsVisualizers.Items)
            {
                if (vis is IVisualizer)
                    ((IVisualizer)vis).Init(this);
            }

            LsVisualizers.SelectedIndex = 0;
                 

            Running = true;
        }

        public bool TimerPass(long Msec)
        {
            if (Timer.ElapsedMilliseconds >= Msec)
            {
                Console.WriteLine(Timer.ElapsedMilliseconds.ToString());
                Timer.Reset();
                Timer.Start();
                return true;
            }
            return false;
        }

        private void VisualizeSetup_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                Hide();

        }

        void TrayIcon_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void VisualizeSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


 
        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void DoEvents()
        {
            if (Running)
            {
                if (TimerPass(Update_Msec))
                {
                    foreach (var vis in LsVisualizers.Items)
                    {
                        if (vis is IVisualizer)
                            ((IVisualizer)vis).Run();
                    }

                    Keyboard.UpdateKeyboard();
                }
            }
        }

        private void LsVisualizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vis = LsVisualizers.SelectedItem;

            if (vis is IVisualizer)
                ((IVisualizer) vis).ShowSettings(PanelVisualizer);
        }

        public void ShowInPanel(Panel panel, Form F)
        {
            F.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(F);
            F.Dock = DockStyle.Fill;
            F.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            F.Visible = true;

        }
    }
}
