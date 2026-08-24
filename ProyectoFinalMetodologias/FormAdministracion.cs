using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalMetodologias
{
    // Clase auxiliar para la vista de administración
    public class HabitacionVista
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
    }

    public partial class FormAdministracion : Form
    {
        private List<HabitacionVista> listaHabitaciones = new List<HabitacionVista>();

        public FormAdministracion()
        {
            InitializeComponent();
        }

        private void FormAdministracion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            listaHabitaciones = new List<HabitacionVista>
            {
                new HabitacionVista { Id = 1, Tipo = "Sencilla", Precio = 500.00m },
                new HabitacionVista { Id = 2, Tipo = "Doble", Precio = 850.00m },
                new HabitacionVista { Id = 3, Tipo = "Suite", Precio = 1500.00m }
            };

            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaHabitaciones;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                string tipo = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
                decimal precio = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio"].Value);

                label1.Text = "Modificando: " + tipo;
                numericUpDown1.Value = precio;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                var habitacion = listaHabitaciones.FirstOrDefault(h => h.Id == idSeleccionado);

                if (habitacion != null)
                {
                    habitacion.Precio = numericUpDown1.Value;
                    RefrescarGrid();
                    MessageBox.Show("¡Precio actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una habitación de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}