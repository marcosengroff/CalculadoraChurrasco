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
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 6);
            }
            else if (txtPicanha.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 6);
                txtPicanha.Clear();
            }
        }

        private void txtPaes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFarofa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCarvao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGelo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRefrigerante_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRefrigerante_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbPaes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPaes.Checked == true)
            {
                txtPaes.Text = numPessoas.Value + "Un";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 0.5m);
            }
            else if (txtPaes.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 0.5m);
                txtPaes.Clear();
            }
        }

        private void cbFarofa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFarofa.Checked == true)
            {
                txtFarofa.Text = "1 pct";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 2.5m);
            }
            else if (txtFarofa.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 2.5m);
                txtFarofa.Clear();
            }
        }

        private void cbCarvao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCarvao.Checked == true)
            {
                txtCarvao.Text = "5 Kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 5m);
            }
            else if (txtCarvao.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 5m);
                txtCarvao.Clear();
            }
        }

        private void cbGelo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGelo.Checked == true)
            {
                txtGelo.Text = "4 Kg";
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + numPessoas.Value * 5m);
            }
            else if (txtFarofa.Text != "")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - numPessoas.Value * 5m);
                txtGelo.Clear();
            }
        }
    }
}

