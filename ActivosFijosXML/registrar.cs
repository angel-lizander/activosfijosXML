using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijosXML
{

    class registrar
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public int noasiento { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public int cuenta { get; set; }
        public string movimiento { get; set; }
        public double monto { get; set; }

        public registrar(int noasiento, string descripcion, DateTime fecha, int cuenta, string movimiento, double monto)
        {
            this.noasiento = noasiento;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.cuenta = cuenta;
            this.movimiento = movimiento;
            this.monto = monto;

        }

        public bool registrando()
        {
            string query = "INSERT INTO asientos (noasiento, descripcion, fechaasiento, cuenta, tipomovimiento, monto)";
            query += " VALUES (@noasiento, @descripcion, @fecha, @cuenta, @movimiento, @monto)";

            try
            {
                cn.Open();
                SqlCommand myCommand = new SqlCommand(query, cn);
                myCommand.Parameters.AddWithValue("@noasiento", noasiento);
                myCommand.Parameters.AddWithValue("@descripcion", descripcion);
                myCommand.Parameters.AddWithValue("@fecha", fecha);
                myCommand.Parameters.AddWithValue("@cuenta", cuenta);
                myCommand.Parameters.AddWithValue("@movimiento", movimiento);
                myCommand.Parameters.AddWithValue("@monto", monto);
                myCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Datos insertados correctamente");
            }

            catch (SqlException p)
            {

                MessageBox.Show(p.Message);
            }
            return true;
        }


    }

}
