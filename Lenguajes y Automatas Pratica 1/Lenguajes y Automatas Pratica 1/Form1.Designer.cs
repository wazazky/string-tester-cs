namespace Lenguajes_y_Automatas_Pratica_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUseless = new System.Windows.Forms.Label();
            this.labeluseless2 = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUseless
            // 
            this.labelUseless.AutoSize = true;
            this.labelUseless.Location = new System.Drawing.Point(126, 37);
            this.labelUseless.Name = "labelUseless";
            this.labelUseless.Size = new System.Drawing.Size(65, 13);
            this.labelUseless.TabIndex = 1;
            this.labelUseless.Text = "Escribe algo";
            // 
            // labeluseless2
            // 
            this.labeluseless2.AutoSize = true;
            this.labeluseless2.Location = new System.Drawing.Point(126, 76);
            this.labeluseless2.Name = "labeluseless2";
            this.labeluseless2.Size = new System.Drawing.Size(59, 13);
            this.labeluseless2.TabIndex = 2;
            this.labeluseless2.Text = "El texto es:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(3, 89);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(0, 13);
            this.labelTipo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 113);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labeluseless2);
            this.Controls.Add(this.labelUseless);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUseless;
        private System.Windows.Forms.Label labeluseless2;
        private System.Windows.Forms.Label labelTipo;
    }
}

