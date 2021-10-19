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

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void TbInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void BtnLogIn_Click(object sender, EventArgs e)
    {

      const string PASSWORD = "prn115";
      const string USER = PASSWORD;

      string psInserted = TbPassword.Text;
      string usInserted = TbUser.Text;

      if (!usInserted.Equals(USER)) 
      {
        MessageBox.Show("El usuario insertado no fue encontrado");
        return;
      }

      if (!psInserted.Equals(PASSWORD)) 
      {
        MessageBox.Show("Contraseña incorrecta");
        return;
      }

      F_option opción = new F_option();
      opción.Show();
      Hide();
    }
  }
}
