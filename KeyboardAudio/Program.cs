// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace KeybaordAudio
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;
    using KeyboardAudio;
    using Lomont;
    using OpenTK.Audio;
    using OpenTK.Audio.OpenAL;

    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// 
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var Visualizer = new Visualizer();
            
            Visualizer.Visible = true;
            
            while (!Application.AllowQuit)
            {
                Visualizer.DoEvents();
                Application.DoEvents();


            }

            
        }
    }
}

