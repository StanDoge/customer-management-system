using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo9
{
  public static class Validation
  {
    /// <summary> metodo encargado de hacer la insercion de datos en la BD </summary>
    static public void sendData(string name, int DUI, string address, string birthday, int phone, string workPlace, double income, int state, string type, double cardLimit, double interest, string aperture)
    {
      MySqlCommand insert1 = new MySqlCommand();
      MySqlCommand insert2 = new MySqlCommand();
      MySqlCommand insert3 = new MySqlCommand();
      Form1.conexionBD.Open();
      insert1.Connection = Form1.conexionBD;
      insert2.Connection = Form1.conexionBD;
      insert3.Connection = Form1.conexionBD;
      insert1.CommandText = "INSERT INTO customers(full_name,dui,address,birthday,phone,workplace,total_income,state) VALUES ('" + name + " ','  " + DUI + "  ',  '  "  + address +  "   ',  '  " + birthday + "  ','  " + phone + "  ','  " + workPlace + "  ',  '  " + income + "',  '  " + state + "');";
      insert2.CommandText = "INSERT INTO cards(card_type,card_limit,interest_rate,customer_id) VALUES (' " + type.ToString() + "', ' " + cardLimit + "','" + interest + "',last_insert_id() );";
      insert3.CommandText = "INSERT INTO openings(date,customer_id,card_id) VALUES (' " + aperture + "', last_insert_id() , last_insert_id() );";

      try
      {
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataAdapter adapter2 = new MySqlDataAdapter();
        MySqlDataAdapter adapter3 = new MySqlDataAdapter();
        adapter.SelectCommand = insert1;
        adapter2.SelectCommand = insert2;
        adapter3.SelectCommand = insert3;
        DataTable tabla = new DataTable();
        adapter.Fill(tabla); //ejecutar el insert
        adapter2.Fill(tabla);
        adapter3.Fill(tabla);
      }
      catch (ArgumentException excep)
      {
        MessageBox.Show($"Algo salio mal {excep}");
      }
      finally
      {
        MessageBox.Show("El insert se realizo con exito");
        Form1.conexionBD.Close();
      }
    }

    /// <summary> valida que ninguno de los campos esten vacios </summary>
    /// <returns> true en caso que ninguno de los campos este vacio y false si hay alguno</returns>
    static public bool controlsNull(string fullname, string DUI, string address, string birthday,string phone,string workPlace, string mainIncome, string otherIncome, string interest)
    {
      if (string.IsNullOrEmpty(fullname))
      {
        MessageBox.Show("Debe insertar el nombre completo");
        return false;
      }

      if (string.IsNullOrEmpty(DUI))
      {
        MessageBox.Show("El dato ingresado en DUI/ID no es válido o el campo está vacío");
        return false;
      }

      if (string.IsNullOrEmpty(address))
      {
        MessageBox.Show("Debe ingresar su dirección completa");
        return false;
      }

      if (string.IsNullOrEmpty(birthday))
      {
        MessageBox.Show("No ha ingresado una fecha de nacimiento");
        return false;
      }

      if (string.IsNullOrEmpty(phone))
      {
        MessageBox.Show("El Teléfono no es válido o el campo está vacío");
        return false;
      }

      if (string.IsNullOrEmpty(workPlace))
      {
        MessageBox.Show("No ha ingresado un lugar de trabajo");
        return false;
      }


      if (string.IsNullOrEmpty(mainIncome))
      {
        MessageBox.Show("No ha un monto dentro del campo de ingresos");
        return false;
      }

      if (string.IsNullOrEmpty(otherIncome))
      {
        MessageBox.Show("El dato ingresado en Otros Ingresos no es válido o el campo está vacío. Ingrese el número cero si no posee otros ingresos");
        return false;
      }

      if (string.IsNullOrEmpty(interest))
      {
        MessageBox.Show("La tasa de interes no puede quedar vacia, por favor inserte un monto valido");
        return false;
      }
      return true;

    }


  }
}
