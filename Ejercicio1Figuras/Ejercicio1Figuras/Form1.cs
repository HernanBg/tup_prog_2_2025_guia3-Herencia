using Ejercicio1Figuras.Models;

namespace Ejercicio1Figuras
{
    public partial class Form1 : Form
    {
        private Servicio servicio;
        public Form1()
        {
            InitializeComponent();
            servicio = new Servicio();

            cbFiguras.Items.Add("Círculo");
            cbFiguras.Items.Add("Rectángulo");
            cbFiguras.Items.Add("Esfera");
            cbFiguras.Items.Add("Cilindro");

          
            if (cbFiguras.Items.Count > 0)
            {
                cbFiguras.SelectedIndex = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarFigura_Click(object sender, EventArgs e)
        {
            IFigura nuevaFigura = null;
            string tipo = cbFiguras.SelectedItem.ToString();


            bool esRadioValido = double.TryParse(tbRadio.Text, out double radio);
            bool esAnchoValido = double.TryParse(tbAncho.Text, out double ancho);
            bool esLargoValido = double.TryParse(tbLargo.Text, out double largo);
            bool esAlturaValida = double.TryParse(tbAlto.Text, out double altura);


            switch (tipo)
            {
                case "Círculo":
                    if (esRadioValido)
                    {
                        nuevaFigura = new Circulo(radio);
                    }
                    break;
                case "Rectángulo":
                    if (esAnchoValido && esLargoValido)
                    {
                        nuevaFigura = new Rectangulo(ancho, largo);
                    }
                    break;
                case "Esfera":
                    if (esRadioValido)
                    {
                        nuevaFigura = new Esfera(radio);
                    }
                    break;
                case "Cilindro":
                    if (esRadioValido && esAlturaValida)
                    {
                        nuevaFigura = new Cilindro(radio, altura);
                    }
                    break;
            }

            if (nuevaFigura != null)
            {
                servicio.AgregarFigura(nuevaFigura);
                ActualizarListaFiguras();
            }
            else
            {

                MessageBox.Show("Por favor, ingrese valores numéricos válidos para el tipo de figura seleccionado.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = lbCreadas.SelectedIndex;
            if (indiceSeleccionado != -1)
            {
                servicio.EliminarFigura(indiceSeleccionado);
                ActualizarListaFiguras();
            }
            else
            {
                MessageBox.Show("Seleccione una figura para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizarListaFiguras()
        {
            lbCreadas.Items.Clear();
            foreach (var figura in servicio.GetFiguras())
            {
               lbCreadas.Items.Add(figura.ToString());
            }
        }
    }
}
