
using System;
using System.Windows.Forms;

namespace pryObraSocial
{
    public partial class frmAfiliado : Form
    {
        public frmAfiliado()
        {
            InitializeComponent();
        }

        private void frmAfiliado_Load(object sender, EventArgs e)
        {
            cmbPlan.SelectedIndex = 0;

            cmdGuardar.Click += cmdGuardar_Click;
            cmdCancelar.Click += cmdCancelar_Click;
        }

        private void grpDatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNroAfiliado.Text == "" ||
                txtApellido.Text == "" ||
                txtNombre.Text == "" ||
                txtDni.Text == "" ||
                txtTelefono.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else if (!long.TryParse(txtDni.Text, out _))
            {
                MessageBox.Show("El DNI debe tener solo numeros");
            }
            else
            {
                MessageBox.Show("Afiliado registrado correctamente");

                Limpiar();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNroAfiliado.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtCosto.Clear();

            dtpFechaNacimiento.Value = DateTime.Today;
            cmbPlan.SelectedIndex = 0;

            txtNroAfiliado.Focus();
        }
    }
}
    