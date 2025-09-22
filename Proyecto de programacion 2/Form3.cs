using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_programacion_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NÚMERO: 381-353-4506 | INSTAGRAM: luciano.sale_ | MAIL: lucianosale@gmail.com" );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuRepuestos menuRepuestos = new MenuRepuestos();
            this.Hide();
            menuRepuestos.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
