﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace ReglasDeNegocio
{
    public class OpAccionesSQL
    {
        public String sLastError = "";


        public static string sServidor;
        public static string sUsuario;
        public static string sContraseña;

        // Obtener el nombre de la computadora
        string nombreDeLaComputadora = Environment.MachineName;



        public Boolean AgregarProspecto(String NombreProspecto, String PrimerApellido, String SegundoApellido, String Calle, 
                                        Int32 Numero, String Colonia, Int32 CodigoPostal, String Telefono, String RFC, String Status, String NombreDocumento, byte[] contenidoDocumento)
        {
            Boolean bAllOk = true;
            using (SqlConnection conexion = new SqlConnection(ConexionDB.CadenaConexion(sServidor, sUsuario, sContraseña)))
            {
                conexion.Open();

                try
                {
                    string query = $"INSERT INTO Prospectos(Nombre, PrimerApellido, SegundoApellido, Calle, Numero, " +
                                                            $"Colonia, CodigoPostal, Telefono, RFC, Estatus) " +
                                    $"VALUES('{NombreProspecto}', '{PrimerApellido}', '{SegundoApellido}', '{Calle}', {Numero}, '{Colonia}', " +
                                    $"{CodigoPostal}, '{Telefono}', '{RFC}', '{Status}'); " +
                                    $"SELECT SCOPE_IDENTITY(); "; // Esta última línea obtiene el ID del prospecto recién insertado.
                    SqlCommand comando = new SqlCommand(query, conexion);
                    

                    // Obtener el ID del prospecto recién insertado.
                    int prospectoID = Convert.ToInt32(comando.ExecuteScalar());

                    // Guardar el documento asociado al prospecto.
                    GuardarDocumentoEnBaseDeDatos(prospectoID, NombreDocumento, contenidoDocumento);

                }
                catch (Exception ex)
                {
                    sLastError = ex.Message;
                    bAllOk = false;
                }
                finally
                {
                    conexion.Close();
                }

                return bAllOk;
            }

        }


        private void GuardarDocumentoEnBaseDeDatos(int prospectoID, string nombreDocumento, byte[] contenidoDocumento)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionDB.CadenaConexion(sServidor, sUsuario, sContraseña)))
            {
                conexion.Open();

                try
                {
                    string queryDocumento = $"INSERT INTO Documentos(ProspectoID, NombreDocumento, Documento) " +
                                                        $"VALUES ({prospectoID}, '{nombreDocumento}', @ContenidoDocumento);";
                    SqlCommand comando = new SqlCommand(queryDocumento, conexion);
                    comando.Parameters.Add("@ContenidoDocumento", System.Data.SqlDbType.VarBinary, -1).Value = contenidoDocumento;
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    sLastError = ex.Message;
                }

                finally
                {
                    conexion.Close();
                }
            }
            
        }


        public DataTable CargarProspectosEnDataGridView(    )
        {
            
            DataTable table = new DataTable();
            using (SqlConnection conexion = new SqlConnection(ConexionDB.CadenaConexion(sServidor, sUsuario, sContraseña)))
            {
                try
                {
                
                    conexion.Open();
                    string query = "SELECT ProspectoID, Nombre, PrimerApellido, SegundoApellido, Estatus FROM Prospectos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    sLastError = ex.Message;
                }
                finally
                {
                    conexion.Close();
                }
                return table;
            }
        }

        public DataTable ObtenerInformacionProspecto(int prospectoID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.CadenaConexion(sServidor, sUsuario, sContraseña)))
            {
                try
                {
                    conexion.Open();

                    string query = $"SELECT * FROM Prospectos WHERE ProspectoID = {prospectoID}";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener información del prospecto: {ex.Message}");
                }
            }

            return dataTable;
        }

        public DataTable ObtenerDocumentosPorProspectoID(int prospectoID)
        {
            DataTable documentos = new DataTable();

            using (SqlConnection conexion = new SqlConnection(ConexionDB.CadenaConexion(sServidor, sUsuario, sContraseña)))
            {
                try
                {
                    conexion.Open();

                    string query = $"SELECT * FROM Documentos WHERE ProspectoID = {prospectoID}";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        adapter.Fill(documentos);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener documentos del prospecto: {ex.Message}");
                }
            }

            return documentos;
        }

    }
}
