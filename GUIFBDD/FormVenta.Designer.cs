namespace GUIFBDD
{
    partial class FormVenta
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
            this.bCancelarV = new System.Windows.Forms.Button();
            this.bGuardarV = new System.Windows.Forms.Button();
            this.txtFechaV = new System.Windows.Forms.MaskedTextBox();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.txtImporteV = new System.Windows.Forms.TextBox();
            this.txtFolioV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelarV
            // 
            this.bCancelarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelarV.Location = new System.Drawing.Point(197, 168);
            this.bCancelarV.Name = "bCancelarV";
            this.bCancelarV.Size = new System.Drawing.Size(75, 23);
            this.bCancelarV.TabIndex = 19;
            this.bCancelarV.Text = "Cancelar";
            this.bCancelarV.UseVisualStyleBackColor = true;
            this.bCancelarV.Click += new System.EventHandler(this.bCancelarV_Click);
            // 
            // bGuardarV
            // 
            this.bGuardarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardarV.Location = new System.Drawing.Point(116, 168);
            this.bGuardarV.Name = "bGuardarV";
            this.bGuardarV.Size = new System.Drawing.Size(75, 23);
            this.bGuardarV.TabIndex = 18;
            this.bGuardarV.Text = "Guardar";
            this.bGuardarV.UseVisualStyleBackColor = true;
            this.bGuardarV.Click += new System.EventHandler(this.bGuardarV_Click);
            // 
            // txtFechaV
            // 
            this.txtFechaV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaV.Location = new System.Drawing.Point(15, 64);
            this.txtFechaV.Mask = "00/00/0000 00:00";
            this.txtFechaV.Name = "txtFechaV";
            this.txtFechaV.Size = new System.Drawing.Size(257, 20);
            this.txtFechaV.TabIndex = 17;
            this.txtFechaV.ValidatingType = typeof(System.DateTime);
            // 
            // txtIDC
            // 
            this.txtIDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDC.Location = new System.Drawing.Point(15, 142);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(257, 20);
            this.txtIDC.TabIndex = 16;
            // 
            // txtImporteV
            // 
            this.txtImporteV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteV.Location = new System.Drawing.Point(15, 103);
            this.txtImporteV.Name = "txtImporteV";
            this.txtImporteV.Size = new System.Drawing.Size(257, 20);
            this.txtImporteV.TabIndex = 15;
            // 
            // txtFolioV
            // 
            this.txtFolioV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolioV.Location = new System.Drawing.Point(15, 25);
            this.txtFolioV.Name = "txtFolioV";
            this.txtFolioV.Size = new System.Drawing.Size(257, 20);
            this.txtFolioV.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de Venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Importe de Venta";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folio Venta";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.bCancelarV);
            this.Controls.Add(this.bGuardarV);
            this.Controls.Add(this.txtFechaV);
            this.Controls.Add(this.txtIDC);
            this.Controls.Add(this.txtImporteV);
            this.Controls.Add(this.txtFolioV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenta";
            this.ShowIcon = false;
            this.Text = "Nueva Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarV;
        private System.Windows.Forms.Button bGuardarV;
        private System.Windows.Forms.MaskedTextBox txtFechaV;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.TextBox txtImporteV;
        private System.Windows.Forms.TextBox txtFolioV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}