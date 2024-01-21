using ReglasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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


        List<string> ListaDocumentos = new List<string>();



        string rutaDocumentoSeleccionado = "";
        private void btnAgregarMas_Click(object sender, EventArgs e)
        {
            // Crea un nuevo TextBox
            TextBox nuevoTextBox = new TextBox();
            Button nuevoBotonCargar = new Button();

            // Configura propiedades del nuevo TextBox y Boton
            nuevoTextBox.Name = "textBox" + contadorTextBox.ToString();
            nuevoTextBox.Enabled = false;
            nuevoTextBox.Location = new System.Drawing.Point(tbDocumento.Location.X, tbDocumento.Location.Y + (contadorTextBox * 30));
            nuevoTextBox.Size = tbDocumento.Size;

            nuevoBotonCargar.Name = "btnCargarDocumento" + contadorBoton.ToString();
            nuevoBotonCargar.Text = "Cargar Documento";
            nuevoBotonCargar.Location = new System.Drawing.Point(btnCargarDocumento.Location.X, btnCargarDocumento.Location.Y + (contadorBoton * 30));
            nuevoBotonCargar.Size = btnCargarDocumento.Size;

            // Suscribe el evento Click al nuevo botón "Cargar Documento"
            nuevoBotonCargar.Click += btnCargarDocumento_Click;

            // Agrega el nuevo TextBox y boton al formulario
            this.Controls.Add(nuevoTextBox);
            this.Controls.Add(nuevoBotonCargar);

            // Incrementa el contador para el siguiente TextBox y boton
            contadorTextBox++;
            contadorBoton++;

            btnSalir.Location = new System.Drawing.Point(btnSalir.Location.X, btnSalir.Location.Y + 30);
            btnEnviar.Location = new System.Drawing.Point(btnEnviar.Location.X, btnEnviar.Location.Y + 30);
            // Ajusta la altura del formulario
            this.Height += 30;

        }

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

                // Mostrar el nombre del documento en el TextBox.
                tbDocumento.Text = Path.GetFileName(rutaDocumentoSeleccionado);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListaDocumentos.Remove(listBox1.SelectedItem.ToString());
            listBox1.DataSource = null;
            listBox1.DataSource = ListaDocumentos;


            if (listBox1.Items.Count == 0)
            {
                btnEliminar.Enabled = false;
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
                tbDocumento.Clear();
                tbNumero.Clear();
                tbTelefono.Clear();
                tbRFC.Clear();
                ListaDocumentos.Clear();
                listBox1.DataSource = null;

                if (listBox1.Items.Count == 0)
                {
                    btnEliminar.Enabled = false;
                }
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

            if (listBox1.Items.Count == 0)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            OpAccionesSQL opAccionesSQL = new OpAccionesSQL();

            string status = "Enviado";
            string nombreDocumento = btnCargarDocumento.Text;

            if(tbDocumento.Text == "" || tbNombreProspecto.Text == "" || tbPrimerApellido.Text == "" || tbSegundoApellido.Text == "" || tbCalle.Text == "" || 
                                               tbNumero.Text == "" || tbColonia.Text == "" || tbCodigoPostal.Text == "")
            {
                MessageBox.Show("Debe de llenar todos los campos e ingresar un documento.");
            }
            else
            {
                // Leer el contenido del archivo.
                byte[] contenidoDocumento = File.ReadAllBytes(rutaDocumentoSeleccionado);
                if (opAccionesSQL.AgregarProspecto(tbNombreProspecto.Text, tbPrimerApellido.Text, tbSegundoApellido.Text, tbCalle.Text,
                                                                Convert.ToInt32(tbNumero.Text), tbColonia.Text, Convert.ToInt32(tbCodigoPostal.Text), tbTelefono.Text, tbRFC.Text, status, tbDocumento.Text, contenidoDocumento))
                {
                    MessageBox.Show("Prospecto enviado correctamente");
                }

                else
                {
                    MessageBox.Show("Ha ocurrido un error. " + opAccionesSQL.sLastError);
                }
            }

            
        }

        private void prospectosCapturadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProspectosCapturados prospectosCapturados = new ProspectosCapturados();
            this.Hide();
            prospectosCapturados.ShowDialog();
        }
    }
}
