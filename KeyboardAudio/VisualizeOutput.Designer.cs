namespace KeyboardAudio
{
    partial class VisualizeOutput
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
            this.PanelOutput = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelOutput
            // 
            this.PanelOutput.Location = new System.Drawing.Point(12, 12);
            this.PanelOutput.Name = "PanelOutput";
            this.PanelOutput.Size = new System.Drawing.Size(757, 311);
            this.PanelOutput.TabIndex = 0;
            // 
            // VisualizeOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 483);
            this.Controls.Add(this.PanelOutput);
            this.Name = "VisualizeOutput";
            this.Text = "VisualizeOutput";
            this.Load += new System.EventHandler(this.VisualizeOutput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOutput;
    }
}