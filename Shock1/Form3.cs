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
                if (txtCuartil.Text != "")
                {
                    float cuartil = objMod1.getLimite(int.Parse(txtCuartil.Text), 4, Form1.dt);
                    MessageBox.Show("Cuartil número " + txtCuartil.Text + " es: " + (Math.Truncate(100 * cuartil) / 100) + ".", "Resultado", MessageBoxButtons.OK);
                }
                else if (txtDecil.Text != "")
                {
                    float decil = objMod1.getLimite(int.Parse(txtDecil.Text), 10, Form1.dt);
                    MessageBox.Show("Decil número " + txtDecil.Text + " es: " + (Math.Truncate(100 * decil) / 100) + ".", "Resultado", MessageBoxButtons.OK);
                }
                else if (txtPercentil.Text != "")
                {
                    float percentil = objMod1.getLimite(int.Parse(txtPercentil.Text), 100, Form1.dt);
                    MessageBox.Show("Percentil número " + txtPercentil.Text + " es: " + (Math.Truncate(100 * percentil) / 100) + ".", "Resultado", MessageBoxButtons.OK);
                }
                else if (txtPP.Text != "" && txtPCP.Text != "")
                {
                    if (int.Parse(txtPP.Text) > int.Parse(txtPCP.Text))
                    {
                        MessageBox.Show("La posición no puede ser mayor a la cantidad de particiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float pers = objMod1.getLimite(int.Parse(txtPP.Text), int.Parse(txtPCP.Text), Form1.dt);
                        MessageBox.Show(txtPCP.Text + " particiones en la posición " + txtPP.Text + " es: " + (Math.Truncate(100 * pers) / 100) + ".", "Resultado", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Complete algun campo para calcular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sin datos cargados no se puede calcular nada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
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
                txtCuartil.Clear();
            }
        }
        private void txtDecil_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDecil.Text, "^([1-9]|10)$") && txtDecil.Text != "")
            {
                txtDecil.Clear();
            }
        }

        private void txtPercentil_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPercentil.Text, "^([1-9]|[1-8][0-9]|9[0-9]|100)$") && txtPercentil.Text != "")
            {
                txtPercentil.Clear();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
