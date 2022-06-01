namespace WindowsFormsApp1
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificación = new System.Windows.Forms.TextBox();
            this.txtsalariodía = new System.Windows.Forms.TextBox();
            this.txtdíaslabor = new System.Windows.Forms.TextBox();
            this.btnAlmacenarregistro = new System.Windows.Forms.Button();
            this.btnCalcularsalario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValortotal = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de nomina del \r\nTrabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignación salario día: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Días laborados:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(347, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtIdentificación
            // 
            this.txtIdentificación.Location = new System.Drawing.Point(347, 107);
            this.txtIdentificación.Name = "txtIdentificación";
            this.txtIdentificación.Size = new System.Drawing.Size(137, 20);
            this.txtIdentificación.TabIndex = 6;
            // 
            // txtsalariodía
            // 
            this.txtsalariodía.Location = new System.Drawing.Point(347, 133);
            this.txtsalariodía.Name = "txtsalariodía";
            this.txtsalariodía.Size = new System.Drawing.Size(137, 20);
            this.txtsalariodía.TabIndex = 7;
            this.txtsalariodía.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdíaslabor
            // 
            this.txtdíaslabor.Location = new System.Drawing.Point(347, 173);
            this.txtdíaslabor.Name = "txtdíaslabor";
            this.txtdíaslabor.Size = new System.Drawing.Size(137, 20);
            this.txtdíaslabor.TabIndex = 8;
            // 
            // btnAlmacenarregistro
            // 
            this.btnAlmacenarregistro.Location = new System.Drawing.Point(362, 199);
            this.btnAlmacenarregistro.Name = "btnAlmacenarregistro";
            this.btnAlmacenarregistro.Size = new System.Drawing.Size(105, 34);
            this.btnAlmacenarregistro.TabIndex = 9;
            this.btnAlmacenarregistro.Text = "Guardar el registro del empleado";
            this.btnAlmacenarregistro.UseVisualStyleBackColor = true;
            // 
            // btnCalcularsalario
            // 
            this.btnCalcularsalario.Location = new System.Drawing.Point(362, 239);
            this.btnCalcularsalario.Name = "btnCalcularsalario";
            this.btnCalcularsalario.Size = new System.Drawing.Size(91, 23);
            this.btnCalcularsalario.TabIndex = 10;
            this.btnCalcularsalario.Text = "Calcularsalario";
            this.btnCalcularsalario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor total devengado:\r\n";
            // 
            // txtValortotal
            // 
            this.txtValortotal.Location = new System.Drawing.Point(347, 273);
            this.txtValortotal.Name = "txtValortotal";
            this.txtValortotal.Size = new System.Drawing.Size(137, 20);
            this.txtValortotal.TabIndex = 12;
            this.txtValortotal.TextChanged += new System.EventHandler(this.txtValortotal_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(136, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(554, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 345);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtValortotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcularsalario);
            this.Controls.Add(this.btnAlmacenarregistro);
            this.Controls.Add(this.txtdíaslabor);
            this.Controls.Add(this.txtsalariodía);
            this.Controls.Add(this.txtIdentificación);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificación;
        private System.Windows.Forms.TextBox txtsalariodía;
        private System.Windows.Forms.TextBox txtdíaslabor;
        private System.Windows.Forms.Button btnAlmacenarregistro;
        private System.Windows.Forms.Button btnCalcularsalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValortotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}

