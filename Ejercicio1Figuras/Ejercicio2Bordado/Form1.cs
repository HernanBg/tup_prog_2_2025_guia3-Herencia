using Ejercicio2Bordado.Models;

namespace Ejercicio2Bordado
{
    public partial class Form1 : Form
    {
        private MaquinaCoser maquina = new MaquinaCoser();
        public Form1()
        {
            InitializeComponent();
            maquina = new MaquinaCoser();

           
            lstMotivosDisponibles.Items.Add("Flor");
            lstMotivosDisponibles.Items.Add("ZigZag");
            lstMotivosDisponibles.Items.Add("Combinado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstMotivosDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un motivo para agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMotivo = lstMotivosDisponibles.SelectedItem.ToString();
            IMotivoBordado nuevoMotivo = null;

            if (selectedMotivo == "Flor")
            {
                nuevoMotivo = new Flor();
            }
            else if (selectedMotivo == "ZigZag")
            {
                nuevoMotivo = new ZigZag();
            }
            else if (selectedMotivo == "Combinado")
            {
                // Para el motivo combinado, usamos una copia de la lista actual de la máquina.
                if (maquina.GetMotivos().Count < 2)
                {
                    MessageBox.Show("Se necesitan al menos dos motivos para crear uno combinado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nuevoMotivo = new Combinado(new List<IMotivoBordado>(maquina.GetMotivos()));
            }

            if (nuevoMotivo != null)
            {
                maquina.AgregarMotivo(nuevoMotivo);
                ActualizarListaMotivos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maquina.GetMotivos().Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un motivo para iniciar la máquina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            maquina.Iniciar();
            txtPanelPuntadas.Clear();

            btnDarPuntada.Enabled = true;
            btnReiniciarMaquina.Enabled = true;
            btnIniciarMaquina.Enabled = false;
            btnAgregarMotivo.Enabled = false;
        }

        private void btnDarPuntada_Click(object sender, EventArgs e)
        {
            string puntada = maquina.DarPuntada();
            if (puntada == "Finalizado")
            {
                MessageBox.Show("La secuencia de bordado ha finalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDarPuntada.Enabled = false;
            }
            else
            {
                txtPanelPuntadas.AppendText(puntada + Environment.NewLine);
            }
        }

        private void btnReiniciarMaquina_Click(object sender, EventArgs e)
        {
            maquina.Reiniciar();
            ActualizarListaMotivos();
            txtPanelPuntadas.Clear();
            btnIniciarMaquina.Enabled = true;
            btnAgregarMotivo.Enabled = true;
            btnDarPuntada.Enabled = false;
            btnReiniciarMaquina.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarListaMotivos()
        {
            lstMotivosAgregados.Items.Clear();
            foreach (var motivo in maquina.GetMotivos())
            {
                lstMotivosAgregados.Items.Add(motivo.ToString());
            }
        }

        private void lstMotivosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
