
namespace Progetto_TPSIT_2022
{
    partial class Menù
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
            this.resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.resume.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.RESUME;
            this.resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resume.Location = new System.Drawing.Point(-5, -6);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(211, 76);
            this.resume.TabIndex = 0;
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // Menù
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 59);
            this.Controls.Add(this.resume);
            this.Name = "Menù";
            this.Text = "Menù";
            this.Load += new System.EventHandler(this.Menù_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resume;
    }
}