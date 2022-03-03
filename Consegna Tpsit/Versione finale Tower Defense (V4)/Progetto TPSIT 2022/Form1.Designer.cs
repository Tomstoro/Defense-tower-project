
namespace Progetto_TPSIT_2022
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.bgw1 = new System.ComponentModel.BackgroundWorker();
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.bgw3 = new System.ComponentModel.BackgroundWorker();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.Prg3 = new System.Windows.Forms.ProgressBar();
            this.Prg2 = new System.Windows.Forms.ProgressBar();
            this.Prg1 = new System.Windows.Forms.ProgressBar();
            this.tbAttaccante = new System.Windows.Forms.TextBox();
            this.lbAttaccante = new System.Windows.Forms.Label();
            this.lbAttaccato = new System.Windows.Forms.Label();
            this.tbAttaccato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPause = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tbVincente = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.EffectPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectPb)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Start.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.play;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Location = new System.Drawing.Point(15, 622);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(147, 43);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Stop.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.STOP;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.Location = new System.Drawing.Point(853, 622);
            this.Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(147, 43);
            this.Stop.TabIndex = 1;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // bgw1
            // 
            this.bgw1.WorkerReportsProgress = true;
            this.bgw1.WorkerSupportsCancellation = true;
            this.bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // bgw2
            // 
            this.bgw2.WorkerReportsProgress = true;
            this.bgw2.WorkerSupportsCancellation = true;
            this.bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // bgw3
            // 
            this.bgw3.WorkerReportsProgress = true;
            this.bgw3.WorkerSupportsCancellation = true;
            this.bgw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.Transparent;
            this.PB1.Image = global::Progetto_TPSIT_2022.Properties.Resources.torre11;
            this.PB1.Location = new System.Drawing.Point(216, 370);
            this.PB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(135, 180);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 2;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Image = global::Progetto_TPSIT_2022.Properties.Resources.torre11;
            this.PB2.Location = new System.Drawing.Point(516, 190);
            this.PB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(117, 154);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB2.TabIndex = 3;
            this.PB2.TabStop = false;
            // 
            // PB3
            // 
            this.PB3.Image = global::Progetto_TPSIT_2022.Properties.Resources.torregg;
            this.PB3.Location = new System.Drawing.Point(797, 395);
            this.PB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(111, 126);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB3.TabIndex = 4;
            this.PB3.TabStop = false;
            // 
            // Prg3
            // 
            this.Prg3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Prg3.Location = new System.Drawing.Point(797, 526);
            this.Prg3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prg3.Maximum = 5;
            this.Prg3.Name = "Prg3";
            this.Prg3.Size = new System.Drawing.Size(111, 32);
            this.Prg3.TabIndex = 6;
            // 
            // Prg2
            // 
            this.Prg2.Location = new System.Drawing.Point(516, 348);
            this.Prg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prg2.Maximum = 5;
            this.Prg2.Name = "Prg2";
            this.Prg2.Size = new System.Drawing.Size(117, 32);
            this.Prg2.TabIndex = 7;
            // 
            // Prg1
            // 
            this.Prg1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prg1.Location = new System.Drawing.Point(216, 555);
            this.Prg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prg1.Maximum = 5;
            this.Prg1.Name = "Prg1";
            this.Prg1.Size = new System.Drawing.Size(135, 32);
            this.Prg1.TabIndex = 8;
            // 
            // tbAttaccante
            // 
            this.tbAttaccante.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbAttaccante.ForeColor = System.Drawing.Color.White;
            this.tbAttaccante.Location = new System.Drawing.Point(216, 640);
            this.tbAttaccante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttaccante.Name = "tbAttaccante";
            this.tbAttaccante.Size = new System.Drawing.Size(140, 22);
            this.tbAttaccante.TabIndex = 9;
            // 
            // lbAttaccante
            // 
            this.lbAttaccante.AutoSize = true;
            this.lbAttaccante.BackColor = System.Drawing.Color.Transparent;
            this.lbAttaccante.Location = new System.Drawing.Point(247, 622);
            this.lbAttaccante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAttaccante.Name = "lbAttaccante";
            this.lbAttaccante.Size = new System.Drawing.Size(75, 17);
            this.lbAttaccante.TabIndex = 10;
            this.lbAttaccante.Text = "Attaccante";
            // 
            // lbAttaccato
            // 
            this.lbAttaccato.AutoSize = true;
            this.lbAttaccato.BackColor = System.Drawing.Color.Transparent;
            this.lbAttaccato.Location = new System.Drawing.Point(699, 622);
            this.lbAttaccato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAttaccato.Name = "lbAttaccato";
            this.lbAttaccato.Size = new System.Drawing.Size(67, 17);
            this.lbAttaccato.TabIndex = 12;
            this.lbAttaccato.Text = "Attaccato";
            // 
            // tbAttaccato
            // 
            this.tbAttaccato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbAttaccato.ForeColor = System.Drawing.Color.White;
            this.tbAttaccato.Location = new System.Drawing.Point(668, 640);
            this.tbAttaccato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAttaccato.Name = "tbAttaccato";
            this.tbAttaccato.Size = new System.Drawing.Size(140, 22);
            this.tbAttaccato.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(545, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Torre 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(283, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Torre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(824, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Torre 3";
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPause.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.PAUSE;
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPause.Location = new System.Drawing.Point(440, 622);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(147, 43);
            this.BtnPause.TabIndex = 16;
            this.BtnPause.UseVisualStyleBackColor = false;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(657, 533);
            this.tb3.Margin = new System.Windows.Forms.Padding(4);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(132, 22);
            this.tb3.TabIndex = 17;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(76, 562);
            this.tb1.Margin = new System.Windows.Forms.Padding(4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(132, 22);
            this.tb1.TabIndex = 18;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(376, 356);
            this.tb2.Margin = new System.Windows.Forms.Padding(4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(132, 22);
            this.tb2.TabIndex = 19;
            // 
            // tbVincente
            // 
            this.tbVincente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbVincente.ForeColor = System.Drawing.Color.White;
            this.tbVincente.Location = new System.Drawing.Point(394, 14);
            this.tbVincente.Margin = new System.Windows.Forms.Padding(4);
            this.tbVincente.Name = "tbVincente";
            this.tbVincente.Size = new System.Drawing.Size(206, 22);
            this.tbVincente.TabIndex = 20;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRestart.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.RESTART;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Location = new System.Drawing.Point(15, 14);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(147, 43);
            this.btnRestart.TabIndex = 21;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // EffectPb
            // 
            this.EffectPb.BackColor = System.Drawing.Color.Transparent;
            this.EffectPb.Location = new System.Drawing.Point(440, 425);
            this.EffectPb.Name = "EffectPb";
            this.EffectPb.Size = new System.Drawing.Size(100, 114);
            this.EffectPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EffectPb.TabIndex = 22;
            this.EffectPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Progetto_TPSIT_2022.Properties.Resources.sfondo_bello1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 678);
            this.Controls.Add(this.EffectPb);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.tbVincente);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAttaccato);
            this.Controls.Add(this.tbAttaccato);
            this.Controls.Add(this.lbAttaccante);
            this.Controls.Add(this.tbAttaccante);
            this.Controls.Add(this.Prg1);
            this.Controls.Add(this.Prg2);
            this.Controls.Add(this.Prg3);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.ComponentModel.BackgroundWorker bgw1;
        private System.ComponentModel.BackgroundWorker bgw2;
        private System.ComponentModel.BackgroundWorker bgw3;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.ProgressBar Prg3;
        private System.Windows.Forms.ProgressBar Prg2;
        private System.Windows.Forms.ProgressBar Prg1;
        private System.Windows.Forms.TextBox tbAttaccante;
        private System.Windows.Forms.Label lbAttaccante;
        private System.Windows.Forms.Label lbAttaccato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tbVincente;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox tbAttaccato;
        private System.Windows.Forms.PictureBox EffectPb;
    }
}

