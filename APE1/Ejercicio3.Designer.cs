namespace APE1
{
    partial class Ejercicio3
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxMatrizA = new System.Windows.Forms.GroupBox();
            this.btMatrizACrear = new System.Windows.Forms.Button();
            this.btLimpiarMatrizA = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrtogonalidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMatrizResultadoR = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.groupBoxMatrizResultadoQ = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::APE1.Properties.Resources.C2;
            this.panel1.Controls.Add(this.lblOrtogonalidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBoxMatrizA);
            this.panel1.Controls.Add(this.btMatrizACrear);
            this.panel1.Controls.Add(this.btLimpiarMatrizA);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 415);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 47);
            this.label4.TabIndex = 25;
            this.label4.Text = "DESCOMPOSICION QR";
            // 
            // groupBoxMatrizA
            // 
            this.groupBoxMatrizA.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBoxMatrizA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMatrizA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizA.Location = new System.Drawing.Point(108, 177);
            this.groupBoxMatrizA.Name = "groupBoxMatrizA";
            this.groupBoxMatrizA.Size = new System.Drawing.Size(374, 208);
            this.groupBoxMatrizA.TabIndex = 24;
            this.groupBoxMatrizA.TabStop = false;
            this.groupBoxMatrizA.Text = "Matriz A";
            // 
            // btMatrizACrear
            // 
            this.btMatrizACrear.BackColor = System.Drawing.Color.YellowGreen;
            this.btMatrizACrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMatrizACrear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatrizACrear.Location = new System.Drawing.Point(387, 74);
            this.btMatrizACrear.Name = "btMatrizACrear";
            this.btMatrizACrear.Size = new System.Drawing.Size(111, 38);
            this.btMatrizACrear.TabIndex = 23;
            this.btMatrizACrear.Text = "Crear Matriz";
            this.btMatrizACrear.UseVisualStyleBackColor = false;
            this.btMatrizACrear.Click += new System.EventHandler(this.btMatrizACrear_Click_1);
            // 
            // btLimpiarMatrizA
            // 
            this.btLimpiarMatrizA.BackColor = System.Drawing.Color.YellowGreen;
            this.btLimpiarMatrizA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpiarMatrizA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarMatrizA.Location = new System.Drawing.Point(387, 118);
            this.btLimpiarMatrizA.Name = "btLimpiarMatrizA";
            this.btLimpiarMatrizA.Size = new System.Drawing.Size(111, 38);
            this.btLimpiarMatrizA.TabIndex = 22;
            this.btLimpiarMatrizA.Text = "Limpiar ";
            this.btLimpiarMatrizA.UseVisualStyleBackColor = false;
            this.btLimpiarMatrizA.Click += new System.EventHandler(this.btLimpiarMatrizA_Click_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(247, 126);
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
            this.numericUpDown1.Location = new System.Drawing.Point(247, 82);
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
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el N. Columnas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese el N. Filas";
            // 
            // lblOrtogonalidad
            // 
            this.lblOrtogonalidad.AutoSize = true;
            this.lblOrtogonalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrtogonalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrtogonalidad.Location = new System.Drawing.Point(244, 397);
            this.lblOrtogonalidad.Name = "lblOrtogonalidad";
            this.lblOrtogonalidad.Size = new System.Drawing.Size(18, 18);
            this.lblOrtogonalidad.TabIndex = 47;
            this.lblOrtogonalidad.Text = "* ";
            this.lblOrtogonalidad.Click += new System.EventHandler(this.lblOrtogonalidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "A = QR ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBoxMatrizResultadoR
            // 
            this.groupBoxMatrizResultadoR.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBoxMatrizResultadoR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMatrizResultadoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizResultadoR.Location = new System.Drawing.Point(319, 498);
            this.groupBoxMatrizResultadoR.Name = "groupBoxMatrizResultadoR";
            this.groupBoxMatrizResultadoR.Size = new System.Drawing.Size(226, 144);
            this.groupBoxMatrizResultadoR.TabIndex = 45;
            this.groupBoxMatrizResultadoR.TabStop = false;
            this.groupBoxMatrizResultadoR.Text = "Resolucion R";
            this.groupBoxMatrizResultadoR.Enter += new System.EventHandler(this.groupBoxMatrizResultadoR_Enter);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.YellowGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(431, 431);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 38);
            this.button9.TabIndex = 44;
            this.button9.Text = "Limpiar ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRespuesta.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta.Location = new System.Drawing.Point(248, 431);
            this.btnRespuesta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(178, 37);
            this.btnRespuesta.TabIndex = 43;
            this.btnRespuesta.Text = "Generar Respuesta";
            this.btnRespuesta.UseVisualStyleBackColor = false;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // groupBoxMatrizResultadoQ
            // 
            this.groupBoxMatrizResultadoQ.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBoxMatrizResultadoQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMatrizResultadoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMatrizResultadoQ.Location = new System.Drawing.Point(82, 498);
            this.groupBoxMatrizResultadoQ.Name = "groupBoxMatrizResultadoQ";
            this.groupBoxMatrizResultadoQ.Size = new System.Drawing.Size(226, 144);
            this.groupBoxMatrizResultadoQ.TabIndex = 42;
            this.groupBoxMatrizResultadoQ.TabStop = false;
            this.groupBoxMatrizResultadoQ.Text = "Resolucion Q";
            this.groupBoxMatrizResultadoQ.Enter += new System.EventHandler(this.groupBoxMatrizResultadoQ_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Matriz Resultante";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::APE1.Properties.Resources.C2;
            this.ClientSize = new System.Drawing.Size(557, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxMatrizResultadoR);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.groupBoxMatrizResultadoQ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMatrizA;
        private System.Windows.Forms.Button btMatrizACrear;
        private System.Windows.Forms.Button btLimpiarMatrizA;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrtogonalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultadoR;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultadoQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}