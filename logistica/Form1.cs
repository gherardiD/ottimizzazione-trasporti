using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistica
{
    public partial class logistica_form : Form
    {
        public logistica_form()
        {
            InitializeComponent();
        }

        public bool check()
        {
            //return false if it's useless to create the table

            int numero_produttori = (int)produttori_num.Value;
            int numero_consumatori = (int)consumatori_num.Value;
            if(numero_produttori == 1 || numero_consumatori == 1)
            {
                return false;
            }
            return true;
        }

        private void genera_btn_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                this.table_default.Visible = true;
                //rows
                for (int r = 0; r < 3; r++)
                {
                    this.table_default.Rows.Add("pcd" + r, 30 + r*10, 10 + r * 10, 20 + r * 10, 50*(r+1));
                }
                this.table_default.Rows.Add("tot" , 100, 120, 80, 300);
            }
            else
            {
                int numero_produttori = (int)produttori_num.Value;
                int numero_consumatori = (int)consumatori_num.Value;
                //creation table
                DataGridView table = new DataGridView();
                table.Name= "table";
                table.Dock = DockStyle.Fill;
                panel_table.Controls.Add(table);
                table.ColumnHeadersVisible = true;
                //columns
                table.Columns.Add("productor", "Productors");
                for (int c = 0; c < numero_consumatori; c++)
                {
                    table.Columns.Add("price_" + c, "Price");
                }
                table.Columns.Add("tot_producted", "tot");
                //rows
                for(int r = 0; r < numero_consumatori; r++)
                {
                    table.Rows.Add("pcd" + r, 0, 0, 0, 0);
                }
            }
        }

    }
}
