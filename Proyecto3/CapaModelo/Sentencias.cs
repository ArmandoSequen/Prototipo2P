using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        public OdbcDataAdapter llenarListaApliUsuario(string tabla, string id)
        {
            string sql = "Select *from " + tabla + " where ID = " + id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void eliminar(string tabla, string condicion, int campo)
        {

            try
            {

                string sql = "delete from " + tabla + " where " + condicion + " " + campo + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        public void actualizar(string dato, string condicion, string tabla, int num)
        {

            string sql = "Update " + tabla + " " + dato + " where " + condicion + " " + num + "; ";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();

        }

    }
}
