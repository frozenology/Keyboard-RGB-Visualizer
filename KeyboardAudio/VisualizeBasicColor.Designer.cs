namespace KeyboardAudio
{
    partial class VisualizeBasicColor
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
            this.PanelColor = new System.Windows.Forms.Panel();
            this.PanelSelectedColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelColor
            // 
            this.PanelColor.Location = new System.Drawing.Point(12, 12);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(512, 512);
            this.PanelColor.TabIndex = 0;
            this.PanelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelColor_Paint);
            this.PanelColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseMove);
            // 
            // PanelSelectedColor
            // 
            this.PanelSelectedColor.Location = new System.Drawing.Point(530, 12);
            this.PanelSelectedColor.Name = "PanelSelectedColor";
            this.PanelSelectedColor.Size = new System.Drawing.Size(135, 100);
            this.PanelSelectedColor.TabIndex = 1;
            // 
            // VisualizeBasicColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 536);
            this.Controls.Add(this.PanelSelectedColor);
            this.Controls.Add(this.PanelColor);
            this.Name = "VisualizeBasicColor";
            this.Text = "VisualizeSolidColor";
            this.Load += new System.EventHandler(this.VisualizeBasicColor_Load);
            this.Shown += new System.EventHandler(this.VisualizeBasicColor_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Panel PanelSelectedColor;
    }
}