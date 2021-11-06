using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo9
{
    public partial class F_search_data : Form
    {
        public F_search_data()
        {
            InitializeComponent();
        }


        string nameSearch ="";
        string cardTypeSearch ="";
        string statusSearch="";
        string dateFromSearch="";
        string dateToSearch="";

        //Los botones no se activan hasta que haya algun dato insertado
        private void F_search_data_Load_1(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnClear.Enabled = false;
        }


     

        private void tbxNameSearch_TextChanged(object sender, EventArgs e)
        {
            nameSearch = tbxNameSearch.Text;
            btnSearch.Enabled = true;
            btnClear.Enabled = true;

        }

       

        private void cbxCardTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardTypeSearch = cbxCardTypeSearch.SelectedItem.ToString();
            

            btnSearch.Enabled = true;
            btnClear.Enabled = true;
        }

        private void cbxStatusSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusSearch = cbxStatusSearch.SelectedItem.ToString();

            btnSearch.Enabled = true;
            btnClear.Enabled = true;
        }

        private void dtpFromSearch_ValueChanged(object sender, EventArgs e)
        {
            dateFromSearch = dtpFromSearch.Value.Date.ToShortTimeString();

            btnSearch.Enabled = true;
            btnClear.Enabled = true;
        }

        private void dtpToSearch_ValueChanged(object sender, EventArgs e)
        {
           

            dateToSearch = dtpToSearch.Value.Date.ToShortTimeString();

            btnSearch.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (nameSearch
             + cardTypeSearch
             + statusSearch
             + dateFromSearch
             + dateToSearch == "")
            {
                MessageBox.Show("Por favor ingrese un valor", "Campos vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
