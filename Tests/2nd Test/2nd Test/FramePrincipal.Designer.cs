namespace _2nd_Test
{
    partial class FramePrincipal
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
            this.buttonPRÓXIMO = new System.Windows.Forms.Button();
            this.buttonVOLTAR = new System.Windows.Forms.Button();
            this.labelNOME = new System.Windows.Forms.Label();
            this.txtBoxNOME = new System.Windows.Forms.TextBox();
            this.listBoxNOME = new System.Windows.Forms.ListBox();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPRÓXIMO
            // 
            this.buttonPRÓXIMO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPRÓXIMO.Location = new System.Drawing.Point(318, 265);
            this.buttonPRÓXIMO.Name = "buttonPRÓXIMO";
            this.buttonPRÓXIMO.Size = new System.Drawing.Size(75, 23);
            this.buttonPRÓXIMO.TabIndex = 1;
            this.buttonPRÓXIMO.Text = "Próximo";
            this.buttonPRÓXIMO.UseVisualStyleBackColor = true;
            this.buttonPRÓXIMO.Click += new System.EventHandler(this.buttonPRÓXIMO_Click);
            // 
            // buttonVOLTAR
            // 
            this.buttonVOLTAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVOLTAR.Location = new System.Drawing.Point(237, 265);
            this.buttonVOLTAR.Name = "buttonVOLTAR";
            this.buttonVOLTAR.Size = new System.Drawing.Size(75, 23);
            this.buttonVOLTAR.TabIndex = 2;
            this.buttonVOLTAR.Text = "Voltar";
            this.buttonVOLTAR.UseVisualStyleBackColor = true;
            this.buttonVOLTAR.Click += new System.EventHandler(this.buttonVOLTAR_Click);
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(12, 9);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(35, 13);
            this.labelNOME.TabIndex = 3;
            this.labelNOME.Text = "Nome";
            // 
            // txtBoxNOME
            // 
            this.txtBoxNOME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNOME.Location = new System.Drawing.Point(72, 6);
            this.txtBoxNOME.Name = "txtBoxNOME";
            this.txtBoxNOME.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNOME.TabIndex = 8;
            this.txtBoxNOME.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNOME_Validating);
            // 
            // listBoxNOME
            // 
            this.listBoxNOME.FormattingEnabled = true;
            this.listBoxNOME.Location = new System.Drawing.Point(13, 54);
            this.listBoxNOME.Name = "listBoxNOME";
            this.listBoxNOME.Size = new System.Drawing.Size(159, 121);
            this.listBoxNOME.TabIndex = 13;
            this.listBoxNOME.DoubleClick += new System.EventHandler(this.listBoxNOME_DoubleClick);
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(178, 4);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 14;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // FramePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 300);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.listBoxNOME);
            this.Controls.Add(this.txtBoxNOME);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.buttonVOLTAR);
            this.Controls.Add(this.buttonPRÓXIMO);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.Name = "FramePrincipal";
            this.Text = "Project Major";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPRÓXIMO;
        private System.Windows.Forms.Button buttonVOLTAR;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.TextBox txtBoxNOME;
        private System.Windows.Forms.ListBox listBoxNOME;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}

