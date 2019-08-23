using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shock1
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        Mod1 objMod1 = new Mod1();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AcceptButton = btnCalcular;
            ActiveControl = txtCuartil;
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        { 
            float lim = objMod1.getLimite(byte.Parse(txtCuartil.Text), 4, Form1.dt);
            MessageBox.Show(objMod1.getAmplitud(Form1.dt).ToString());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCuartil_Click(object sender, EventArgs e)
        {

        }
    }
}
