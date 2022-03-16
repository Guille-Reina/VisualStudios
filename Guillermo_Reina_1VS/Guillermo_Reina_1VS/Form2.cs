using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guillermo_Reina_1VS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login, Password;
            Login = txtLogin.Text.Trim();
            Password = txtPassword.Text.TrimEnd();
            if (Login == "SMA" && Password == "SMA2019")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
