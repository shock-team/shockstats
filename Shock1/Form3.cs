using System;
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

            txtCuartil.GotFocus += new EventHandler(txtCon_GotFocus);
            txtDecil.GotFocus += new EventHandler(txtCon_GotFocus);
            txtPercentil.GotFocus += new EventHandler(txtCon_GotFocus);
            txtPCP.GotFocus += new EventHandler(txtPCP_GotFocus);
            txtPP.GotFocus += new EventHandler(txtPCP_GotFocus);


            txtCuartil.TextChanged += new EventHandler(txtCuartil_TextChanged);
            txtDecil.TextChanged += new EventHandler(txtDecil_TextChanged);
            txtPercentil.TextChanged += new EventHandler(txtPercentil_TextChanged);

        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (Form1.dt.Rows.Count != 0)
            {

                float cuartil = objMod1.getLimite(byte.Parse(txtCuartil.Text), 4, Form1.dt);
                MessageBox.Show("Cuartil número " + txtCuartil.Text + " es: " + (Math.Truncate(100 * cuartil) / 100) + ".", "Resultado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sin datos no se puede calcular nada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void txtCon_GotFocus(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void txtPCP_GotFocus(object sender, EventArgs e)
        {
            txtCuartil.Clear();
            txtDecil.Clear();
            txtPercentil.Clear();
        }

        private void txtCuartil_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCuartil.Text, "^([1-4])$") && txtCuartil.Text != "")
            {
                //MessageBox.Show("Ingresa solo valores entre el 1-4");
                txtCuartil.Clear();
            }
        }
        private void txtDecil_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDecil.Text, "^([1-9]|10)$") && txtDecil.Text != "")
            {
                // MessageBox.Show("Ingresa solo valores entre el 1-10");
                txtDecil.Clear();
            }
        }

        private void txtPercentil_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPercentil.Text, "^([1-9]|[1-8][0-9]|9[0-9]|100)$") && txtPercentil.Text != "")
            {
                //MessageBox.Show("Ingresa solo valores entre el 1-100");
                txtPercentil.Clear();
            }
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
