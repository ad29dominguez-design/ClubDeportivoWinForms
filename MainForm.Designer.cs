
using System.Windows.Forms;

namespace ClubDeportivo.WinForms
{
    partial class MainForm
    {
        private TabControl tabs;
        private TabPage tabPersonas;
        private TabPage tabSocios;
        private TabPage tabActividades;

        private DataGridView dgvPersonas;
        private TextBox txtIdPersona, txtNombre, txtApellido, txtDni;
        private DateTimePicker dtpNacimiento;
        private Button btnAddPersona, btnDelPersona;

        private DataGridView dgvSocios;
        private TextBox txtIdSocio, txtSocioIdPersona;
        private Button btnAddSocio, btnDelSocio;

        private DataGridView dgvActividades;
        private TextBox txtIdActividad, txtNombreActividad;
        private Button btnAddActividad, btnDelActividad;

        private void InitializeComponent()
        {
            this.Text = "Club Deportivo - ABM";
            this.Width = 1000;
            this.Height = 650;

            tabs = new TabControl { Dock = DockStyle.Fill };
            tabPersonas = new TabPage("Personas");
            tabSocios = new TabPage("Socios");
            tabActividades = new TabPage("Actividades");
            tabs.TabPages.AddRange(new[] { tabPersonas, tabSocios, tabActividades });
            this.Controls.Add(tabs);

            dgvPersonas = new DataGridView { Dock = DockStyle.Bottom, Height = 350, ReadOnly = true, AllowUserToAddRows = false };
            txtIdPersona = new TextBox { Left = 20, Top = 20, Width = 120, PlaceholderText = "IdPersona" };
            txtNombre = new TextBox { Left = 160, Top = 20, Width = 160, PlaceholderText = "Nombre" };
            txtApellido = new TextBox { Left = 340, Top = 20, Width = 160, PlaceholderText = "Apellido" };
            txtDni = new TextBox { Left = 520, Top = 20, Width = 160, PlaceholderText = "DNI" };
            dtpNacimiento = new DateTimePicker { Left = 700, Top = 20, Width = 200 };
            btnAddPersona = new Button { Left = 20, Top = 60, Width = 140, Text = "Agregar Persona" };
            btnDelPersona = new Button { Left = 180, Top = 60, Width = 160, Text = "Eliminar seleccionada" };
            btnAddPersona.Click += btnAddPersona_Click;
            btnDelPersona.Click += btnDelPersona_Click;
            tabPersonas.Controls.AddRange(new Control[] { txtIdPersona, txtNombre, txtApellido, txtDni, dtpNacimiento, btnAddPersona, btnDelPersona, dgvPersonas });

            dgvSocios = new DataGridView { Dock = DockStyle.Bottom, Height = 350, ReadOnly = true, AllowUserToAddRows = false };
            txtIdSocio = new TextBox { Left = 20, Top = 20, Width = 120, PlaceholderText = "IdSocio" };
            txtSocioIdPersona = new TextBox { Left = 160, Top = 20, Width = 180, PlaceholderText = "IdPersona (existente)" };
            btnAddSocio = new Button { Left = 20, Top = 60, Width = 140, Text = "Agregar Socio" };
            btnDelSocio = new Button { Left = 180, Top = 60, Width = 160, Text = "Eliminar seleccionado" };
            btnAddSocio.Click += btnAddSocio_Click;
            btnDelSocio.Click += btnDelSocio_Click;
            tabSocios.Controls.AddRange(new Control[] { txtIdSocio, txtSocioIdPersona, btnAddSocio, btnDelSocio, dgvSocios });

            dgvActividades = new DataGridView { Dock = DockStyle.Bottom, Height = 350, ReadOnly = true, AllowUserToAddRows = false };
            txtIdActividad = new TextBox { Left = 20, Top = 20, Width = 120, PlaceholderText = "IdActividad" };
            txtNombreActividad = new TextBox { Left = 160, Top = 20, Width = 220, PlaceholderText = "Nombre actividad" };
            btnAddActividad = new Button { Left = 20, Top = 60, Width = 140, Text = "Agregar Actividad" };
            btnDelActividad = new Button { Left = 180, Top = 60, Width = 160, Text = "Eliminar seleccionada" };
            btnAddActividad.Click += btnAddActividad_Click;
            btnDelActividad.Click += btnDelActividad_Click;
            tabActividades.Controls.AddRange(new Control[] { txtIdActividad, txtNombreActividad, btnAddActividad, btnDelActividad, dgvActividades });
        }
    }
}
