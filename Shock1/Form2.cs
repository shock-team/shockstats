using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MaterialSkin.Controls;
using AutoUpdaterDotNET;



namespace Shock1
{
    public partial class Form1 : MaterialForm
    {
        //
        // INICIALIZADORES
        //
        Mod1 objMod1 = new Mod1();
        public static DataTable dt = new DataTable();
        public static DataTable dt2 = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://sant11h.github.io/updater.xml");
            AcceptButton = btnInsert;
            dt.Columns.AddRange(new DataColumn[4]
            {
                new DataColumn("Xi", typeof(float)),
                new DataColumn("Fi", typeof(float)),
                new DataColumn("Fk", typeof(float)),
                new DataColumn("Frp", typeof(float))
            });

            txtXi.KeyPress +=(txtEntrada_Changed);
            txtXi2.KeyPress += (txtEntrada_Changed);
            txtFi.KeyPress += (txtEntrada_Changed);
        }

        //
        //METODOS PUBLICOS
        //
        public void refreshDatos()
        {
            lblN.Text = objMod1.getN(dt).ToString();
            lblMedia.Text = (Math.Truncate(100f * objMod1.getMedia(dt)) / 100f).ToString();
            lblMediana.Text = (Math.Truncate(100f * objMod1.getMediana(dt)) / 100f).ToString();
            lblFisher.Text = (Math.Truncate(100f * objMod1.getCoeficienteDeFisher(dt)) / 100f).ToString();
            lblPearson.Text = (Math.Truncate(100f * objMod1.getCoeficienteDePearson(dt)) / 100f).ToString();

        }

        public void refreshTabla()
        {
            objMod1.actualizarFk(dt, dataGV);
            objMod1.actualizarFrp(dt, dataGV);
        }

        
        
        //
        //VENTANA
        //
        
        private void txtEntrada_Changed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtXi.Text != "")
            {
                dataGV.DataSource = dt;
                if (txtFi.Text == "")
                {
                    txtFi.Text = 1.ToString();
                }

                int pos = objMod1.getPosRepetido(dt, float.Parse(txtXi.Text));
                if (pos != -1)
                {
                    objMod1.sumarRepetido(dt, dataGV, pos, float.Parse(txtFi.Text));
                }
                else
                {
                    if (rbContinuo.Checked)
                    {
                        if (txtXi2.Text != "")
                        {
                            rbDiscreto.Enabled = false;
                            dt.Rows.Add(objMod1.getMi(float.Parse(txtXi.Text), float.Parse(txtXi2.Text)), Math.Abs(float.Parse(txtFi.Text)));
                        }
                        else
                        {
                            MessageBox.Show("Ingrese datos para insertar.", "Aviso", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        rbContinuo.Enabled = false;
                        dt.Rows.Add(float.Parse(txtXi.Text), Math.Abs(float.Parse(txtFi.Text)));
                    }
                }
                refreshTabla();
                refreshDatos();

                txtFi.Clear();
                txtXi.Clear();
                txtXi2.Clear();
                
               
                ActiveControl = txtXi;
                txtXi.Focus();
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
            refreshDatos();
            rbContinuo.Enabled = true;
            rbDiscreto.Enabled = true;
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
                        if (dt2.Rows.Count != 0)
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
                    dataGV.Refresh();
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
            if (dataGV.SelectedRows.Count > 0 && dt.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in dataGV.SelectedRows)
                {
                    dataGV.Rows.RemoveAt(item.Index);
                }
                dataGV.Refresh();
                refreshTabla();
                refreshDatos();
                

            }
            else
            {
                MessageBox.Show("Seleccione una fila a eliminar", "Aviso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            }

        }

        private void BtnParticiones_Click(object sender, EventArgs e)
        {
            Form3 part = new Form3();
            part.ShowDialog();
        }

        
    }
}
