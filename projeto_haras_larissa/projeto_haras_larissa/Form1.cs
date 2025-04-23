using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_haras_larissa
{
    public partial class frmHaras : Form
    {
        public frmHaras()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNumcavalos.Text = string.Empty;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finalizar sitemas?",
                "Verificar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int num1, result;

            num1 = Convert.ToInt32(txtNumcavalos.Text);

            result = num1 * 4;

            MessageBox.Show("O resultado é " + result, "Resultado",
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

    }
}


