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
    public partial class NuevoAsiento : Form
    {
        public NuevoAsiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            var registro = new registrar(Convert.ToInt32(txtnoasiento.Text), txtdescripcion.Text, Convert.ToDateTime(txtfecha.Text), Convert.ToInt32(txtcuenta.Text),a , Convert.ToDouble(txtmonto.Text));
            registro.registrando();
        }
    }
}
