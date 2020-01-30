using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Asociados_CA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnJubilados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAgregarSocio());
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Menu formaSiguiente = new Menu();
            this.Hide();
            formaSiguiente.Show();

        }

        private void btnBeneficiario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmBeneficiarios());
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTaller());
        }
    }
}
