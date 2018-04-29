namespace GUIFBDD
{
    partial class ListaVentas
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
            this.dgListaVentas = new System.Windows.Forms.DataGridView();
            this.bNuevoV = new System.Windows.Forms.Button();
            this.bEliminarV = new System.Windows.Forms.Button();
            this.bVolverV = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // dgListaVentas
            // 
            this.dgListaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaVentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaVentas.Location = new System.Drawing.Point(23, 77);
            this.dgListaVentas.Name = "dgListaVentas";
            this.dgListaVentas.Size = new System.Drawing.Size(765, 332);
            this.dgListaVentas.TabIndex = 1;
            // 
            // bNuevoV
            // 
            this.bNuevoV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNuevoV.Location = new System.Drawing.Point(23, 415);
            this.bNuevoV.Name = "bNuevoV";
            this.bNuevoV.Size = new System.Drawing.Size(75, 23);
            this.bNuevoV.TabIndex = 2;
            this.bNuevoV.Text = "Nuevo";
            this.bNuevoV.UseVisualStyleBackColor = true;
            this.bNuevoV.Click += new System.EventHandler(this.bNuevoV_Click);
            // 
            // bEliminarV
            // 
            this.bEliminarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEliminarV.Location = new System.Drawing.Point(149, 415);
            this.bEliminarV.Name = "bEliminarV";
            this.bEliminarV.Size = new System.Drawing.Size(75, 23);
            this.bEliminarV.TabIndex = 3;
            this.bEliminarV.Text = "Eliminar";
            this.bEliminarV.UseVisualStyleBackColor = true;
            this.bEliminarV.Click += new System.EventHandler(this.bEliminarV_Click);
            // 
            // bVolverV
            // 
            this.bVolverV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVolverV.Location = new System.Drawing.Point(713, 415);
            this.bVolverV.Name = "bVolverV";
            this.bVolverV.Size = new System.Drawing.Size(75, 23);
            this.bVolverV.TabIndex = 4;
            this.bVolverV.Text = "Volver";
            this.bVolverV.UseVisualStyleBackColor = true;
            this.bVolverV.Click += new System.EventHandler(this.bVolverV_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bVolverV);
            this.Controls.Add(this.bEliminarV);
            this.Controls.Add(this.bNuevoV);
            this.Controls.Add(this.dgListaVentas);
            this.Controls.Add(this.label1);
            this.Name = "ListaVentas";
            this.ShowIcon = false;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.ListaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListaVentas;
        private System.Windows.Forms.Button bNuevoV;
        private System.Windows.Forms.Button bEliminarV;
        private System.Windows.Forms.Button bVolverV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}