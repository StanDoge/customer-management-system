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


        //valida que haya al menos un campo con datos
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


        //limpiar todos los campos
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            F_option opción = new F_option();
            opción.Show();
            Hide();
        }


        //Valida que el rango de fechas sea correcto
        private void dtpToSearch_CloseUp(object sender, EventArgs e)
        {
            DateTime a = Convert.ToDateTime(dtpFromSearch.Text);
            DateTime b = Convert.ToDateTime(dtpToSearch.Text);

            if (a >=b)
            {
                MessageBox.Show("La fecha \"Hasta\" debe ser mayor que \"Desde\"", "Rango de fecha incorrecto",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (a <= b)
                {
                    MessageBox.Show("La fecha \"Desde\" debe ser menor que \"Hasta\"", "Rango de fecha incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
