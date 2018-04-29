namespace GUIFBDD
{
    partial class ListaDevC
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
            this.dgDevC = new System.Windows.Forms.DataGridView();
            this.bNuevoDC = new System.Windows.Forms.Button();
            this.bEliminarDC = new System.Windows.Forms.Button();
            this.bVolverDC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones a Clientes";
            // 
            // dgDevC
            // 
            this.dgDevC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDevC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDevC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDevC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevC.Location = new System.Drawing.Point(23, 77);
            this.dgDevC.Name = "dgDevC";
            this.dgDevC.Size = new System.Drawing.Size(765, 332);
            this.dgDevC.TabIndex = 1;
            // 
            // bNuevoDC
            // 
            this.bNuevoDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoDC.Location = new System.Drawing.Point(23, 415);
            this.bNuevoDC.Name = "bNuevoDC";
            this.bNuevoDC.Size = new System.Drawing.Size(75, 23);
            this.bNuevoDC.TabIndex = 2;
            this.bNuevoDC.Text = "Nuevo";
            this.bNuevoDC.UseCompatibleTextRendering = true;
            this.bNuevoDC.UseVisualStyleBackColor = true;
            this.bNuevoDC.Click += new System.EventHandler(this.bNuevoDC_Click);
            // 
            // bEliminarDC
            // 
            this.bEliminarDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarDC.Location = new System.Drawing.Point(149, 415);
            this.bEliminarDC.Name = "bEliminarDC";
            this.bEliminarDC.Size = new System.Drawing.Size(75, 23);
            this.bEliminarDC.TabIndex = 3;
            this.bEliminarDC.Text = "Eliminar";
            this.bEliminarDC.UseVisualStyleBackColor = true;
            this.bEliminarDC.Click += new System.EventHandler(this.bEliminarDC_Click);
            // 
            // bVolverDC
            // 
            this.bVolverDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverDC.Location = new System.Drawing.Point(713, 415);
            this.bVolverDC.Name = "bVolverDC";
            this.bVolverDC.Size = new System.Drawing.Size(75, 23);
            this.bVolverDC.TabIndex = 4;
            this.bVolverDC.Text = "Volver";
            this.bVolverDC.UseVisualStyleBackColor = true;
            this.bVolverDC.Click += new System.EventHandler(this.bVolverDC_Click);
            // 
            // ListaDevC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVolverDC);
            this.Controls.Add(this.bEliminarDC);
            this.Controls.Add(this.bNuevoDC);
            this.Controls.Add(this.dgDevC);
            this.Controls.Add(this.label1);
            this.Name = "ListaDevC";
            this.ShowIcon = false;
            this.Text = "Devoluciones a Clientes";
            this.Load += new System.EventHandler(this.ListaDevC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDevC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDevC;
        private System.Windows.Forms.Button bNuevoDC;
        private System.Windows.Forms.Button bEliminarDC;
        private System.Windows.Forms.Button bVolverDC;
    }
}