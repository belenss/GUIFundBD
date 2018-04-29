namespace GUIFBDD
{
    partial class FormDevC
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
            this.bCancelarDC = new System.Windows.Forms.Button();
            this.bGuardarDC = new System.Windows.Forms.Button();
            this.txtFechaDC = new System.Windows.Forms.MaskedTextBox();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.txtImporteDC = new System.Windows.Forms.TextBox();
            this.txtFolioDC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelarDC
            // 
            this.bCancelarDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelarDC.Location = new System.Drawing.Point(197, 168);
            this.bCancelarDC.Name = "bCancelarDC";
            this.bCancelarDC.Size = new System.Drawing.Size(75, 23);
            this.bCancelarDC.TabIndex = 29;
            this.bCancelarDC.Text = "Cancelar";
            this.bCancelarDC.UseVisualStyleBackColor = true;
            this.bCancelarDC.Click += new System.EventHandler(this.bCancelarDC_Click);
            // 
            // bGuardarDC
            // 
            this.bGuardarDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardarDC.Location = new System.Drawing.Point(116, 168);
            this.bGuardarDC.Name = "bGuardarDC";
            this.bGuardarDC.Size = new System.Drawing.Size(75, 23);
            this.bGuardarDC.TabIndex = 28;
            this.bGuardarDC.Text = "Guardar";
            this.bGuardarDC.UseVisualStyleBackColor = true;
            this.bGuardarDC.Click += new System.EventHandler(this.bGuardarDC_Click);
            // 
            // txtFechaDC
            // 
            this.txtFechaDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDC.Location = new System.Drawing.Point(15, 64);
            this.txtFechaDC.Mask = "00/00/0000 00:00";
            this.txtFechaDC.Name = "txtFechaDC";
            this.txtFechaDC.Size = new System.Drawing.Size(257, 20);
            this.txtFechaDC.TabIndex = 27;
            this.txtFechaDC.ValidatingType = typeof(System.DateTime);
            // 
            // txtIDC
            // 
            this.txtIDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDC.Location = new System.Drawing.Point(15, 142);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(257, 20);
            this.txtIDC.TabIndex = 26;
            // 
            // txtImporteDC
            // 
            this.txtImporteDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteDC.Location = new System.Drawing.Point(15, 103);
            this.txtImporteDC.Name = "txtImporteDC";
            this.txtImporteDC.Size = new System.Drawing.Size(257, 20);
            this.txtImporteDC.TabIndex = 25;
            // 
            // txtFolioDC
            // 
            this.txtFolioDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolioDC.Location = new System.Drawing.Point(15, 25);
            this.txtFolioDC.Name = "txtFolioDC";
            this.txtFolioDC.Size = new System.Drawing.Size(257, 20);
            this.txtFolioDC.TabIndex = 24;
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
            this.label4.TabIndex = 23;
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
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha de Devolución";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Importe de Devolución";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Folio Devolución";
            // 
            // FormDevC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.bCancelarDC);
            this.Controls.Add(this.bGuardarDC);
            this.Controls.Add(this.txtFechaDC);
            this.Controls.Add(this.txtIDC);
            this.Controls.Add(this.txtImporteDC);
            this.Controls.Add(this.txtFolioDC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevC";
            this.ShowIcon = false;
            this.Text = "Devolución de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarDC;
        private System.Windows.Forms.Button bGuardarDC;
        private System.Windows.Forms.MaskedTextBox txtFechaDC;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.TextBox txtImporteDC;
        private System.Windows.Forms.TextBox txtFolioDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}