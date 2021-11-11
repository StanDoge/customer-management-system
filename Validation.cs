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
    static public void sendData(string name, int DUI, string address, string birthday, int phone, string workPlace,double income, int state, string type, double cardLimit, double interest, string aperture )
    {
      MySqlCommand insertar1 = new MySqlCommand();
      MySqlCommand insertar2 = new MySqlCommand();
      MySqlCommand insertar3 = new MySqlCommand();
      Form1.conexionBD.Open();
      insertar1.Connection = Form1.conexionBD;
      insertar2.Connection = Form1.conexionBD;
      insertar3.Connection = Form1.conexionBD;
      insertar1.CommandText = "INSERT INTO customers(full_name,dui,address,birthday,phone,workplace,total_income,state) VALUES ('"+ name + "  ','" + DUI +  "  ',  '  " + address + "  ',  '  " + birthday + "  ','  " + phone+ "  ','  " + workPlace +   "  ',  '  " + income + "',  '  " + state + "');";
      insertar2.CommandText = "INSERT INTO cards(card_type,card_limit,interest_rate,customer_id) VALUES (' "  + type.ToString() + "', ' " + cardLimit + "','" + interest + "',last_insert_id() );";
      insertar3.CommandText = "INSERT INTO openings(date,customer_id,card_id) VALUES (' "  + aperture + "', last_insert_id() , last_insert_id() );";

      try
      {
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        MySqlDataAdapter adaptador2 = new MySqlDataAdapter();
        MySqlDataAdapter adaptador3 = new MySqlDataAdapter();
        adaptador.SelectCommand = insertar1;
        adaptador2.SelectCommand = insertar2;
        adaptador3.SelectCommand = insertar3;
        DataTable tabla = new DataTable();
        adaptador.Fill(tabla); //ejecutar el insert
        adaptador2.Fill(tabla); 
        adaptador3.Fill(tabla); 
      }
      catch (ArgumentException excepcion)
      {
        MessageBox.Show($"Algo salio mal {excepcion}");
      }
      finally
      {
        MessageBox.Show("El insert se realizo con exito");
        Form1.conexionBD.Close();
      }
    }


  }
}
