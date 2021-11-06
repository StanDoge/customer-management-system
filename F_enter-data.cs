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
      
      defaultCustomer.fullName = TbFirstName.Text + TbLastName.Text;
      defaultCustomer.address = TbHouse.Text + TbNeighborhood.Text + TbCity.Text;
      defaultCustomer.birthday = DtpDateOfBirth.Text;
      defaultCustomer.workPlace = TbWorkPlace.Text;

      //Validación de entradas en los textbox para impedir que queden vacios y donde deban ir números solo acepte números.
      bool number = false;//Variable que permitirá donde deban ir solamente números
      double addInterest;   
            
      if (string.IsNullOrEmpty(defaultCustomer.fullName)) 
      {
        MessageBox.Show("Debe insertar el nombre completo");
        return;
      }

      number = int.TryParse(TbID.Text, out defaultCustomer.DUI);
      if (!number || string.IsNullOrEmpty(TbID.Text))  
      {
        MessageBox.Show("El dato ingresado en DUI/ID no es válido o el campo está vacío");
        return;
      }
      defaultCustomer.DUI = int.Parse(TbID.Text);

      if (string.IsNullOrEmpty(defaultCustomer.address)) 
      {
        MessageBox.Show("Debe ingresar su dirección completa");
        return;
      }

      if (string.IsNullOrEmpty(defaultCustomer.birthday))  
      {
        MessageBox.Show("No ha ingresado una fecha de nacimiento");
        return;
      }

      number = int.TryParse(TbPhone.Text, out defaultCustomer.phoneNumber);
      if (!number || string.IsNullOrEmpty(TbPhone.Text)) 
      {
        MessageBox.Show("El Teléfono no es válido o el campo está vacío");
        return;
      }
      defaultCustomer.phoneNumber = int.Parse(TbPhone.Text);

      if (string.IsNullOrEmpty(defaultCustomer.workPlace))  
      {
        MessageBox.Show("No ha ingresado un lugar de trabajo");
        return;
      }

      number = double.TryParse(TbIncome.Text, out defaultCustomer.totalIncome);
      if (!number || string.IsNullOrEmpty(TbIncome.Text)) 
      {
        MessageBox.Show("No ha ingresado un sueldo o ingreso principal");
        return;
      }

      number = double.TryParse(TbOtherIncome.Text, out defaultCustomer.totalIncome);
      if (!number || string.IsNullOrEmpty(TbOtherIncome.Text))  
      {
        MessageBox.Show("El dato ingresado en Otros Ingresos no es válido o el campo está vacío. Ingrese el número cero si no posee otros ingresos");
        return;
      }
      defaultCustomer.totalIncome = double.Parse(TbIncome.Text) + double.Parse(TbOtherIncome.Text);

      number = double.TryParse(TbInterestRate.Text, out addInterest);
      if (!number || string.IsNullOrEmpty(TbInterestRate.Text) || Convert.ToDouble(TbInterestRate.Text) < 0.30 || Convert.ToDouble(TbInterestRate.Text) > 0.40)  
      {
        MessageBox.Show("La tasa de interés no es válida o el campo se encuntra vacío");
        return;
      }

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
