namespace MenuProgramas
{
    partial class GradosaR
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
            this.Gradoss = new System.Windows.Forms.TextBox();
            this.Convertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pon los grados a convertir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gradoss
            // 
            this.Gradoss.Location = new System.Drawing.Point(261, 153);
            this.Gradoss.Name = "Gradoss";
            this.Gradoss.Size = new System.Drawing.Size(174, 22);
            this.Gradoss.TabIndex = 1;
            this.Gradoss.TextChanged += new System.EventHandler(this.Gradoss_TextChanged);
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(283, 208);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(131, 51);
            this.Convertir.TabIndex = 2;
            this.Convertir.Text = "Convertir";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // GradosaR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.Gradoss);
            this.Controls.Add(this.label1);
            this.Name = "GradosaR";
            this.Text = "GradosaR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Gradoss;
        private System.Windows.Forms.Button Convertir;
    }
}