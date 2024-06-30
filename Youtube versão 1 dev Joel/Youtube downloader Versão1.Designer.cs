namespace Youtube_versão_1_dev_Joel
{
    partial class frYoutube
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frYoutube));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.rdMp3 = new System.Windows.Forms.RadioButton();
            this.rdMp4 = new System.Windows.Forms.RadioButton();
            this.CmbQualidade = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(12, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(713, 36);
            this.txtUrl.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(732, 12);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(120, 36);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // rdMp3
            // 
            this.rdMp3.AutoSize = true;
            this.rdMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp3.Location = new System.Drawing.Point(13, 64);
            this.rdMp3.Name = "rdMp3";
            this.rdMp3.Size = new System.Drawing.Size(149, 29);
            this.rdMp3.TabIndex = 2;
            this.rdMp3.TabStop = true;
            this.rdMp3.Text = "Formato Mp3";
            this.rdMp3.UseVisualStyleBackColor = true;
            // 
            // rdMp4
            // 
            this.rdMp4.AutoSize = true;
            this.rdMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp4.Location = new System.Drawing.Point(182, 64);
            this.rdMp4.Name = "rdMp4";
            this.rdMp4.Size = new System.Drawing.Size(149, 29);
            this.rdMp4.TabIndex = 3;
            this.rdMp4.TabStop = true;
            this.rdMp4.Text = "Formato Mp4";
            this.rdMp4.UseVisualStyleBackColor = true;
            // 
            // CmbQualidade
            // 
            this.CmbQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbQualidade.FormattingEnabled = true;
            this.CmbQualidade.Location = new System.Drawing.Point(355, 60);
            this.CmbQualidade.Name = "CmbQualidade";
            this.CmbQualidade.Size = new System.Drawing.Size(194, 33);
            this.CmbQualidade.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(12, 116);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(101, 36);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(120, 116);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(105, 36);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(232, 116);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 36);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(12, 169);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(840, 32);
            this.Avanco.TabIndex = 8;
            // 
            // frYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 215);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.CmbQualidade);
            this.Controls.Add(this.rdMp4);
            this.Controls.Add(this.rdMp3);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frYoutube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Versão 1 © Dev Joel Portugal ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.RadioButton rdMp3;
        private System.Windows.Forms.RadioButton rdMp4;
        private System.Windows.Forms.ComboBox CmbQualidade;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ProgressBar Avanco;
    }
}

