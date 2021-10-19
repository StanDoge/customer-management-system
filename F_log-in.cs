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
            F_option opción = new F_option();
            opción.Show();
            Hide();
        }
    }
}
