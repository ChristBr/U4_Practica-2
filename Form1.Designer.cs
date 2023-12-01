namespace U4_Practica_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            txtPapas = new TextBox();
            txtRefresco = new TextBox();
            txtTe = new TextBox();
            txtSandwich = new TextBox();
            txtHotdog = new TextBox();
            txtHamburguesa = new TextBox();
            label1 = new Label();
            txtTotal = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(33, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selección por pedidos";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(9, 126);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(112, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(9, 96);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(233, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "#3 (Sandwich, Refresco, Papas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(9, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(224, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "#2 (HotDog, Refresco, Papas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(9, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(263, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "#1 (Hamburguesa, Refresco, Papas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtPapas);
            groupBox2.Controls.Add(txtRefresco);
            groupBox2.Controls.Add(txtTe);
            groupBox2.Controls.Add(txtSandwich);
            groupBox2.Controls.Add(txtHotdog);
            groupBox2.Controls.Add(txtHamburguesa);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(324, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alimentos seleccionados";
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(6, 325);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(91, 27);
            txtPapas.TabIndex = 7;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(6, 274);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(91, 27);
            txtRefresco.TabIndex = 6;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(6, 216);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(91, 27);
            txtTe.TabIndex = 4;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(6, 160);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(91, 27);
            txtSandwich.TabIndex = 3;
            // 
            // txtHotdog
            // 
            txtHotdog.Location = new Point(6, 110);
            txtHotdog.Name = "txtHotdog";
            txtHotdog.Size = new Size(91, 27);
            txtHotdog.TabIndex = 2;
            // 
            // txtHamburguesa
            // 
            txtHamburguesa.Location = new Point(6, 60);
            txtHamburguesa.Name = "txtHamburguesa";
            txtHamburguesa.Size = new Size(91, 27);
            txtHamburguesa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(77, 237);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 201);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Total a cobrar";
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 308);
            button1.Name = "button1";
            button1.Size = new Size(130, 62);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(163, 309);
            button2.Name = "button2";
            button2.Size = new Size(129, 61);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 63);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 8;
            label3.Text = "Hamburguesa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 113);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 9;
            label4.Text = "HotDog";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 163);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Sandwich";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 219);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 11;
            label6.Text = "Te";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 277);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "Refresco";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 328);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 13;
            label8.Text = "Papas fritas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(212, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(221, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.AccessibleRole = AccessibleRole.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(221, 89);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(221, 145);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(221, 201);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(221, 257);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(221, 310);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(630, 409);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cobro de servicio de comida";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private TextBox txtPapas;
        private TextBox txtRefresco;
        private TextBox txtTe;
        private TextBox txtSandwich;
        private TextBox txtHotdog;
        private TextBox txtHamburguesa;
        private Label label1;
        private TextBox txtTotal;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
    }
}