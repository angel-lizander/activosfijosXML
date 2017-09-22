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
            var registro = new registrar(Convert.ToInt32(txtnoasiento.Text), richTextBox1.ToString(), Convert.ToDateTime(txtfecha.Text), Convert.ToInt16(txtcuenta.Text), comboBox1.ToString(), Convert.ToDouble(txtmonto.Text));
            registro.registrando();
        }
    }
}
