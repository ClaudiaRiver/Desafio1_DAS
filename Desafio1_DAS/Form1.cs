using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Desafio1_DAS
{
    public partial class Form1 : Form
    {
        private Data data = new Data();

        public Form1()
        {
            InitializeComponent();
            dgvLibros.AutoGenerateColumns = false;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvHistorialLibro.AutoGenerateColumns = false;
            dgvPrestamos.AutoGenerateColumns = false;
            CargarUsuariosEnComboBoxPrestamo();
            CargarLibrosEnComboBoxPrestamo();
            CargarUsuariosParaDevolucion();
            cmbUsuarioPrestamo.SelectedIndexChanged += cmbUsuariosHistorial_SelectedIndexChanged;
        }

        //Libros

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (txtIdLibro.Text == "" || txtTitulo.Text == "" || txtAutor.Text == "" || txtAño.Text == "")
            {
                MessageBox.Show("Por favor completa todos los campos del libro.");
                return;
            }

            var libro = new Libro(txtIdLibro.Text, txtTitulo.Text, txtAutor.Text, txtAño.Text);

            data.AgregarLibro(libro);
            CargarLibrosEnComboBoxPrestamo();
            ActualizarGrillaLibros();
            LimpiarCamposLibro();
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int index = dgvLibros.CurrentRow.Index;
                var libro = data.Libros[index];

                libro.Id = txtIdLibro.Text;
                libro.Titulo = txtTitulo.Text;
                libro.Autor = txtAutor.Text;
                libro.Año = txtAño.Text;

                ActualizarGrillaLibros();
                LimpiarCamposLibro();
            }
            else
            {
                MessageBox.Show("Selecciona un libro en la tabla para editar.");
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                int index = dgvLibros.CurrentRow.Index;
                data.Libros.RemoveAt(index);
                ActualizarGrillaLibros();
                LimpiarCamposLibro();
            }
            else
            {
                MessageBox.Show("Selecciona un libro en la tabla para eliminar.");
            }
        }

        private void LimpiarCamposLibro()
        {
            txtIdLibro.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
        }

        private void ActualizarGrillaLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = data.Libros.Select(l => new
            {
                ID = l.Id,
                Titulo = l.Titulo,
                Autor = l.Autor,
                Año = l.Año
            }).ToList();
        }

        //Usuarios:

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUsuarioId.Text, out int id))
            {
                var usuario = new Usuario(id, txtNombreUsuario.Text, txtEmailUsuario.Text);
                data.AgregarUsuario(usuario);
                ActualizarGrillaUsuarios();
                LimpiarCamposUsuario();
                CargarUsuariosEnComboBoxPrestamo();
                CargarUsuariosParaDevolucion();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un ID válido.");
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int index = dgvUsuarios.CurrentRow.Index;
                var usuario = data.Usuarios[index];
                usuario.Nombre = txtNombreUsuario.Text;
                usuario.Email = txtEmailUsuario.Text;
                ActualizarGrillaUsuarios();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int index = dgvUsuarios.CurrentRow.Index;
                data.Usuarios.RemoveAt(index);
                ActualizarGrillaUsuarios();
            }
        }

        private void LimpiarCamposUsuario()
        {
            txtUsuarioId.Clear();
            txtNombreUsuario.Clear();
            txtEmailUsuario.Clear();
        }

        private void ActualizarGrillaUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = data.Usuarios.Select(u => new
            {
                ID = u.Id,
                Nombre = u.Nombre,
                Email = u.Email
            }).ToList();
        }

        //Prestamos:
        private void txtLibroIdPrestamo_TextChanged(object sender, EventArgs e)
        {
            string idLibro = txtLibroIdPrestamo.Text.Trim();
            var libro = data.Libros.FirstOrDefault(l => l.Id == idLibro);

            if (libro != null)
            {
                txtLibroTituloPrestamo.Text = libro.Titulo;
            }
            else
            {
                txtLibroTituloPrestamo.Text = "No disponible";
            }
        }


        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuarioPrestamo.SelectedItem is Usuario usuario)
            {
                string idLibro = txtLibroIdPrestamo.Text.Trim();
                var libro = data.Libros.FirstOrDefault(l => l.Id == idLibro);

                if (libro == null)
                {
                    MessageBox.Show("El libro no existe o no está disponible.");
                    return;
                }

                var prestamo = new Prestamo(data.Prestamos.Count + 1, usuario, libro)
                {
                    FechaPrestamo = dtpFechaPrestamo.Value
                };

                data.Prestamos.Add(prestamo);
                ActualizarGrillaPrestamos();
                MostrarEstadisticas();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario válido.");
            }
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow != null)
            {
                int id = int.Parse(dtpFechaPrestamo.Text);
                var prestamo = data.Prestamos.FirstOrDefault(p => p.Id == id);

                if (prestamo != null && !prestamo.FechaDevolucion.HasValue)
                {
                    prestamo.FechaDevolucion = DateTime.Now;
                    ActualizarGrillaPrestamos();
                    MostrarEstadisticas();
                }
                else
                {
                    MessageBox.Show("Este préstamo ya fue devuelto o no existe.");
                }
            }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow != null)
            {
                int index = dgvPrestamos.CurrentRow.Index;
                data.Prestamos.RemoveAt(index);
                ActualizarGrillaPrestamos();
            }
        }

        private void ActualizarGrillaPrestamos()
        {
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = data.Prestamos.Select(p => new
            {
                ID = p.Id,
                LibroID = p.Libro.Titulo,
                Fecha = p.FechaPrestamo.ToShortDateString(),
                Devolución = p.FechaDevolucion.HasValue ? p.FechaDevolucion.Value.ToShortDateString() : "Pendiente"
            }).ToList();
        }

        //Estadisticas:

        private void MostrarEstadisticas()
        {
            chartLibros.Series.Clear();
            var serie = chartLibros.Series.Add("Préstamos");
            serie.ChartType = SeriesChartType.Bar;

            foreach (var item in data.EstadisticasLibros.OrderByDescending(x => x.Value))
            {
                serie.Points.AddXY(item.Key, item.Value);
            }
        }


        //Menu usuarios:


        private void cmbUsuariosHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarioPrestamo.SelectedItem is Usuario usuario)
            {
                var historial = data.Prestamos
                    .Where(p => p.Usuario.Id == usuario.Id)
                    .Select(p => new
                    {
                        Id = p.Id,
                        Libro = p.Libro.Titulo,
                        FechaPrestamo = p.FechaPrestamo.ToShortDateString(),
                        FechaDevolucion = p.FechaDevolucion.HasValue ? p.FechaDevolucion.Value.ToShortDateString() : "Pendiente"
                    }).ToList();

                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = historial;
            }
        }

        //cargar info:
        private void CargarUsuariosParaDevolucion()
        {
            cmbUsuarioDevolucion.DataSource = null;
            cmbUsuarioDevolucion.DataSource = data.Usuarios;
            cmbUsuarioDevolucion.DisplayMember = "Nombre";
            cmbUsuarioDevolucion.ValueMember = "Id";
        }


        private void CargarUsuariosEnComboBoxPrestamo()
        {
            cmbUsuarioPrestamo.DataSource = null;
            cmbUsuarioPrestamo.DataSource = data.Usuarios;
            cmbUsuarioPrestamo.DisplayMember = "Nombre";
            cmbUsuarioPrestamo.ValueMember = "Id";
        }

        private void CargarLibrosEnComboBoxPrestamo()
        {
            cmbUsuarioDevolucion.DataSource = null;
            cmbUsuarioDevolucion.DataSource = data.Libros;
            cmbUsuarioDevolucion.DisplayMember = "Titulo";
            cmbUsuarioDevolucion.ValueMember = "Id";
        }


        //Menu historial usuarios:
        private void cmbLibrosPrestados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarioDevolucion.SelectedItem is Libro libro)
            {
                var historial = data.Prestamos
                    .Where(p => p.Libro.Id == libro.Id)
                    .Select(p => new
                    {
                        ID = p.Id,
                        FechaPrestamo = p.FechaPrestamo.ToShortDateString(),
                        FechaDevolucion = p.FechaDevolucion.HasValue ? p.FechaDevolucion.Value.ToShortDateString() : "Pendiente"
                    }).ToList();

                dgvHistorialLibro.DataSource = null;
                dgvHistorialLibro.DataSource = historial;
            }
        }

        //Devolucion de libro:
        private void cmbUsuarioDevolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarioDevolucion.SelectedItem is Usuario usuario)
            {
                txtIdUsuarioDevolucion.Text = usuario.Id.ToString();

                var prestamo = data.Prestamos
                    .Where(p => p.Usuario.Id == usuario.Id && !p.FechaDevolucion.HasValue)
                    .OrderByDescending(p => p.FechaPrestamo)
                    .FirstOrDefault();

                if (prestamo != null)
                {
                    txtFechaPrestamo.Text = prestamo.FechaPrestamo.ToShortDateString();
                }
                else
                {
                    txtFechaPrestamo.Text = "Sin préstamos activos";
                }
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (cmbUsuarioDevolucion.SelectedItem is Usuario usuario)
            {
                var prestamo = data.Prestamos
                    .Where(p => p.Usuario.Id == usuario.Id && !p.FechaDevolucion.HasValue)
                    .OrderByDescending(p => p.FechaPrestamo)
                    .FirstOrDefault();

                if (prestamo != null)
                {
                    prestamo.FechaDevolucion = dtpFechaDevolucion.Value;
                    ActualizarGrillaPrestamos();
                    MostrarEstadisticas();
                    MessageBox.Show("Devolución registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No hay préstamos activos para este usuario.");
                }
            }
        }

        //Eventos vacios:

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarDevolucion_Click_1(object sender, EventArgs e)
        {

        }
    }
}