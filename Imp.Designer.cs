namespace MenuProgramas
{
    partial class Imp
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
            this.chkesMedicamento = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkesMedicamento
            // 
            this.chkesMedicamento.AutoSize = true;
            this.chkesMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkesMedicamento.Location = new System.Drawing.Point(113, 294);
            this.chkesMedicamento.Name = "chkesMedicamento";
            this.chkesMedicamento.Size = new System.Drawing.Size(52, 29);
            this.chkesMedicamento.TabIndex = 0;
            this.chkesMedicamento.Text = "Si";
            this.chkesMedicamento.UseVisualStyleBackColor = true;
            this.chkesMedicamento.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce el precio del producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduce el numero de unidades";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(127, 160);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(152, 22);
            this.Precio.TabIndex = 3;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(491, 160);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(182, 22);
            this.Numero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿El producto es un medicamento?";
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(300, 355);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(135, 50);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Imp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkesMedicamento);
            this.Name = "Imp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkesMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calcular;
    }
}