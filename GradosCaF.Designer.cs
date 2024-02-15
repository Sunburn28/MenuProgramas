namespace MenuProgramas
{
    partial class GradosCaF
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
            this.Convertir = new System.Windows.Forms.Button();
            this.Celsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(290, 238);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(131, 51);
            this.Convertir.TabIndex = 5;
            this.Convertir.Text = "Convertir";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(268, 183);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(174, 22);
            this.Celsius.TabIndex = 4;
            this.Celsius.TextChanged += new System.EventHandler(this.Gradoss_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pon los grados centigrados a convertir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GradosCaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.label1);
            this.Name = "GradosCaF";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.Label label1;
    }
}