namespace KeyboardAudio
{
    partial class VisualizeAudio
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
            this.LsAudioDevices = new System.Windows.Forms.ComboBox();
            this.ChEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TrAmp = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrAmp)).BeginInit();
            this.SuspendLayout();
            // 
            // LsAudioDevices
            // 
            this.LsAudioDevices.FormattingEnabled = true;
            this.LsAudioDevices.Location = new System.Drawing.Point(83, 50);
            this.LsAudioDevices.Name = "LsAudioDevices";
            this.LsAudioDevices.Size = new System.Drawing.Size(295, 24);
            this.LsAudioDevices.TabIndex = 0;
            // 
            // ChEnable
            // 
            this.ChEnable.AutoSize = true;
            this.ChEnable.Location = new System.Drawing.Point(13, 13);
            this.ChEnable.Name = "ChEnable";
            this.ChEnable.Size = new System.Drawing.Size(74, 21);
            this.ChEnable.TabIndex = 2;
            this.ChEnable.Text = "Enable";
            this.ChEnable.UseVisualStyleBackColor = true;
            this.ChEnable.CheckedChanged += new System.EventHandler(this.ChEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // TrAmp
            // 
            this.TrAmp.Location = new System.Drawing.Point(83, 153);
            this.TrAmp.Maximum = 64;
            this.TrAmp.Name = "TrAmp";
            this.TrAmp.Size = new System.Drawing.Size(450, 56);
            this.TrAmp.TabIndex = 6;
            // 
            // VisualizeAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 491);
            this.Controls.Add(this.TrAmp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChEnable);
            this.Controls.Add(this.LsAudioDevices);
            this.Name = "VisualizeAudio";
            this.Text = "VisualizeAudio";
            ((System.ComponentModel.ISupportInitialize)(this.TrAmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LsAudioDevices;
        private System.Windows.Forms.CheckBox ChEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar TrAmp;
    }
}