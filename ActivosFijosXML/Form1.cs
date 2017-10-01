using ActivosFijosXML.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijosXML
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //var staticData = new List<Asiento>()
            //{
            //    new Asiento { NoAsiento = 1, Descripcion = "Desc 1", Cuenta = "00012132", TipoMoviemiento = "TEST", Monto = 12000.0 },
            //    new Asiento { NoAsiento = 2, Descripcion = "Desc 1", Cuenta = "0001231", TipoMoviemiento = "TEST", Monto = 15000.0 },
            //    new Asiento { NoAsiento = 3, Descripcion = "Desc 1", Cuenta = "00018465", TipoMoviemiento = "TEST", Monto = 16000.0 },
            //    new Asiento { NoAsiento = 4, Descripcion = "Desc 1", Cuenta = "00018465", TipoMoviemiento = "TEST", Monto = 17000.0 },
            //    new Asiento { NoAsiento = 5, Descripcion = "Desc 1", Cuenta = "000174117", TipoMoviemiento = "TEST", Monto = 18000.0 },
            //};

            DataTable dt = new DataTable();
            dt.Columns.Add("No.Asiento", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Cuenta", typeof(int));
            dt.Columns.Add("TipoMovimiento", typeof(string));
            dt.Columns.Add("Monto", typeof(double));

            //foreach (var item in staticData)
            //{
            //    dt.Rows.Add(item.NoAsiento, item.Descripcion, item.Fecha, item.Cuenta, item.TipoMoviemiento, item.Monto);
            //}

            //dataGridView1.DataSource = dt;

            SqlDataAdapter da;
            var tabla = new DataTable();
            da = new SqlDataAdapter("select * from asientos", cn);
            da.Fill(tabla);

            dataGridView1.DataSource = tabla;

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da;
            //DataTable tabla = new DataTable();
            //da = new SqlDataAdapter("select * from asientos", cn);
            //da.Fill(tabla);
            //DataSet dataSet = new DataSet();
            //dataSet.Tables.Add(tabla);
            //SaveFileDialog savefile1 = new SaveFileDialog();
            //savefile1.Filter = "XML Files (.XML)|*.XML";
            //savefile1.AddExtension = true;
            //savefile1.ShowDialog();
            //string saveas = savefile1.FileName;
            //tabla.WriteXml(saveas);

            //SqlDataAdapter da;
            DataTable tabla = new DataTable();

            if (dataGridView1.DataSource is DataTable)
            {
                tabla = (DataTable)dataGridView1.DataSource;
            }

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(tabla);
            SaveFileDialog savefile1 = new SaveFileDialog();
            savefile1.Filter = "XML Files (.XML)|*.XML";
            savefile1.AddExtension = true;
            savefile1.ShowDialog();
            string saveas = savefile1.FileName;
            tabla.WriteXml(saveas);
        }
    }
}
