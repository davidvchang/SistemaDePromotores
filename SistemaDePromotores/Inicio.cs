using ReglasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePromotores
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        

        int contadorTextBox = 1;
        int contadorBoton = 1;


        public List<string> ListaDocumentos = new List<string>();



        string rutaDocumentoSeleccionado = "";

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void tbCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número o la tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void btnCargarDocumento_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura propiedades del diálogo
            openFileDialog.Title = "Subir archivo";
            openFileDialog.AddExtension = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                // Obtener la ruta completa del archivo seleccionado.
                rutaDocumentoSeleccionado = openFileDialog.FileName;
                string nombreDocumento = Path.GetFileName(openFileDialog.FileName);

               

                // Agrega el nombre del archivo a la lista
                ListaDocumentos.Add(rutaDocumentoSeleccionado);

                // Mostrar el nombre del documento en el TextBox.
                listBox1.Items.Add(nombreDocumento);

            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir? Tenga en cuenta que si sales, no se guardarán los prospectos.", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cierra la aplicación
                tbNombreProspecto.Clear();
                tbPrimerApellido.Clear();
                tbSegundoApellido.Clear();
                tbCalle.Clear();
                tbCodigoPostal.Clear();
                tbColonia.Clear();
                tbNumero.Clear();
                tbTelefono.Clear();
                tbRFC.Clear();
                ListaDocumentos.Clear();
                listBox1.DataSource = null;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // mandar datos a la dll
            OpAccionesSQL.sServidor = Environment.MachineName; ;
            OpAccionesSQL.sUsuario = "David";
            OpAccionesSQL.sContraseña = "davidchang10";
            ConexionDB conexionDB = new ConexionDB();

            if (conexionDB.AbrirConexion(OpAccionesSQL.sServidor, OpAccionesSQL.sUsuario = "David", OpAccionesSQL.sContraseña = "davidchang10"))
            {
                MessageBox.Show("Conectado correctamente");

                this.Hide();
            }
            else
            {
                MessageBox.Show($"Ha ocurrido un error: {conexionDB.sLastError}");
                Application.Exit();
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            OpAccionesSQL opAccionesSQL = new OpAccionesSQL();

            string status = "Enviado";

            if (listBox1.Items.Count == null || tbNombreProspecto.Text == "" || tbPrimerApellido.Text == "" || tbSegundoApellido.Text == "" || tbCalle.Text == "" ||
                tbNumero.Text == "" || tbColonia.Text == "" || tbCodigoPostal.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos e ingresar al menos un documento.");
            }
            else
            {
                if (ListaDocumentos.Count == 0)
                {
                    MessageBox.Show("Debe cargar al menos un documento antes de enviar el prospecto.");
                    return;
                }

                // Crear una lista para almacenar los contenidos de los documentos
                List<byte[]> contenidosDocumentos = new List<byte[]>();

                // Leer el contenido de cada documento y almacenarlo en la lista
                foreach (string rutaDocumento in ListaDocumentos)
                {
                    // Leer el contenido del archivo utilizando la ruta completa
                    byte[] contenidoDocumento = File.ReadAllBytes(rutaDocumento);

                    // Agregar el contenido del documento a la lista
                    contenidosDocumentos.Add(contenidoDocumento);
                }

                if (opAccionesSQL.AgregarProspecto(tbNombreProspecto.Text, tbPrimerApellido.Text, tbSegundoApellido.Text, tbCalle.Text,
                    Convert.ToInt32(tbNumero.Text), tbColonia.Text, Convert.ToInt32(tbCodigoPostal.Text), tbTelefono.Text, tbRFC.Text, status, ListaDocumentos, contenidosDocumentos))
                {
                    MessageBox.Show("Prospecto enviado correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. " + opAccionesSQL.sLastError);
                    Limpiar();
                }
            }
        }

        void Limpiar()
        {
            tbCalle.Clear();
            tbCodigoPostal.Clear();
            tbColonia.Clear();
            tbNombreProspecto.Clear();
            tbNumero.Clear();
            tbPrimerApellido.Clear();
            tbRFC.Clear();
            tbSegundoApellido.Clear();
            tbTelefono.Clear();
            listBox1.Items.Clear();
        }

        private void prospectosCapturadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProspectosCapturados prospectosCapturados = new ProspectosCapturados(this);
            this.Hide();
            prospectosCapturados.ShowDialog();
        }

    }
}
