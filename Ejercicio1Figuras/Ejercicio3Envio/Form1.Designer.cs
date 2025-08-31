namespace Ejercicio3Envio
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
            btnAltaEnvio = new Button();
            btnListarEnvios = new Button();
            txtListado = new TextBox();
            SuspendLayout();
            // 
            // btnAltaEnvio
            // 
            btnAltaEnvio.Location = new Point(575, 73);
            btnAltaEnvio.Name = "btnAltaEnvio";
            btnAltaEnvio.Size = new Size(168, 97);
            btnAltaEnvio.TabIndex = 0;
            btnAltaEnvio.Text = "Alta Envio";
            btnAltaEnvio.UseVisualStyleBackColor = true;
            btnAltaEnvio.Click += btnAltaEnvio_Click;
            // 
            // btnListarEnvios
            // 
            btnListarEnvios.Location = new Point(575, 265);
            btnListarEnvios.Name = "btnListarEnvios";
            btnListarEnvios.Size = new Size(168, 95);
            btnListarEnvios.TabIndex = 1;
            btnListarEnvios.Text = "Listar Envio";
            btnListarEnvios.UseVisualStyleBackColor = true;
            btnListarEnvios.Click += btnListarEnvios_Click_1;
            // 
            // txtListado
            // 
            txtListado.Location = new Point(57, 54);
            txtListado.Multiline = true;
            txtListado.Name = "txtListado";
            txtListado.Size = new Size(447, 306);
            txtListado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtListado);
            Controls.Add(btnListarEnvios);
            Controls.Add(btnAltaEnvio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Button btnAltaEnvio;
        public Button btnListarEnvios;
        public TextBox txtListado;
    }
}
