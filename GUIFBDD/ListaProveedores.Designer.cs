namespace GUIFBDD
{
    partial class ListaProveedores
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
            this.dgListaP = new System.Windows.Forms.DataGridView();
            this.bNuevoP = new System.Windows.Forms.Button();
            this.bEliminarP = new System.Windows.Forms.Button();
            this.bVolverP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores 2018";
            // 
            // dgListaP
            // 
            this.dgListaP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaP.Location = new System.Drawing.Point(12, 77);
            this.dgListaP.Name = "dgListaP";
            this.dgListaP.Size = new System.Drawing.Size(760, 324);
            this.dgListaP.TabIndex = 1;
            // 
            // bNuevoP
            // 
            this.bNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoP.Location = new System.Drawing.Point(12, 407);
            this.bNuevoP.Name = "bNuevoP";
            this.bNuevoP.Size = new System.Drawing.Size(75, 23);
            this.bNuevoP.TabIndex = 2;
            this.bNuevoP.Text = "Nuevo";
            this.bNuevoP.UseVisualStyleBackColor = true;
            this.bNuevoP.Click += new System.EventHandler(this.bNuevoP_Click);
            // 
            // bEliminarP
            // 
            this.bEliminarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarP.Location = new System.Drawing.Point(103, 407);
            this.bEliminarP.Name = "bEliminarP";
            this.bEliminarP.Size = new System.Drawing.Size(75, 23);
            this.bEliminarP.TabIndex = 3;
            this.bEliminarP.Text = "Eliminar";
            this.bEliminarP.UseVisualStyleBackColor = true;
            this.bEliminarP.Click += new System.EventHandler(this.bEliminarP_Click);
            // 
            // bVolverP
            // 
            this.bVolverP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverP.Location = new System.Drawing.Point(697, 406);
            this.bVolverP.Name = "bVolverP";
            this.bVolverP.Size = new System.Drawing.Size(75, 23);
            this.bVolverP.TabIndex = 4;
            this.bVolverP.Text = "Volver";
            this.bVolverP.UseVisualStyleBackColor = true;
            this.bVolverP.Click += new System.EventHandler(this.bVolverP_Click);
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.bVolverP);
            this.Controls.Add(this.bEliminarP);
            this.Controls.Add(this.bNuevoP);
            this.Controls.Add(this.dgListaP);
            this.Controls.Add(this.label1);
            this.Name = "ListaProveedores";
            this.Text = "ListaProveedores";
            this.Load += new System.EventHandler(this.ListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaP;
        private System.Windows.Forms.Button bNuevoP;
        private System.Windows.Forms.Button bEliminarP;
        private System.Windows.Forms.Button bVolverP;
    }
}