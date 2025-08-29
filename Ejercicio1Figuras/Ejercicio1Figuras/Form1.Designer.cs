namespace Ejercicio1Figuras
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
            btnAgregarFigura = new Button();
            btnQuitar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbCreadas = new ListBox();
            tbRadio = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            tbLargo = new TextBox();
            cbFiguras = new ComboBox();
            SuspendLayout();
            // 
            // btnAgregarFigura
            // 
            btnAgregarFigura.Location = new Point(493, 129);
            btnAgregarFigura.Name = "btnAgregarFigura";
            btnAgregarFigura.Size = new Size(75, 23);
            btnAgregarFigura.TabIndex = 0;
            btnAgregarFigura.Text = "Agregar Figura";
            btnAgregarFigura.UseVisualStyleBackColor = true;
            btnAgregarFigura.Click += btnAgregarFigura_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(398, 343);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "Quitar Figura";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Creación de la figura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Elija el tipo de figura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 110);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Radio :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 164);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Alto :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 110);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 6;
            label5.Text = "Ancho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 161);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 7;
            label6.Text = "Largo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 246);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 8;
            label7.Text = "Figuras Creadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 280);
            label8.Name = "label8";
            label8.Size = new Size(157, 15);
            label8.TabIndex = 9;
            label8.Text = "Elija la Figura para eliminarla";
            label8.Click += label8_Click;
            // 
            // lbCreadas
            // 
            lbCreadas.FormattingEnabled = true;
            lbCreadas.ItemHeight = 15;
            lbCreadas.Location = new Point(34, 314);
            lbCreadas.Name = "lbCreadas";
            lbCreadas.Size = new Size(331, 94);
            lbCreadas.TabIndex = 10;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(225, 107);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(82, 23);
            tbRadio.TabIndex = 11;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(225, 161);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(82, 23);
            tbAlto.TabIndex = 12;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(398, 107);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(79, 23);
            tbAncho.TabIndex = 13;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(398, 158);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(83, 23);
            tbLargo.TabIndex = 14;
            // 
            // cbFiguras
            // 
            cbFiguras.FormattingEnabled = true;
            cbFiguras.Location = new Point(34, 107);
            cbFiguras.Name = "cbFiguras";
            cbFiguras.Size = new Size(121, 23);
            cbFiguras.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbFiguras);
            Controls.Add(tbLargo);
            Controls.Add(tbAncho);
            Controls.Add(tbAlto);
            Controls.Add(tbRadio);
            Controls.Add(lbCreadas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregarFigura);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        public Button btnQuitar;
        public ListBox lbCreadas;
        public Button btnAgregarFigura;
        public ComboBox cbFiguras;
        public TextBox tbRadio;
        public TextBox tbAlto;
        public TextBox tbAncho;
        public TextBox tbLargo;
    }
}
