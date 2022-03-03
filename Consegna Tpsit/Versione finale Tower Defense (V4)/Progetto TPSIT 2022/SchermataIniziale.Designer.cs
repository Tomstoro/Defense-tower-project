
namespace Progetto_TPSIT_2022
{
    partial class SchermataIniziale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchermataIniziale));
            this.Inizio = new System.Windows.Forms.Button();
            this.TastoValuta = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TastoValuta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inizio
            // 
            this.Inizio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Inizio.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.start;
            this.Inizio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inizio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inizio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Inizio.Location = new System.Drawing.Point(12, 515);
            this.Inizio.Name = "Inizio";
            this.Inizio.Size = new System.Drawing.Size(335, 62);
            this.Inizio.TabIndex = 0;
            this.Inizio.UseVisualStyleBackColor = false;
            this.Inizio.Click += new System.EventHandler(this.Inizio_Click);
            // 
            // TastoValuta
            // 
            this.TastoValuta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TastoValuta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TastoValuta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.TastoValuta.Location = new System.Drawing.Point(0, 0);
            this.TastoValuta.Name = "TastoValuta";
            this.TastoValuta.Size = new System.Drawing.Size(359, 31);
            this.TastoValuta.TabIndex = 1;
            this.TastoValuta.Text = "toolStrip1";
            this.TastoValuta.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TastoValuta_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Info";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(251, 28);
            this.toolStripLabel1.Text = "Tower defense game by Tommaso P.";
            // 
            // SchermataIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.SfondoForm21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 589);
            this.Controls.Add(this.TastoValuta);
            this.Controls.Add(this.Inizio);
            this.Name = "SchermataIniziale";
            this.Text = "SchermataIniziale";
            this.TastoValuta.ResumeLayout(false);
            this.TastoValuta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inizio;
        private System.Windows.Forms.ToolStrip TastoValuta;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}