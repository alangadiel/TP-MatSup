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
            this.tabConversion = new System.Windows.Forms.TabPage();
            this.textBoxConv = new System.Windows.Forms.TextBox();
            this.labelResulConv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonConv = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxOB1 = new System.Windows.Forms.TextBox();
            this.labelResulOB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonOB = new System.Windows.Forms.Button();
            this.textBoxOB2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOB = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabConversion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConversion);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 212);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConversion
            // 
            this.tabConversion.Controls.Add(this.textBoxConv);
            this.tabConversion.Controls.Add(this.labelResulConv);
            this.tabConversion.Controls.Add(this.label1);
            this.tabConversion.Controls.Add(this.botonConv);
            this.tabConversion.Location = new System.Drawing.Point(4, 22);
            this.tabConversion.Name = "tabConversion";
            this.tabConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConversion.Size = new System.Drawing.Size(438, 186);
            this.tabConversion.TabIndex = 0;
            this.tabConversion.Text = "Conversión";
            this.tabConversion.UseVisualStyleBackColor = true;
            // 
            // textBoxConv
            // 
            this.textBoxConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConv.Location = new System.Drawing.Point(189, 20);
            this.textBoxConv.Name = "textBoxConv";
            this.textBoxConv.Size = new System.Drawing.Size(116, 26);
            this.textBoxConv.TabIndex = 2;
            // 
            // labelResulConv
            // 
            this.labelResulConv.AutoSize = true;
            this.labelResulConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResulConv.Location = new System.Drawing.Point(16, 148);
            this.labelResulConv.Name = "labelResulConv";
            this.labelResulConv.Size = new System.Drawing.Size(104, 24);
            this.labelResulConv.TabIndex = 1;
            this.labelResulConv.Text = "Resultado: ";
            this.labelResulConv.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero complejo:";
            // 
            // botonConv
            // 
            this.botonConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConv.Location = new System.Drawing.Point(323, 130);
            this.botonConv.Name = "botonConv";
            this.botonConv.Size = new System.Drawing.Size(100, 42);
            this.botonConv.TabIndex = 0;
            this.botonConv.Text = "Convertir";
            this.botonConv.UseVisualStyleBackColor = true;
            this.botonConv.Click += new System.EventHandler(this.BotonConvClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxOB);
            this.tabPage1.Controls.Add(this.textBoxOB2);
            this.tabPage1.Controls.Add(this.textBoxOB1);
            this.tabPage1.Controls.Add(this.labelResulOB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.botonOB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 186);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Operaciones Basicas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxOB1
            // 
            this.textBoxOB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOB1.Location = new System.Drawing.Point(218, 18);
            this.textBoxOB1.Name = "textBoxOB1";
            this.textBoxOB1.Size = new System.Drawing.Size(116, 26);
            this.textBoxOB1.TabIndex = 6;
            // 
            // labelResulOB
            // 
            this.labelResulOB.AutoSize = true;
            this.labelResulOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResulOB.Location = new System.Drawing.Point(16, 145);
            this.labelResulOB.Name = "labelResulOB";
            this.labelResulOB.Size = new System.Drawing.Size(104, 24);
            this.labelResulOB.TabIndex = 4;
            this.labelResulOB.Text = "Resultado: ";
            this.labelResulOB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numeros complejos:";
            // 
            // botonOB
            // 
            this.botonOB.Enabled = false;
            this.botonOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOB.Location = new System.Drawing.Point(323, 136);
            this.botonOB.Name = "botonOB";
            this.botonOB.Size = new System.Drawing.Size(100, 42);
            this.botonOB.TabIndex = 3;
            this.botonOB.Text = "Operar";
            this.botonOB.UseVisualStyleBackColor = true;
            this.botonOB.Click += new System.EventHandler(this.BotonOBClick);
            // 
            // textBoxOB2
            // 
            this.textBoxOB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOB2.Location = new System.Drawing.Point(218, 50);
            this.textBoxOB2.Name = "textBoxOB2";
            this.textBoxOB2.Size = new System.Drawing.Size(116, 26);
            this.textBoxOB2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operacion:";
            // 
            // comboBoxOB
            // 
            this.comboBoxOB.FormattingEnabled = true;
            this.comboBoxOB.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "Cociente"});
            this.comboBoxOB.Location = new System.Drawing.Point(218, 88);
            this.comboBoxOB.Name = "comboBoxOB";
            this.comboBoxOB.Size = new System.Drawing.Size(116, 21);
            this.comboBoxOB.TabIndex = 7;
            this.comboBoxOB.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 236);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabConversion.ResumeLayout(false);
            this.tabConversion.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConversion;
        private System.Windows.Forms.TextBox textBoxConv;
        private System.Windows.Forms.Label labelResulConv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonConv;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxOB1;
        private System.Windows.Forms.Label labelResulOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonOB;
        private System.Windows.Forms.ComboBox comboBoxOB;
        private System.Windows.Forms.TextBox textBoxOB2;
        private System.Windows.Forms.Label label4;
    }
}

