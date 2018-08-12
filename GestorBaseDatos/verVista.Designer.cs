namespace GestorBaseDatos
{
    partial class verVista
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreVistaShow = new System.Windows.Forms.TextBox();
            this.dataVista = new System.Windows.Forms.DataGridView();
            this.cmdVisualizarVista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visor de Vistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Nombre de Vista";
            // 
            // txtNombreVistaShow
            // 
            this.txtNombreVistaShow.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVistaShow.Location = new System.Drawing.Point(228, 44);
            this.txtNombreVistaShow.Name = "txtNombreVistaShow";
            this.txtNombreVistaShow.Size = new System.Drawing.Size(179, 31);
            this.txtNombreVistaShow.TabIndex = 2;
            // 
            // dataVista
            // 
            this.dataVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVista.Location = new System.Drawing.Point(25, 80);
            this.dataVista.Name = "dataVista";
            this.dataVista.Size = new System.Drawing.Size(523, 198);
            this.dataVista.TabIndex = 3;
            // 
            // cmdVisualizarVista
            // 
            this.cmdVisualizarVista.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVisualizarVista.Location = new System.Drawing.Point(413, 45);
            this.cmdVisualizarVista.Name = "cmdVisualizarVista";
            this.cmdVisualizarVista.Size = new System.Drawing.Size(135, 29);
            this.cmdVisualizarVista.TabIndex = 4;
            this.cmdVisualizarVista.Text = "Mostrar Vista";
            this.cmdVisualizarVista.UseVisualStyleBackColor = true;
            this.cmdVisualizarVista.Click += new System.EventHandler(this.cmdVisualizarVista_Click);
            // 
            // verVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 283);
            this.Controls.Add(this.cmdVisualizarVista);
            this.Controls.Add(this.dataVista);
            this.Controls.Add(this.txtNombreVistaShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "verVista";
            this.Text = "verVista";
            ((System.ComponentModel.ISupportInitialize)(this.dataVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreVistaShow;
        private System.Windows.Forms.DataGridView dataVista;
        private System.Windows.Forms.Button cmdVisualizarVista;
    }
}