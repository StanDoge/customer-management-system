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


        string limit;
        private void BtnConfirm_Click(object sender, EventArgs e)
    {

    //asignacion de la informacion de los input al objeto cliente

    defaultCustomer.fullName = TbFirstName.Text + TbLastName.Text;
    defaultCustomer.address = TbHouse.Text + TbNeighborhood.Text + TbCity.Text;
    defaultCustomer.birthday = DtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd");
            defaultCustomer.workPlace = TbWorkPlace.Text;
    defaultCustomer.DUI = Convert.ToInt32(TbID.Text);



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
            limit = "400";
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
            limit = "600";
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
            limit = "1000";
          }
          else
          {
            LblStatus.Text = "Denegado";
            return;
          }
          break;
      }

            double ingresoTotal;
            ingresoTotal = Convert.ToDouble(TbIncome.Text) + Convert.ToDouble(TbOtherIncome.Text);

            F_Confirm.nombre = defaultCustomer.fullName;
            F_Confirm.dui = Convert.ToInt32(TbID.Text);
            F_Confirm.direccion = defaultCustomer.address;
            F_Confirm.fechanacimiento = defaultCustomer.birthday;
            F_Confirm.tel = Convert.ToInt32(TbPhone.Text);
            F_Confirm.trabajo = defaultCustomer.workPlace;
            F_Confirm.ingresos = ingresoTotal;
            F_Confirm.estado = LblStatus.Text;
            F_Confirm.tipotarj = CbCardsTypes.Text;
            F_Confirm.tarjlim = Convert.ToDouble(limit);
            F_Confirm.interes = Convert.ToDouble(TbInterestRate.Text);

            F_Confirm confirmar = new F_Confirm();
            confirmar.Show();

            
           

        }
        


        
        public void btnClear_Click(object sender, EventArgs e)
            
        {
            foreach (Control ctrl in groupBox1.Controls)

            {

                if (ctrl is TextBox)

                {

                    TextBox textBox = (TextBox)ctrl;

                    textBox.Text = null;

                }

                if (ctrl is ComboBox)

                {

                    ComboBox comboBox = (ComboBox)ctrl;

                    comboBox.SelectedIndex = -1;
                }
            }



        }


       

  }
}
