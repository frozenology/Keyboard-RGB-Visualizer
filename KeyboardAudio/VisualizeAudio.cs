using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lomont;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

namespace KeyboardAudio
{
    public partial class VisualizeAudio : Form, IVisualizer
    {
        public VisualizeAudio()
        {
            InitializeComponent();
        }

        public bool AudioMode = false;
        public AudioCapture AudioCapturer;



        #region IVisualizer Members

        Visualizer Main;
        LomontFFT fftTransoformer = new LomontFFT();
        byte[] audioBuffer = new byte[256];
        byte[] fftData = new byte[256];
        double[] fft = new double[256];
        double fftavg = 0;
        float amplitude = 10.0f;

        public bool Init(Visualizer Host)
        {
            this.Main = Host;

            LsAudioDevices.Items.Clear();
            foreach (string item in AudioCapture.AvailableDevices)
                LsAudioDevices.Items.Add(item);
            LsAudioDevices.SelectedIndex = 0;

            return true;
        }

        private void ChEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (ChEnable.Checked)
            {
                try
                {
                    

                    AudioCapturer = new AudioCapture(AudioCapture.AvailableDevices[LsAudioDevices.SelectedIndex], 8000, ALFormat.Mono8, 256);
                    AudioCapturer.Start();
                }
                catch
                {
                }
            }
            else
            {
                if (AudioCapturer != null)
                {
                    AudioCapturer.Stop();
                    AudioCapturer.Dispose();
                    AudioCapturer = null;
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        public void Run()
        {
            if (!ChEnable.Checked)
                return;

            if (AudioCapturer == null)
                return;


            //for (int j = 0; j < 92; j++)
            {
                // reset mem
                for (int i = 0; i < 256; i++)
                {
                    audioBuffer[i] = 0;
                    fftData[i] = 0;
                    fft[i] = 0;
                }

                AudioCapturer.ReadSamples(audioBuffer, 256);

                for (int i = 0; i < 256; i++)
                {
                    fft[i] = (audioBuffer[i] - 128) * amplitude;
                }

                fftTransoformer.TableFFT(fft, true);

                for (int i = 0; i < 256; i += 2)
                {
                    double fftmag = Math.Sqrt((fft[i] * fft[i]) + (fft[i + 1] * fft[i + 1]));
                    fftavg += fftmag;
                    fftData[i] = (byte)fftmag;
                    fftData[i + 1] = fftData[i];
                }

                //fftavg /= 10;

                Main.Keyboard.WriteAudio(fft);
            }
        }

        public bool Done()
        {
            return true;
        }

        #endregion


        public override string ToString()
        {
            return "Audio";
        }

        #region IVisualizer Members


        public void ShowSettings(Panel P)
        {
            Main.ShowInPanel(P, this);
        }

        #endregion

    }
}
