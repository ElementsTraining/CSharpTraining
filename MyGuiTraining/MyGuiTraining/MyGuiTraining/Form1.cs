using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGuiTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMyForm();
        }

        private void InitializeMyForm()
        {
            this.textBox2.Text = "";
            this.textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = this.textBox1.Text;
            string pass = this.textBox2.Text;
            if(user.Length <= 0 && pass.Length <= 0)
            {
                return;
            }
            Console.WriteLine("Usuario: {0}\nSenha: {1}\n Logado.",user,pass);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }
    }
}
