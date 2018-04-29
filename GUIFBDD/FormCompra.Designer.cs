namespace GUIFBDD
{
    partial class FormCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolioC = new System.Windows.Forms.TextBox();
            this.txtImporteC = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtFechaC = new System.Windows.Forms.MaskedTextBox();
            this.bGuardarCr = new System.Windows.Forms.Button();
            this.bCancelarCr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio Compra";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Importe de Compra";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Compra";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Proveedor";
            // 
            // txtFolioC
            // 
            this.txtFolioC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolioC.Location = new System.Drawing.Point(15, 25);
            this.txtFolioC.Name = "txtFolioC";
            this.txtFolioC.Size = new System.Drawing.Size(257, 20);
            this.txtFolioC.TabIndex = 4;
            // 
            // txtImporteC
            // 
            this.txtImporteC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteC.Location = new System.Drawing.Point(15, 103);
            this.txtImporteC.Name = "txtImporteC";
            this.txtImporteC.Size = new System.Drawing.Size(257, 20);
            this.txtImporteC.TabIndex = 5;
            // 
            // txtIDP
            // 
            this.txtIDP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDP.Location = new System.Drawing.Point(15, 142);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(257, 20);
            this.txtIDP.TabIndex = 6;
            // 
            // txtFechaC
            // 
            this.txtFechaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaC.Location = new System.Drawing.Point(15, 64);
            this.txtFechaC.Mask = "00/00/0000 00:00";
            this.txtFechaC.Name = "txtFechaC";
            this.txtFechaC.Size = new System.Drawing.Size(257, 20);
            this.txtFechaC.TabIndex = 7;
            this.txtFechaC.ValidatingType = typeof(System.DateTime);
            // 
            // bGuardarCr
            // 
            this.bGuardarCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardarCr.Location = new System.Drawing.Point(116, 168);
            this.bGuardarCr.Name = "bGuardarCr";
            this.bGuardarCr.Size = new System.Drawing.Size(75, 23);
            this.bGuardarCr.TabIndex = 8;
            this.bGuardarCr.Text = "Guardar";
            this.bGuardarCr.UseVisualStyleBackColor = true;
            this.bGuardarCr.Click += new System.EventHandler(this.bGuardarCr_Click);
            // 
            // bCancelarCr
            // 
            this.bCancelarCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelarCr.Location = new System.Drawing.Point(197, 168);
            this.bCancelarCr.Name = "bCancelarCr";
            this.bCancelarCr.Size = new System.Drawing.Size(75, 23);
            this.bCancelarCr.TabIndex = 9;
            this.bCancelarCr.Text = "Cancelar";
            this.bCancelarCr.UseVisualStyleBackColor = true;
            this.bCancelarCr.Click += new System.EventHandler(this.bCancelarCr_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.bCancelarCr);
            this.Controls.Add(this.bGuardarCr);
            this.Controls.Add(this.txtFechaC);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.txtImporteC);
            this.Controls.Add(this.txtFolioC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompra";
            this.ShowIcon = false;
            this.Text = "Nueva Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioC;
        private System.Windows.Forms.TextBox txtImporteC;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.MaskedTextBox txtFechaC;
        private System.Windows.Forms.Button bGuardarCr;
        private System.Windows.Forms.Button bCancelarCr;
    }
}