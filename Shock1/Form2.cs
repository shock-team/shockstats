using System;
using System.Data;
using System.Windows.Forms;

namespace Shock1
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        //
        // INICIALIZADORES
        //

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[2]
            {
                new DataColumn("Xi", typeof(float)),
                new DataColumn("Fi", typeof(float))
            });
            lblN.Text = 0.ToString();
        }

        //
        //METODOS PUBLICOS
        //
        public float getN()
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Fi");
            }
            return aux;
        }

        public void actualizarFk()
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Fi");
                dataGV.Rows[i].Cells["Fk"].Value = aux;
            }
        }

        public float getMedia()
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux = dt.Rows[i].Field<float>("Xi") * dt.Rows[i].Field<float>("Fi");
            }
            return (float)Math.Truncate(100 * aux / getN()) / 100;
        }

        public float getRango()
        {
            return
        }


        //
        //VENTANA
        //


        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtFi.Text != "" && txtXi.Text != "")
            {
                dt.Rows.Add(float.Parse(txtXi.Text), Math.Abs(float.Parse(txtFi.Text)));
                dataGV.DataSource = dt;
                lblN.Text = getN().ToString();
                lblMedia.Text = getMedia().ToString();
                if (dataGV.Columns.Contains("Fk"))
                {
                    actualizarFk();
                }

                txtFi.Text = "";
                txtXi.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese datos para insertar.");
            }
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dataGV.DataSource = dt;
            dataGV.Refresh();
            lblN.Text = 0.ToString();
            lblMedia.Text = 0.ToString();
        }

        private void CbAcumulada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAcumulada.Checked)
            {
                dt.Columns.Add(new DataColumn("Fk", typeof(float)));
                if (dt.Rows.Count != 0 && dataGV.Columns.Contains("Fk"))
                {
                    actualizarFk();
                }
            }
            else if (!cbAcumulada.Checked)
            {
                dt.Columns.Remove("Fk");
            }
        }


        private void CbRelativa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRelativa.Checked)
            {
                if (getN() > 0)
                {
                    dt2 = dt.Copy();
                    dataGV.DataSource = dt2;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGV.Rows[i].Cells["Fi"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fi") / getN())) / 1000;
                        if (dt.Rows.Count != 0 && dataGV.Columns.Contains("Fk"))
                        {
                            dataGV.Rows[i].Cells["Fk"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fk") / getN())) / 1000;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos ingresados.");

                    cbRelativa.Checked = false;
                }
            }
            if (!cbRelativa.Checked)
            {
                if (dt.Rows.Count != 0)
                {
                    dataGV.DataSource = dt;
                }
            }
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RbContinuo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContinuo.Checked)
            {
                rbDiscreto.Checked = false;
                lblDash.Visible = true;
                txtXi2.Visible = true;
                lblXi.Visible = false;
            }
        }

        private void RbDiscreto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiscreto.Checked)
            {
                rbContinuo.Checked = false;
                lblDash.Visible = false;
                txtXi2.Visible = false;
                lblXi.Visible = true;
            }      
        }
    }
}
