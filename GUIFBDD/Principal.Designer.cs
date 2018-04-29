namespace GUIFBDD
{
    partial class Principal
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
            this.Clientes = new System.Windows.Forms.Button();
            this.Proveedores = new System.Windows.Forms.Button();
            this.Compras = new System.Windows.Forms.Button();
            this.DevC = new System.Windows.Forms.Button();
            this.Refacciones = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.Button();
            this.DevP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Location = new System.Drawing.Point(539, 97);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(141, 62);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.Location = new System.Drawing.Point(131, 181);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(141, 62);
            this.Proveedores.TabIndex = 1;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Compras
            // 
            this.Compras.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compras.Location = new System.Drawing.Point(131, 259);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(141, 62);
            this.Compras.TabIndex = 2;
            this.Compras.Text = "Compras";
            this.Compras.UseVisualStyleBackColor = true;
            this.Compras.Click += new System.EventHandler(this.Compras_Click);
            // 
            // DevC
            // 
            this.DevC.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevC.Location = new System.Drawing.Point(539, 181);
            this.DevC.Name = "DevC";
            this.DevC.Size = new System.Drawing.Size(141, 62);
            this.DevC.TabIndex = 3;
            this.DevC.Text = "Dev. C.";
            this.DevC.UseVisualStyleBackColor = true;
            this.DevC.Click += new System.EventHandler(this.DevC_Click);
            // 
            // Refacciones
            // 
            this.Refacciones.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refacciones.Location = new System.Drawing.Point(131, 97);
            this.Refacciones.Name = "Refacciones";
            this.Refacciones.Size = new System.Drawing.Size(141, 62);
            this.Refacciones.TabIndex = 4;
            this.Refacciones.Text = "Refacciones";
            this.Refacciones.UseVisualStyleBackColor = true;
            this.Refacciones.Click += new System.EventHandler(this.Refacciones_Click);
            // 
            // Ventas
            // 
            this.Ventas.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.Location = new System.Drawing.Point(341, 181);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(141, 62);
            this.Ventas.TabIndex = 5;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // DevP
            // 
            this.DevP.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevP.Location = new System.Drawing.Point(539, 259);
            this.DevP.Name = "DevP";
            this.DevP.Size = new System.Drawing.Size(141, 62);
            this.DevP.TabIndex = 6;
            this.DevP.Text = "Dev. P.";
            this.DevP.UseVisualStyleBackColor = true;
            this.DevP.Click += new System.EventHandler(this.DevP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Juice ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biketitud";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevP);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.Refacciones);
            this.Controls.Add(this.DevC);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.Clientes);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Proveedores;
        private System.Windows.Forms.Button Compras;
        private System.Windows.Forms.Button DevC;
        private System.Windows.Forms.Button Refacciones;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button DevP;
        private System.Windows.Forms.Label label1;
    }
}