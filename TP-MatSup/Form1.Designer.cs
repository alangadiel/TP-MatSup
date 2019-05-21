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
            this.comboBoxOB = new System.Windows.Forms.ComboBox();
            this.textBoxOB2 = new System.Windows.Forms.TextBox();
            this.textBoxOB1 = new System.Windows.Forms.TextBox();
            this.labelResulOB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonOB = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxOA = new System.Windows.Forms.ListBox();
            this.comboBoxOA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonOA = new System.Windows.Forms.Button();
            this.textBoxOA2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOA1 = new System.Windows.Forms.TextBox();
            this.labelResulOA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxFrec2 = new System.Windows.Forms.TextBox();
            this.textBoxFase1 = new System.Windows.Forms.TextBox();
            this.textBoxFase2 = new System.Windows.Forms.TextBox();
            this.textBoxFrec1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxFun2 = new System.Windows.Forms.ComboBox();
            this.comboBoxFun1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAmp2 = new System.Windows.Forms.TextBox();
            this.textBoxAmp1 = new System.Windows.Forms.TextBox();
            this.labelResulSF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.botonSF = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabConversion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConversion);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 212);
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
            this.tabConversion.Size = new System.Drawing.Size(497, 186);
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
            this.textBoxConv.TabIndex = 0;
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
            this.botonConv.TabIndex = 1;
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
            this.tabPage1.Size = new System.Drawing.Size(497, 186);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Operaciones Basicas";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.comboBoxOB.TabIndex = 2;
            // 
            // textBoxOB2
            // 
            this.textBoxOB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOB2.Location = new System.Drawing.Point(218, 50);
            this.textBoxOB2.Name = "textBoxOB2";
            this.textBoxOB2.Size = new System.Drawing.Size(116, 26);
            this.textBoxOB2.TabIndex = 1;
            // 
            // textBoxOB1
            // 
            this.textBoxOB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOB1.Location = new System.Drawing.Point(218, 18);
            this.textBoxOB1.Name = "textBoxOB1";
            this.textBoxOB1.Size = new System.Drawing.Size(116, 26);
            this.textBoxOB1.TabIndex = 0;
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
            this.botonOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOB.Location = new System.Drawing.Point(323, 136);
            this.botonOB.Name = "botonOB";
            this.botonOB.Size = new System.Drawing.Size(100, 42);
            this.botonOB.TabIndex = 3;
            this.botonOB.Text = "Operar";
            this.botonOB.UseVisualStyleBackColor = true;
            this.botonOB.Click += new System.EventHandler(this.BotonOBClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxOA);
            this.tabPage2.Controls.Add(this.comboBoxOA);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.botonOA);
            this.tabPage2.Controls.Add(this.textBoxOA2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxOA1);
            this.tabPage2.Controls.Add(this.labelResulOA);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 186);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Operaciones Avanzadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxOA
            // 
            this.listBoxOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOA.FormattingEnabled = true;
            this.listBoxOA.ItemHeight = 18;
            this.listBoxOA.Location = new System.Drawing.Point(126, 147);
            this.listBoxOA.Name = "listBoxOA";
            this.listBoxOA.Size = new System.Drawing.Size(259, 22);
            this.listBoxOA.TabIndex = 12;
            this.listBoxOA.Visible = false;
            // 
            // comboBoxOA
            // 
            this.comboBoxOA.FormattingEnabled = true;
            this.comboBoxOA.Items.AddRange(new object[] {
            "Potencia",
            "Radicacion"});
            this.comboBoxOA.Location = new System.Drawing.Point(189, 92);
            this.comboBoxOA.Name = "comboBoxOA";
            this.comboBoxOA.Size = new System.Drawing.Size(116, 21);
            this.comboBoxOA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operacion:";
            // 
            // botonOA
            // 
            this.botonOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOA.Location = new System.Drawing.Point(391, 136);
            this.botonOA.Name = "botonOA";
            this.botonOA.Size = new System.Drawing.Size(100, 42);
            this.botonOA.TabIndex = 3;
            this.botonOA.Text = "Operar";
            this.botonOA.UseVisualStyleBackColor = true;
            this.botonOA.Click += new System.EventHandler(this.BotonOA_Click);
            // 
            // textBoxOA2
            // 
            this.textBoxOA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOA2.Location = new System.Drawing.Point(189, 56);
            this.textBoxOA2.Name = "textBoxOA2";
            this.textBoxOA2.Size = new System.Drawing.Size(116, 26);
            this.textBoxOA2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numero natural: ";
            // 
            // textBoxOA1
            // 
            this.textBoxOA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOA1.Location = new System.Drawing.Point(189, 17);
            this.textBoxOA1.Name = "textBoxOA1";
            this.textBoxOA1.Size = new System.Drawing.Size(116, 26);
            this.textBoxOA1.TabIndex = 0;
            // 
            // labelResulOA
            // 
            this.labelResulOA.AutoSize = true;
            this.labelResulOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResulOA.Location = new System.Drawing.Point(16, 145);
            this.labelResulOA.Name = "labelResulOA";
            this.labelResulOA.Size = new System.Drawing.Size(104, 24);
            this.labelResulOA.TabIndex = 4;
            this.labelResulOA.Text = "Resultado: ";
            this.labelResulOA.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero complejo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxFrec2);
            this.tabPage3.Controls.Add(this.textBoxFase1);
            this.tabPage3.Controls.Add(this.textBoxFase2);
            this.tabPage3.Controls.Add(this.textBoxFrec1);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboBoxFun2);
            this.tabPage3.Controls.Add(this.comboBoxFun1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxAmp2);
            this.tabPage3.Controls.Add(this.textBoxAmp1);
            this.tabPage3.Controls.Add(this.labelResulSF);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.botonSF);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(497, 186);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Suma Fasores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxFrec2
            // 
            this.textBoxFrec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrec2.Location = new System.Drawing.Point(183, 74);
            this.textBoxFrec2.Name = "textBoxFrec2";
            this.textBoxFrec2.Size = new System.Drawing.Size(61, 26);
            this.textBoxFrec2.TabIndex = 6;
            // 
            // textBoxFase1
            // 
            this.textBoxFase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFase1.Location = new System.Drawing.Point(296, 42);
            this.textBoxFase1.Name = "textBoxFase1";
            this.textBoxFase1.Size = new System.Drawing.Size(61, 26);
            this.textBoxFase1.TabIndex = 3;
            // 
            // textBoxFase2
            // 
            this.textBoxFase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFase2.Location = new System.Drawing.Point(296, 74);
            this.textBoxFase2.Name = "textBoxFase2";
            this.textBoxFase2.Size = new System.Drawing.Size(61, 26);
            this.textBoxFase2.TabIndex = 7;
            // 
            // textBoxFrec1
            // 
            this.textBoxFrec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrec1.Location = new System.Drawing.Point(183, 42);
            this.textBoxFrec1.Name = "textBoxFrec1";
            this.textBoxFrec1.Size = new System.Drawing.Size(61, 26);
            this.textBoxFrec1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(161, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "(";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(250, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "* t +";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(250, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "* t +";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(363, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 24);
            this.label16.TabIndex = 18;
            this.label16.Text = ")";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(363, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = ")";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "(";
            // 
            // comboBoxFun2
            // 
            this.comboBoxFun2.FormattingEnabled = true;
            this.comboBoxFun2.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "Cociente"});
            this.comboBoxFun2.Location = new System.Drawing.Point(108, 77);
            this.comboBoxFun2.Name = "comboBoxFun2";
            this.comboBoxFun2.Size = new System.Drawing.Size(47, 21);
            this.comboBoxFun2.TabIndex = 5;
            // 
            // comboBoxFun1
            // 
            this.comboBoxFun1.FormattingEnabled = true;
            this.comboBoxFun1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "Cociente"});
            this.comboBoxFun1.Location = new System.Drawing.Point(108, 43);
            this.comboBoxFun1.Name = "comboBoxFun1";
            this.comboBoxFun1.Size = new System.Drawing.Size(47, 21);
            this.comboBoxFun1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // textBoxAmp2
            // 
            this.textBoxAmp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmp2.Location = new System.Drawing.Point(20, 72);
            this.textBoxAmp2.Name = "textBoxAmp2";
            this.textBoxAmp2.Size = new System.Drawing.Size(61, 26);
            this.textBoxAmp2.TabIndex = 4;
            // 
            // textBoxAmp1
            // 
            this.textBoxAmp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmp1.HideSelection = false;
            this.textBoxAmp1.Location = new System.Drawing.Point(20, 40);
            this.textBoxAmp1.Name = "textBoxAmp1";
            this.textBoxAmp1.Size = new System.Drawing.Size(61, 26);
            this.textBoxAmp1.TabIndex = 0;
            // 
            // labelResulSF
            // 
            this.labelResulSF.AutoSize = true;
            this.labelResulSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResulSF.Location = new System.Drawing.Point(16, 140);
            this.labelResulSF.Name = "labelResulSF";
            this.labelResulSF.Size = new System.Drawing.Size(104, 24);
            this.labelResulSF.TabIndex = 9;
            this.labelResulSF.Text = "Resultado: ";
            this.labelResulSF.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Funciones:";
            // 
            // botonSF
            // 
            this.botonSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSF.Location = new System.Drawing.Point(323, 131);
            this.botonSF.Name = "botonSF";
            this.botonSF.Size = new System.Drawing.Size(100, 42);
            this.botonSF.TabIndex = 8;
            this.botonSF.Text = "Sumar";
            this.botonSF.UseVisualStyleBackColor = true;
            this.botonSF.Click += new System.EventHandler(this.BotonSF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 236);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabConversion.ResumeLayout(false);
            this.tabConversion.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxOA2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOA1;
        private System.Windows.Forms.Label labelResulOA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonOA;
        private System.Windows.Forms.ListBox listBoxOA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxFase2;
        private System.Windows.Forms.TextBox textBoxFrec1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxFun2;
        private System.Windows.Forms.ComboBox comboBoxFun1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAmp2;
        private System.Windows.Forms.TextBox textBoxAmp1;
        private System.Windows.Forms.Label labelResulSF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botonSF;
        private System.Windows.Forms.TextBox textBoxFrec2;
        private System.Windows.Forms.TextBox textBoxFase1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

