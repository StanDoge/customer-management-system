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

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
        //
        //
        //
        //CODIGO PARA CONEXION DE BD
        static  string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        static string bd = "clave5_grupo9db"; //Nombre de la base de datos
        static string userBD = "root"; //Usuario de acceso a MySQL
        static string pwdBD = "root"; //Contraseña de usuario de acceso a MySQL
        //Crearemos la cadena de conexión concatenando las variables
        static public string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id = " + userBD + "; Password=" + pwdBD +";";
        //Instancia para conexión a MySQL, recibe la cadena de conexión
         static public MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
        //
        //
        //

        private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void TbInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }


        void login()
        {
            F_option opción = new F_option();
            opción.Show();
            Hide();


        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {

            const string PASSWORD = "prn115";
            const string USER = PASSWORD;

            string psInserted = TbPassword.Text;
            string usInserted = TbUser.Text;

            if (!usInserted.Equals(USER) || string.IsNullOrEmpty(TbUser.Text))
            {
                MessageBox.Show("El usuario insertado no fue encontrado");
                return;
            }

            if (!psInserted.Equals(PASSWORD) || string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Contraseña incorrecta");
                return;

                
            }

            login();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

    }
}
