namespace GUIFBDD
{
    partial class FormDevP
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
            this.bCancelarDP = new System.Windows.Forms.Button();
            this.bGuardarDP = new System.Windows.Forms.Button();
            this.txtFechaDP = new System.Windows.Forms.MaskedTextBox();
            this.txtIDR = new System.Windows.Forms.TextBox();
            this.txtImporteDP = new System.Windows.Forms.TextBox();
            this.txtFolioDP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelarDP
            // 
            this.bCancelarDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelarDP.Location = new System.Drawing.Point(197, 168);
            this.bCancelarDP.Name = "bCancelarDP";
            this.bCancelarDP.Size = new System.Drawing.Size(75, 23);
            this.bCancelarDP.TabIndex = 39;
            this.bCancelarDP.Text = "Cancelar";
            this.bCancelarDP.UseVisualStyleBackColor = true;
            this.bCancelarDP.Click += new System.EventHandler(this.bCancelarDP_Click);
            // 
            // bGuardarDP
            // 
            this.bGuardarDP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardarDP.Location = new System.Drawing.Point(116, 168);
            this.bGuardarDP.Name = "bGuardarDP";
            this.bGuardarDP.Size = new System.Drawing.Size(75, 23);
            this.bGuardarDP.TabIndex = 38;
            this.bGuardarDP.Text = "Guardar";
            this.bGuardarDP.UseVisualStyleBackColor = true;
            this.bGuardarDP.Click += new System.EventHandler(this.bGuardarDP_Click);
            // 
            // txtFechaDP
            // 
            this.txtFechaDP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaDP.Location = new System.Drawing.Point(15, 64);
            this.txtFechaDP.Mask = "00/00/0000 00:00";
            this.txtFechaDP.Name = "txtFechaDP";
            this.txtFechaDP.Size = new System.Drawing.Size(257, 20);
            this.txtFechaDP.TabIndex = 37;
            this.txtFechaDP.ValidatingType = typeof(System.DateTime);
            // 
            // txtIDR
            // 
            this.txtIDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDR.Location = new System.Drawing.Point(15, 142);
            this.txtIDR.Name = "txtIDR";
            this.txtIDR.Size = new System.Drawing.Size(257, 20);
            this.txtIDR.TabIndex = 36;
            // 
            // txtImporteDP
            // 
            this.txtImporteDP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporteDP.Location = new System.Drawing.Point(15, 103);
            this.txtImporteDP.Name = "txtImporteDP";
            this.txtImporteDP.Size = new System.Drawing.Size(257, 20);
            this.txtImporteDP.TabIndex = 35;
            // 
            // txtFolioDP
            // 
            this.txtFolioDP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolioDP.Location = new System.Drawing.Point(15, 25);
            this.txtFolioDP.Name = "txtFolioDP";
            this.txtFolioDP.Size = new System.Drawing.Size(257, 20);
            this.txtFolioDP.TabIndex = 34;
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
            this.label4.TabIndex = 33;
            this.label4.Text = "ID Refacción";
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
            this.label3.TabIndex = 32;
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
            this.label2.TabIndex = 31;
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
            this.label1.TabIndex = 30;
            this.label1.Text = "Folio Devolución";
            // 
            // FormDevP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.bCancelarDP);
            this.Controls.Add(this.bGuardarDP);
            this.Controls.Add(this.txtFechaDP);
            this.Controls.Add(this.txtIDR);
            this.Controls.Add(this.txtImporteDP);
            this.Controls.Add(this.txtFolioDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevP";
            this.ShowIcon = false;
            this.Text = "FormDevP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarDP;
        private System.Windows.Forms.Button bGuardarDP;
        private System.Windows.Forms.MaskedTextBox txtFechaDP;
        private System.Windows.Forms.TextBox txtIDR;
        private System.Windows.Forms.TextBox txtImporteDP;
        private System.Windows.Forms.TextBox txtFolioDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}