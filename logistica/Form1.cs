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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logistica
{
    public partial class logistica_form : Form
    {
        //DataGridView table;
        int prezzo_tot;
        //DataGridView table_copy;
        public logistica_form()
        {
            InitializeComponent();
            this.prezzo_tot = 0;
          //  table_copy= new DataGridView();
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
                //panel_table.Controls.Remove(this.table);
                //this.table.ColumnHeadersVisible = true;
                ///this.table.Columns.Add("productor", "Productors");


                // columns
                for (int c = 0; c < numero_consumatori; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                    if (numero_consumatori >= 6)
                    {
                        this.table.Columns["price_" + c].Width = 50;
                    }else if(numero_consumatori > 3 && numero_consumatori < 6)
                    {
                        this.table.Columns["price_" + c].Width = 80;
                    }
                }
                this.table.Columns.Add("tot_produced", "Tot produced");

                // rows
                for(int r = 0; r < numero_produttori; r++)
                {
                    this.table.Rows.Add("pcd" + r);
                }
                this.table.Rows.Add("tot");
            }
            this.genera_btn.Enabled = false;
        }


        private void genera_numeri_btn_Click(object sender, EventArgs e)
        {
            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            Random rnd = new Random();

            // price values max 100
            int casual_number_cell = rnd.Next(100);
            int casual_tot_requested = 0;
            int casual_tot_produced = 0;
            int max = 0;

            if(righe > 12)
            {
                max = 3;
            }
            else
            {
                max = 2;
            }

            // tot = total producted = total requested
            int tot = 0;
            
            for (int r = 0; r < righe - 1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    if(r == 0)
                    {
                        // put random numbers in total requested (last line) and calculate tot
                        casual_tot_requested = rnd.Next(colonne + righe, 300);
                        this.table.Rows[righe - 1].Cells[c].Value = casual_tot_requested;
                        tot += casual_tot_requested;
                    }
                    
                    // put random prices
                    this.table.Rows[r].Cells[c].Value = casual_number_cell;
                    casual_number_cell = rnd.Next(1, 100);
            
                    if(c == colonne - 2)
                    {
                        // setting total produced values based to tot
                        if(r == 0)
                        {
                            // set tot value in the last row and last coloumn
                            this.table.Rows[righe - 1].Cells[colonne - 1].Value = tot;
                        }
                        // minimun and maximum to avoid total produced values = 0
                        /// MessageBox.Show(tot + "");
                        casual_tot_produced = rnd.Next(1, (tot - (righe - r))/max);

                        if(r == righe - 2)
                        {
                            // setting the last total produced to tot (by doing so -> tot = total porduced = total requested)
                            this.table.Rows[r].Cells[colonne - 1].Value = tot;
                        }
                        else
                        {
                            this.table.Rows[r].Cells[colonne - 1].Value = casual_tot_produced;
                        }
                        // updating tot
                        tot = tot - casual_tot_produced;
                    }
                }
            }

            this.table.Refresh();
        }

        private void CloneDataGrid(DataGridView sorgente, DataGridView destinatario)
        {

            destinatario.ColumnCount = sorgente.ColumnCount;
            destinatario.RowCount = sorgente.RowCount;
            for (int riga = 0; riga < sorgente.RowCount; riga++)
                for (int colonna = 0; colonna < sorgente.ColumnCount; colonna++)
                    destinatario.Rows[riga].Cells[colonna].Value = sorgente.Rows[riga].Cells[colonna].Value;
            for (int colonna = 0; colonna < sorgente.ColumnCount; colonna++)
            {
                destinatario.Columns[colonna].HeaderText=sorgente.Columns[colonna].HeaderText;
                destinatario.Columns[colonna].Name = sorgente.Columns[colonna].Name;
                destinatario.Columns[colonna].Width = sorgente.Columns[colonna].Width;
                destinatario.Columns[colonna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            destinatario.Refresh();
            return;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            this.panel_text.Visible= true;
            this.panel_text.Refresh();
            this.text.Refresh();

            // copy the main dataGrid
            CloneDataGrid(this.table,this.table_copy);
            int costo_nord = nord_ovest(righe , colonne);
            // reset main dataGrid
            CloneDataGrid(this.table_copy,this.table);

            // reset prezzo_tot
            this.prezzo_tot = 0;

            Thread.Sleep(1000);
            int costo_min = minimi_costi(righe , colonne);

            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("Hai risparmiato: " + (costo_nord - costo_min));
        }

        private int nord_ovest(int righe, int colonne)
        {
            for (int r = 0; r < righe - 1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    int valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    int total_produced = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    int total_requested = int.Parse(this.table.Rows[righe - 1].Cells[c].Value.ToString());

                    String num_pcd = this.table.Rows[r].Cells[0].Value.ToString().Substring(3);
                    String num_con = this.table.Columns[c].Name.Trim().Substring(6);

                    if (delete(r, c, valore_cella, total_produced, total_requested, righe) == 'c')
                    {
                        this.text.AppendText(Environment.NewLine);
                        this.text.AppendText(" Produttore  " + num_pcd + " soddisfa Consumatore " + num_con + " Prezzo = " + total_requested * valore_cella);
                        colonne -= 1;
                        c--;
                    }
                    else
                    {
                        this.text.AppendText(Environment.NewLine);
                        this.text.AppendText(" Consumatore " + num_con + " è stato soddisfato da Produttore " + num_pcd + " Prezzo = " + total_produced * valore_cella);
                        righe -= 1;
                        r--;
                        break;
                    }
                    this.text.Refresh();
                    this.table.Refresh();
                    Thread.Sleep(1000);
                }
                this.table.Refresh();
                Thread.Sleep(1000);
            }
            this.table.Rows.RemoveAt(0);

            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("PREZZO TOTALE: " + this.prezzo_tot);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.Refresh();

            ///MessageBox.Show("prezzo totale per trasferire tutta la merce: " + this.prezzo_tot);
            return prezzo_tot;
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

        private int minimi_costi(int righe, int colonne)
        {
            
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("MINIMI-COSTI SYSTEM");
            int[] pos = new int[5];
            while (righe > 1 && colonne >= 3)
            {
                pos = find_min_data(righe, colonne);
                if (delete(pos[0], pos[1], pos[2], pos[3], pos[4], righe) == 'c')
                {
                    this.text.AppendText(Environment.NewLine);
                    this.text.AppendText(" Produttore  " + pos[0] + " soddisfa Consumatore " + pos[1] + " Prezzo = " + pos[2] * pos[4]);
                    colonne -= 1;
                }
                else
                {
                    this.text.AppendText(Environment.NewLine);
                    this.text.AppendText(" Produttore  " + pos[1] + " soddisfa Consumatore " + pos[0] + " Prezzo = " + pos[2] * pos[4]);
                    righe -= 1;
                }
                this.table.Refresh();
                Thread.Sleep(1000);
            }
            this.table.Rows.RemoveAt(0);

            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("PREZZO TOTALE: " + this.prezzo_tot);
            this.text.Refresh();

            ///MessageBox.Show("prezzo totale per trasferire tutta la merce: " + this.prezzo_tot);
            return prezzo_tot;
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
                        // MessageBox.Show(Max + "");
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
