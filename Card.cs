using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave5_Grupo9
{
  enum cardTypes
  {
    azul,
    dorado,
    platino
  }

  class Card
  {
    public double cardLimit;
    public double interestRate;
    public DateTime date;
    public cardTypes card;
  }
}
