namespace TareaEjercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nota1textBox = new System.Windows.Forms.TextBox();
            this.nota3textBox = new System.Windows.Forms.TextBox();
            this.nota2textBox = new System.Windows.Forms.TextBox();
            this.nota4textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota primer Parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota cuarto parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota tercer parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota segundo parcial:";
            // 
            // nota1textBox
            // 
            this.nota1textBox.Location = new System.Drawing.Point(298, 69);
            this.nota1textBox.Name = "nota1textBox";
            this.nota1textBox.Size = new System.Drawing.Size(100, 20);
            this.nota1textBox.TabIndex = 4;
            // 
            // nota3textBox
            // 
            this.nota3textBox.Location = new System.Drawing.Point(298, 137);
            this.nota3textBox.Name = "nota3textBox";
            this.nota3textBox.Size = new System.Drawing.Size(100, 20);
            this.nota3textBox.TabIndex = 5;
            // 
            // nota2textBox
            // 
            this.nota2textBox.Location = new System.Drawing.Point(298, 98);
            this.nota2textBox.Name = "nota2textBox";
            this.nota2textBox.Size = new System.Drawing.Size(100, 20);
            this.nota2textBox.TabIndex = 6;
            // 
            // nota4textBox
            // 
            this.nota4textBox.Location = new System.Drawing.Point(298, 174);
            this.nota4textBox.Name = "nota4textBox";
            this.nota4textBox.Size = new System.Drawing.Size(100, 20);
            this.nota4textBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(186, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular Promedio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nota4textBox);
            this.Controls.Add(this.nota2textBox);
            this.Controls.Add(this.nota3textBox);
            this.Controls.Add(this.nota1textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nota1textBox;
        private System.Windows.Forms.TextBox nota3textBox;
        private System.Windows.Forms.TextBox nota2textBox;
        private System.Windows.Forms.TextBox nota4textBox;
        private System.Windows.Forms.Button button1;
    }
}

