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
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 120;
        }
    }
}
