namespace GUIFBDD
{
    partial class FormProveedor
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
            this.bCancelarP = new System.Windows.Forms.Button();
            this.bGuardarP = new System.Windows.Forms.Button();
            this.txtTelP = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFCP = new System.Windows.Forms.TextBox();
            this.txtCorreoP = new System.Windows.Forms.TextBox();
            this.txtDomicilioP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCancelarP
            // 
            this.bCancelarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelarP.Location = new System.Drawing.Point(204, 254);
            this.bCancelarP.Name = "bCancelarP";
            this.bCancelarP.Size = new System.Drawing.Size(72, 23);
            this.bCancelarP.TabIndex = 29;
            this.bCancelarP.Text = "Cancelar";
            this.bCancelarP.UseVisualStyleBackColor = true;
            this.bCancelarP.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardarP
            // 
            this.bGuardarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardarP.Location = new System.Drawing.Point(126, 254);
            this.bGuardarP.Name = "bGuardarP";
            this.bGuardarP.Size = new System.Drawing.Size(72, 23);
            this.bGuardarP.TabIndex = 28;
            this.bGuardarP.Text = "Guardar";
            this.bGuardarP.UseVisualStyleBackColor = true;
            this.bGuardarP.Click += new System.EventHandler(this.bGuardarP_Click);
            // 
            // txtTelP
            // 
            this.txtTelP.Location = new System.Drawing.Point(15, 143);
            this.txtTelP.Mask = "000-000-0000";
            this.txtTelP.Name = "txtTelP";
            this.txtTelP.Size = new System.Drawing.Size(264, 20);
            this.txtTelP.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "RFC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID Proveedor";
            // 
            // txtRFCP
            // 
            this.txtRFCP.Location = new System.Drawing.Point(15, 220);
            this.txtRFCP.Name = "txtRFCP";
            this.txtRFCP.Size = new System.Drawing.Size(264, 20);
            this.txtRFCP.TabIndex = 20;
            // 
            // txtCorreoP
            // 
            this.txtCorreoP.Location = new System.Drawing.Point(15, 181);
            this.txtCorreoP.Name = "txtCorreoP";
            this.txtCorreoP.Size = new System.Drawing.Size(264, 20);
            this.txtCorreoP.TabIndex = 19;
            // 
            // txtDomicilioP
            // 
            this.txtDomicilioP.Location = new System.Drawing.Point(15, 103);
            this.txtDomicilioP.Name = "txtDomicilioP";
            this.txtDomicilioP.Size = new System.Drawing.Size(264, 20);
            this.txtDomicilioP.TabIndex = 18;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(15, 64);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(264, 20);
            this.txtNombreP.TabIndex = 17;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(15, 25);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(264, 20);
            this.txtIDP.TabIndex = 16;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 289);
            this.Controls.Add(this.bCancelarP);
            this.Controls.Add(this.bGuardarP);
            this.Controls.Add(this.txtTelP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRFCP);
            this.Controls.Add(this.txtCorreoP);
            this.Controls.Add(this.txtDomicilioP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtIDP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarP;
        private System.Windows.Forms.Button bGuardarP;
        private System.Windows.Forms.MaskedTextBox txtTelP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFCP;
        private System.Windows.Forms.TextBox txtCorreoP;
        private System.Windows.Forms.TextBox txtDomicilioP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtIDP;
    }
}