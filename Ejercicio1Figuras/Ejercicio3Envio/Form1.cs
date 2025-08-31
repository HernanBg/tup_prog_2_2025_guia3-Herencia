using Ejercicio3Envio.Models;

namespace Ejercicio3Envio
{
    public partial class Form1 : Form
    {
        private List<Envio> envios;
        public Form1()
        {
            InitializeComponent();
            envios = new List<Envio>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaEnvio_Click(object sender, EventArgs e)
        {

            Envio nuevoEnvio = new Envio();

            nuevoEnvio.AgregarCosto(new Fijo("Peaje puente Z�rate", 300.00));
            nuevoEnvio.AgregarCosto(new Variable("Combustible", 50.00, 1500.00));
            nuevoEnvio.AgregarCosto(new Fijo("Peaje t�nel", 300.00));
            nuevoEnvio.AgregarCosto(new Variable("Horas de conducci�n", 10.00, 500.00));

            
            envios.Add(nuevoEnvio);

            MessageBox.Show("Env�o agregado exitosamente.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListarEnvios_Click(object sender, EventArgs e)
        {
            ActualizarListadoEnvios();
        }
        private void ActualizarListadoEnvios()
        {

            if (envios.Count == 0)
            {
                txtListado.Text = "";
                MessageBox.Show("No hay env�os para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ordenar la lista de env�os por su ValorTotal de forma descendente
            var enviosOrdenados = envios.OrderByDescending(e => e.ValorTotal).ToList();

            string listadoCompleto = "";
            foreach (var envio in enviosOrdenados)
            {
                listadoCompleto += envio.VerDetalle() + "\r\n\r\n";
            }

            txtListado.Text = listadoCompleto;
        }
        

        private void txtListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListarEnvios_Click_1(object sender, EventArgs e)
        {
            ActualizarListadoEnvios();
        }
    }
}
