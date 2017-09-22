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
            /* DataTable dt = new DataTable();
             dt.Columns.Add("No.Asiento", typeof(int));
             dt.Columns.Add("Descripcion", typeof(string));
             dt.Columns.Add("Fecha", typeof(DateTime));
             dt.Columns.Add("Cuenta", typeof(int));
             dt.Columns.Add("TipoMovimiento", typeof(string));
             dt.Columns.Add("Monto", typeof(double));

             dataGridView1.DataSource = dt;*/

            SqlDataAdapter da;
            var tabla = new DataTable();
            da = new SqlDataAdapter("select * from asientos", cn);
            da.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            var tabla = new DataTable();
            da = new SqlDataAdapter("select * from asientos", cn);
            SaveFileDialog savefile1 = new SaveFileDialog();
            savefile1.Filter = "XML Files (.XML)|*.XML";
            savefile1.DefaultExt = "xml";
            savefile1.AddExtension = true;
            savefile1.DefaultExt = "txt";
            savefile1.ShowDialog();
            string saveas = savefile1.FileName;
            tabla.WriteXml(saveas);
        }
    }
}
