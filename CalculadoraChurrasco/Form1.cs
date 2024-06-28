using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraChurrasco
{
    public partial class frmChurrasco : Form
    {
        public frmChurrasco()
        {
            InitializeComponent();
        }

        private void frmChurrasco_Load(object sender, EventArgs e)
        {
            txtTotal.Text = 0.ToString();
        }

        private void cbFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFrango.Checked == true)
            {
                txtFrango.Text = numPessoas.Value * 0.100m + "kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 1);
            }
            else if (txtFrango.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 1);
                txtFrango.Clear();
            }
        }

        private void cbLinguica_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLinguica.Checked == true)
            {
                txtLinguica.Text = numPessoas.Value * 0.200m + "kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 2);
            }
            else if (txtLinguica.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 2);
                txtLinguica.Clear();
            }
        }

        private void cbMaminha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaminha.Checked == true)
            {
                txtMaminha.Text = numPessoas.Value * 0.150m + "kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 3);
            }
            else if (txtMaminha.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 3);
                txtMaminha.Clear();
            }
        }

        private void cbPicanha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPicanha.Checked == true)
            {
                txtPicanha.Text = numPessoas.Value * 0.300m + "kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 5);
            }
            else if (txtPicanha.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 5);
                txtPicanha.Clear();
            }
        }
    }
}

