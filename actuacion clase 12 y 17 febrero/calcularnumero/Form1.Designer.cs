
namespace calcularnumero
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
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.CheckBox();
            this.restar = new System.Windows.Forms.CheckBox();
            this.multiplicar = new System.Windows.Forms.CheckBox();
            this.dividir = new System.Windows.Forms.CheckBox();
            this.modulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(267, 288);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones Basicas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero 2";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(268, 88);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(125, 20);
            this.tbNum1.TabIndex = 4;
            this.tbNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(270, 212);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(122, 20);
            this.tbNum2.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(458, 250);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(50, 13);
            this.Result.TabIndex = 6;
            this.Result.Text = "resultado";
            // 
            // sumar
            // 
            this.sumar.AutoSize = true;
            this.sumar.Location = new System.Drawing.Point(533, 103);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(51, 17);
            this.sumar.TabIndex = 7;
            this.sumar.Text = "suma";
            this.sumar.UseVisualStyleBackColor = true;
            // 
            // restar
            // 
            this.restar.AutoSize = true;
            this.restar.Location = new System.Drawing.Point(533, 126);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(43, 17);
            this.restar.TabIndex = 8;
            this.restar.Text = "rest";
            this.restar.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Location = new System.Drawing.Point(533, 149);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(47, 17);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "multi";
            this.multiplicar.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Location = new System.Drawing.Point(533, 172);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(53, 17);
            this.dividir.TabIndex = 10;
            this.dividir.Text = "dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // modulo
            // 
            this.modulo.AutoSize = true;
            this.modulo.Location = new System.Drawing.Point(533, 195);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(60, 17);
            this.modulo.TabIndex = 11;
            this.modulo.Text = "modulo";
            this.modulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.CheckBox sumar;
        private System.Windows.Forms.CheckBox restar;
        private System.Windows.Forms.CheckBox multiplicar;
        private System.Windows.Forms.CheckBox dividir;
        private System.Windows.Forms.CheckBox modulo;
    }
}

