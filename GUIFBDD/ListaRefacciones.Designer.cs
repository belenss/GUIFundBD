namespace GUIFBDD
{
    partial class ListaRefacciones
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
            this.dgListaR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bNuevoR = new System.Windows.Forms.Button();
            this.bEliminarR = new System.Windows.Forms.Button();
            this.bVolverR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaR
            // 
            this.dgListaR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaR.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaR.Location = new System.Drawing.Point(23, 77);
            this.dgListaR.Name = "dgListaR";
            this.dgListaR.Size = new System.Drawing.Size(760, 324);
            this.dgListaR.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refacciones 2018";
            // 
            // bNuevoR
            // 
            this.bNuevoR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoR.Location = new System.Drawing.Point(23, 415);
            this.bNuevoR.Name = "bNuevoR";
            this.bNuevoR.Size = new System.Drawing.Size(75, 23);
            this.bNuevoR.TabIndex = 2;
            this.bNuevoR.Text = "Nuevo";
            this.bNuevoR.UseVisualStyleBackColor = true;
            this.bNuevoR.Click += new System.EventHandler(this.bNuevoR_Click);
            // 
            // bEliminarR
            // 
            this.bEliminarR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarR.Location = new System.Drawing.Point(122, 415);
            this.bEliminarR.Name = "bEliminarR";
            this.bEliminarR.Size = new System.Drawing.Size(75, 23);
            this.bEliminarR.TabIndex = 3;
            this.bEliminarR.Text = "Eliminar";
            this.bEliminarR.UseVisualStyleBackColor = true;
            this.bEliminarR.Click += new System.EventHandler(this.bEliminarR_Click);
            // 
            // bVolverR
            // 
            this.bVolverR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverR.Location = new System.Drawing.Point(708, 415);
            this.bVolverR.Name = "bVolverR";
            this.bVolverR.Size = new System.Drawing.Size(75, 23);
            this.bVolverR.TabIndex = 4;
            this.bVolverR.Text = "Volver";
            this.bVolverR.UseVisualStyleBackColor = true;
            this.bVolverR.Click += new System.EventHandler(this.bVolverR_Click);
            // 
            // ListaRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVolverR);
            this.Controls.Add(this.bEliminarR);
            this.Controls.Add(this.bNuevoR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListaR);
            this.Name = "ListaRefacciones";
            this.ShowIcon = false;
            this.Text = "ListaRefacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNuevoR;
        private System.Windows.Forms.Button bEliminarR;
        private System.Windows.Forms.Button bVolverR;
    }
}