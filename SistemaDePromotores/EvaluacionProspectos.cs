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
    public partial class EvaluacionProspectos : Form
    {
        public EvaluacionProspectos(int prospectoID, ProspectosCapturados prospectosCapturados)
        {
            InitializeComponent();
            this.prospectoID = prospectoID;
            this.prospectosCapturados = prospectosCapturados;
        }


        public ProspectosCapturados prospectosCapturados;

        public int prospectoID;

        private void rbRechazar_CheckedChanged(object sender, EventArgs e)
        {
            tbObservacioneRechazo.Enabled = true;
            tbObservacioneRechazo.Visible = true;
            this.BackColor = Color.Brown;
        }

        private void rbAutorizar_CheckedChanged(object sender, EventArgs e)
        {
            tbObservacioneRechazo.Enabled = false;
            tbObservacioneRechazo.Visible = false;
            this.BackColor = Color.ForestGreen;
        }

        private void EvaluacionProspectos_Load(object sender, EventArgs e)
        {
            CargarInformacionProspecto();

        }

        void CargarInformacionProspecto()
        {

            OpAccionesSQL opAccionesSQL = new OpAccionesSQL();
            DataTable prospectoInfo = opAccionesSQL.ObtenerInformacionProspecto(prospectoID);

            if (prospectoInfo.Rows.Count > 0)
            {
                // Suponiendo que tbNombre, tbApellido, etc., son TextBoxes en tu formulario
                tbNombreProspecto.Text = prospectoInfo.Rows[0]["Nombre"].ToString();
                tbPrimerApellido.Text = prospectoInfo.Rows[0]["PrimerApellido"].ToString();
                tbSegundoApellido.Text = prospectoInfo.Rows[0]["SegundoApellido"].ToString();
                tbCalle.Text = prospectoInfo.Rows[0]["Calle"].ToString();
                tbNumero.Text = prospectoInfo.Rows[0]["Numero"].ToString();
                tbColonia.Text = prospectoInfo.Rows[0]["Colonia"].ToString();
                tbCodigoPostal.Text = prospectoInfo.Rows[0]["CodigoPostal"].ToString();
                tbTelefono.Text = prospectoInfo.Rows[0]["Telefono"].ToString();
                tbRFC.Text = prospectoInfo.Rows[0]["RFC"].ToString();
                tbEstatus.Text = prospectoInfo.Rows[0]["Estatus"].ToString();
                tbObservacioneRechazo.Text = prospectoInfo.Rows[0]["ObservacionesRechazo"].ToString();

                if (tbEstatus.Text == "ENVIADO")
                {
                    tbEstatus.BackColor = Color.Yellow;
                    tbObservacioneRechazo.Visible = false;
                }
                else if (tbEstatus.Text == "AUTORIZADO")
                {
                    tbEstatus.BackColor = Color.Green;
                    tbObservacioneRechazo.Visible = false;
                }
                else
                {
                    tbEstatus.BackColor = Color.Red;
                    tbObservacioneRechazo.Visible = true;
                }

                //Para cargar los Documentos
                opAccionesSQL.ObtenerDocumentosPorProspectoID(prospectoID);

                DataTable documentos = opAccionesSQL.ObtenerDocumentosPorProspectoID(prospectoID);

                // Limpiar el ListBox antes de cargar nuevos documentos
                listBox1.Items.Clear();

                foreach (DataRow row in documentos.Rows)
                {
                    string nombreDocumento = row["NombreDocumento"].ToString();
                    listBox1.Items.Add(nombreDocumento);
                }
            }
            else
            {
                MessageBox.Show("No se encontró información para el prospecto con ID: " + prospectoID);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ProspectosCapturados prospectosCapturados = (ProspectosCapturados)Application.OpenForms["prospectosCapturados"];
            this.Hide();
            prospectosCapturados.Visible = true;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            OpAccionesSQL accionesSQL = new OpAccionesSQL();
            string Opcion = "";
            if(rbAutorizar.Checked == true)
            {
                Opcion = "Autorizado";
            }
            else if(rbRechazar.Checked == true)
            {
                Opcion = "Rechazado";
            }

            if(accionesSQL.Evaluar(prospectoID, Opcion, tbObservacioneRechazo.Text))
            {
                MessageBox.Show("Evaluado Correctamente.");
                CargarInformacionProspecto();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la evaluacion. " + accionesSQL.sLastError);
            }
        }
    }
}
