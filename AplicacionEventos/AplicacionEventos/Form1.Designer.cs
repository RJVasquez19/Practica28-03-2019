namespace AplicacionEventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbMarca1 = new System.Windows.Forms.CheckBox();
            this.chbMarca2 = new System.Windows.Forms.CheckBox();
            this.chbMarca3 = new System.Windows.Forms.CheckBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRadio = new System.Windows.Forms.Button();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.cbbColores = new System.Windows.Forms.ComboBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbMarca1
            // 
            this.chbMarca1.AutoSize = true;
            this.chbMarca1.Location = new System.Drawing.Point(27, 43);
            this.chbMarca1.Name = "chbMarca1";
            this.chbMarca1.Size = new System.Drawing.Size(62, 17);
            this.chbMarca1.TabIndex = 0;
            this.chbMarca1.Text = "Marca1";
            this.chbMarca1.UseVisualStyleBackColor = true;
            this.chbMarca1.CheckedChanged += new System.EventHandler(this.chbMarca1_CheckedChanged);
            // 
            // chbMarca2
            // 
            this.chbMarca2.AutoSize = true;
            this.chbMarca2.Location = new System.Drawing.Point(27, 67);
            this.chbMarca2.Name = "chbMarca2";
            this.chbMarca2.Size = new System.Drawing.Size(62, 17);
            this.chbMarca2.TabIndex = 1;
            this.chbMarca2.Text = "Marca2";
            this.chbMarca2.UseVisualStyleBackColor = true;
            this.chbMarca2.CheckedChanged += new System.EventHandler(this.chbMarca2_CheckedChanged);
            // 
            // chbMarca3
            // 
            this.chbMarca3.AutoSize = true;
            this.chbMarca3.Location = new System.Drawing.Point(27, 91);
            this.chbMarca3.Name = "chbMarca3";
            this.chbMarca3.Size = new System.Drawing.Size(62, 17);
            this.chbMarca3.TabIndex = 2;
            this.chbMarca3.Text = "Marca3";
            this.chbMarca3.UseVisualStyleBackColor = true;
            this.chbMarca3.CheckedChanged += new System.EventHandler(this.chbMarca3_CheckedChanged);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoCheck = false;
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(166, 43);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(52, 17);
            this.rbSuma.TabIndex = 3;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoCheck = false;
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(166, 67);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rbMultiplicacion.TabIndex = 4;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "Multiplicacion";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoCheck = false;
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(166, 91);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(53, 17);
            this.rbResta.TabIndex = 5;
            this.rbResta.TabStop = true;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(27, 157);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(92, 23);
            this.btnAccion.TabIndex = 6;
            this.btnAccion.Text = "Accion Check";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(27, 125);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            this.lblResultado.DoubleClick += new System.EventHandler(this.lblResultado_DoubleClick);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(166, 157);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(98, 23);
            this.btnRadio.TabIndex = 8;
            this.btnRadio.Text = "Accion Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            // 
            // rbDivision
            // 
            this.rbDivision.AutoCheck = false;
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(166, 114);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(62, 17);
            this.rbDivision.TabIndex = 9;
            this.rbDivision.TabStop = true;
            this.rbDivision.Text = "Division";
            this.rbDivision.UseVisualStyleBackColor = true;
            // 
            // cbbColores
            // 
            this.cbbColores.BackColor = System.Drawing.SystemColors.Window;
            this.cbbColores.FormattingEnabled = true;
            this.cbbColores.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Formulario Gris",
            "Forulario Celeste",
            "Formulario Naranja"});
            this.cbbColores.Location = new System.Drawing.Point(304, 43);
            this.cbbColores.Name = "cbbColores";
            this.cbbColores.Size = new System.Drawing.Size(121, 21);
            this.cbbColores.TabIndex = 10;
            this.cbbColores.SelectedIndexChanged += new System.EventHandler(this.cbbColores_SelectedIndexChanged);
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(319, 157);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(75, 23);
            this.btnLlenar.TabIndex = 11;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(304, 91);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 12;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(304, 122);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.cbbColores);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.btnRadio);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.rbResta);
            this.Controls.Add(this.rbMultiplicacion);
            this.Controls.Add(this.rbSuma);
            this.Controls.Add(this.chbMarca3);
            this.Controls.Add(this.chbMarca2);
            this.Controls.Add(this.chbMarca1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbMarca1;
        private System.Windows.Forms.CheckBox chbMarca2;
        private System.Windows.Forms.CheckBox chbMarca3;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.ComboBox cbbColores;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

