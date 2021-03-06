﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.Modelo;
using System.Globalization;
using FrbaOfertas.BaseDeDatos;


//CONECTOR ENTRE SQL SERVER Y C# PARA TODAS LAS FUNCIONALIDADES RELACIONADAS CON USUARIO USOS PRINCIPALES: LOGIN, REGISTRO Y OTORGAR A UN USUARIO FUNCIONALIDAD

namespace FrbaOfertas.ConectorDB
{
    class FuncionesUsername
    {
        public static int validLogin(string username, string password)
        {
            int RespuestaProtocolo;
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            conn.Open();
            string SQL = "SELECT HPBC.validar_usuario(@usario,@pass)";

            SqlCommand command = new SqlCommand(SQL, conn);
            // command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@usario", username);
            command.Parameters.AddWithValue("@pass", password);


            RespuestaProtocolo = (int)command.ExecuteScalar();
            conn.Close();
            return RespuestaProtocolo;

        }
        public static void resetearCant_login_Fallido(string username)
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "HPBC.pr_resetear_cant_login_fallido";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            conn.Close();

        }
        public static void aumentarCant_login_Fallido(string username)
        {
            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "HPBC.pr_aumentar_cant_login_fallido";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            conn.Close();

        }

        public static void recuperar_usuario_id(string username, string pass)
        {

            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT usuario_id FROM HPBC.Usuario WHERE usuario_username = '" + username + "' and usuario_password = HASHBYTES('SHA2_256', '" + pass + "')";
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();
            Usuario.id = (int)reader["usuario_id"];
            Usuario.rol = null;
            Usuario.username = username;
            Usuario.password = pass;
            command.Connection.Close();
            conn.Close();


        }

        public static void recuperar_usuario_id_logueado(string username, string pass)
        {

            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT usuario_id FROM HPBC.Usuario WHERE usuario_username = '" + username + "' and usuario_password = HASHBYTES('SHA2_256', '" + pass + "')";
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();
            UsuarioLogeado.id = (int)reader["usuario_id"];
            UsuarioLogeado.rol = null;
            UsuarioLogeado.username = username;
            UsuarioLogeado.password = pass;
            command.Connection.Close();
            conn.Close();


        }




        public static List<String> ObtenerFuncionalidadesDeUnUsuario(string username)
        {
            List<String> lista = new List<string>();

            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();
            comm.CommandText =
                "SELECT Distinct Func_detalle FROM HPBC.Funcion f join HPBC.Funcion_Por_Rol fr on f.Func_ID = fr.Func_ID join HPBC.Rol r on fr.Rol_ID = r.Rol_ID join HPBC.Rol_Por_Usuario on ID_Rol = r.Rol_ID join HPBC.Usuario on usuario_id = ID_Usuario where usuario_username = '" + username + "'";
            comm.Connection = connection;
            comm.Connection.Open();
            SqlDataReader reader = comm.ExecuteReader() as SqlDataReader;
            while (reader.Read())
            {
                lista.Add(reader["Func_detalle"].ToString());
            }
            return lista;

        }
        public static Boolean existeUsername(string username)
        {
            return FrbaOfertas.ConectorDB.FuncionesGlobales.existeTabla(username, "Usuario");
        }

        public static void GuardarUsuario(String usuario, String pass)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "INSERT INTO HPBC.Usuario(usuario_username, usuario_password, usuario_habilitado, usuario_bloqueado, usuario_cant_logeo_error) " +
                                "VALUES ('" + usuario + "'," + "HASHBYTES('SHA2_256','" + pass + "') , 1 , 0 , 0)";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();


        }

        public static void insertarRolxUsuario(string Rol, string usuario)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "INSERT INTO HPBC.Rol_Por_Usuario(ID_Rol ,ID_Usuario) " +
                                "VALUES ((SELECT Distinct ID_Rol from HPBC.Rol_Por_Usuario join HPBC.Rol on ID_Rol = Rol_ID where Rol_detalle = '" + Rol + "'), (SELECT usuario_id from  HPBC.Usuario WHERE usuario_username= '" + usuario + "'))";
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();


        }

        public static void updatearUsuario(int id, string contraseña, Boolean habilitado, Boolean bloqueado)
        {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "UPDATE HPBC.Usuario SET usuario_password = " + "HASHBYTES('SHA2_256','" + contraseña + "'), usuario_habilitado = " + Convert.ToInt32(habilitado) + ", usuario_bloqueado = " + Convert.ToInt32(bloqueado) + ", usuario_cant_logeo_error = 0 WHERE usuario_id = "+ id;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();


        }

        public static int get_id(string username)
        {

            SqlConnection conn = new SqlConnection(Conexion.getStringConnection());
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT usuario_id FROM HPBC.Usuario WHERE usuario_username = '" + username + "'";
            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader() as SqlDataReader;
            reader.Read();

            int id = (int)reader["usuario_id"];
            command.Connection.Close();
            conn.Close();
            return id;


        }

        public static void desbloquearUsuario(int id) {
            SqlConnection connection = new SqlConnection(Conexion.getStringConnection());
            SqlCommand comm = connection.CreateCommand();

            comm.CommandText = "UPDATE HPBC.Usuario SET usuario_bloqueado = 0 , usuario_cant_logeo_error = 0 WHERE usuario_id = "+ id;
            comm.Connection = connection;
            comm.Connection.Open();
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            connection.Close();
        
        
        }

        public static void BajaLogicaUsuario(int id) {

            FrbaOfertas.ConectorDB.FuncionesGlobales.BajaLogica(id, "Usuario");
        
        }


    }

}
