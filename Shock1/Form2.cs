using System;
using System.Data;
using System.Windows.Forms;



namespace Shock1
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Mod1 objMod1 = new Mod1();
    


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
            txtXi.Focus();
        }

        //
        //METODOS PUBLICOS
        //
        public void refreshDatos()
        {
            lblN.Text = objMod1.getN(dt).ToString();
            lblMedia.Text = objMod1.getMedia(dt).ToString();
        }        

        public void refreshTabla()
        {
            if (dataGV.Columns.Contains("Fk"))
            {
                objMod1.actualizarFk(dt, dataGV);
            }
            if (dataGV.Columns.Contains("Frp"))
            {
                objMod1.actualizarFrp(dt, dataGV);
            }
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
                refreshDatos();
                refreshTabla();



                txtFi.Text = "";
                txtXi.Text = "";
                ActiveControl = txtXi;
                txtXi.Focus();
                txtXi.Select();
            }
            else
            {
                MessageBox.Show("Ingrese datos para insertar.", "Aviso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
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
                if (dt.Rows.Count != 0 && dt.Columns.Contains("Fk"))
                {
                    objMod1.actualizarFk(dt, dataGV);
                }

                if (cbPorcentual.Checked)
                {
                    objMod1.actualizarFrp(dt, dataGV);
                }
            }
            else if (!cbAcumulada.Checked)
            {
                dt.Columns.Remove("Fk");
                if (dt.Columns.Contains("Fkrp"))
                {
                    dt.Columns.Remove("Fkrp");
                }
            }
        }

        private void CbPorcentual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorcentual.Checked)
            {
                dt.Columns.Add(new DataColumn("Frp", typeof(float)));

                if (dt.Rows.Count != 0 && dt.Columns.Contains("Frp"))
                {
                    objMod1.actualizarFrp(dt,dataGV);
                }
            }
            else if (!cbPorcentual.Checked)
            {
                dt.Columns.Remove("Frp");
                if (dt.Columns.Contains("Fkrp"))
                {
                    dt.Columns.Remove("Fkrp");
                }
            }
        }


        private void CbRelativa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRelativa.Checked)
            {
                if (objMod1.getN(dt) > 0)
                {
                    dt2 = dt.Copy();
                    dataGV.DataSource = dt2;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGV.Rows[i].Cells["Fi"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fi") / objMod1.getN(dt))) / 1000;
                        if (dt2.Rows.Count != 0 && dt2.Columns.Contains("Fk"))
                        {
                            dataGV.Rows[i].Cells["Fk"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fk") / objMod1.getN(dt))) / 1000;
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
                lblLRI.Visible = true;
                lblLRS.Visible = true;
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
                lblLRI.Visible = false;
                lblLRS.Visible = false;
            }      
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGV.SelectedRows)
                {
                    dataGV.Rows.RemoveAt(item.Index);
                }
                dataGV.Refresh();
                refreshDatos();
                refreshTabla();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a eliminar", "Aviso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            }
            
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            float[] arre = objMod1.getModa(dt);
            MessageBox.Show(arre[0].ToString());
        }
    }
}
