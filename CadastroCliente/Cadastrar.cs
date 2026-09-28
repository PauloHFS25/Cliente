using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
