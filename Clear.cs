using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo9
{
    class Clear
    {
        public void clearForm(GroupBox gb)
        {
            foreach (var txt in gb.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).ResetText();
                }
                else if (txt is DateTimePicker)
                {
                    ((DateTimePicker)txt).ResetText();
                }
            }
        }
    }
}
