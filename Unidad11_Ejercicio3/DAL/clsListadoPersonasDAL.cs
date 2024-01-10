using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.Data.SqlClient;

namespace DAL
{
    internal class clsListadoPersonasDAL
    {
        public static ObservableCollection<clsPersona> listadoCompletoPersonas()
        {
            SqlConnection miConexion = new SqlConnection();

            ObservableCollection<clsPersona> listadoPersonas = new ObservableCollection<clsPersona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsPersona oPersona;

            miConexion.ConnectionString = clsConnection.connection();

            try
            {

                miConexion.Open();

                miComando.CommandText = "SELECT * FROM Personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector

                if (miLector.HasRows)

                {

                    while (miLector.Read())

                    {

                        oPersona = new clsPersona();

                        oPersona.Id = (int)miLector["ID"];

                        oPersona.Nombre = (string)miLector["Nombre"];

                        oPersona.Apellido = (string)miLector["Apellidos"];

                        oPersona.IdDepartamento = (int)miLector["IDDepartamento"];

                        if (miLector["FechaNacimiento"] != System.DBNull.Value)

                        { oPersona.FNac = (DateTime)miLector["FechaNacimiento"]; }

                        oPersona.Direccion = (string)miLector["Direccion"];

                        oPersona.Tlf = (string)miLector["Telefono"];

                        listadoPersonas.Add(oPersona);

                    }

                }

                miLector.Close();

                miConexion.Close();

            }

            catch (SqlException exSql)

            {
                throw exSql;

            }
            return listadoPersonas;
        }

        public static clsPersona getPersonaId(int id)
        {
            SqlConnection miConexion = new SqlConnection();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            clsPersona oPersona = new clsPersona();

            miConexion.ConnectionString = clsConnection.connection();

            try

            {

                miConexion.Open();

                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                miComando.CommandText = "SELECT * FROM Personas WHERE ID=@id";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector

                if (miLector.HasRows)

                {

                    miLector.Read();

                    oPersona.Id = (int)miLector["ID"];

                    oPersona.Nombre = (string)miLector["Nombre"];

                    oPersona.Apellido = (string)miLector["Apellidos"];

                    oPersona.IdDepartamento = (int)miLector["IDDepartamento"];

                }


                miLector.Close();

                miConexion.Close();

            }

            catch (SqlException exSql)

            {
                throw exSql;

            }
            return oPersona;
        }
    }
}
