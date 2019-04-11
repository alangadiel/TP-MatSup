namespace TP_MatSup
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPolar = new System.Windows.Forms.TabPage();
            this.boton_a_polar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.tabBinomico = new System.Windows.Forms.TabPage();
            this.label_resul_a_polar = new System.Windows.Forms.Label();
            this.txt_angulo = new System.Windows.Forms.TextBox();
            this.txt_radio = new System.Windows.Forms.TextBox();
            this.label_res_a_binomico = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boton_a_binomico = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPolar.SuspendLayout();
            this.tabBinomico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBinomico);
            this.tabControl1.Controls.Add(this.tabPolar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPolar
            // 
            this.tabPolar.Controls.Add(this.txt_angulo);
            this.tabPolar.Controls.Add(this.txt_radio);
            this.tabPolar.Controls.Add(this.label_res_a_binomico);
            this.tabPolar.Controls.Add(this.label4);
            this.tabPolar.Controls.Add(this.label5);
            this.tabPolar.Controls.Add(this.boton_a_binomico);
            this.tabPolar.Location = new System.Drawing.Point(4, 22);
            this.tabPolar.Name = "tabPolar";
            this.tabPolar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPolar.Size = new System.Drawing.Size(438, 144);
            this.tabPolar.TabIndex = 1;
            this.tabPolar.Text = "Polar";
            this.tabPolar.UseVisualStyleBackColor = true;
            // 
            // boton_a_polar
            // 
            this.boton_a_polar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_a_polar.Location = new System.Drawing.Point(317, 14);
            this.boton_a_polar.Name = "boton_a_polar";
            this.boton_a_polar.Size = new System.Drawing.Size(100, 68);
            this.boton_a_polar.TabIndex = 0;
            this.boton_a_polar.Text = "Convertir A Polar";
            this.boton_a_polar.UseVisualStyleBackColor = true;
            this.boton_a_polar.Click += new System.EventHandler(this.boton_a_polar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parte Real: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parte Imaginaria: ";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(128, 24);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 2;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(176, 58);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(100, 20);
            this.txtImg.TabIndex = 2;
            // 
            // tabBinomico
            // 
            this.tabBinomico.Controls.Add(this.txtImg);
            this.tabBinomico.Controls.Add(this.txtReal);
            this.tabBinomico.Controls.Add(this.label_resul_a_polar);
            this.tabBinomico.Controls.Add(this.label2);
            this.tabBinomico.Controls.Add(this.label1);
            this.tabBinomico.Controls.Add(this.boton_a_polar);
            this.tabBinomico.Location = new System.Drawing.Point(4, 22);
            this.tabBinomico.Name = "tabBinomico";
            this.tabBinomico.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinomico.Size = new System.Drawing.Size(438, 144);
            this.tabBinomico.TabIndex = 0;
            this.tabBinomico.Text = "Binomico";
            this.tabBinomico.UseVisualStyleBackColor = true;
            this.tabBinomico.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label_resul_a_polar
            // 
            this.label_resul_a_polar.AutoSize = true;
            this.label_resul_a_polar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resul_a_polar.Location = new System.Drawing.Point(18, 96);
            this.label_resul_a_polar.Name = "label_resul_a_polar";
            this.label_resul_a_polar.Size = new System.Drawing.Size(104, 24);
            this.label_resul_a_polar.TabIndex = 1;
            this.label_resul_a_polar.Text = "Resultado: ";
            this.label_resul_a_polar.Visible = false;
            // 
            // txt_angulo
            // 
            this.txt_angulo.Location = new System.Drawing.Point(106, 63);
            this.txt_angulo.Name = "txt_angulo";
            this.txt_angulo.Size = new System.Drawing.Size(100, 20);
            this.txt_angulo.TabIndex = 7;
            // 
            // txt_radio
            // 
            this.txt_radio.Location = new System.Drawing.Point(94, 29);
            this.txt_radio.Name = "txt_radio";
            this.txt_radio.Size = new System.Drawing.Size(100, 20);
            this.txt_radio.TabIndex = 8;
            // 
            // label_res_a_binomico
            // 
            this.label_res_a_binomico.AutoSize = true;
            this.label_res_a_binomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_res_a_binomico.Location = new System.Drawing.Point(21, 101);
            this.label_res_a_binomico.Name = "label_res_a_binomico";
            this.label_res_a_binomico.Size = new System.Drawing.Size(104, 24);
            this.label_res_a_binomico.TabIndex = 4;
            this.label_res_a_binomico.Text = "Resultado: ";
            this.label_res_a_binomico.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Angulo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Radio: ";
            // 
            // boton_a_binomico
            // 
            this.boton_a_binomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_a_binomico.Location = new System.Drawing.Point(305, 19);
            this.boton_a_binomico.Name = "boton_a_binomico";
            this.boton_a_binomico.Size = new System.Drawing.Size(115, 68);
            this.boton_a_binomico.TabIndex = 3;
            this.boton_a_binomico.Text = "Convertir A Binomico";
            this.boton_a_binomico.UseVisualStyleBackColor = true;
            this.boton_a_binomico.Click += new System.EventHandler(this.boton_a_binomico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 195);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPolar.ResumeLayout(false);
            this.tabPolar.PerformLayout();
            this.tabBinomico.ResumeLayout(false);
            this.tabBinomico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPolar;
        private System.Windows.Forms.TabPage tabBinomico;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label label_resul_a_polar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_a_polar;
        private System.Windows.Forms.TextBox txt_angulo;
        private System.Windows.Forms.TextBox txt_radio;
        private System.Windows.Forms.Label label_res_a_binomico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_a_binomico;
    }
}

