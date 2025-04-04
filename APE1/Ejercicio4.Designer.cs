namespace APE1
{
    partial class Ejercicio4
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
            this.button9 = new System.Windows.Forms.Button();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.groupBoxMatrizResultado = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMatrizA = new System.Windows.Forms.GroupBox();
            this.btMatrizACrear = new System.Windows.Forms.Button();
            this.btLimpiarMatrizA = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Peru;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(391, 359);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 38);
            this.button9.TabIndex = 35;
            this.button9.Text = "Limpiar ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.BackColor = System.Drawing.Color.Peru;
            this.btnRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRespuesta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta.Location = new System.Drawing.Point(228, 359);
            this.btnRespuesta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(158, 37);
            this.btnRespuesta.TabIndex = 34;
            this.btnRespuesta.Text = "Generar Respuesta";
            this.btnRespuesta.UseVisualStyleBackColor = false;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // groupBoxMatrizResultado
            // 
            this.groupBoxMatrizResultado.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxMatrizResultado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizResultado.Location = new System.Drawing.Point(40, 440);
            this.groupBoxMatrizResultado.Name = "groupBoxMatrizResultado";
            this.groupBoxMatrizResultado.Size = new System.Drawing.Size(478, 173);
            this.groupBoxMatrizResultado.TabIndex = 33;
            this.groupBoxMatrizResultado.TabStop = false;
            this.groupBoxMatrizResultado.Enter += new System.EventHandler(this.groupBoxMatrizResultado_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Matriz Resultante";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.BackgroundImage = global::APE1.Properties.Resources.T33;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBoxMatrizA);
            this.panel1.Controls.Add(this.btMatrizACrear);
            this.panel1.Controls.Add(this.btLimpiarMatrizA);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 352);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 47);
            this.label3.TabIndex = 25;
            this.label3.Text = "MÉTODO DE ITERACIÓN DE JACOBI";
            // 
            // groupBoxMatrizA
            // 
            this.groupBoxMatrizA.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxMatrizA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizA.Location = new System.Drawing.Point(100, 147);
            this.groupBoxMatrizA.Name = "groupBoxMatrizA";
            this.groupBoxMatrizA.Size = new System.Drawing.Size(374, 175);
            this.groupBoxMatrizA.TabIndex = 24;
            this.groupBoxMatrizA.TabStop = false;
            this.groupBoxMatrizA.Text = "Matriz A";
            // 
            // btMatrizACrear
            // 
            this.btMatrizACrear.BackColor = System.Drawing.Color.Peru;
            this.btMatrizACrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMatrizACrear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatrizACrear.Location = new System.Drawing.Point(387, 54);
            this.btMatrizACrear.Name = "btMatrizACrear";
            this.btMatrizACrear.Size = new System.Drawing.Size(116, 38);
            this.btMatrizACrear.TabIndex = 23;
            this.btMatrizACrear.Text = "Crear Matriz";
            this.btMatrizACrear.UseVisualStyleBackColor = false;
            this.btMatrizACrear.Click += new System.EventHandler(this.btMatrizACrear_Click);
            // 
            // btLimpiarMatrizA
            // 
            this.btLimpiarMatrizA.BackColor = System.Drawing.Color.Peru;
            this.btLimpiarMatrizA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpiarMatrizA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarMatrizA.Location = new System.Drawing.Point(387, 98);
            this.btLimpiarMatrizA.Name = "btLimpiarMatrizA";
            this.btLimpiarMatrizA.Size = new System.Drawing.Size(116, 41);
            this.btLimpiarMatrizA.TabIndex = 22;
            this.btLimpiarMatrizA.Text = "Limpiar ";
            this.btLimpiarMatrizA.UseVisualStyleBackColor = false;
            this.btLimpiarMatrizA.Click += new System.EventHandler(this.btLimpiarMatrizA_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(247, 98);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 26);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(247, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 26);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el N. Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese el N. Filas";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::APE1.Properties.Resources.T33;
            this.ClientSize = new System.Drawing.Size(550, 625);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.groupBoxMatrizResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMatrizA;
        private System.Windows.Forms.Button btMatrizACrear;
        private System.Windows.Forms.Button btLimpiarMatrizA;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}