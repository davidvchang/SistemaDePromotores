using ReglasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePromotores
{
    public partial class ProspectosCapturados : Form
    {
        public ProspectosCapturados()
        {
            InitializeComponent();
        }

        private void ProspectosCapturados_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
            TamañoColumnasDGV();
        }


        void CargarDatosEnDataGridView()
        {
            OpAccionesSQL opAccionesSQL = new OpAccionesSQL();
            DataTable datos = opAccionesSQL.CargarProspectosEnDataGridView();
            dataGridView1.DataSource = datos;
        }

        void TamañoColumnasDGV()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 100;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            int prospectoID = ObtenerProspectoIDSeleccionado();

            if (prospectoID != -1)
            {
                DetallesProspectos detallesProspectos = new DetallesProspectos(prospectoID);
                this.Hide();
                detallesProspectos.ShowDialog();
            }
                
        }

        int ObtenerProspectoIDSeleccionado()
        {
            // Implementa la lógica para obtener el ID del prospecto seleccionado
            int prospectoID = -1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                // Suponiendo que el ID está en la primera celda de la fila
                prospectoID = Convert.ToInt32(filaSeleccionada.Cells["ProspectoID"].Value);
            }
            return prospectoID;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnVerDetalle.Enabled = true;
            }
            else
            {
                btnVerDetalle.Enabled = false;
            }
        }
    }
}
