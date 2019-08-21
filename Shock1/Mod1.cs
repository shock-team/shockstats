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
            return (float)Math.Round(getRango(dt) / getK(dt));
        }

      /*  public float getModa(DataTable dt)
        {
            float Fmax = getFmax(dt);

            return aux;
        }
        */

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
                return (float)Math.Truncate(100 * aux / getN(dt)) / 100;
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
                if (aux > dt.Rows[i].Field<float>("Fi"))
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
                if (aux > dt.Rows[i].Field<float>("Xi"))
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
                if (aux < dt.Rows[i].Field<float>("Xi"))
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




        public void actualizarFk(DataTable dt, DataGridView dgv)
        {
            float aux = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                aux += dt.Rows[i].Field<float>("Fi");
                dgv.Rows[i].Cells["Fk"].Value = aux;
            }
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
