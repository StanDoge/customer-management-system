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
  public partial class F_enter_data : Form
  {
    public F_enter_data()
    {
      InitializeComponent();
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
      //creacion del objeto cliente sobre el que estaremos trabajando, este tienen todos los atributos que necesitamos
      Customer defaultCustomer = new Customer();
      //sumatoria de los valores del texbox en el atributo del cliente
      defaultCustomer.totalIncome = double.Parse(TbIncome.Text) + double.Parse(TbOtherIncome.Text);

      int indexOfSelections = CbCardsTypes.SelectedIndex;

      switch (indexOfSelections)
      {
        case 0:
          //esto se repite por los tres casos, por lo que podria hacerse una funcion que se llame en cada caso en lugar de escribir el codigo tres veces
          if (defaultCustomer.totalIncome >= 400)
          {
            defaultCustomer.state = true;
            MessageBox.Show("Tu estado es true");
          }
          else
          {
            defaultCustomer.state = false;
            MessageBox.Show("Tu estado es false");
          }
          break;
      }
    }
  }
}
