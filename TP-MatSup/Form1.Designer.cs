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
            this.txtbox_conv = new System.Windows.Forms.TextBox();
            this.label_resul_conv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_convertir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConversion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 136);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConversion
            // 
            this.tabConversion.Controls.Add(this.txtbox_conv);
            this.tabConversion.Controls.Add(this.label_resul_conv);
            this.tabConversion.Controls.Add(this.label1);
            this.tabConversion.Controls.Add(this.boton_convertir);
            this.tabConversion.Location = new System.Drawing.Point(4, 22);
            this.tabConversion.Name = "tabConversion";
            this.tabConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConversion.Size = new System.Drawing.Size(438, 110);
            this.tabConversion.TabIndex = 0;
            this.tabConversion.Text = "Conversión";
            this.tabConversion.UseVisualStyleBackColor = true;
            // 
            // txtbox_conv
            // 
            this.txtbox_conv.Location = new System.Drawing.Point(189, 25);
            this.txtbox_conv.Name = "txtbox_conv";
            this.txtbox_conv.Size = new System.Drawing.Size(100, 20);
            this.txtbox_conv.TabIndex = 2;
            // 
            // label_resul_conv
            // 
            this.label_resul_conv.AutoSize = true;
            this.label_resul_conv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resul_conv.Location = new System.Drawing.Point(16, 71);
            this.label_resul_conv.Name = "label_resul_conv";
            this.label_resul_conv.Size = new System.Drawing.Size(104, 24);
            this.label_resul_conv.TabIndex = 1;
            this.label_resul_conv.Text = "Resultado: ";
            this.label_resul_conv.Visible = false;
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
            // boton_convertir
            // 
            this.boton_convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_convertir.Location = new System.Drawing.Point(317, 14);
            this.boton_convertir.Name = "boton_convertir";
            this.boton_convertir.Size = new System.Drawing.Size(100, 42);
            this.boton_convertir.TabIndex = 0;
            this.boton_convertir.Text = "Convertir";
            this.boton_convertir.UseVisualStyleBackColor = true;
            this.boton_convertir.Click += new System.EventHandler(this.boton_convertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 157);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabConversion.ResumeLayout(false);
            this.tabConversion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConversion;
        private System.Windows.Forms.TextBox txtbox_conv;
        private System.Windows.Forms.Label label_resul_conv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_convertir;
    }
}

