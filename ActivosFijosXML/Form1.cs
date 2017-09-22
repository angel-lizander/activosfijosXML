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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = true;

            DataTable gridTable = new DataTable();
            gridTable.Columns.Add("No. asiento", typeof(int));
            gridTable.Columns.Add("Fecha del asiento", typeof(DateTime));
            gridTable.Columns.Add("Cuenta contable", typeof(double));
            gridTable.Columns.Add("TTipo de movimiento", typeof(string));

            dataGridView1.DataSource = gridTable;

        }
    }
}
