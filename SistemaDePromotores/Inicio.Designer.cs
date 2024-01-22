namespace SistemaDePromotores
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectosCapturadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbNombreProspecto = new System.Windows.Forms.TextBox();
            this.tbPrimerApellido = new System.Windows.Forms.TextBox();
            this.tbSegundoApellido = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.btnAgregarMas = new System.Windows.Forms.Button();
            this.btnCargarDocumento = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prospectosCapturadosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // prospectosCapturadosToolStripMenuItem
            // 
            this.prospectosCapturadosToolStripMenuItem.Name = "prospectosCapturadosToolStripMenuItem";
            this.prospectosCapturadosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.prospectosCapturadosToolStripMenuItem.Text = "Prospectos Capturados";
            this.prospectosCapturadosToolStripMenuItem.Click += new System.EventHandler(this.prospectosCapturadosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del prospecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Colonia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Codigo Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "RFC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Documentos";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(353, 443);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(468, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbNombreProspecto
            // 
            this.tbNombreProspecto.Location = new System.Drawing.Point(17, 72);
            this.tbNombreProspecto.Name = "tbNombreProspecto";
            this.tbNombreProspecto.Size = new System.Drawing.Size(145, 20);
            this.tbNombreProspecto.TabIndex = 13;
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.Location = new System.Drawing.Point(208, 72);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(145, 20);
            this.tbPrimerApellido.TabIndex = 14;
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.Location = new System.Drawing.Point(398, 72);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(145, 20);
            this.tbSegundoApellido.TabIndex = 15;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(17, 139);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(111, 20);
            this.tbCalle.TabIndex = 16;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(153, 139);
            this.tbNumero.MaxLength = 10;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(111, 20);
            this.tbNumero.TabIndex = 17;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbColonia
            // 
            this.tbColonia.Location = new System.Drawing.Point(292, 139);
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(111, 20);
            this.tbColonia.TabIndex = 18;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(432, 139);
            this.tbCodigoPostal.MaxLength = 5;
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(111, 20);
            this.tbCodigoPostal.TabIndex = 19;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoPostal_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(17, 219);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(111, 20);
            this.tbTelefono.TabIndex = 20;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tbRFC
            // 
            this.tbRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRFC.Location = new System.Drawing.Point(153, 219);
            this.tbRFC.MaxLength = 13;
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(111, 20);
            this.tbRFC.TabIndex = 21;
            // 
            // tbDocumento
            // 
            this.tbDocumento.Enabled = false;
            this.tbDocumento.Location = new System.Drawing.Point(12, 289);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(325, 20);
            this.tbDocumento.TabIndex = 23;
            // 
            // btnAgregarMas
            // 
            this.btnAgregarMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMas.Location = new System.Drawing.Point(491, 289);
            this.btnAgregarMas.Name = "btnAgregarMas";
            this.btnAgregarMas.Size = new System.Drawing.Size(24, 23);
            this.btnAgregarMas.TabIndex = 24;
            this.btnAgregarMas.Text = "+";
            this.btnAgregarMas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarMas.UseVisualStyleBackColor = true;
            this.btnAgregarMas.Click += new System.EventHandler(this.btnAgregarMas_Click);
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.Location = new System.Drawing.Point(351, 289);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.Size = new System.Drawing.Size(128, 23);
            this.btnCargarDocumento.TabIndex = 23;
            this.btnCargarDocumento.Text = "Cargar Documento";
            this.btnCargarDocumento.UseVisualStyleBackColor = true;
            this.btnCargarDocumento.Click += new System.EventHandler(this.btnCargarDocumento_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(323, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(24, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "-";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 326);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 95);
            this.listBox1.TabIndex = 27;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.tbSegundoApellido);
            this.Controls.Add(this.btnAgregarMas);
            this.Controls.Add(this.btnCargarDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombreProspecto);
            this.Controls.Add(this.tbPrimerApellido);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbNombreProspecto;
        private System.Windows.Forms.TextBox tbPrimerApellido;
        private System.Windows.Forms.TextBox tbSegundoApellido;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbColonia;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.ToolStripMenuItem prospectosCapturadosToolStripMenuItem;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.Button btnAgregarMas;
        private System.Windows.Forms.Button btnCargarDocumento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

