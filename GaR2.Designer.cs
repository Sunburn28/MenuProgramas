namespace MenuProgramas
{
    partial class GaR2
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
            this.Grados = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Rad = new System.Windows.Forms.RadioButton();
            this.Gra = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Radianes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dame los grados";
            // 
            // Grados
            // 
            this.Grados.Location = new System.Drawing.Point(93, 164);
            this.Grados.Name = "Grados";
            this.Grados.Size = new System.Drawing.Size(172, 22);
            this.Grados.TabIndex = 12;
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(337, 354);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(156, 42);
            this.Calcular.TabIndex = 11;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Rad
            // 
            this.Rad.AutoSize = true;
            this.Rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad.Location = new System.Drawing.Point(551, 234);
            this.Rad.Name = "Rad";
            this.Rad.Size = new System.Drawing.Size(203, 29);
            this.Rad.TabIndex = 10;
            this.Rad.TabStop = true;
            this.Rad.Text = "Radianes A Grados";
            this.Rad.UseVisualStyleBackColor = true;
            // 
            // Gra
            // 
            this.Gra.AutoSize = true;
            this.Gra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gra.Location = new System.Drawing.Point(49, 234);
            this.Gra.Name = "Gra";
            this.Gra.Size = new System.Drawing.Size(203, 29);
            this.Gra.TabIndex = 9;
            this.Gra.TabStop = true;
            this.Gra.Text = "Grados A Radianes";
            this.Gra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dame Los Radianes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Radianes
            // 
            this.Radianes.Location = new System.Drawing.Point(551, 164);
            this.Radianes.Name = "Radianes";
            this.Radianes.Size = new System.Drawing.Size(172, 22);
            this.Radianes.TabIndex = 16;
            this.Radianes.TextChanged += new System.EventHandler(this.ApotemaA_TextChanged);
            // 
            // GaR2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Radianes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grados);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Rad);
            this.Controls.Add(this.Gra);
            this.Name = "GaR2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grados;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.RadioButton Rad;
        private System.Windows.Forms.RadioButton Gra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Radianes;
    }
}