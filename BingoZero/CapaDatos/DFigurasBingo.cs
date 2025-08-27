using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class DFigurasBingo
    {
        #region "PATRON SINGLETON"
        private static DFigurasBingo daoEmpleado = null;
        private DFigurasBingo() { }
        public static DFigurasBingo GetInstance()
        {
            if (daoEmpleado == null)
            {
                daoEmpleado = new DFigurasBingo();
            }
            return daoEmpleado;
        }
        #endregion

        public Respuesta<bool> RegistrarFigura(string FiguraXml)
        {

            try
            {
                bool respuesta = false;

                using (SqlConnection con = ConexionBD.GetInstance().ConexionDB())
                {
                    using (SqlCommand cmd = new SqlCommand("usp_RegistrarFigura", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetro de entrada
                        cmd.Parameters.AddWithValue("@FiguraXml", FiguraXml);

                        // Agregar parámetro de salida
                        var outputParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        // Abrir la conexión y ejecutar el comando
                        con.Open();
                        cmd.ExecuteNonQuery();

                        respuesta = Convert.ToBoolean(outputParam.Value);
                    }
                }
                return new Respuesta<bool>
                {
                    Estado = respuesta,
                    Mensaje = respuesta ? "Se registro correctamente" : "Error al registrar intente mas tarde"
                };
            }
            catch (Exception ex)
            {
                return new Respuesta<bool> { Estado = false, Mensaje = "Ocurrió un error: " + ex.Message };
            }
        }

        public Respuesta<List<EFiguraDTO>> ObtenerFigura(int idFigura)
        {
            try
            {
                List<EFiguraDTO> rptLista = new List<EFiguraDTO>();
                using (SqlConnection con = ConexionBD.GetInstance().ConexionDB())
                {
                    using (SqlCommand comando = new SqlCommand("sp_ObtenerFigura", con))
                    {
                        comando.Parameters.AddWithValue("@IdFigura", idFigura);
                        comando.CommandType = CommandType.StoredProcedure;
                        con.Open();

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                rptLista.Add(new EFiguraDTO()
                                {
                                    Columna = dr["Columna"].ToString(),
                                    Fila = Convert.ToInt32(dr["Fila"])
                                });
                            }
                        }
                    }
                }
                return new Respuesta<List<EFiguraDTO>>()
                {
                    Estado = true,
                    Data = rptLista,
                    Mensaje = "Figura obtenidos correctamente"
                };
            }
            catch (Exception ex)
            {
                return new Respuesta<List<EFiguraDTO>>()
                {
                    Estado = false,
                    Mensaje = "Ocurrió un error: " + ex.Message,
                    Data = null
                };
            }
        }

    }
}
