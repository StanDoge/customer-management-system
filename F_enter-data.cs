using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clave5_Grupo9
{
  public partial class F_enter_data : Form
  {
    Customer defaultCustomer = new Customer();

    public F_enter_data()
    {
      InitializeComponent();
    }


    //variables de proceso
    double addInterest;
    double ingresoTotal;
    double income;
    double othIcome;

    private void BtnConfirm_Click(object sender, EventArgs e)
    {

      //asignacion de la informacion de los input al objeto cliente

      defaultCustomer.fullName = $"{TbFirstName.Text} {TbLastName.Text}";
      defaultCustomer.address = $"{TbHouse.Text} {TbNeighborhood.Text} {TbCity.Text}";
      defaultCustomer.birthday = DtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd");
      defaultCustomer.workPlace = TbWorkPlace.Text;


      if (!Validation.controlsNull(defaultCustomer.fullName, TbID.Text, defaultCustomer.address, defaultCustomer.birthday, TbPhone.Text, defaultCustomer.workPlace, TbIncome.Text, TbOtherIncome.Text, TbInterestRate.Text))
      {
        MessageBox.Show("Error en los valores de entrada");
        return;
      }

      bool DUIValidate = int.TryParse(TbID.Text, out defaultCustomer.DUI);
      bool phoneValidate = int.TryParse(TbPhone.Text, out defaultCustomer.phoneNumber);
      bool mainIncome = double.TryParse(TbIncome.Text, out income);
      bool otherIncome = double.TryParse(TbOtherIncome.Text, out othIcome);
      bool rate = double.TryParse(TbInterestRate.Text, out addInterest);

      if(!DUIValidate || !phoneValidate || !mainIncome || !otherIncome || !rate) 
      {
        MessageBox.Show("El DUI, numero de telefono e ingresos deben de ser valores numericos");
        return;
      }

      defaultCustomer.totalIncome = income + othIcome;      

      if (addInterest < 0.30 || addInterest > 0.40)
      {
        MessageBox.Show("El monto de interes asignado debe de estar entre el 30% y 40% por ciento");
        return;
      }

      int indexOfSelections = CbCardsTypes.SelectedIndex;



      ///<summary> En este bloque de codigo se valida si el usuario es apto para obtener la categoria de tarjeta seleccionada </summary>
      ///<remarks> Cuando pasa la condicion y es apto se ejecuta el metodo sendData() que recibe como argumentos los datos del cliente</remarks>
      switch (indexOfSelections)
      {
        case 0:
          if (defaultCustomer.totalIncome >= 400)
          {
            defaultCustomer.state = 1;
            defaultCustomer.openning = new Card(400, addInterest, cardTypes.azul);
            //defaultCustomer.openning.interestRate
            LblStatus.Text = "Aprobado";
            if (defaultCustomer.state == 1)
            {
              //Metodo que ejecuta el insert con los valores que se le pasan como argumentos 
              Validation.sendData(defaultCustomer.fullName, defaultCustomer.DUI, defaultCustomer.address, defaultCustomer.birthday, defaultCustomer.phoneNumber, defaultCustomer.workPlace, defaultCustomer.totalIncome, defaultCustomer.state, defaultCustomer.openning.card.ToString(), defaultCustomer.openning.cardLimit, defaultCustomer.openning.interestRate, defaultCustomer.openning.date);
            }
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
            defaultCustomer.state = 1;
            defaultCustomer.openning = new Card(600, addInterest, cardTypes.dorado);
            LblStatus.Text = "Aprobado";
            if (defaultCustomer.state == 1)
            {
              Validation.sendData(defaultCustomer.fullName, defaultCustomer.DUI, defaultCustomer.address, defaultCustomer.birthday, defaultCustomer.phoneNumber, defaultCustomer.workPlace, defaultCustomer.totalIncome, defaultCustomer.state, defaultCustomer.openning.card.ToString(), defaultCustomer.openning.cardLimit, defaultCustomer.openning.interestRate, defaultCustomer.openning.date);
            }
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
            defaultCustomer.state = 1;
            defaultCustomer.openning = new Card(1000, addInterest, cardTypes.platino);
            LblStatus.Text = "Aprobado";
            if (defaultCustomer.state == 1)
            {
              Validation.sendData(defaultCustomer.fullName, defaultCustomer.DUI, defaultCustomer.address, defaultCustomer.birthday, defaultCustomer.phoneNumber, defaultCustomer.workPlace, defaultCustomer.totalIncome, defaultCustomer.state, defaultCustomer.openning.card.ToString(), defaultCustomer.openning.cardLimit, defaultCustomer.openning.interestRate, defaultCustomer.openning.date);
            }
          }
          else
          {
            LblStatus.Text = "Denegado";
            return;
          }
          break;
      }

      ingresoTotal = Convert.ToDouble(TbIncome.Text) + Convert.ToDouble(TbOtherIncome.Text);

      F_Confirm.nombre = defaultCustomer.fullName;
      F_Confirm.dui = defaultCustomer.DUI;
      F_Confirm.direccion = defaultCustomer.address;
      F_Confirm.fechanacimiento = defaultCustomer.birthday;
      F_Confirm.tel = defaultCustomer.phoneNumber;
      F_Confirm.trabajo = defaultCustomer.workPlace;
      F_Confirm.ingresos = defaultCustomer.totalIncome;
      F_Confirm.estado = defaultCustomer.state;
      F_Confirm.tipotarj = defaultCustomer.openning.card.ToString();
      F_Confirm.tarjlim = defaultCustomer.openning.cardLimit;
      F_Confirm.interes = defaultCustomer.openning.interestRate;

      F_Confirm confirmar = new F_Confirm();
      confirmar.Show();

    }

    /// <summary> Limpia los inputs o controles </summary>
    private void BtnNew_Click(object sender, EventArgs e)
    {
        Clear clear = new Clear();
        clear.clearForm(GbClientData);
        clear.clearForm(GbConfirmData);
        LblStatus.Text = "Vacío";
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
      F_option opción = new F_option();
      opción.Show();
      Hide();
    }
  }
}






