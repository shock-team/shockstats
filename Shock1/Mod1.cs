using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Shock1
{
    public class Mod1
    {
        public float getK(DataTable dt)
        {
            float aux = 1f + 3.3f * (float)Math.Log10(getN(dt));
            return aux;
        }

        public float getAmplitud(DataTable dt)
        {
            //return (float)Math.Round(getRango(dt) / getK(dt));
            return dt.Rows[1].Field<float>("Xi") - dt.Rows[0].Field<float>("Xi");
        }

        public float[] getModa(DataTable dt)
        {
            float Fmax = getFmax(dt);
            var listaDeModa = new List<float>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<float>("Fi") == Fmax)
                {
                    listaDeModa.Add(dt.Rows[i].Field<float>("Xi"));
                }
            }
            return listaDeModa.ToArray();
        }

        public float getMedia(DataTable dt)
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Xi") * dt.Rows[i].Field<float>("Fi");
            }
            if (getN(dt) == 0)
            {
                return 0;
            }
            else
            {
                return aux / getN(dt);
            }
           
        }

        public float getN(DataTable dt)
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Fi");
            }
            return aux;
        }

        public float getFmax(DataTable dt)
        {
            float aux = dt.Rows[0].Field<float>("Fi");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (aux < dt.Rows[i].Field<float>("Fi"))
                {
                    aux = dt.Rows[i].Field<float>("Fi");
                }
            }
            return aux;
        }

        public float getXmax(DataTable dt)
        {
            float aux = dt.Rows[0].Field<float>("Xi");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (aux < dt.Rows[i].Field<float>("Xi"))
                {
                    aux = dt.Rows[i].Field<float>("Xi");
                }
            }
            return aux;
        }

        public float getXmin(DataTable dt)
        {
            float aux = dt.Rows[0].Field<float>("Xi");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (aux > dt.Rows[i].Field<float>("Xi"))
                {
                    aux = dt.Rows[i].Field<float>("Xi");
                }
            }
            return aux;
        }

        public float getRango(DataTable dt)
        {
            return getXmax(dt) - getXmin(dt);
        }

        public float getDesvio(DataTable dt, float xi)
        {
            float aux = xi - getMedia(dt);
            return aux;
        }

        public float getVarianza(DataTable dt)
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += (float)Math.Pow(getDesvio(dt, dt.Rows[i].Field<float>("Xi")), 2) *
                                   dt.Rows[i].Field<float>("Fi");
            }
            return aux / getN(dt);
        } 

        public float getDesvioEstandar(DataTable dt)
        {
            return (float)Math.Sqrt(getVarianza(dt));
        }

        public float getCoeficienteDePearson(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            float coeficiente = 0;
            float[] modas = getModa(dt);
            if (modas.Length == 1)
            {
                coeficiente = (getMedia(dt) - modas[0]) / getDesvioEstandar(dt);
            }
            return coeficiente;
        }

        public float getCoeficienteDeFisher(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            float coeficiente = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                coeficiente += (float)Math.Pow(getDesvio(dt, dt.Rows[i].Field<float>("Xi")), 3) *
                                   dt.Rows[i].Field<float>("Fi");
            }
            float aux = (coeficiente / getN(dt)) / (float)Math.Pow(getDesvioEstandar(dt), 3);
            return aux;
        }


        public void actualizarFk(DataTable dt, DataGridView dgv)
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Fi");
                dgv.Rows[i].Cells["Fk"].Value = aux;
            }
        }

        public float getPosicion(byte i, byte cantidad, DataTable dt)
        {
            return i * getN(dt) / cantidad;
        }
        
        public float getLRI(byte i, byte cantidad, DataTable dt)
        {
            float c = getAmplitud(dt);
            float pos = getPosicion(i, cantidad, dt);
            float posFrec = 0;
            int j = 0;
            while (j < dt.Rows.Count && dt.Rows[j].Field<float>("Fk") < pos)
            {
                posFrec = dt.Rows[j+1].Field<float>("Xi");
                j++;
            }
            return posFrec - (c / 2);
        }



        public float getLimite(byte i, byte cantidad, DataTable dt)
        {
            float LRI = getLRI(i,cantidad,dt); 
            byte posicionFrecuencia = 0;
            float posicion = getPosicion(i, cantidad, dt);
            float sumatoriaFrecuenciasAnteriores = 0;
            while (posicionFrecuencia < dt.Rows.Count && dt.Rows[posicionFrecuencia].Field<float>("Fk") < posicion)
            {
                sumatoriaFrecuenciasAnteriores += dt.Rows[posicionFrecuencia].Field<float>("Fi");
                posicionFrecuencia++;
            }
            float numerador = (posicion - sumatoriaFrecuenciasAnteriores) * getAmplitud(dt);
            float denominador = dt.Rows[posicionFrecuencia].Field<float>("Fi");

            /*MessageBox.Show("LRI: " + LRI.ToString());
            MessageBox.Show("numerador: " + numerador.ToString());
            MessageBox.Show("denominador: " + denominador.ToString());*/

            return LRI + (numerador / denominador);
        }


        public float getMi(float LRI, float LRS)
        {
            return (LRI + LRS) / 2;
        }



        public void actualizarFrp(DataTable dt, DataGridView dgv)
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["Frp"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fi") / getN(dt))) / 10;
                if (dt.Rows.Count != 0 && dt.Columns.Contains("Fk"))
                {
                    if (!dt.Columns.Contains("Fkrp"))
                    {
                        dt.Columns.Add(new DataColumn("Fkrp", typeof(float)));
                        dgv.Rows[i].Cells["Fkrp"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fk") / getN(dt))) / 10;
                    }
                    else
                    {
                        dgv.Rows[i].Cells["Fkrp"].Value = Math.Truncate(1000 * (dt.Rows[i].Field<float>("Fk") / getN(dt))) / 10;
                    }
                    
                }
            }
        }

    }
}
