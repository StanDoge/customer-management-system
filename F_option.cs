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
    public partial class F_option : Form
    {
        public F_option()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            F_enter_data ingresar = new F_enter_data();
            ingresar.Show();
            Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            F_search_data buscar = new F_search_data();
            buscar.Show();
            Hide();
        }
    }
  enum cardTypes
  {
    azul,
    dorado,
    platino
  }

  class Card
  {
    double cardLimit;
    double interestRate;
    string date;
    bool state;
    cardTypes card;
  }
}
