namespace GUIFBDD
{
    partial class ListaClientes
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
            this.bNuevoC = new System.Windows.Forms.Button();
            this.bEliminarC = new System.Windows.Forms.Button();
            this.bVolverC = new System.Windows.Forms.Button();
            this.dgListaC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaC)).BeginInit();
            this.SuspendLayout();
            // 
            // bNuevoC
            // 
            this.bNuevoC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoC.Location = new System.Drawing.Point(12, 406);
            this.bNuevoC.Name = "bNuevoC";
            this.bNuevoC.Size = new System.Drawing.Size(75, 23);
            this.bNuevoC.TabIndex = 1;
            this.bNuevoC.Text = "Nuevo";
            this.bNuevoC.UseVisualStyleBackColor = true;
            this.bNuevoC.Click += new System.EventHandler(this.bNuevoC_Click);
            // 
            // bEliminarC
            // 
            this.bEliminarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarC.Location = new System.Drawing.Point(104, 406);
            this.bEliminarC.Name = "bEliminarC";
            this.bEliminarC.Size = new System.Drawing.Size(75, 23);
            this.bEliminarC.TabIndex = 2;
            this.bEliminarC.Text = "Eliminar";
            this.bEliminarC.UseVisualStyleBackColor = true;
            this.bEliminarC.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bVolverC
            // 
            this.bVolverC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverC.Location = new System.Drawing.Point(697, 406);
            this.bVolverC.Name = "bVolverC";
            this.bVolverC.Size = new System.Drawing.Size(75, 23);
            this.bVolverC.TabIndex = 3;
            this.bVolverC.Text = "Volver";
            this.bVolverC.UseVisualStyleBackColor = true;
            this.bVolverC.Click += new System.EventHandler(this.bVolverC_Click);
            // 
            // dgListaC
            // 
            this.dgListaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaC.Location = new System.Drawing.Point(12, 74);
            this.dgListaC.Name = "dgListaC";
            this.dgListaC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaC.Size = new System.Drawing.Size(760, 324);
            this.dgListaC.TabIndex = 0;
            this.dgListaC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaC_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clientes 2018";
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolverC);
            this.Controls.Add(this.bEliminarC);
            this.Controls.Add(this.bNuevoC);
            this.Controls.Add(this.dgListaC);
            this.Name = "ListaClientes";
            this.ShowIcon = false;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bNuevoC;
        private System.Windows.Forms.Button bEliminarC;
        private System.Windows.Forms.Button bVolverC;
        private System.Windows.Forms.DataGridView dgListaC;
        private System.Windows.Forms.Label label1;
    }
}