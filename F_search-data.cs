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
    /// <summary>
    /// AUTORES
    /// Pablo Linqui
    /// Stanley Melgar
    /// Cesar Torres
    /// Version 1.0
    /// </summary>

  public partial class F_search_data : Form
  {
    public F_search_data()
    {
      InitializeComponent();
    }

    /// <summary>
    /// variables para lbl desde y hasta
    /// </summary>
    string dateFromSearch;
    string dateToSearch;
    string displayFrom;
    string displayTo;
   
         
    ///<summary>
    ///Los botones no se activan hasta que haya algun dato insertado
    ///</summary>
    
        private void F_search_data_Load_1(object sender, EventArgs e)
    {
      btnSearch.Enabled = false;
      dtpFromSearch.Value = DateTime.Now;
      dtpToSearch.Value = dtpFromSearch.Value.AddDays(1);
    }

        ///<summary>
        ///Fechas en formato ISO
        ///</summary>
        private void dtpFromSearch_ValueChanged(object sender, EventArgs e)
    {
      dateFromSearch = dtpFromSearch.Value.Date.ToString("yyyy-MM-dd");        
      btnSearch.Enabled = true;
    }

        ///<summary>
        ///Valida que el rango de fechas sea correcto
        ///</summary>
        void validDate()
    {
      DateTime a = Convert.ToDateTime(dtpFromSearch.Text);
      DateTime b = Convert.ToDateTime(dtpToSearch.Text);
      if (a > b)
      {
        MessageBox.Show("La fecha \"Hasta\" debe ser mayor que \"Desde\"", "Rango de fecha incorrecto",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

    }

        //Valida que el rango sea real
    private void dtpToSearch_ValueChanged(object sender, EventArgs e)
    {
      dateToSearch = dtpToSearch.Value.Date.ToString("yyyy-MM-dd");            
      btnSearch.Enabled = true;


      DateTime a = Convert.ToDateTime(dtpFromSearch.Text);
      DateTime b = Convert.ToDateTime(dtpToSearch.Text);
      if (b < a)
      {
        MessageBox.Show("La fecha \"Desde\" debe ser menor que \"Hasta\"", "Rango de fecha incorrecto",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }


        ///<summary>
        ///valida que haya al menos un campo con datos antes de buscar
        ///</summary>

        private void btnSearch_Click(object sender, EventArgs e)
    {
            if (
               dateFromSearch
             + dateToSearch == "")
            {
                MessageBox.Show("Por favor ingrese un valor", "Campos vacios",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                displayFrom = dtpFromSearch.Value.Date.ToString("dd/MM/yyy");
                displayTo = dtpToSearch.Value.Date.ToString("dd/MM/yyy");
                lblFrom.Text = displayFrom;
                lblTo.Text = displayTo;

                validDate();

                


                ///<return>
                ///Conecta la bd
                ///</return>
                MySqlCommand consulta = new MySqlCommand();
                Form1.conexionBD.Open(); //se abre la conexion de la variable global declara en la parte superior del formulario
                                         //Instancia para conexión a MySQL, recibe la cadena de conexión
                consulta.Connection = Form1.conexionBD;
                //consulta.CommandText = (" select* from customers  JOIN openings ON customers.customer_id=openings.customer_id  JOIN cards ON customers.customer_id=cards.customer_id; ");
                consulta.CommandText = (" SELECT * FROM clave5_grupo9db.full_table where `Fecha de apertura` between '" + dateFromSearch + "' and '" + dateToSearch + "'");

                try
                {
                    //Inicializa una nueva instancia de la clase MySqlDataAdapter con
                    // el MySqlCommand especificado como propiedad SelectCommand.
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla);
                    dgSearch.DataSource = tabla;
                    lblCount.Text = tabla.Rows.Count.ToString();
                }
                catch
                {
                }
                finally
                {
                    Form1.conexionBD.Close();
                }
            }
    }
        ///<summary>
        ///regresa a form de opciones
        ///</summary>
        private void Volver_Click(object sender, EventArgs e)
    {
      F_option opción = new F_option();
      opción.Show();
      Hide();
    }
        ///<summary>
        ///Muestra toda la base de datos 
        ///</summary>
    private void btnGetAll_Click(object sender, EventArgs e)
    {
      //Inicializa una nueva instancia de la clase MySqlCommand.
      MySqlCommand consulta = new MySqlCommand();
      Form1.conexionBD.Open(); //se abre la conexion de la variable global declara en la parte superior del formulario
                               //Instancia para conexión a MySQL, recibe la cadena de conexión
      consulta.Connection = Form1.conexionBD;
      //consulta.CommandText = (" select* from customers  JOIN openings ON customers.customer_id=openings.customer_id  JOIN cards ON customers.customer_id=cards.customer_id; ");
      consulta.CommandText = ("  SELECT * FROM clave5_grupo9db.full_table"); //LLama a una view combinada de la BD completa y enlazada con llave primaria
      try
      {
        //Inicializa una nueva instancia de la clase MySqlDataAdapter con
        // el MySqlCommand especificado como propiedad SelectCommand.
        MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
        adaptadorMySQL.SelectCommand = consulta;
        DataTable tabla = new DataTable();
        adaptadorMySQL.Fill(tabla);
        dgSearch.DataSource = tabla;
        lblCount.Text = tabla.Rows.Count.ToString();
      }
      catch
      {
      }
      finally
      {
        Form1.conexionBD.Close();
      }
      lblFrom.Text = "";
      lblTo.Text = "";
    }

    private void comprobarConexionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Form1.conexionBD.Open(); //se abre la conexion de la variable global declara en la parte superior del formulario
        MessageBox.Show("Conexión exitosa!");// se manda un mensaje de estado deconexion
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex);
      }
      finally
      {
        Form1.conexionBD.Close(); // se cierra la conexion
      }
    }
  }
}


