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
            this.comboBoxLISTA = new System.Windows.Forms.ComboBox();
            this.labelLISTA = new System.Windows.Forms.Label();
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
            this.txtBoxNOME.Size = new System.Drawing.Size(321, 20);
            this.txtBoxNOME.TabIndex = 8;
            this.txtBoxNOME.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNOME_Validating);
            // 
            // comboBoxLISTA
            // 
            this.comboBoxLISTA.FormattingEnabled = true;
            this.comboBoxLISTA.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "abelardo",
            "bacia",
            "carro",
            "dedo",
            "elefante",
            "filho"});
            this.comboBoxLISTA.Location = new System.Drawing.Point(72, 48);
            this.comboBoxLISTA.Name = "comboBoxLISTA";
            this.comboBoxLISTA.Size = new System.Drawing.Size(321, 21);
            this.comboBoxLISTA.TabIndex = 16;
            // 
            // labelLISTA
            // 
            this.labelLISTA.AutoSize = true;
            this.labelLISTA.Location = new System.Drawing.Point(13, 55);
            this.labelLISTA.Name = "labelLISTA";
            this.labelLISTA.Size = new System.Drawing.Size(29, 13);
            this.labelLISTA.TabIndex = 17;
            this.labelLISTA.Text = "Lista";
            // 
            // FramePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 300);
            this.Controls.Add(this.labelLISTA);
            this.Controls.Add(this.comboBoxLISTA);
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
        private System.Windows.Forms.ComboBox comboBoxLISTA;
        private System.Windows.Forms.Label labelLISTA;
    }
}

