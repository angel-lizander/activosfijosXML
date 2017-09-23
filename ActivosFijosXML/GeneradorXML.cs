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
    public partial class GeneradorXML : Form
    {
        public GeneradorXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoAsiento nuevo = new NuevoAsiento();
            nuevo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 generar = new Form1();
            generar.ShowDialog();
        }
    }
}
