using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijosXML
{
    public partial class LeerXML : Form
    {
        public LeerXML()
        {
            InitializeComponent();
        }

        private void LeerXML_Load(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "XML Files (.xml)|*.xml";
            abrir.ShowDialog();
            string ruta = abrir.FileName;

            DataSet ds = new DataSet();
            ds.ReadXml(ruta);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
