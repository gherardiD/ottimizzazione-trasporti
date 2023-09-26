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
            if (check())
            {
                //to do
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ciao");
        }
    }
}
