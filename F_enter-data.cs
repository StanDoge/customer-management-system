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
    Customer defaultCustomer = new Customer();

    public F_enter_data()
    {
      InitializeComponent();
    }

    private void BtnConfirm_Click(object sender, EventArgs e)
    {

      //asignacion de la informacion de los input al objeto cliente
      defaultCustomer.totalIncome = double.Parse(TbIncome.Text) + double.Parse(TbOtherIncome.Text);
      defaultCustomer.fullName = TbFirstName.Text + TbLastName.Text;
      defaultCustomer.DUI = int.Parse(TbID.Text);
      defaultCustomer.address = TbHouse.Text + TbNeighborhood.Text + TbCity.Text;
      defaultCustomer.birthday = DtpDateOfBirth.Text;
      defaultCustomer.phoneNumber = int.Parse(TbPhone.Text);
      defaultCustomer.workPlace = TbWorkPlace.Text;


      int indexOfSelections = CbCardsTypes.SelectedIndex;

      //comprobacion de que es apto para el tipo de tarjeta elegido
      switch (indexOfSelections)
      {
        case 0:
          if (defaultCustomer.totalIncome >= 400)
          {
            defaultCustomer.state = true;
            defaultCustomer.openning = new Card(400, Double.Parse(TbInterestRate.Text), cardTypes.azul);
            LblStatus.Text = "Aprobado";
          }
          else
          {
            LblStatus.Text = "Denegado";
            return;
          }
          break;
        case 1:
          if (defaultCustomer.totalIncome > 500)
          {
            defaultCustomer.state = true;
            defaultCustomer.openning = new Card(600, Double.Parse(TbInterestRate.Text), cardTypes.dorado);
            LblStatus.Text = "Aprobado";
          }
          else
          {
            LblStatus.Text = "Denegado";
            return;
          }
          break;
        case 2:
          if (defaultCustomer.totalIncome > 700)
          {
            defaultCustomer.state = true;
            defaultCustomer.openning = new Card(1000, Double.Parse(TbInterestRate.Text), cardTypes.platino);
            LblStatus.Text = "Aprobado";
          }
          else
          {
            LblStatus.Text = "Denegado";
            return;
          }
          break;
      }

    }
  }
}
