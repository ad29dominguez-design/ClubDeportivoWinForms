
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ClubDeportivo.Domain;

namespace ClubDeportivo.WinForms
{
    public partial class MainForm : Form
    {
        private readonly BindingList<Persona> personas = new();
        private readonly BindingList<Socio> socios = new();
        private readonly BindingList<Actividad> actividades = new();

        public MainForm()
        {
            InitializeComponent();
            dgvPersonas.DataSource = personas;
            dgvSocios.DataSource = socios;
            dgvActividades.DataSource = actividades;
            dgvPersonas.AutoGenerateColumns = true;
            dgvSocios.AutoGenerateColumns = true;
            dgvActividades.AutoGenerateColumns = true;
        }

        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdPersona.Text, out int id)) { MessageBox.Show("Id inválido"); return; }
            var p = new Persona
            {
                IdPersona = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = txtDni.Text,
                FechaNacimiento = dtpNacimiento.Value
            };
            personas.Add(p);
            LimpiarPersonas();
        }

        private void btnDelPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow?.DataBoundItem is Persona p)
                personas.Remove(p);
        }

        private void btnAddSocio_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdSocio.Text, out int idS)) { MessageBox.Show("IdSocio inválido"); return; }
            if (!int.TryParse(txtSocioIdPersona.Text, out int idP)) { MessageBox.Show("IdPersona inválido"); return; }
            var p = personas.FirstOrDefault(x => x.IdPersona == idP);
            if (p == null) { MessageBox.Show("La Persona no existe"); return; }

            var s = new Socio
            {
                IdSocio = idS,
                IdPersona = idP,
                Persona = p,
                FechaAlta = DateTime.Today,
                FechaVencimientoCuota = DateTime.Today.AddMonths(1),
                EstadoMembresia = "ACTIVO",
                TipoSocio = "adulto",
                AptoFisico = false,
                PagoCuota = false
            };
            socios.Add(s);
            LimpiarSocios();
        }

        private void btnDelSocio_Click(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow?.DataBoundItem is Socio s)
                socios.Remove(s);
        }

        private void btnAddActividad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdActividad.Text, out int idA)) { MessageBox.Show("IdActividad inválido"); return; }
            var a = new Actividad { IdActividad = idA, Nombre = txtNombreActividad.Text, IdProfesor = 0 };
            actividades.Add(a);
            LimpiarActividades();
        }

        private void btnDelActividad_Click(object sender, EventArgs e)
        {
            if (dgvActividades.CurrentRow?.DataBoundItem is Actividad a)
                actividades.Remove(a);
        }

        private void LimpiarPersonas()
        {
            txtIdPersona.Clear(); txtNombre.Clear(); txtApellido.Clear(); txtDni.Clear();
        }
        private void LimpiarSocios()
        {
            txtIdSocio.Clear(); txtSocioIdPersona.Clear();
        }
        private void LimpiarActividades()
        {
            txtIdActividad.Clear(); txtNombreActividad.Clear();
        }
    }
}
