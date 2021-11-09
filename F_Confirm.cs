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
  public partial class F_Confirm : Form
  {


    public F_Confirm()
    {
      InitializeComponent();

    }

    public static string nombre;
    public static int dui;
    public static string direccion;
    public static string fechanacimiento;
    public static int tel;
    public static string trabajo;
    public static double ingresos;
    public static string estado;
    public static int idcliente;
    public static int idtarj;
    public static string tipotarj;
    public static double tarjlim;
    public static double interes;
    public static DateTime OpenDate = DateTime.Now;


    private void F_Confirm_Load(object sender, EventArgs e)
    {
      lblFullName.Text = nombre;
      lblDui.Text = Convert.ToString(dui);
      lblAddress.Text = direccion;
      lblBirthday.Text = Convert.ToString(fechanacimiento);
      lblPhone.Text = Convert.ToString(tel);
      lblWorkplace.Text = trabajo;
      lblTotalIncome.Text = Convert.ToString(ingresos);
      lblStatus.Text = estado;
      lblCardType.Text = tipotarj;
      lblCardLimit.Text = Convert.ToString(tarjlim);
      lblInterestRate.Text = Convert.ToString(interes);
    }

    public static void insertBD()
    {
      //
      //
      //
      //INSERCION EN BD
      MySqlCommand consulta = new MySqlCommand();
      Form1.conexionBD.Open();
      consulta.Connection = Form1.conexionBD;
      consulta.CommandText = "insert into customers (customer_id, full_name, dui, address, birthday, phone, workplace, total_income, state)" +
      " values(0,'" + nombre + "', '" + dui + "', '" + direccion + "','" + fechanacimiento + "','" + tel + "','" + trabajo + "','" + ingresos + "','" + estado + "');"

      + "insert into cards (card_id, card_type, card_limit, interest_rate)" +
      " values(0,'" + tipotarj + "', '" + tarjlim + "', '" + interes + ");"

       + "insert into openings (opening_id, date)" +
      " values(0','" + OpenDate + ");";
      try
      {



        MessageBox.Show("Agregado Exitosamente!!");
      }
      catch
      {
      }
      finally
      {
        Form1.conexionBD.Close();
      }
      //FIN INSERCION EN BD
      //
      //
      //

    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
      insertBD();
      Hide();
    }
  }
}
