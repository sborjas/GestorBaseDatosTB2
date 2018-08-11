namespace GestorBaseDatos
{
    partial class BorrarTabla
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
            this.txtNameTabDel = new System.Windows.Forms.TextBox();
            this.cmdDelTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el nombre que desee eliminar:";
            // 
            // txtNameTabDel
            // 
            this.txtNameTabDel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTabDel.Location = new System.Drawing.Point(27, 91);
            this.txtNameTabDel.Name = "txtNameTabDel";
            this.txtNameTabDel.Size = new System.Drawing.Size(313, 31);
            this.txtNameTabDel.TabIndex = 2;
            // 
            // cmdDelTable
            // 
            this.cmdDelTable.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelTable.Location = new System.Drawing.Point(27, 128);
            this.cmdDelTable.Name = "cmdDelTable";
            this.cmdDelTable.Size = new System.Drawing.Size(154, 32);
            this.cmdDelTable.TabIndex = 3;
            this.cmdDelTable.Text = "Eliminar Tabla";
            this.cmdDelTable.UseVisualStyleBackColor = true;
            this.cmdDelTable.Click += new System.EventHandler(this.cmdDelTable_Click);
            // 
            // BorrarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 187);
            this.Controls.Add(this.cmdDelTable);
            this.Controls.Add(this.txtNameTabDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BorrarTabla";
            this.Text = "BorrarTabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameTabDel;
        private System.Windows.Forms.Button cmdDelTable;
    }
}