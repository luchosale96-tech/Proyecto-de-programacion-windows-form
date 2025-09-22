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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login()
        {
            string usuario = textBox1.Text.Trim();
            string contraseña = textBox2.Text.Trim();
            bool valido = true;

            errorProvider1.Clear();

            //Text box vacio xd
            if (string.IsNullOrWhiteSpace(textBox1.Text.ToLower()))
            {
                errorProvider1.SetError(textBox1, "Ingresa un usuario");
                label3.Text = "Ingrese su usuario";
                valido = false;
                textBox1.Clear();
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text.ToLower()))
            {
                errorProvider1.SetError(textBox2, "Ingresa una contraseña");
                label4.Text = "Ingresa tu contraseña";
                valido = false;
                label4.Text = "Ingresa una contraseña";
                textBox2.Clear();
            }
            
            if (!valido)
            {
                return;
            }
            //_______________________________________________________________
            //Diferente a admin
            if (usuario == "Admin1" && contraseña == "0000")
            {
                MessageBox.Show("Login Exitoso");
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }


            else if (usuario == "Cliente" && contraseña == "1111")
            {
                MessageBox.Show("Login Exitoso");
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
                this.Show();
            }

            //En caso de ser diferente
            else 
            {
                errorProvider1.SetError(textBox1, "Usuario o contraseña incorrectos");
                errorProvider1.SetError(textBox2, "Usuario o contraseña incorrectos");
                label3.Text = "Usuario Incorrecto";
                label4.Text = "Contraseña Incorrecta";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login();
        }

        //borrar textbox xd
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
