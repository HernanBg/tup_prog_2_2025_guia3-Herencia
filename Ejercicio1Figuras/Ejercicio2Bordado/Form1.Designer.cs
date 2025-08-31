namespace Ejercicio2Bordado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnIniciarMaquina = new Button();
            btnAgregarMotivo = new Button();
            btnReiniciarMaquina = new Button();
            lstMotivosDisponibles = new ListBox();
            lstMotivosAgregados = new ListBox();
            btnDarPuntada = new Button();
            txtPanelPuntadas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Elegir Motivo de Bordado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 1;
            label2.Text = "Tipos Motivos   \r\ndisponibles\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 83);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 2;
            label3.Text = "Motivos agregados a \r\nla maquina\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 60);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 3;
            label4.Text = "Operación maquina";
            // 
            // btnIniciarMaquina
            // 
            btnIniciarMaquina.Location = new Point(220, 146);
            btnIniciarMaquina.Name = "btnIniciarMaquina";
            btnIniciarMaquina.Size = new Size(91, 66);
            btnIniciarMaquina.TabIndex = 5;
            btnIniciarMaquina.Text = "Iniciar Maquina";
            btnIniciarMaquina.UseVisualStyleBackColor = true;
            btnIniciarMaquina.Click += button1_Click;
            // 
            // btnAgregarMotivo
            // 
            btnAgregarMotivo.Location = new Point(220, 233);
            btnAgregarMotivo.Name = "btnAgregarMotivo";
            btnAgregarMotivo.Size = new Size(91, 64);
            btnAgregarMotivo.TabIndex = 6;
            btnAgregarMotivo.Text = "Agregar Motivo a la maquina";
            btnAgregarMotivo.UseVisualStyleBackColor = true;
            btnAgregarMotivo.Click += button2_Click;
            // 
            // btnReiniciarMaquina
            // 
            btnReiniciarMaquina.Location = new Point(220, 323);
            btnReiniciarMaquina.Name = "btnReiniciarMaquina";
            btnReiniciarMaquina.Size = new Size(91, 67);
            btnReiniciarMaquina.TabIndex = 7;
            btnReiniciarMaquina.Text = "Reiniciar Maquina";
            btnReiniciarMaquina.UseVisualStyleBackColor = true;
            // 
            // lstMotivosDisponibles
            // 
            lstMotivosDisponibles.FormattingEnabled = true;
            lstMotivosDisponibles.ItemHeight = 15;
            lstMotivosDisponibles.Location = new Point(26, 134);
            lstMotivosDisponibles.Name = "lstMotivosDisponibles";
            lstMotivosDisponibles.Size = new Size(162, 274);
            lstMotivosDisponibles.TabIndex = 8;
            lstMotivosDisponibles.SelectedIndexChanged += lstMotivosDisponibles_SelectedIndexChanged;
            // 
            // lstMotivosAgregados
            // 
            lstMotivosAgregados.FormattingEnabled = true;
            lstMotivosAgregados.ItemHeight = 15;
            lstMotivosAgregados.Location = new Point(337, 134);
            lstMotivosAgregados.Name = "lstMotivosAgregados";
            lstMotivosAgregados.Size = new Size(146, 274);
            lstMotivosAgregados.TabIndex = 9;
            // 
            // btnDarPuntada
            // 
            btnDarPuntada.Location = new Point(529, 90);
            btnDarPuntada.Name = "btnDarPuntada";
            btnDarPuntada.Size = new Size(120, 23);
            btnDarPuntada.TabIndex = 10;
            btnDarPuntada.Text = "Dar puntada";
            btnDarPuntada.UseVisualStyleBackColor = true;
            btnDarPuntada.Click += btnDarPuntada_Click;
            // 
            // txtPanelPuntadas
            // 
            txtPanelPuntadas.Location = new Point(529, 134);
            txtPanelPuntadas.Multiline = true;
            txtPanelPuntadas.Name = "txtPanelPuntadas";
            txtPanelPuntadas.Size = new Size(156, 274);
            txtPanelPuntadas.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPanelPuntadas);
            Controls.Add(btnDarPuntada);
            Controls.Add(lstMotivosAgregados);
            Controls.Add(lstMotivosDisponibles);
            Controls.Add(btnReiniciarMaquina);
            Controls.Add(btnAgregarMotivo);
            Controls.Add(btnIniciarMaquina);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ListBox lstMotivosDisponibles;
        public Button btnIniciarMaquina;
        public Button btnAgregarMotivo;
        public Button btnReiniciarMaquina;
        public Button btnDarPuntada;
        public ListBox lstMotivosAgregados;
        public TextBox txtPanelPuntadas;
    }
}
