namespace MenuProgramas
{
    partial class AyP
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
            this.Perimetro = new System.Windows.Forms.RadioButton();
            this.Area = new System.Windows.Forms.RadioButton();
            this.Calcular = new System.Windows.Forms.Button();
            this.LadoP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.PerimetroA = new System.Windows.Forms.TextBox();
            this.ApotemaA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perimetro
            // 
            this.Perimetro.AutoSize = true;
            this.Perimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perimetro.Location = new System.Drawing.Point(12, 271);
            this.Perimetro.Name = "Perimetro";
            this.Perimetro.Size = new System.Drawing.Size(231, 29);
            this.Perimetro.TabIndex = 0;
            this.Perimetro.TabStop = true;
            this.Perimetro.Text = "Perimetro Del Poligono";
            this.Perimetro.UseVisualStyleBackColor = true;
            this.Perimetro.CheckedChanged += new System.EventHandler(this.Perimetro_CheckedChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(530, 271);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(190, 29);
            this.Area.TabIndex = 1;
            this.Area.TabStop = true;
            this.Area.Text = "Area Del Poligono";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.CheckedChanged += new System.EventHandler(this.Area_CheckedChanged);
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(300, 347);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(156, 42);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // LadoP
            // 
            this.LadoP.Location = new System.Drawing.Point(56, 157);
            this.LadoP.Name = "LadoP";
            this.LadoP.Size = new System.Drawing.Size(172, 22);
            this.LadoP.TabIndex = 3;
            this.LadoP.TextChanged += new System.EventHandler(this.Lado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dame el valor de un lado del poligono";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(515, 47);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(187, 25);
            this.label.TabIndex = 5;
            this.label.Text = "Ingresa El Perimetro";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // PerimetroA
            // 
            this.PerimetroA.Location = new System.Drawing.Point(520, 88);
            this.PerimetroA.Name = "PerimetroA";
            this.PerimetroA.Size = new System.Drawing.Size(172, 22);
            this.PerimetroA.TabIndex = 6;
            this.PerimetroA.TextChanged += new System.EventHandler(this.PerimetroA_TextChanged);
            // 
            // ApotemaA
            // 
            this.ApotemaA.Location = new System.Drawing.Point(520, 206);
            this.ApotemaA.Name = "ApotemaA";
            this.ApotemaA.Size = new System.Drawing.Size(172, 22);
            this.ApotemaA.TabIndex = 7;
            this.ApotemaA.TextChanged += new System.EventHandler(this.ApotemaA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresa El Apotema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AyP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApotemaA);
            this.Controls.Add(this.PerimetroA);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LadoP);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Perimetro);
            this.Name = "AyP";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Perimetro;
        private System.Windows.Forms.RadioButton Area;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox LadoP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox PerimetroA;
        private System.Windows.Forms.TextBox ApotemaA;
        private System.Windows.Forms.Label label2;
    }
}