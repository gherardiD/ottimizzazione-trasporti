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
        DataGridView table;
        int prezzo_tot;
        public logistica_form()
        {
            InitializeComponent();
            this.prezzo_tot = 0;
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
            //generate the table
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
                this.table = new DataGridView();
                this.table.Name= "table";
                this.table.Dock = DockStyle.Fill;
                panel_table.Controls.Add(this.table);
                this.table.ColumnHeadersVisible = true;
                //columns
                this.table.Columns.Add("productor", "Productors");
                for (int c = 0; c < numero_consumatori; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                }
                this.table.Columns.Add("tot_producted", "tot");
                //rows
                for(int r = 0; r < numero_produttori; r++)
                {
                    this.table.Rows.Add("pcd" + r, 0, 0, 0, 0);
                }
                this.table.Rows.Add("tot", 0, 0, 0, 0);
            }
        }


        public void update()
        {
            //to do
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            

            for (int r = 0; r < righe - 2; r++)
            {   
                for (int c = 1; c < colonne-1; c++)
                {
                    int valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    int totale_prodotto = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    int tot_request = int.Parse(this.table.Rows[righe - 2].Cells[c].Value.ToString());
                    MessageBox.Show(valore_cella + "");
                    MessageBox.Show(totale_prodotto + "");
                    MessageBox.Show(tot_request + "");


                    if (totale_prodotto - tot_request > 0)
                    {
                        this.prezzo_tot += tot_request * valore_cella;
                        totale_prodotto -= tot_request;
                        tot_request = 0;
                        this.table.Columns.RemoveAt(c);
                        colonne -= 1;
                    }
                    else
                    {
                        this.prezzo_tot += totale_prodotto * valore_cella;
                        tot_request -= totale_prodotto;
                        totale_prodotto = 0;
                        this.table.Rows.RemoveAt(r);
                        righe -= 1;
                        break;
                    }
                }
            }
            ///MessageBox.Show(this.prezzo_tot + "");
            ///MessageBox.Show(this.table.Rows[righe - 2].Cells[colonne - 2].Value.ToString());
            /*
            foreach (DataGridViewRow row in this.table.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //do operations with cell
                    MessageBox.Show(cell.Value + "");
                }
            }
            */
            /*for (int r = 0; r < righe - 2; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    ///MessageBox.Show(this.table.Rows[r].Cells[c].Value.ToString());
                }
            }*/
        }
    }
}
