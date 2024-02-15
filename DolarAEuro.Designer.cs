namespace MenuProgramas
{
    partial class DolarAEuro
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
            this.Dolar = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Euro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cuantos dolares quieres cambiar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dolar
            // 
            this.Dolar.Location = new System.Drawing.Point(277, 107);
            this.Dolar.Name = "Dolar";
            this.Dolar.Size = new System.Drawing.Size(162, 22);
            this.Dolar.TabIndex = 1;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(298, 276);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(123, 47);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Caclular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Euro
            // 
            this.Euro.Location = new System.Drawing.Point(277, 213);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(162, 22);
            this.Euro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dame el tipo de cambio";
            // 
            // DolarAEuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Euro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Dolar);
            this.Controls.Add(this.label1);
            this.Name = "DolarAEuro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dolar;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox Euro;
        private System.Windows.Forms.Label label2;
    }
}