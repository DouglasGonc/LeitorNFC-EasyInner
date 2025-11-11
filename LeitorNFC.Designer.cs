namespace LeitorNFC_EasyInner
{
    partial class LeitorNFC
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
            this.rtbLog = new System.Windows.Forms.Label();
            this.btnConectar = new MaterialSkin.Controls.MaterialButton();
            this.txtPorta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIpLeitor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnIniciar = new MaterialSkin.Controls.MaterialButton();
            this.btnParar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.txtNumeroInner = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPortaNFC1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEnderecoIpNFC1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.logRichControle = new gao_controle_entrega_material.LogRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.AutoSize = true;
            this.rtbLog.BackColor = System.Drawing.Color.Transparent;
            this.rtbLog.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rtbLog.Location = new System.Drawing.Point(18, 225);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(84, 13);
            this.rtbLog.TabIndex = 55;
            this.rtbLog.Text = "Log de conexão";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConectar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConectar.Depth = 0;
            this.btnConectar.HighEmphasis = true;
            this.btnConectar.Icon = null;
            this.btnConectar.Location = new System.Drawing.Point(383, 213);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConectar.Size = new System.Drawing.Size(98, 36);
            this.btnConectar.TabIndex = 54;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConectar.UseAccentColor = false;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorta.AnimateReadOnly = false;
            this.txtPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorta.Depth = 0;
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPorta.LeadingIcon = null;
            this.txtPorta.Location = new System.Drawing.Point(381, 148);
            this.txtPorta.MaxLength = 50;
            this.txtPorta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPorta.Multiline = false;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 50);
            this.txtPorta.TabIndex = 53;
            this.txtPorta.Text = "3570";
            this.txtPorta.TrailingIcon = null;
            // 
            // txtIpLeitor
            // 
            this.txtIpLeitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIpLeitor.AnimateReadOnly = false;
            this.txtIpLeitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIpLeitor.Depth = 0;
            this.txtIpLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIpLeitor.LeadingIcon = null;
            this.txtIpLeitor.Location = new System.Drawing.Point(18, 148);
            this.txtIpLeitor.MaxLength = 50;
            this.txtIpLeitor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIpLeitor.Multiline = false;
            this.txtIpLeitor.Name = "txtIpLeitor";
            this.txtIpLeitor.Size = new System.Drawing.Size(251, 50);
            this.txtIpLeitor.TabIndex = 52;
            this.txtIpLeitor.Text = "192.168.6.231";
            this.txtIpLeitor.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 56;
            this.materialLabel2.Text = "Conectar Leitor NFC";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciar.Depth = 0;
            this.btnIniciar.HighEmphasis = true;
            this.btnIniciar.Icon = null;
            this.btnIniciar.Location = new System.Drawing.Point(332, 543);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciar.Size = new System.Drawing.Size(73, 36);
            this.btnIniciar.TabIndex = 58;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciar.UseAccentColor = false;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnParar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnParar.Depth = 0;
            this.btnParar.HighEmphasis = true;
            this.btnParar.Icon = null;
            this.btnParar.Location = new System.Drawing.Point(413, 543);
            this.btnParar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnParar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParar.Name = "btnParar";
            this.btnParar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnParar.Size = new System.Drawing.Size(68, 36);
            this.btnParar.TabIndex = 57;
            this.btnParar.Text = "Parar";
            this.btnParar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnParar.UseAccentColor = false;
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.HighEmphasis = true;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(249, 543);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(18, 277);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(463, 185);
            this.dgvLeituras.TabIndex = 60;
            // 
            // txtNumeroInner
            // 
            this.txtNumeroInner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroInner.AnimateReadOnly = false;
            this.txtNumeroInner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroInner.Depth = 0;
            this.txtNumeroInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumeroInner.LeadingIcon = null;
            this.txtNumeroInner.Location = new System.Drawing.Point(275, 148);
            this.txtNumeroInner.MaxLength = 50;
            this.txtNumeroInner.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroInner.Multiline = false;
            this.txtNumeroInner.Name = "txtNumeroInner";
            this.txtNumeroInner.Size = new System.Drawing.Size(100, 50);
            this.txtNumeroInner.TabIndex = 62;
            this.txtNumeroInner.Text = "1";
            this.txtNumeroInner.TrailingIcon = null;
            // 
            // lblPortaNFC1
            // 
            this.lblPortaNFC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortaNFC1.AutoSize = true;
            this.lblPortaNFC1.Depth = 0;
            this.lblPortaNFC1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPortaNFC1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblPortaNFC1.Location = new System.Drawing.Point(380, 119);
            this.lblPortaNFC1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPortaNFC1.Name = "lblPortaNFC1";
            this.lblPortaNFC1.Size = new System.Drawing.Size(31, 17);
            this.lblPortaNFC1.TabIndex = 64;
            this.lblPortaNFC1.Text = "Port:";
            // 
            // lblEnderecoIpNFC1
            // 
            this.lblEnderecoIpNFC1.AutoSize = true;
            this.lblEnderecoIpNFC1.Depth = 0;
            this.lblEnderecoIpNFC1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEnderecoIpNFC1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblEnderecoIpNFC1.Location = new System.Drawing.Point(15, 119);
            this.lblEnderecoIpNFC1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnderecoIpNFC1.Name = "lblEnderecoIpNFC1";
            this.lblEnderecoIpNFC1.Size = new System.Drawing.Size(131, 17);
            this.lblEnderecoIpNFC1.TabIndex = 63;
            this.lblEnderecoIpNFC1.Text = "Endereço IP do leitor:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.Location = new System.Drawing.Point(274, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 17);
            this.materialLabel1.TabIndex = 65;
            this.materialLabel1.Text = "N° do Inner:";
            // 
            // logRichControle
            // 
            this.logRichControle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logRichControle.Location = new System.Drawing.Point(18, 468);
            this.logRichControle.Name = "logRichControle";
            this.logRichControle.Size = new System.Drawing.Size(463, 66);
            this.logRichControle.TabIndex = 61;
            this.logRichControle.Text = "";
            // 
            // LeitorNFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblPortaNFC1);
            this.Controls.Add(this.lblEnderecoIpNFC1);
            this.Controls.Add(this.txtNumeroInner);
            this.Controls.Add(this.logRichControle);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIpLeitor);
            this.Name = "LeitorNFC";
            this.Padding = new System.Windows.Forms.Padding(15, 64, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor NFC - EasyInner";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rtbLog;
        private MaterialSkin.Controls.MaterialButton btnConectar;
        private MaterialSkin.Controls.MaterialTextBox txtPorta;
        private MaterialSkin.Controls.MaterialTextBox txtIpLeitor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialButton btnParar;
        private MaterialSkin.Controls.MaterialButton btnLimpar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private gao_controle_entrega_material.LogRichTextBox logRichControle;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroInner;
        private MaterialSkin.Controls.MaterialLabel lblPortaNFC1;
        private MaterialSkin.Controls.MaterialLabel lblEnderecoIpNFC1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

