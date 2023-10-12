using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logistica
{
    public partial class logistica_form : Form
    {
        //DataGridView table;
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
            this.table.Visible = true;
            if (!check())
            {
                //default table

                //columns
                for (int c = 0; c < 3; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                    this.table.Columns["price_" + c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                this.table.Columns.Add("tot_produced", "Tot produced");
                this.table.Columns["tot_produced"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //rows
                for (int r = 0; r < 3; r++)
                {
                    this.table.Rows.Add("pcd" + r, 30 + r*10, 10 + r * 10, 20 + r * 10, 50*(r+1));
                }
                this.table.Rows.Add("tot" , 100, 120, 80, 300);
            }
            else
            {
                //user table
                int numero_produttori = (int)produttori_num.Value;
                int numero_consumatori = (int)consumatori_num.Value;

                //creation table
                //this.table = new DataGridView();
                //this.table.Name= "table";
                //this.table.Dock = DockStyle.Fill;
                //panel_table.Controls.Add(this.table);
                //this.table.ColumnHeadersVisible = true;
                ///this.table.Columns.Add("productor", "Productors");
                

                // columns
                for (int c = 0; c < numero_consumatori; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                }
                this.table.Columns.Add("tot_produced", "Tot produced");

                // rows
                for(int r = 0; r < numero_produttori; r++)
                {
                    this.table.Rows.Add("pcd" + r, 0, 0, 0, 0);
                }
                this.table.Rows.Add("tot", 0, 0, 0, 0);
            }
            this.genera_btn.Enabled = false;
        }


        public void update()
        {
            // to do
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            this.panel_text.Visible= true;
            nord_ovest(righe , colonne);
            // minimi_costi(righe , colonne);
        }

        private void nord_ovest(int righe, int colonne)
        {
            for (int r = 0; r < righe - 1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    int valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    int total_produced = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    int total_requested = int.Parse(this.table.Rows[righe - 1].Cells[c].Value.ToString());

                    if(delete(r, c, valore_cella, total_produced, total_requested, righe) == 'c')
                    {
                        colonne -= 1;
                        c--;
                    }
                    else
                    {
                        righe -= 1;
                        r--;
                        break;
                    }

                    this.table.Refresh();
                    Thread.Sleep(1000);
                }
                this.table.Refresh();
                Thread.Sleep(1000);
            }
            MessageBox.Show(this.prezzo_tot + "");
        }

        private char delete(int riga, int colonna, int valore_cella, int total_produced, int total_requested, int righe)
        {
            // calculates if we have to delete the producer or the consumer
            if (total_produced - total_requested > 0)
            {
                // delete requester
                this.prezzo_tot += total_requested * valore_cella;
                total_produced -= total_requested;
                this.table.Rows[riga].Cells["tot_produced"].Value = total_produced;
                total_requested = 0;
                this.table.Columns.RemoveAt(colonna);
                return 'c';
            }
            else
            {
                // delete producer
                this.prezzo_tot += total_produced * valore_cella;
                total_requested -= total_produced;
                this.table.Rows[righe - 1].Cells[colonna].Value = total_requested;
                total_produced = 0;
                this.table.Rows.RemoveAt(riga);
                return 'r';
            }
        }

        private void minimi_costi(int righe, int colonne)
        {
            int[] pos = new int[5];
            while (righe > 1 && colonne >= 3)
            {
                pos = find_min_data(righe, colonne);
                if (delete(pos[0], pos[1], pos[2], pos[3], pos[4], righe) == 'c')
                {
                    colonne -= 1;
                }
                else
                {
                    righe -= 1;
                }
                this.table.Refresh();
                Thread.Sleep(1000);
            }
            MessageBox.Show(this.prezzo_tot + "");
        }

        private int[] find_min_data(int righe, int colonne )
        {
            // return min data - riga[0] - colonna[1] - valore[2] - tot-prod[3] - tot-req[4]
            int Max = 1000000;
            int[] min_data = new int[5];
            int valore_cella = 0;
            int total_produced = 0;
            int total_requested = 0;
            for (int r = 0; r < righe-1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    total_produced = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    total_requested = int.Parse(this.table.Rows[righe - 1].Cells[c].Value.ToString());
                    if ( valore_cella < Max)
                    {
                        Max = valore_cella;
                        MessageBox.Show(Max + "");
                        min_data[0] = r;
                        min_data[1] = c;
                        min_data[2] = valore_cella;
                        min_data[3] = total_produced;
                        min_data[4] = total_requested;
                    }
                }
            }
            return min_data;
        }
    }
}
