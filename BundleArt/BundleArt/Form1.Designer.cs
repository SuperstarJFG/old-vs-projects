
namespace BundleArt
{
    partial class BundleArt
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
            this.bundle = new System.Windows.Forms.PictureBox();
            this.pictureBoxBruh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bundle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBruh)).BeginInit();
            this.SuspendLayout();
            // 
            // bundle
            // 
            this.bundle.Image = global::BundleArt.Properties.Resources._2020_11_13_22_10_19;
            this.bundle.Location = new System.Drawing.Point(0, 0);
            this.bundle.Margin = new System.Windows.Forms.Padding(2);
            this.bundle.Name = "bundle";
            this.bundle.Size = new System.Drawing.Size(608, 664);
            this.bundle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bundle.TabIndex = 0;
            this.bundle.TabStop = false;
            // 
            // pictureBoxBruh
            // 
            this.pictureBoxBruh.Image = global::BundleArt.Properties.Resources.lime;
            this.pictureBoxBruh.Location = new System.Drawing.Point(16, 64);
            this.pictureBoxBruh.Name = "pictureBoxBruh";
            this.pictureBoxBruh.Size = new System.Drawing.Size(64, 63);
            this.pictureBoxBruh.TabIndex = 1;
            this.pictureBoxBruh.TabStop = false;
            // 
            // BundleArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 664);
            this.Controls.Add(this.pictureBoxBruh);
            this.Controls.Add(this.bundle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BundleArt";
            this.Text = "BundleArt";
            ((System.ComponentModel.ISupportInitialize)(this.bundle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBruh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bundle;
        private System.Windows.Forms.PictureBox pictureBoxBruh;
    }
}

