namespace KeyboardAudio
{
    partial class Visualizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LsVisualizers = new System.Windows.Forms.CheckedListBox();
            this.PanelVisualizer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LsVisualizers
            // 
            this.LsVisualizers.Location = new System.Drawing.Point(12, 12);
            this.LsVisualizers.Name = "LsVisualizers";
            this.LsVisualizers.Size = new System.Drawing.Size(155, 565);
            this.LsVisualizers.TabIndex = 0;
            this.LsVisualizers.SelectedIndexChanged += new System.EventHandler(this.LsVisualizers_SelectedIndexChanged);
            // 
            // PanelVisualizer
            // 
            this.PanelVisualizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVisualizer.Location = new System.Drawing.Point(173, 12);
            this.PanelVisualizer.Name = "PanelVisualizer";
            this.PanelVisualizer.Size = new System.Drawing.Size(708, 562);
            this.PanelVisualizer.TabIndex = 1;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 597);
            this.Controls.Add(this.PanelVisualizer);
            this.Controls.Add(this.LsVisualizers);
            this.Name = "Visualizer";
            this.Text = "VisualizeSetup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisualizeSetup_FormClosed);
            this.Load += new System.EventHandler(this.VisualizeSetup_Load);
            this.Shown += new System.EventHandler(this.VisualizeSetup_Shown);
            this.Resize += new System.EventHandler(this.VisualizeSetup_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox LsVisualizers;
        private System.Windows.Forms.Panel PanelVisualizer;

    }
}