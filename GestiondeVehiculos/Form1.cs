namespace GestiondeVehiculos
{
    public partial class Form1 : Form
    {
        private Vehiculo nuevovehiculo;
        private List<Vehiculo> ListaVehiculo = new List<Vehiculo>();

        public Form1()
        {
            InitializeComponent();
            cboTipoVehiculo.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cboTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTipoVehiculo.SelectedItem.ToString() == "Auto" || cboTipoVehiculo.SelectedItem.ToString() == "Motocicleta")
            {
                lblBateria.Visible = false;
                txtCarga.Visible = false;
                lblCapacidadCarga.Visible = false;
                txtBateria.Visible = false;
            }
            if (cboTipoVehiculo.SelectedItem.ToString() == "Cami�n")
            {
                lblCapacidadCarga.Visible = true;
                txtCarga.Visible = true;
            }
            else
            {
                lblCapacidadCarga.Visible = false;
                txtCarga.Visible = false;
            }

            if (cboTipoVehiculo.SelectedItem.ToString() == "Vehiculo El�ctrico")
            {
                lblBateria.Visible = true;
                txtBateria.Visible = true;
                btnCargarBateria.Visible = true;
            }
            else
            {
                lblBateria.Visible = false;
                txtBateria.Visible = false;
                btnCargarBateria.Visible = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int porcentajeBateria;
            if (string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || (lblCapacidadCarga.Visible && string.IsNullOrWhiteSpace(txtCarga.Text)) || (lblBateria.Visible && string.IsNullOrWhiteSpace(txtBateria.Text)))
            {
                MessageBox.Show("Por favor, rellene los par�metros necesarios.");
            }
            else
            {
                SeleccionarVehiculo();
                MessageBox.Show("Vehiculo agregado");
                ListaVehiculo.Add(nuevovehiculo);
                MostrarDatos();
            }
            if (string.IsNullOrWhiteSpace(txtBateria.Text) || int.TryParse(txtBateria.Text, out porcentajeBateria))
            {
                if ((txtBateria.Text) == "Vehiculo El�ctrico")
                {
                    MessageBox.Show("Por favor, ingrese un valor v�lido para la bater�a.");
                }
                return;
            }

            if (porcentajeBateria <= 30)
            {
                MessageBox.Show($"Cargue el vehiculo, no se podr� usar");
                Close();
            }
            else
            {
                MessageBox.Show($"La bateria est� en buen estado.");
            }

            string vehiucloactual = nuevovehiculo.ToString();

        }

        private void SeleccionarVehiculo()
        {
            string seleccion = cboTipoVehiculo.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Auto":
                    nuevovehiculo = new Auto();
                    Auto auto = (Auto)nuevovehiculo;
                    auto.Marca = txtMarca.Text;
                    auto.Modelo = txtModelo.Text;
                    break;

                case "Motocicleta":
                    nuevovehiculo = new Motocicleta();
                    Motocicleta motocicleta = (Motocicleta)nuevovehiculo;
                    motocicleta.Marca = txtMarca.Text;
                    motocicleta.Modelo = txtModelo.Text;
                    break;

                case "Cami�n":
                    nuevovehiculo = new Cami�n();
                    Cami�n camion = (Cami�n)nuevovehiculo;
                    camion.Marca = txtMarca.Text;
                    camion.Modelo = txtModelo.Text;
                    camion.CapacidadCarga = int.Parse(txtCarga.Text);
                    break;

                case "Vehiculo El�ctrico":
                    nuevovehiculo = new VehiculoElectrico();
                    VehiculoElectrico electrico = (VehiculoElectrico)nuevovehiculo;
                    electrico.Marca = txtMarca.Text;
                    electrico.Modelo = txtModelo.Text;
                    electrico.Bateria = int.Parse(txtBateria.Text);
                    break;

                default:
                    break;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            nuevovehiculo.Iniciar();
        }

        private void btnMoverse_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            nuevovehiculo.Moverse();
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cargando el vehiculo...");
            MessageBox.Show("Vehiculo Cargado...");
        }

        private void btnDetenerse_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            nuevovehiculo.Detener();
        }

        private void lstMostrarVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void MostrarDatos()
        {
            lstMostrarVehiculos.Items.Clear();
            foreach (var item in ListaVehiculo)
            {
                lstMostrarVehiculos.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBateria.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtCarga.Clear();
        }
    }
}
