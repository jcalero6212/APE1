namespace APE1
{
    partial class Ejercicio1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMatrizResultado = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btMultiMatrices = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMatrizB = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrizA = new System.Windows.Forms.GroupBox();
            this.btMatrizACrear = new System.Windows.Forms.Button();
            this.btLimpiarMatrizA = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.BackgroundImage = global::APE1.Properties.Resources.a1_1;
            this.panel1.Controls.Add(this.groupBoxMatrizResultado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.btMultiMatrices);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 643);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMatrizResultado
            // 
            this.groupBoxMatrizResultado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxMatrizResultado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizResultado.Location = new System.Drawing.Point(64, 407);
            this.groupBoxMatrizResultado.Name = "groupBoxMatrizResultado";
            this.groupBoxMatrizResultado.Size = new System.Drawing.Size(478, 199);
            this.groupBoxMatrizResultado.TabIndex = 31;
            this.groupBoxMatrizResultado.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Matriz Resultante";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SkyBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(574, 463);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 48);
            this.button9.TabIndex = 29;
            this.button9.Text = "Limpiar ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btMultiMatrices
            // 
            this.btMultiMatrices.BackColor = System.Drawing.Color.SkyBlue;
            this.btMultiMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMultiMatrices.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiMatrices.Location = new System.Drawing.Point(574, 407);
            this.btMultiMatrices.Name = "btMultiMatrices";
            this.btMultiMatrices.Size = new System.Drawing.Size(63, 50);
            this.btMultiMatrices.TabIndex = 27;
            this.btMultiMatrices.Text = "*";
            this.btMultiMatrices.UseVisualStyleBackColor = false;
            this.btMultiMatrices.Click += new System.EventHandler(this.btMultiMatrices_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Violet;
            this.panel3.BackgroundImage = global::APE1.Properties.Resources.a1_1;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.groupBoxMatrizB);
            this.panel3.Controls.Add(this.groupBoxMatrizA);
            this.panel3.Controls.Add(this.btMatrizACrear);
            this.panel3.Controls.Add(this.btLimpiarMatrizA);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, -9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 377);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 47);
            this.label3.TabIndex = 18;
            this.label3.Text = "MULTIPLICACIÓN DE MATRICES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxMatrizB
            // 
            this.groupBoxMatrizB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxMatrizB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMatrizB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizB.Location = new System.Drawing.Point(373, 154);
            this.groupBoxMatrizB.Name = "groupBoxMatrizB";
            this.groupBoxMatrizB.Size = new System.Drawing.Size(331, 210);
            this.groupBoxMatrizB.TabIndex = 17;
            this.groupBoxMatrizB.TabStop = false;
            this.groupBoxMatrizB.Text = "Matriz B";
            // 
            // groupBoxMatrizA
            // 
            this.groupBoxMatrizA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxMatrizA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMatrizA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizA.Location = new System.Drawing.Point(33, 154);
            this.groupBoxMatrizA.Name = "groupBoxMatrizA";
            this.groupBoxMatrizA.Size = new System.Drawing.Size(321, 210);
            this.groupBoxMatrizA.TabIndex = 15;
            this.groupBoxMatrizA.TabStop = false;
            this.groupBoxMatrizA.Text = "Matriz A";
            this.groupBoxMatrizA.Enter += new System.EventHandler(this.groupBoxMatrizA_Enter);
            // 
            // btMatrizACrear
            // 
            this.btMatrizACrear.BackColor = System.Drawing.Color.SkyBlue;
            this.btMatrizACrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMatrizACrear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatrizACrear.Location = new System.Drawing.Point(373, 66);
            this.btMatrizACrear.Name = "btMatrizACrear";
            this.btMatrizACrear.Size = new System.Drawing.Size(129, 38);
            this.btMatrizACrear.TabIndex = 14;
            this.btMatrizACrear.Text = "Crear Matriz";
            this.btMatrizACrear.UseVisualStyleBackColor = false;
            this.btMatrizACrear.Click += new System.EventHandler(this.btMatrizACrear_Click);
            // 
            // btLimpiarMatrizA
            // 
            this.btLimpiarMatrizA.BackColor = System.Drawing.Color.SkyBlue;
            this.btLimpiarMatrizA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpiarMatrizA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarMatrizA.Location = new System.Drawing.Point(373, 110);
            this.btLimpiarMatrizA.Name = "btLimpiarMatrizA";
            this.btLimpiarMatrizA.Size = new System.Drawing.Size(129, 38);
            this.btLimpiarMatrizA.TabIndex = 13;
            this.btLimpiarMatrizA.Text = "Limpiar ";
            this.btLimpiarMatrizA.UseVisualStyleBackColor = false;
            this.btLimpiarMatrizA.Click += new System.EventHandler(this.btLimpiarMatrizA_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(254, 98);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 26);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(254, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el N. Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el N. Filas";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 636);
            this.Controls.Add(this.panel1);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btMultiMatrices;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxMatrizB;
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