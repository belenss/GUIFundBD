namespace GUIFBDD
{
    partial class ListaCompras
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
            this.bNuevoCr = new System.Windows.Forms.Button();
            this.bEliminarCr = new System.Windows.Forms.Button();
            this.bVolverCr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgListaCr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCr)).BeginInit();
            this.SuspendLayout();
            // 
            // bNuevoCr
            // 
            this.bNuevoCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoCr.Location = new System.Drawing.Point(23, 415);
            this.bNuevoCr.Name = "bNuevoCr";
            this.bNuevoCr.Size = new System.Drawing.Size(75, 23);
            this.bNuevoCr.TabIndex = 0;
            this.bNuevoCr.Text = "Nuevo";
            this.bNuevoCr.UseVisualStyleBackColor = true;
            this.bNuevoCr.Click += new System.EventHandler(this.bNuevoCr_Click);
            // 
            // bEliminarCr
            // 
            this.bEliminarCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarCr.Location = new System.Drawing.Point(151, 415);
            this.bEliminarCr.Name = "bEliminarCr";
            this.bEliminarCr.Size = new System.Drawing.Size(75, 23);
            this.bEliminarCr.TabIndex = 1;
            this.bEliminarCr.Text = "Eliminar";
            this.bEliminarCr.UseVisualStyleBackColor = true;
            this.bEliminarCr.Click += new System.EventHandler(this.bEliminarCr_Click);
            // 
            // bVolverCr
            // 
            this.bVolverCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverCr.Location = new System.Drawing.Point(704, 415);
            this.bVolverCr.Name = "bVolverCr";
            this.bVolverCr.Size = new System.Drawing.Size(75, 23);
            this.bVolverCr.TabIndex = 2;
            this.bVolverCr.Text = "Volver";
            this.bVolverCr.UseVisualStyleBackColor = true;
            this.bVolverCr.Click += new System.EventHandler(this.bVolverCr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Compras";
            // 
            // dgListaCr
            // 
            this.dgListaCr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaCr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaCr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaCr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCr.Location = new System.Drawing.Point(23, 77);
            this.dgListaCr.Name = "dgListaCr";
            this.dgListaCr.Size = new System.Drawing.Size(756, 332);
            this.dgListaCr.TabIndex = 4;
            // 
            // ListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListaCr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolverCr);
            this.Controls.Add(this.bEliminarCr);
            this.Controls.Add(this.bNuevoCr);
            this.Name = "ListaCompras";
            this.ShowIcon = false;
            this.Text = "ListaCompras";
            this.Load += new System.EventHandler(this.ListaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNuevoCr;
        private System.Windows.Forms.Button bEliminarCr;
        private System.Windows.Forms.Button bVolverCr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaCr;
    }
}